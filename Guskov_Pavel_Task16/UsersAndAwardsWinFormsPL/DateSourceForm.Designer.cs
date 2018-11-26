namespace UsersAndAwardsWinFormsPL
{
    partial class DateSourceForm
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
            this.lblDataSelect = new System.Windows.Forms.Label();
            this.btnRam = new System.Windows.Forms.Button();
            this.btnDB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDataSelect
            // 
            this.lblDataSelect.AutoSize = true;
            this.lblDataSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDataSelect.Location = new System.Drawing.Point(12, 9);
            this.lblDataSelect.Name = "lblDataSelect";
            this.lblDataSelect.Size = new System.Drawing.Size(170, 24);
            this.lblDataSelect.TabIndex = 0;
            this.lblDataSelect.Text = "Select Data Source";
            // 
            // btnRam
            // 
            this.btnRam.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnRam.Location = new System.Drawing.Point(16, 48);
            this.btnRam.Name = "btnRam";
            this.btnRam.Size = new System.Drawing.Size(75, 23);
            this.btnRam.TabIndex = 1;
            this.btnRam.Text = "RAM";
            this.btnRam.UseVisualStyleBackColor = true;
            // 
            // btnDB
            // 
            this.btnDB.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnDB.Location = new System.Drawing.Point(107, 48);
            this.btnDB.Name = "btnDB";
            this.btnDB.Size = new System.Drawing.Size(75, 23);
            this.btnDB.TabIndex = 2;
            this.btnDB.Text = "Data Base";
            this.btnDB.UseVisualStyleBackColor = true;
            // 
            // DateSourceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 85);
            this.Controls.Add(this.btnDB);
            this.Controls.Add(this.btnRam);
            this.Controls.Add(this.lblDataSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DateSourceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Data Source";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDataSelect;
        private System.Windows.Forms.Button btnRam;
        private System.Windows.Forms.Button btnDB;
    }
}