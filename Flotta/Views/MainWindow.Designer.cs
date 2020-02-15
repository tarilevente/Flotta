namespace Flotta.Views
{
    partial class MainWindow
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemFooldal = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSzervizek = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemMuszaki = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemGepjarmuvek = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFelszerelesek = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemProfilom = new System.Windows.Forms.ToolStripMenuItem();
            this.szervizkonyvtablaTableAdapter = new Flotta.autokDataSetTableAdapters.szervizkonyvtablaTableAdapter();
            this.buttonKilepes = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFooldal,
            this.toolStripMenuItemSzervizek,
            this.toolStripMenuItemMuszaki,
            this.toolStripMenuItemGepjarmuvek,
            this.toolStripMenuItemFelszerelesek,
            this.toolStripMenuItemProfilom});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1012, 36);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // toolStripMenuItemFooldal
            // 
            this.toolStripMenuItemFooldal.Name = "toolStripMenuItemFooldal";
            this.toolStripMenuItemFooldal.Size = new System.Drawing.Size(90, 32);
            this.toolStripMenuItemFooldal.Text = "Főoldal";
            this.toolStripMenuItemFooldal.Click += new System.EventHandler(this.toolStripMenuItemFooldal_Click);
            // 
            // toolStripMenuItemSzervizek
            // 
            this.toolStripMenuItemSzervizek.Name = "toolStripMenuItemSzervizek";
            this.toolStripMenuItemSzervizek.Size = new System.Drawing.Size(104, 32);
            this.toolStripMenuItemSzervizek.Text = "Szervizek";
            this.toolStripMenuItemSzervizek.Click += new System.EventHandler(this.toolStripMenuItemSzervizek_Click);
            // 
            // toolStripMenuItemMuszaki
            // 
            this.toolStripMenuItemMuszaki.Name = "toolStripMenuItemMuszaki";
            this.toolStripMenuItemMuszaki.Size = new System.Drawing.Size(208, 32);
            this.toolStripMenuItemMuszaki.Text = "Műszaki esedékesség";
            this.toolStripMenuItemMuszaki.Click += new System.EventHandler(this.toolStripMenuItemMuszaki_Click);
            // 
            // toolStripMenuItemGepjarmuvek
            // 
            this.toolStripMenuItemGepjarmuvek.Name = "toolStripMenuItemGepjarmuvek";
            this.toolStripMenuItemGepjarmuvek.Size = new System.Drawing.Size(140, 32);
            this.toolStripMenuItemGepjarmuvek.Text = "Gépjárművek";
            this.toolStripMenuItemGepjarmuvek.Click += new System.EventHandler(this.toolStripMenuItemGepjarmuvek_Click);
            // 
            // toolStripMenuItemFelszerelesek
            // 
            this.toolStripMenuItemFelszerelesek.Name = "toolStripMenuItemFelszerelesek";
            this.toolStripMenuItemFelszerelesek.Size = new System.Drawing.Size(112, 32);
            this.toolStripMenuItemFelszerelesek.Text = "Áttekintés";
            this.toolStripMenuItemFelszerelesek.Click += new System.EventHandler(this.toolStripMenuItemFelszerelesek_Click);
            // 
            // toolStripMenuItemProfilom
            // 
            this.toolStripMenuItemProfilom.Name = "toolStripMenuItemProfilom";
            this.toolStripMenuItemProfilom.Size = new System.Drawing.Size(132, 32);
            this.toolStripMenuItemProfilom.Text = "Profilkezelés";
            this.toolStripMenuItemProfilom.Click += new System.EventHandler(this.toolStripMenuItemProfilom_Click);
            // 
            // szervizkonyvtablaTableAdapter
            // 
            this.szervizkonyvtablaTableAdapter.ClearBeforeFill = true;
            // 
            // buttonKilepes
            // 
            this.buttonKilepes.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonKilepes.Location = new System.Drawing.Point(857, 481);
            this.buttonKilepes.Name = "buttonKilepes";
            this.buttonKilepes.Size = new System.Drawing.Size(112, 45);
            this.buttonKilepes.TabIndex = 10;
            this.buttonKilepes.Text = "Kilépés";
            this.buttonKilepes.UseVisualStyleBackColor = true;
            this.buttonKilepes.Click += new System.EventHandler(this.buttonKilepes_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 558);
            this.Controls.Add(this.buttonKilepes);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1030, 605);
            this.MinimumSize = new System.Drawing.Size(1030, 605);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flotta - Főoldal";
            this.TransparencyKey = System.Drawing.Color.Thistle;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private autokDataSetTableAdapters.szervizkonyvtablaTableAdapter szervizkonyvtablaTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFooldal;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSzervizek;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemMuszaki;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemGepjarmuvek;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFelszerelesek;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemProfilom;
        private System.Windows.Forms.Button buttonKilepes;
    }
}



