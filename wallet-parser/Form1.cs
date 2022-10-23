using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wallet_parser.Cbr;

namespace wallet_parser
{
    public partial class Form1 : Form
    {

        const int dollarCode = 840;
        const int euroCode = 978;

        public Form1() {
            InitializeComponent();
        }

        static void Swap<T>(ref T fst, ref T snd) {
            T temp;
            temp = fst;
            fst = snd;
            snd = temp;
        }

        private void button1_Click(object sender, EventArgs e) {
            resultListBox.Items.Clear();
            try {
                //получаем временной интервал
                var start = Convert.ToDateTime(startDateTB.Text);
                var end = Convert.ToDateTime(endDateTB.Text);

                //если даты позже текущей даты - выбрасываем исключение
                if (end > DateTime.Now || start > DateTime.Now) {
                    throw new Exception();
                }

                //в случае если первую дату ввели более позднюю, меняем даты
                if (start > end) {
                    Swap(ref start, ref end);
                }

                var dailyInfo = new DailyInfo();
                
                //идем от начальной даты до конечной, прибавляя по 1 дню
                for (var curDate = start; curDate <= end; curDate = curDate.AddDays(1)) {

                    var dailyCurs = dailyInfo.GetCursOnDate(curDate); // получаем объект типа DataSet

                    //если на сайте центробанка не нашлась информация по этой дате
                    //выбрасываем исключение, корректируем даты
                    if (dailyCurs == null) {
                        throw new Exception();
                    }

                    var table = dailyCurs.Tables[0]; // берем первую и единственную таблицу из DataSet
                    var rows = table.Select($"Vcode = {euroCode} or Vcode = {dollarCode}"); // получаем массив табличных строк с нужными валютами (по коду валют)

                    resultListBox.Items.Add(curDate.ToString("dd/MM/yyyy"));//подготовка вывода по текущей дате

                    //проходим по этим строкам и печатаем поля с названием валюты и курса
                    foreach (var row in rows) {
                        resultListBox.Items.Add(row["Vname"].ToString().Trim() + ':');
                        resultListBox.Items.Add(row["Vcurs"].ToString().Trim() + " руб.");
                    }
                    resultListBox.Items.Add("");
                }
            }
            catch {
                MessageBox.Show(
                   this,
                   "Некорректный ввод даты",
                   "Ошибка",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.None,
                   MessageBoxDefaultButton.Button1);
            }
        }

        static void MakeStartCaret(MaskedTextBox tb) {
            //если поле для ввода даты пустое, ставим курсор в начало
            if (tb.Text == "  .  .") {
                tb.SelectionStart = 0;
            }
        }

        private void startDateTB_Click(object sender, EventArgs e) {
            MakeStartCaret(sender as MaskedTextBox);
        }

        private void endDateTB_Click(object sender, EventArgs e) {
            MakeStartCaret(sender as MaskedTextBox);
        }
    }
}
