namespace Vapour
{
    partial class Main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_URL_Steam = new System.Windows.Forms.Label();
            this.t_steamURL = new System.Windows.Forms.TextBox();
            this.l_action = new System.Windows.Forms.Label();
            this.choicebox = new System.Windows.Forms.ComboBox();
            this.btn_lancer = new System.Windows.Forms.Button();
            this.aProposToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aProposToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(424, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGray;
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.aProposToolStripMenuItem.Text = "A propos";
            this.aProposToolStripMenuItem.Click += new System.EventHandler(this.aProposToolStripMenuItem1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.34837F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.65163F));
            this.tableLayoutPanel1.Controls.Add(this.label_URL_Steam, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.t_steamURL, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.l_action, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.choicebox, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.30769F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.76923F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.92308F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(399, 104);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label_URL_Steam
            // 
            this.label_URL_Steam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label_URL_Steam.Location = new System.Drawing.Point(3, 0);
            this.label_URL_Steam.Name = "label_URL_Steam";
            this.label_URL_Steam.Size = new System.Drawing.Size(150, 23);
            this.label_URL_Steam.TabIndex = 0;
            this.label_URL_Steam.Text = "Entrez l\'url de la page steam :";
            this.label_URL_Steam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // t_steamURL
            // 
            this.t_steamURL.BackColor = System.Drawing.Color.Black;
            this.t_steamURL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.t_steamURL.Location = new System.Drawing.Point(159, 3);
            this.t_steamURL.Name = "t_steamURL";
            this.t_steamURL.Size = new System.Drawing.Size(237, 20);
            this.t_steamURL.TabIndex = 1;
            // 
            // l_action
            // 
            this.l_action.AutoSize = true;
            this.l_action.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.l_action.Location = new System.Drawing.Point(3, 43);
            this.l_action.Name = "l_action";
            this.l_action.Size = new System.Drawing.Size(93, 13);
            this.l_action.TabIndex = 2;
            this.l_action.Text = "Choisisez l\'action :";
            // 
            // choicebox
            // 
            this.choicebox.BackColor = System.Drawing.Color.Black;
            this.choicebox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.choicebox.FormattingEnabled = true;
            this.choicebox.Items.AddRange(new object[] {
            "Vérifier la compatibilité avec le jeu",
            "Ouvrir le gestionnaire de backup",
            "Installer un(e) application/jeu",
            "Valider les fichiers locaux d\'une application"});
            this.choicebox.Location = new System.Drawing.Point(159, 46);
            this.choicebox.Name = "choicebox";
            this.choicebox.Size = new System.Drawing.Size(237, 21);
            this.choicebox.TabIndex = 3;
            // 
            // btn_lancer
            // 
            this.btn_lancer.BackColor = System.Drawing.Color.Black;
            this.btn_lancer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btn_lancer.Location = new System.Drawing.Point(172, 149);
            this.btn_lancer.Name = "btn_lancer";
            this.btn_lancer.Size = new System.Drawing.Size(75, 23);
            this.btn_lancer.TabIndex = 4;
            this.btn_lancer.Text = "Lancer";
            this.btn_lancer.UseVisualStyleBackColor = false;
            this.btn_lancer.Click += new System.EventHandler(this.button1_Click);
            // 
            // aProposToolStripMenuItem1
            // 
            this.aProposToolStripMenuItem1.ForeColor = System.Drawing.Color.DarkGray;
            this.aProposToolStripMenuItem1.Name = "aProposToolStripMenuItem1";
            this.aProposToolStripMenuItem1.Size = new System.Drawing.Size(67, 20);
            this.aProposToolStripMenuItem1.Text = "A propos";
            this.aProposToolStripMenuItem1.Click += new System.EventHandler(this.aProposToolStripMenuItem1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(424, 196);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btn_lancer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::Vapour.Properties.Resources.VapourIcon;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Vapour";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_URL_Steam;
        private System.Windows.Forms.TextBox t_steamURL;
        private System.Windows.Forms.Label l_action;
        private System.Windows.Forms.ComboBox choicebox;
        private System.Windows.Forms.Button btn_lancer;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem1;
    }
}

