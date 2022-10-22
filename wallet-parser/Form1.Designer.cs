namespace wallet_parser
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.resultListBox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.endDateTB = new System.Windows.Forms.MaskedTextBox();
            this.startDateTB = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(165, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 63);
            this.button1.TabIndex = 2;
            this.button1.Text = "Запросить информацию";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ShortcutsEnabled = false;
            this.textBox1.Size = new System.Drawing.Size(288, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Введите временной интервал в формате (дд.мм.гггг)";
            // 
            // resultListBox
            // 
            this.resultListBox.BackColor = System.Drawing.SystemColors.Control;
            this.resultListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultListBox.FormattingEnabled = true;
            this.resultListBox.Location = new System.Drawing.Point(0, 125);
            this.resultListBox.Name = "resultListBox";
            this.resultListBox.Size = new System.Drawing.Size(288, 444);
            this.resultListBox.TabIndex = 4;
            this.resultListBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.endDateTB);
            this.panel1.Controls.Add(this.startDateTB);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 117);
            this.panel1.TabIndex = 5;
            // 
            // endDateTB
            // 
            this.endDateTB.Location = new System.Drawing.Point(24, 71);
            this.endDateTB.Mask = "00/00/0000";
            this.endDateTB.Name = "endDateTB";
            this.endDateTB.Size = new System.Drawing.Size(100, 20);
            this.endDateTB.TabIndex = 1;
            this.endDateTB.ValidatingType = typeof(System.DateTime);
            this.endDateTB.Click += new System.EventHandler(this.endDateTB_Click);
            // 
            // startDateTB
            // 
            this.startDateTB.Location = new System.Drawing.Point(24, 28);
            this.startDateTB.Mask = "00/00/0000";
            this.startDateTB.Name = "startDateTB";
            this.startDateTB.Size = new System.Drawing.Size(100, 20);
            this.startDateTB.TabIndex = 0;
            this.startDateTB.ValidatingType = typeof(System.DateTime);
            this.startDateTB.Click += new System.EventHandler(this.startDateTB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(288, 567);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.resultListBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox resultListBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox endDateTB;
        private System.Windows.Forms.MaskedTextBox startDateTB;
    }
}

