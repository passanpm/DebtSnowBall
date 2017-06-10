namespace DebtSnowBall2017
{
    partial class mainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.principleTextBox = new System.Windows.Forms.TextBox();
            this.interestTextBox = new System.Windows.Forms.TextBox();
            this.monthsInPaymentTextBox = new System.Windows.Forms.TextBox();
            this.addToListButton = new System.Windows.Forms.Button();
            this.principleLabel = new System.Windows.Forms.Label();
            this.interestLabel = new System.Windows.Forms.Label();
            this.monthsInPaymentLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.principleLabelList = new System.Windows.Forms.Label();
            this.interestLabelList = new System.Windows.Forms.Label();
            this.totalOwedList = new System.Windows.Forms.Label();
            this.totalPaidList = new System.Windows.Forms.Label();
            this.loanTypeBox = new System.Windows.Forms.ComboBox();
            this.loanTypeLabel = new System.Windows.Forms.Label();
            this.monthlySalaryBox = new System.Windows.Forms.TextBox();
            this.monthlySalaryLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // principleTextBox
            // 
            this.principleTextBox.Location = new System.Drawing.Point(25, 302);
            this.principleTextBox.Name = "principleTextBox";
            this.principleTextBox.Size = new System.Drawing.Size(100, 20);
            this.principleTextBox.TabIndex = 0;
            // 
            // interestTextBox
            // 
            this.interestTextBox.Location = new System.Drawing.Point(185, 304);
            this.interestTextBox.Name = "interestTextBox";
            this.interestTextBox.Size = new System.Drawing.Size(50, 20);
            this.interestTextBox.TabIndex = 1;
            // 
            // monthsInPaymentTextBox
            // 
            this.monthsInPaymentTextBox.Location = new System.Drawing.Point(287, 304);
            this.monthsInPaymentTextBox.Name = "monthsInPaymentTextBox";
            this.monthsInPaymentTextBox.Size = new System.Drawing.Size(100, 20);
            this.monthsInPaymentTextBox.TabIndex = 2;
            // 
            // addToListButton
            // 
            this.addToListButton.Location = new System.Drawing.Point(497, 304);
            this.addToListButton.Name = "addToListButton";
            this.addToListButton.Size = new System.Drawing.Size(75, 23);
            this.addToListButton.TabIndex = 3;
            this.addToListButton.Text = "Add";
            this.addToListButton.UseVisualStyleBackColor = true;
            this.addToListButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // principleLabel
            // 
            this.principleLabel.AutoSize = true;
            this.principleLabel.Location = new System.Drawing.Point(22, 286);
            this.principleLabel.Name = "principleLabel";
            this.principleLabel.Size = new System.Drawing.Size(47, 13);
            this.principleLabel.TabIndex = 4;
            this.principleLabel.Text = "Principle";
            // 
            // interestLabel
            // 
            this.interestLabel.AutoSize = true;
            this.interestLabel.Location = new System.Drawing.Point(182, 286);
            this.interestLabel.Name = "interestLabel";
            this.interestLabel.Size = new System.Drawing.Size(42, 13);
            this.interestLabel.TabIndex = 5;
            this.interestLabel.Text = "Interest";
            this.interestLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // monthsInPaymentLabel
            // 
            this.monthsInPaymentLabel.AutoSize = true;
            this.monthsInPaymentLabel.Location = new System.Drawing.Point(284, 286);
            this.monthsInPaymentLabel.Name = "monthsInPaymentLabel";
            this.monthsInPaymentLabel.Size = new System.Drawing.Size(97, 13);
            this.monthsInPaymentLabel.TabIndex = 6;
            this.monthsInPaymentLabel.Text = "Months in Payment";
            this.monthsInPaymentLabel.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.0597F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.9403F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 163F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 39);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.47826F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(560, 221);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // principleLabelList
            // 
            this.principleLabelList.AutoSize = true;
            this.principleLabelList.Location = new System.Drawing.Point(9, 23);
            this.principleLabelList.Name = "principleLabelList";
            this.principleLabelList.Size = new System.Drawing.Size(47, 13);
            this.principleLabelList.TabIndex = 8;
            this.principleLabelList.Text = "Principle";
            // 
            // interestLabelList
            // 
            this.interestLabelList.AutoSize = true;
            this.interestLabelList.Location = new System.Drawing.Point(182, 23);
            this.interestLabelList.Name = "interestLabelList";
            this.interestLabelList.Size = new System.Drawing.Size(42, 13);
            this.interestLabelList.TabIndex = 9;
            this.interestLabelList.Text = "Interest";
            // 
            // totalOwedList
            // 
            this.totalOwedList.AutoSize = true;
            this.totalOwedList.Location = new System.Drawing.Point(284, 23);
            this.totalOwedList.Name = "totalOwedList";
            this.totalOwedList.Size = new System.Drawing.Size(97, 13);
            this.totalOwedList.TabIndex = 7;
            this.totalOwedList.Text = "Months in Payment";
            this.totalOwedList.Click += new System.EventHandler(this.label3_Click);
            // 
            // totalPaidList
            // 
            this.totalPaidList.AutoSize = true;
            this.totalPaidList.Location = new System.Drawing.Point(444, 23);
            this.totalPaidList.Name = "totalPaidList";
            this.totalPaidList.Size = new System.Drawing.Size(94, 13);
            this.totalPaidList.TabIndex = 10;
            this.totalPaidList.Text = "Total Amount Paid";
            // 
            // loanTypeBox
            // 
            this.loanTypeBox.FormattingEnabled = true;
            this.loanTypeBox.Location = new System.Drawing.Point(408, 304);
            this.loanTypeBox.Name = "loanTypeBox";
            this.loanTypeBox.Size = new System.Drawing.Size(83, 21);
            this.loanTypeBox.TabIndex = 0;
            this.loanTypeBox.Text = "Student Loan";
            // 
            // loanTypeLabel
            // 
            this.loanTypeLabel.AutoSize = true;
            this.loanTypeLabel.Location = new System.Drawing.Point(405, 285);
            this.loanTypeLabel.Name = "loanTypeLabel";
            this.loanTypeLabel.Size = new System.Drawing.Size(58, 13);
            this.loanTypeLabel.TabIndex = 11;
            this.loanTypeLabel.Text = "Loan Type";
            // 
            // monthlySalaryBox
            // 
            this.monthlySalaryBox.Location = new System.Drawing.Point(124, 356);
            this.monthlySalaryBox.Name = "monthlySalaryBox";
            this.monthlySalaryBox.Size = new System.Drawing.Size(100, 20);
            this.monthlySalaryBox.TabIndex = 12;
            // 
            // monthlySalaryLabel
            // 
            this.monthlySalaryLabel.AutoSize = true;
            this.monthlySalaryLabel.Location = new System.Drawing.Point(121, 340);
            this.monthlySalaryLabel.Name = "monthlySalaryLabel";
            this.monthlySalaryLabel.Size = new System.Drawing.Size(76, 13);
            this.monthlySalaryLabel.TabIndex = 13;
            this.monthlySalaryLabel.Text = "Monthly Salary";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(240, 354);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 14;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.monthlySalaryLabel);
            this.Controls.Add(this.monthlySalaryBox);
            this.Controls.Add(this.loanTypeLabel);
            this.Controls.Add(this.loanTypeBox);
            this.Controls.Add(this.totalPaidList);
            this.Controls.Add(this.totalOwedList);
            this.Controls.Add(this.interestLabelList);
            this.Controls.Add(this.principleLabelList);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.monthsInPaymentLabel);
            this.Controls.Add(this.interestLabel);
            this.Controls.Add(this.principleLabel);
            this.Controls.Add(this.addToListButton);
            this.Controls.Add(this.monthsInPaymentTextBox);
            this.Controls.Add(this.interestTextBox);
            this.Controls.Add(this.principleTextBox);
            this.Name = "mainWindow";
            this.Text = "Debt Snowball";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox principleTextBox;
        private System.Windows.Forms.TextBox interestTextBox;
        private System.Windows.Forms.TextBox monthsInPaymentTextBox;
        private System.Windows.Forms.Button addToListButton;
        private System.Windows.Forms.Label principleLabel;
        private System.Windows.Forms.Label interestLabel;
        private System.Windows.Forms.Label monthsInPaymentLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label principleLabelList;
        private System.Windows.Forms.Label interestLabelList;
        private System.Windows.Forms.Label totalOwedList;
        private System.Windows.Forms.Label totalPaidList;
        private System.Windows.Forms.ComboBox loanTypeBox;
        private System.Windows.Forms.Label loanTypeLabel;
        private System.Windows.Forms.TextBox monthlySalaryBox;
        private System.Windows.Forms.Label monthlySalaryLabel;
        private System.Windows.Forms.Button calculateButton;
    }
}

