namespace dates
{
    partial class DateForm
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
            this.monthButton = new System.Windows.Forms.Button();
            this.dayButton = new System.Windows.Forms.Button();
            this.yearButton = new System.Windows.Forms.Button();
            this.monthBox = new System.Windows.Forms.TextBox();
            this.dayBox = new System.Windows.Forms.TextBox();
            this.yearBox = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.monthLabel = new System.Windows.Forms.Label();
            this.dayLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.dateBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // monthButton
            // 
            this.monthButton.Location = new System.Drawing.Point(164, 48);
            this.monthButton.Name = "monthButton";
            this.monthButton.Size = new System.Drawing.Size(86, 23);
            this.monthButton.TabIndex = 0;
            this.monthButton.Text = "Update Month";
            this.monthButton.UseVisualStyleBackColor = true;
            // 
            // dayButton
            // 
            this.dayButton.Location = new System.Drawing.Point(164, 76);
            this.dayButton.Name = "dayButton";
            this.dayButton.Size = new System.Drawing.Size(86, 23);
            this.dayButton.TabIndex = 1;
            this.dayButton.Text = "Update Day";
            this.dayButton.UseVisualStyleBackColor = true;
            // 
            // yearButton
            // 
            this.yearButton.Location = new System.Drawing.Point(164, 104);
            this.yearButton.Name = "yearButton";
            this.yearButton.Size = new System.Drawing.Size(86, 23);
            this.yearButton.TabIndex = 2;
            this.yearButton.Text = "Update Year";
            this.yearButton.UseVisualStyleBackColor = true;
            // 
            // monthBox
            // 
            this.monthBox.Location = new System.Drawing.Point(58, 50);
            this.monthBox.Name = "monthBox";
            this.monthBox.Size = new System.Drawing.Size(100, 20);
            this.monthBox.TabIndex = 3;
            // 
            // dayBox
            // 
            this.dayBox.Location = new System.Drawing.Point(58, 78);
            this.dayBox.Name = "dayBox";
            this.dayBox.Size = new System.Drawing.Size(100, 20);
            this.dayBox.TabIndex = 4;
            // 
            // yearBox
            // 
            this.yearBox.Location = new System.Drawing.Point(58, 106);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(100, 20);
            this.yearBox.TabIndex = 5;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(43, 15);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(33, 13);
            this.dateLabel.TabIndex = 6;
            this.dateLabel.Text = "Date:";
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Location = new System.Drawing.Point(12, 53);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(40, 13);
            this.monthLabel.TabIndex = 7;
            this.monthLabel.Text = "Month:";
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.Location = new System.Drawing.Point(23, 81);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(29, 13);
            this.dayLabel.TabIndex = 8;
            this.dayLabel.Text = "Day:";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(20, 109);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(32, 13);
            this.yearLabel.TabIndex = 9;
            this.yearLabel.Text = "Year:";
            // 
            // dateBox
            // 
            this.dateBox.Location = new System.Drawing.Point(82, 12);
            this.dateBox.Name = "dateBox";
            this.dateBox.ReadOnly = true;
            this.dateBox.Size = new System.Drawing.Size(100, 20);
            this.dateBox.TabIndex = 10;
            // 
            // DateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 145);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.dayLabel);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.dayBox);
            this.Controls.Add(this.monthBox);
            this.Controls.Add(this.yearButton);
            this.Controls.Add(this.dayButton);
            this.Controls.Add(this.monthButton);
            this.Name = "DateForm";
            this.Text = "Lab 9";
            this.Load += new System.EventHandler(this.DateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button monthButton;
        private System.Windows.Forms.Button dayButton;
        private System.Windows.Forms.Button yearButton;
        private System.Windows.Forms.TextBox monthBox;
        private System.Windows.Forms.TextBox dayBox;
        private System.Windows.Forms.TextBox yearBox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TextBox dateBox;
    }
}

