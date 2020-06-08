namespace Flotta.Views
{
    partial class MuszakiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MuszakiForm));
            this.labelCimke = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewMuszaki = new System.Windows.Forms.DataGridView();
            this.textBoxSofNev = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSofTel = new System.Windows.Forms.TextBox();
            this.errorProviderDB = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStripButtonVissza = new System.Windows.Forms.Button();
            this.toolStripButtonKeres = new System.Windows.Forms.Button();
            this.toolStripTextBoxKeres = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.errorProviderKeres = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMuszaki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderKeres)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCimke
            // 
            this.labelCimke.AutoSize = true;
            this.labelCimke.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.labelCimke.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.labelCimke.Location = new System.Drawing.Point(236, 12);
            this.labelCimke.Name = "labelCimke";
            this.labelCimke.Size = new System.Drawing.Size(350, 45);
            this.labelCimke.TabIndex = 27;
            this.labelCimke.Text = "Műszaki esedékesség";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.Location = new System.Drawing.Point(637, 618);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 50);
            this.button1.TabIndex = 29;
            this.button1.Text = "Főoldal";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataGridViewMuszaki
            // 
            this.dataGridViewMuszaki.AllowUserToAddRows = false;
            this.dataGridViewMuszaki.AllowUserToDeleteRows = false;
            this.dataGridViewMuszaki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMuszaki.Location = new System.Drawing.Point(12, 98);
            this.dataGridViewMuszaki.Name = "dataGridViewMuszaki";
            this.dataGridViewMuszaki.ReadOnly = true;
            this.dataGridViewMuszaki.RowTemplate.Height = 24;
            this.dataGridViewMuszaki.Size = new System.Drawing.Size(344, 523);
            this.dataGridViewMuszaki.TabIndex = 30;
            this.dataGridViewMuszaki.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewMuszaki_ColumnHeaderMouseClick);
            this.dataGridViewMuszaki.Click += new System.EventHandler(this.dataGridViewMuszaki_Click);
            // 
            // textBoxSofNev
            // 
            this.textBoxSofNev.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSofNev.Location = new System.Drawing.Point(451, 126);
            this.textBoxSofNev.Name = "textBoxSofNev";
            this.textBoxSofNev.ReadOnly = true;
            this.textBoxSofNev.Size = new System.Drawing.Size(336, 30);
            this.textBoxSofNev.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Location = new System.Drawing.Point(446, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "Sofőr neve:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Location = new System.Drawing.Point(446, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 25);
            this.label2.TabIndex = 32;
            this.label2.Text = "Sofőr telefonszáma:";
            // 
            // textBoxSofTel
            // 
            this.textBoxSofTel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSofTel.Location = new System.Drawing.Point(451, 219);
            this.textBoxSofTel.Name = "textBoxSofTel";
            this.textBoxSofTel.ReadOnly = true;
            this.textBoxSofTel.Size = new System.Drawing.Size(336, 30);
            this.textBoxSofTel.TabIndex = 31;
            // 
            // errorProviderDB
            // 
            this.errorProviderDB.ContainerControl = this;
            this.errorProviderDB.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderDB.Icon")));
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Location = new System.Drawing.Point(163, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 1);
            this.panel1.TabIndex = 57;
            // 
            // toolStripButtonVissza
            // 
            this.toolStripButtonVissza.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.toolStripButtonVissza.BackColor = System.Drawing.Color.Transparent;
            this.toolStripButtonVissza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toolStripButtonVissza.FlatAppearance.BorderSize = 0;
            this.toolStripButtonVissza.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.toolStripButtonVissza.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.toolStripButtonVissza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toolStripButtonVissza.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.toolStripButtonVissza.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.toolStripButtonVissza.Location = new System.Drawing.Point(339, 633);
            this.toolStripButtonVissza.Name = "toolStripButtonVissza";
            this.toolStripButtonVissza.Size = new System.Drawing.Size(101, 39);
            this.toolStripButtonVissza.TabIndex = 58;
            this.toolStripButtonVissza.Text = "Vissza";
            this.toolStripButtonVissza.UseVisualStyleBackColor = false;
            this.toolStripButtonVissza.Click += new System.EventHandler(this.toolStripButtonVissza_Click);
            // 
            // toolStripButtonKeres
            // 
            this.toolStripButtonKeres.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.toolStripButtonKeres.BackColor = System.Drawing.Color.Transparent;
            this.toolStripButtonKeres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toolStripButtonKeres.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolStripButtonKeres.FlatAppearance.BorderSize = 0;
            this.toolStripButtonKeres.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.toolStripButtonKeres.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.toolStripButtonKeres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toolStripButtonKeres.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.toolStripButtonKeres.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.toolStripButtonKeres.Location = new System.Drawing.Point(205, 633);
            this.toolStripButtonKeres.Name = "toolStripButtonKeres";
            this.toolStripButtonKeres.Size = new System.Drawing.Size(112, 39);
            this.toolStripButtonKeres.TabIndex = 59;
            this.toolStripButtonKeres.Text = "Keres";
            this.toolStripButtonKeres.UseVisualStyleBackColor = false;
            this.toolStripButtonKeres.Click += new System.EventHandler(this.toolStripButtonKeres_Click);
            // 
            // toolStripTextBoxKeres
            // 
            this.toolStripTextBoxKeres.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.toolStripTextBoxKeres.Location = new System.Drawing.Point(12, 637);
            this.toolStripTextBoxKeres.Name = "toolStripTextBoxKeres";
            this.toolStripTextBoxKeres.Size = new System.Drawing.Size(187, 31);
            this.toolStripTextBoxKeres.TabIndex = 60;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(748, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 40);
            this.button2.TabIndex = 61;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorProviderKeres
            // 
            this.errorProviderKeres.ContainerControl = this;
            this.errorProviderKeres.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderKeres.Icon")));
            // 
            // MuszakiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 680);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.toolStripTextBoxKeres);
            this.Controls.Add(this.toolStripButtonVissza);
            this.Controls.Add(this.toolStripButtonKeres);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSofTel);
            this.Controls.Add(this.textBoxSofNev);
            this.Controls.Add(this.dataGridViewMuszaki);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelCimke);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 680);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 680);
            this.Name = "MuszakiForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flotta - Műszaki esedékesség";
            this.Load += new System.EventHandler(this.MuszakiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMuszaki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderKeres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelCimke;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewMuszaki;
        private System.Windows.Forms.TextBox textBoxSofNev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSofTel;
        private System.Windows.Forms.ErrorProvider errorProviderDB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button toolStripButtonVissza;
        private System.Windows.Forms.Button toolStripButtonKeres;
        private System.Windows.Forms.TextBox toolStripTextBoxKeres;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider errorProviderKeres;
    }
}