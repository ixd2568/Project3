namespace Project3
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.resetFormButton = new System.Windows.Forms.Button();
            this.showResultsButton = new System.Windows.Forms.Button();
            this.zipBox = new System.Windows.Forms.TextBox();
            this.countyBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.citiesCombo = new System.Windows.Forms.ComboBox();
            this.statesCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.orgNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.orgTypeCombo = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.resetFormButton);
            this.groupBox1.Controls.Add(this.showResultsButton);
            this.groupBox1.Controls.Add(this.zipBox);
            this.groupBox1.Controls.Add(this.countyBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.citiesCombo);
            this.groupBox1.Controls.Add(this.statesCombo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.orgNameBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.orgTypeCombo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 232);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Criteria";
            // 
            // resetFormButton
            // 
            this.resetFormButton.Location = new System.Drawing.Point(243, 194);
            this.resetFormButton.Name = "resetFormButton";
            this.resetFormButton.Size = new System.Drawing.Size(93, 23);
            this.resetFormButton.TabIndex = 12;
            this.resetFormButton.Text = "Reset Form";
            this.resetFormButton.UseVisualStyleBackColor = true;
            this.resetFormButton.Click += new System.EventHandler(this.resetFormButton_Click);
            // 
            // showResultsButton
            // 
            this.showResultsButton.Location = new System.Drawing.Point(9, 194);
            this.showResultsButton.Name = "showResultsButton";
            this.showResultsButton.Size = new System.Drawing.Size(93, 23);
            this.showResultsButton.TabIndex = 11;
            this.showResultsButton.Text = "Show Results";
            this.showResultsButton.UseVisualStyleBackColor = true;
            this.showResultsButton.Click += new System.EventHandler(this.showResultsButton_Click);
            // 
            // zipBox
            // 
            this.zipBox.Location = new System.Drawing.Point(133, 146);
            this.zipBox.Name = "zipBox";
            this.zipBox.Size = new System.Drawing.Size(203, 20);
            this.zipBox.TabIndex = 10;
            // 
            // countyBox
            // 
            this.countyBox.Location = new System.Drawing.Point(133, 118);
            this.countyBox.Name = "countyBox";
            this.countyBox.Size = new System.Drawing.Size(203, 20);
            this.countyBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Zip Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "County";
            // 
            // citiesCombo
            // 
            this.citiesCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.citiesCombo.FormattingEnabled = true;
            this.citiesCombo.Location = new System.Drawing.Point(193, 90);
            this.citiesCombo.Name = "citiesCombo";
            this.citiesCombo.Size = new System.Drawing.Size(143, 21);
            this.citiesCombo.TabIndex = 6;
            // 
            // statesCombo
            // 
            this.statesCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statesCombo.FormattingEnabled = true;
            this.statesCombo.Items.AddRange(new object[] {
            "-All-",
            "AK",
            "AL",
            "AR",
            "AZ",
            "CA",
            "CO",
            "CT",
            "DC",
            "DE",
            "FL",
            "GA",
            "HI",
            "IA",
            "ID",
            "IL",
            "IN",
            "KS",
            "KY",
            "LA",
            "MA",
            "MD",
            "ME",
            "MI",
            "MN",
            "MO",
            "MS",
            "MT",
            "NC",
            "ND",
            "NE",
            "NH",
            "NJ",
            "NM",
            "NV",
            "NY",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VA",
            "VT",
            "WA",
            "WI",
            "WV"});
            this.statesCombo.Location = new System.Drawing.Point(133, 90);
            this.statesCombo.Name = "statesCombo";
            this.statesCombo.Size = new System.Drawing.Size(53, 21);
            this.statesCombo.TabIndex = 5;
            this.statesCombo.SelectedIndexChanged += new System.EventHandler(this.statesCombo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "State";
            // 
            // orgNameBox
            // 
            this.orgNameBox.Location = new System.Drawing.Point(133, 62);
            this.orgNameBox.Name = "orgNameBox";
            this.orgNameBox.Size = new System.Drawing.Size(203, 20);
            this.orgNameBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Organization Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Organization Type";
            // 
            // orgTypeCombo
            // 
            this.orgTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orgTypeCombo.FormattingEnabled = true;
            this.orgTypeCombo.Location = new System.Drawing.Point(133, 34);
            this.orgTypeCombo.Name = "orgTypeCombo";
            this.orgTypeCombo.Size = new System.Drawing.Size(203, 21);
            this.orgTypeCombo.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 256);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Organization Search";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox orgNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox orgTypeCombo;
        private System.Windows.Forms.ComboBox statesCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox citiesCombo;
        private System.Windows.Forms.Button resetFormButton;
        private System.Windows.Forms.Button showResultsButton;
        private System.Windows.Forms.TextBox zipBox;
        private System.Windows.Forms.TextBox countyBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;

    }
}

