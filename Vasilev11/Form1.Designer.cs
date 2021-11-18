namespace Vasilev11
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
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.numericMoney = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboNumbers = new System.Windows.Forms.ComboBox();
            this.buttTakePut = new System.Windows.Forms.Button();
            this.PutNum = new System.Windows.Forms.NumericUpDown();
            this.TakeNum = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttGen = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboFrom = new System.Windows.Forms.ComboBox();
            this.comboTo = new System.Windows.Forms.ComboBox();
            this.buttTransfer = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.richSongs = new System.Windows.Forms.RichTextBox();
            this.richTransactions = new System.Windows.Forms.RichTextBox();
            this.comboTransaction = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PutNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TakeNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(712, 366);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.comboTransaction);
            this.tabPage1.Controls.Add(this.richTransactions);
            this.tabPage1.Controls.Add(this.numericMoney);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.comboNumbers);
            this.tabPage1.Controls.Add(this.buttTakePut);
            this.tabPage1.Controls.Add(this.PutNum);
            this.tabPage1.Controls.Add(this.TakeNum);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.buttGen);
            this.tabPage1.Controls.Add(this.numericUpDown1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.comboFrom);
            this.tabPage1.Controls.Add(this.comboTo);
            this.tabPage1.Controls.Add(this.buttTransfer);
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(704, 340);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "#";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // numericMoney
            // 
            this.numericMoney.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericMoney.Location = new System.Drawing.Point(430, 276);
            this.numericMoney.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericMoney.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericMoney.Name = "numericMoney";
            this.numericMoney.Size = new System.Drawing.Size(90, 20);
            this.numericMoney.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(380, 278);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Сумма";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(385, 108);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Счёт: ";
            // 
            // comboNumbers
            // 
            this.comboNumbers.FormattingEnabled = true;
            this.comboNumbers.Location = new System.Drawing.Point(423, 106);
            this.comboNumbers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboNumbers.Name = "comboNumbers";
            this.comboNumbers.Size = new System.Drawing.Size(92, 21);
            this.comboNumbers.TabIndex = 19;
            // 
            // buttTakePut
            // 
            this.buttTakePut.Location = new System.Drawing.Point(370, 182);
            this.buttTakePut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttTakePut.Name = "buttTakePut";
            this.buttTakePut.Size = new System.Drawing.Size(150, 32);
            this.buttTakePut.TabIndex = 17;
            this.buttTakePut.Text = "Выполнить";
            this.buttTakePut.UseVisualStyleBackColor = true;
            this.buttTakePut.Click += new System.EventHandler(this.buttTakePut_Click);
            // 
            // PutNum
            // 
            this.PutNum.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.PutNum.Location = new System.Drawing.Point(424, 158);
            this.PutNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PutNum.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.PutNum.Name = "PutNum";
            this.PutNum.Size = new System.Drawing.Size(90, 20);
            this.PutNum.TabIndex = 16;
            // 
            // TakeNum
            // 
            this.TakeNum.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.TakeNum.Location = new System.Drawing.Point(424, 130);
            this.TakeNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TakeNum.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.TakeNum.Name = "TakeNum";
            this.TakeNum.Size = new System.Drawing.Size(90, 20);
            this.TakeNum.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Внести: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Снять: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(413, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Количество";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttGen
            // 
            this.buttGen.Location = new System.Drawing.Point(370, 60);
            this.buttGen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttGen.Name = "buttGen";
            this.buttGen.Size = new System.Drawing.Size(150, 32);
            this.buttGen.TabIndex = 11;
            this.buttGen.Text = "Сгенерировать";
            this.buttGen.UseVisualStyleBackColor = true;
            this.buttGen.Click += new System.EventHandler(this.buttGen_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(401, 36);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(90, 20);
            this.numericUpDown1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 255);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "На счёт";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 230);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Со счёта";
            // 
            // comboFrom
            // 
            this.comboFrom.FormattingEnabled = true;
            this.comboFrom.Location = new System.Drawing.Point(430, 228);
            this.comboFrom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboFrom.Name = "comboFrom";
            this.comboFrom.Size = new System.Drawing.Size(92, 21);
            this.comboFrom.TabIndex = 3;
            // 
            // comboTo
            // 
            this.comboTo.FormattingEnabled = true;
            this.comboTo.Location = new System.Drawing.Point(430, 252);
            this.comboTo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboTo.Name = "comboTo";
            this.comboTo.Size = new System.Drawing.Size(92, 21);
            this.comboTo.TabIndex = 2;
            // 
            // buttTransfer
            // 
            this.buttTransfer.Location = new System.Drawing.Point(371, 301);
            this.buttTransfer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttTransfer.Name = "buttTransfer";
            this.buttTransfer.Size = new System.Drawing.Size(150, 32);
            this.buttTransfer.TabIndex = 1;
            this.buttTransfer.Text = "Перевести";
            this.buttTransfer.UseVisualStyleBackColor = true;
            this.buttTransfer.Click += new System.EventHandler(this.buttTransfer_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(7, 5);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(360, 329);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.label16);
            this.tabPage6.Controls.Add(this.richTextBox2);
            this.tabPage6.Controls.Add(this.label14);
            this.tabPage6.Controls.Add(this.richSongs);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(591, 340);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "#2";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(395, 80);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 13);
            this.label16.TabIndex = 7;
            this.label16.Text = "Сравнение";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(280, 95);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(264, 239);
            this.richTextBox2.TabIndex = 6;
            this.richTextBox2.Text = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(117, 4);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Список песен";
            // 
            // richSongs
            // 
            this.richSongs.Location = new System.Drawing.Point(7, 20);
            this.richSongs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richSongs.Name = "richSongs";
            this.richSongs.Size = new System.Drawing.Size(270, 314);
            this.richSongs.TabIndex = 0;
            this.richSongs.Text = "";
            // 
            // richTransactions
            // 
            this.richTransactions.Location = new System.Drawing.Point(525, 36);
            this.richTransactions.Name = "richTransactions";
            this.richTransactions.Size = new System.Drawing.Size(169, 260);
            this.richTransactions.TabIndex = 23;
            this.richTransactions.Text = "";
            // 
            // comboTransaction
            // 
            this.comboTransaction.FormattingEnabled = true;
            this.comboTransaction.Location = new System.Drawing.Point(525, 10);
            this.comboTransaction.Margin = new System.Windows.Forms.Padding(2);
            this.comboTransaction.Name = "comboTransaction";
            this.comboTransaction.Size = new System.Drawing.Size(169, 21);
            this.comboTransaction.TabIndex = 24;
            this.comboTransaction.SelectedIndexChanged += new System.EventHandler(this.comboTransaction_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(525, 302);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 32);
            this.button1.TabIndex = 25;
            this.button1.Text = "Dispose";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 366);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PutNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TakeNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.NumericUpDown numericMoney;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboNumbers;
        private System.Windows.Forms.Button buttTakePut;
        private System.Windows.Forms.NumericUpDown PutNum;
        private System.Windows.Forms.NumericUpDown TakeNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttGen;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboFrom;
        private System.Windows.Forms.ComboBox comboTo;
        private System.Windows.Forms.Button buttTransfer;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RichTextBox richSongs;
        private System.Windows.Forms.ComboBox comboTransaction;
        private System.Windows.Forms.RichTextBox richTransactions;
        private System.Windows.Forms.Button button1;
    }
}

