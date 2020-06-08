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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemFooldal = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSzervizek = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemMuszaki = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemGepjarmuvek = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFelszerelesek = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemProfilom = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonKilepes = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProviderDBError = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDBError2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDBError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDBError2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Transparent;
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
            this.menuStrip.Size = new System.Drawing.Size(1150, 36);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // toolStripMenuItemFooldal
            // 
            this.toolStripMenuItemFooldal.Name = "toolStripMenuItemFooldal";
            this.toolStripMenuItemFooldal.Size = new System.Drawing.Size(90, 32);
            this.toolStripMenuItemFooldal.Text = "Főoldal";
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
            // buttonKilepes
            // 
            this.buttonKilepes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonKilepes.BackColor = System.Drawing.Color.Transparent;
            this.buttonKilepes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonKilepes.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonKilepes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.buttonKilepes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonKilepes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKilepes.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonKilepes.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonKilepes.Location = new System.Drawing.Point(972, 586);
            this.buttonKilepes.Name = "buttonKilepes";
            this.buttonKilepes.Size = new System.Drawing.Size(125, 50);
            this.buttonKilepes.TabIndex = 10;
            this.buttonKilepes.Text = "Kilépés";
            this.buttonKilepes.UseVisualStyleBackColor = false;
            this.buttonKilepes.Click += new System.EventHandler(this.buttonKilepes_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonKilepes, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 36);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1150, 644);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1138, 535);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // errorProviderDBError
            // 
            this.errorProviderDBError.ContainerControl = this;
            this.errorProviderDBError.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderDBError.Icon")));
            this.errorProviderDBError.Tag = "";
            // 
            // errorProviderDBError2
            // 
            this.errorProviderDBError2.ContainerControl = this;
            this.errorProviderDBError2.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderDBError2.Icon")));
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Location = new System.Drawing.Point(1094, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 36);
            this.button1.TabIndex = 58;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1150, 680);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1150, 680);
            this.MinimumSize = new System.Drawing.Size(1150, 680);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flotta - Főoldal";
            this.TransparencyKey = System.Drawing.Color.Thistle;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDBError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDBError2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFooldal;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSzervizek;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemMuszaki;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemGepjarmuvek;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFelszerelesek;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemProfilom;
        private System.Windows.Forms.Button buttonKilepes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProviderDBError;
        private System.Windows.Forms.ErrorProvider errorProviderDBError2;
        private System.Windows.Forms.Button button1;
    }
}



