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
            this.totalOwedTextBox = new System.Windows.Forms.TextBox();
            this.addToListButton = new System.Windows.Forms.Button();
            this.principleLabel = new System.Windows.Forms.Label();
            this.interestLabel = new System.Windows.Forms.Label();
            this.totalOwedLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.principleLabelList = new System.Windows.Forms.Label();
            this.interestLabelList = new System.Windows.Forms.Label();
            this.totalOwedList = new System.Windows.Forms.Label();
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
            // totalOwedTextBox
            // 
            this.totalOwedTextBox.Location = new System.Drawing.Point(287, 304);
            this.totalOwedTextBox.Name = "totalOwedTextBox";
            this.totalOwedTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalOwedTextBox.TabIndex = 2;
            // 
            // addToListButton
            // 
            this.addToListButton.Location = new System.Drawing.Point(453, 302);
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
            // totalOwedLabel
            // 
            this.totalOwedLabel.AutoSize = true;
            this.totalOwedLabel.Location = new System.Drawing.Point(284, 286);
            this.totalOwedLabel.Name = "totalOwedLabel";
            this.totalOwedLabel.Size = new System.Drawing.Size(101, 13);
            this.totalOwedLabel.TabIndex = 6;
            this.totalOwedLabel.Text = "Total Amount Owed";
            this.totalOwedLabel.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.0597F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.9403F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 163F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 39);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(560, 220);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // principleLabelList
            // 
            this.principleLabelList.AutoSize = true;
            this.principleLabelList.Location = new System.Drawing.Point(22, 23);
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
            this.totalOwedList.Size = new System.Drawing.Size(101, 13);
            this.totalOwedList.TabIndex = 7;
            this.totalOwedList.Text = "Total Amount Owed";
            this.totalOwedList.Click += new System.EventHandler(this.label3_Click);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.totalOwedList);
            this.Controls.Add(this.interestLabelList);
            this.Controls.Add(this.principleLabelList);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.totalOwedLabel);
            this.Controls.Add(this.interestLabel);
            this.Controls.Add(this.principleLabel);
            this.Controls.Add(this.addToListButton);
            this.Controls.Add(this.totalOwedTextBox);
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
        private System.Windows.Forms.TextBox totalOwedTextBox;
        private System.Windows.Forms.Button addToListButton;
        private System.Windows.Forms.Label principleLabel;
        private System.Windows.Forms.Label interestLabel;
        private System.Windows.Forms.Label totalOwedLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label principleLabelList;
        private System.Windows.Forms.Label interestLabelList;
        private System.Windows.Forms.Label totalOwedList;
    }
}

