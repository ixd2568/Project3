namespace Project3.View
{
    partial class Results
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
            this.orgData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.orgData)).BeginInit();
            this.SuspendLayout();
            // 
            // orgData
            // 
            this.orgData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.orgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orgData.Location = new System.Drawing.Point(12, 12);
            this.orgData.Name = "orgData";
            this.orgData.Size = new System.Drawing.Size(776, 478);
            this.orgData.TabIndex = 0;
            this.orgData.SelectionChanged += new System.EventHandler(this.orgData_SelectionChanged);
            this.orgData.MouseDown += new System.Windows.Forms.MouseEventHandler(this.orgData_MouseDown);
            this.orgData.MouseUp += new System.Windows.Forms.MouseEventHandler(this.orgData_MouseUp);
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.orgData);
            this.Name = "Results";
            this.Text = "Results";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Results_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.orgData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView orgData;
    }
}