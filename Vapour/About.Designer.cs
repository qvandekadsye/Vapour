namespace Vapour
{
    partial class About
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
            this.l_qvdk = new System.Windows.Forms.Label();
            this.lw_qvdk = new System.Windows.Forms.LinkLabel();
            this.lw_GH = new System.Windows.Forms.LinkLabel();
            this.btn_about_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // l_qvdk
            // 
            this.l_qvdk.AutoSize = true;
            this.l_qvdk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.l_qvdk.Location = new System.Drawing.Point(28, 9);
            this.l_qvdk.Name = "l_qvdk";
            this.l_qvdk.Size = new System.Drawing.Size(222, 13);
            this.l_qvdk.TabIndex = 0;
            this.l_qvdk.Text = "Vapour v 1.0 - Quentin Van de Kadsye - 2015";
            // 
            // lw_qvdk
            // 
            this.lw_qvdk.AutoSize = true;
            this.lw_qvdk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.lw_qvdk.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.lw_qvdk.Location = new System.Drawing.Point(60, 36);
            this.lw_qvdk.Name = "lw_qvdk";
            this.lw_qvdk.Size = new System.Drawing.Size(157, 13);
            this.lw_qvdk.TabIndex = 1;
            this.lw_qvdk.TabStop = true;
            this.lw_qvdk.Text = "http://qvandekadsye.legtux.org";
            this.lw_qvdk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lw_qvdk_LinkClicked);
            // 
            // lw_GH
            // 
            this.lw_GH.AutoSize = true;
            this.lw_GH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.lw_GH.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.lw_GH.Location = new System.Drawing.Point(60, 62);
            this.lw_GH.Name = "lw_GH";
            this.lw_GH.Size = new System.Drawing.Size(170, 13);
            this.lw_GH.TabIndex = 2;
            this.lw_GH.TabStop = true;
            this.lw_GH.Text = "https://github.com/qvandekadsye";
            this.lw_GH.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lw_GH_LinkClicked);
            // 
            // btn_about_OK
            // 
            this.btn_about_OK.BackColor = System.Drawing.Color.Black;
            this.btn_about_OK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btn_about_OK.Location = new System.Drawing.Point(102, 89);
            this.btn_about_OK.Name = "btn_about_OK";
            this.btn_about_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_about_OK.TabIndex = 3;
            this.btn_about_OK.Text = "Ok";
            this.btn_about_OK.UseVisualStyleBackColor = false;
            this.btn_about_OK.Click += new System.EventHandler(this.btn_about_OK_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(284, 126);
            this.Controls.Add(this.btn_about_OK);
            this.Controls.Add(this.lw_GH);
            this.Controls.Add(this.lw_qvdk);
            this.Controls.Add(this.l_qvdk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "A propos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_qvdk;
        private System.Windows.Forms.LinkLabel lw_qvdk;
        private System.Windows.Forms.LinkLabel lw_GH;
        private System.Windows.Forms.Button btn_about_OK;
    }
}