namespace LB_BasicThreading
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
            this.BtnRUN = new System.Windows.Forms.Button();
            this.lblThreadStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnRUN
            // 
            this.BtnRUN.Location = new System.Drawing.Point(290, 242);
            this.BtnRUN.Name = "BtnRUN";
            this.BtnRUN.Size = new System.Drawing.Size(194, 53);
            this.BtnRUN.TabIndex = 3;
            this.BtnRUN.Text = "RUN";
            this.BtnRUN.UseVisualStyleBackColor = true;
            // 
            // lblThreadStatus
            // 
            this.lblThreadStatus.AutoSize = true;
            this.lblThreadStatus.Font = new System.Drawing.Font("Microsoft Tai Le", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThreadStatus.Location = new System.Drawing.Point(187, 156);
            this.lblThreadStatus.Name = "lblThreadStatus";
            this.lblThreadStatus.Size = new System.Drawing.Size(426, 45);
            this.lblThreadStatus.TabIndex = 2;
            this.lblThreadStatus.Text = "-Before Starting Thread-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnRUN);
            this.Controls.Add(this.lblThreadStatus);
            this.Name = "Form1";
            this.Text = "FrmThreading";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRUN;
        private System.Windows.Forms.Label lblThreadStatus;
    }
}

