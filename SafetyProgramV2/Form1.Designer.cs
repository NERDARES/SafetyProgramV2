namespace SafetyProgramV2
{
    partial class SafetyProgramForm
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
            this.titleLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.dateLbl = new System.Windows.Forms.Label();
            this.stdNumLbl = new System.Windows.Forms.Label();
            this.stdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.descriptionRichTxtBox = new System.Windows.Forms.RichTextBox();
            this.descriptionLbl = new System.Windows.Forms.Label();
            this.resolutionLbl = new System.Windows.Forms.Label();
            this.resolutionRichTxtBox = new System.Windows.Forms.RichTextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.createBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stdNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(12, 9);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(564, 67);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Safety Program";
            this.titleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameLbl
            // 
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.Location = new System.Drawing.Point(12, 87);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(240, 34);
            this.nameLbl.TabIndex = 1;
            this.nameLbl.Text = "Name";
            this.nameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxtBox.Location = new System.Drawing.Point(12, 129);
            this.nameTxtBox.Multiline = true;
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(240, 28);
            this.nameTxtBox.TabIndex = 2;
            // 
            // dateLbl
            // 
            this.dateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLbl.Location = new System.Drawing.Point(120, 160);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(344, 34);
            this.dateLbl.TabIndex = 3;
            this.dateLbl.Text = "Date";
            this.dateLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stdNumLbl
            // 
            this.stdNumLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdNumLbl.Location = new System.Drawing.Point(332, 83);
            this.stdNumLbl.Name = "stdNumLbl";
            this.stdNumLbl.Size = new System.Drawing.Size(240, 42);
            this.stdNumLbl.TabIndex = 5;
            this.stdNumLbl.Text = "Student number";
            this.stdNumLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stdNumericUpDown
            // 
            this.stdNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdNumericUpDown.Location = new System.Drawing.Point(332, 129);
            this.stdNumericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.stdNumericUpDown.Name = "stdNumericUpDown";
            this.stdNumericUpDown.Size = new System.Drawing.Size(240, 29);
            this.stdNumericUpDown.TabIndex = 7;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(120, 197);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(344, 29);
            this.dateTimePicker.TabIndex = 8;
            // 
            // descriptionRichTxtBox
            // 
            this.descriptionRichTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionRichTxtBox.Location = new System.Drawing.Point(14, 299);
            this.descriptionRichTxtBox.Name = "descriptionRichTxtBox";
            this.descriptionRichTxtBox.Size = new System.Drawing.Size(560, 96);
            this.descriptionRichTxtBox.TabIndex = 9;
            this.descriptionRichTxtBox.Text = "";
            // 
            // descriptionLbl
            // 
            this.descriptionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLbl.Location = new System.Drawing.Point(13, 245);
            this.descriptionLbl.Name = "descriptionLbl";
            this.descriptionLbl.Size = new System.Drawing.Size(560, 51);
            this.descriptionLbl.TabIndex = 11;
            this.descriptionLbl.Text = "Describe the situation";
            this.descriptionLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resolutionLbl
            // 
            this.resolutionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resolutionLbl.Location = new System.Drawing.Point(13, 424);
            this.resolutionLbl.Name = "resolutionLbl";
            this.resolutionLbl.Size = new System.Drawing.Size(560, 51);
            this.resolutionLbl.TabIndex = 13;
            this.resolutionLbl.Text = "Describe how the situation was resolved";
            this.resolutionLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resolutionRichTxtBox
            // 
            this.resolutionRichTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resolutionRichTxtBox.Location = new System.Drawing.Point(14, 478);
            this.resolutionRichTxtBox.Name = "resolutionRichTxtBox";
            this.resolutionRichTxtBox.Size = new System.Drawing.Size(560, 96);
            this.resolutionRichTxtBox.TabIndex = 12;
            this.resolutionRichTxtBox.Text = "";
            // 
            // submitBtn
            // 
            this.submitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.Location = new System.Drawing.Point(12, 687);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(560, 62);
            this.submitBtn.TabIndex = 14;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // createBtn
            // 
            this.createBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBtn.Location = new System.Drawing.Point(12, 608);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(562, 62);
            this.createBtn.TabIndex = 15;
            this.createBtn.Text = "Create excel document";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // SafetyProgramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 761);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.resolutionLbl);
            this.Controls.Add(this.resolutionRichTxtBox);
            this.Controls.Add(this.descriptionLbl);
            this.Controls.Add(this.descriptionRichTxtBox);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.stdNumericUpDown);
            this.Controls.Add(this.stdNumLbl);
            this.Controls.Add(this.dateLbl);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.titleLbl);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 800);
            this.MinimizeBox = false;
            this.Name = "SafetyProgramForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Safety Program v2.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stdNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.Label stdNumLbl;
        private System.Windows.Forms.NumericUpDown stdNumericUpDown;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.RichTextBox descriptionRichTxtBox;
        private System.Windows.Forms.Label descriptionLbl;
        private System.Windows.Forms.Label resolutionLbl;
        private System.Windows.Forms.RichTextBox resolutionRichTxtBox;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button createBtn;
    }
}

