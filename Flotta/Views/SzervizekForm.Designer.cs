namespace Flotta.Views
{
    partial class SzervizekForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SzervizekForm));
            this.listBoxRendszamok = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxRendszam = new System.Windows.Forms.TextBox();
            this.textBoxTipus = new System.Windows.Forms.TextBox();
            this.textBoxKm = new System.Windows.Forms.TextBox();
            this.textBoxGyartmany = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMuszaki = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxBizt = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxIdopont = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxIdopont = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanelNav = new System.Windows.Forms.TableLayoutPanel();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.labelpage = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonUj = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonTorles = new System.Windows.Forms.Button();
            this.errorProviderErrorDB = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderKeres = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBoxLeiras = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanelNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderErrorDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderKeres)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxRendszamok
            // 
            this.listBoxRendszamok.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxRendszamok.FormattingEnabled = true;
            this.listBoxRendszamok.ItemHeight = 25;
            this.listBoxRendszamok.Location = new System.Drawing.Point(22, 74);
            this.listBoxRendszamok.Name = "listBoxRendszamok";
            this.listBoxRendszamok.Size = new System.Drawing.Size(164, 554);
            this.listBoxRendszamok.TabIndex = 2;
            this.listBoxRendszamok.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBoxRendszamok_MouseClick);
            this.listBoxRendszamok.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listBoxRendszamok_KeyUp);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.24569F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.43103F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.21552F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxRendszam, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxTipus, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxKm, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxGyartmany, 1, 1);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(204, 74);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(928, 71);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Location = new System.Drawing.Point(228, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gyártmány";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rendszám";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.Location = new System.Drawing.Point(464, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Típus";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label4.Location = new System.Drawing.Point(698, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Km";
            // 
            // textBoxRendszam
            // 
            this.textBoxRendszam.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxRendszam.Location = new System.Drawing.Point(3, 38);
            this.textBoxRendszam.Name = "textBoxRendszam";
            this.textBoxRendszam.ReadOnly = true;
            this.textBoxRendszam.Size = new System.Drawing.Size(205, 30);
            this.textBoxRendszam.TabIndex = 4;
            // 
            // textBoxTipus
            // 
            this.textBoxTipus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxTipus.Location = new System.Drawing.Point(464, 38);
            this.textBoxTipus.Name = "textBoxTipus";
            this.textBoxTipus.ReadOnly = true;
            this.textBoxTipus.Size = new System.Drawing.Size(205, 30);
            this.textBoxTipus.TabIndex = 6;
            // 
            // textBoxKm
            // 
            this.textBoxKm.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxKm.Location = new System.Drawing.Point(698, 38);
            this.textBoxKm.Name = "textBoxKm";
            this.textBoxKm.ReadOnly = true;
            this.textBoxKm.Size = new System.Drawing.Size(205, 30);
            this.textBoxKm.TabIndex = 7;
            // 
            // textBoxGyartmany
            // 
            this.textBoxGyartmany.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxGyartmany.Location = new System.Drawing.Point(228, 38);
            this.textBoxGyartmany.Name = "textBoxGyartmany";
            this.textBoxGyartmany.ReadOnly = true;
            this.textBoxGyartmany.Size = new System.Drawing.Size(205, 30);
            this.textBoxGyartmany.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.32432F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.43103F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxMuszaki, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxBizt, 3, 0);
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(204, 148);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(928, 41);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Műszaki érvényesség";
            // 
            // textBoxMuszaki
            // 
            this.textBoxMuszaki.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxMuszaki.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxMuszaki.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMuszaki.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxMuszaki.Location = new System.Drawing.Point(229, 9);
            this.textBoxMuszaki.Name = "textBoxMuszaki";
            this.textBoxMuszaki.ReadOnly = true;
            this.textBoxMuszaki.Size = new System.Drawing.Size(204, 23);
            this.textBoxMuszaki.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label6.Location = new System.Drawing.Point(465, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Biztosítás érvényesség";
            // 
            // textBoxBizt
            // 
            this.textBoxBizt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxBizt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxBizt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBizt.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxBizt.Location = new System.Drawing.Point(697, 9);
            this.textBoxBizt.Name = "textBoxBizt";
            this.textBoxBizt.ReadOnly = true;
            this.textBoxBizt.Size = new System.Drawing.Size(207, 23);
            this.textBoxBizt.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.35345F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.43103F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.10776F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBoxIdopont, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label7, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.comboBoxIdopont, 3, 0);
            this.tableLayoutPanel3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(204, 190);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(928, 54);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label8.Location = new System.Drawing.Point(3, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 23);
            this.label8.TabIndex = 1;
            this.label8.Text = "Szervizelés időpontja";
            // 
            // textBoxIdopont
            // 
            this.textBoxIdopont.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxIdopont.Location = new System.Drawing.Point(229, 12);
            this.textBoxIdopont.Name = "textBoxIdopont";
            this.textBoxIdopont.ReadOnly = true;
            this.textBoxIdopont.Size = new System.Drawing.Size(204, 30);
            this.textBoxIdopont.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label7.Location = new System.Drawing.Point(465, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 23);
            this.label7.TabIndex = 3;
            this.label7.Text = "Ugrás időponthoz";
            // 
            // comboBoxIdopont
            // 
            this.comboBoxIdopont.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxIdopont.BackColor = System.Drawing.Color.PeachPuff;
            this.comboBoxIdopont.FormattingEnabled = true;
            this.comboBoxIdopont.Location = new System.Drawing.Point(698, 14);
            this.comboBoxIdopont.Name = "comboBoxIdopont";
            this.comboBoxIdopont.Size = new System.Drawing.Size(205, 31);
            this.comboBoxIdopont.TabIndex = 4;
            this.comboBoxIdopont.SelectedIndexChanged += new System.EventHandler(this.comboBoxIdopont_SelectedIndexChanged);
            // 
            // tableLayoutPanelNav
            // 
            this.tableLayoutPanelNav.ColumnCount = 5;
            this.tableLayoutPanelNav.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.tableLayoutPanelNav.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.tableLayoutPanelNav.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.tableLayoutPanelNav.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.tableLayoutPanelNav.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.tableLayoutPanelNav.Controls.Add(this.buttonFirst, 0, 0);
            this.tableLayoutPanelNav.Controls.Add(this.buttonPrevious, 1, 0);
            this.tableLayoutPanelNav.Controls.Add(this.buttonNext, 3, 0);
            this.tableLayoutPanelNav.Controls.Add(this.buttonLast, 4, 0);
            this.tableLayoutPanelNav.Controls.Add(this.labelpage, 2, 0);
            this.tableLayoutPanelNav.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tableLayoutPanelNav.Location = new System.Drawing.Point(418, 601);
            this.tableLayoutPanelNav.Name = "tableLayoutPanelNav";
            this.tableLayoutPanelNav.RowCount = 1;
            this.tableLayoutPanelNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelNav.Size = new System.Drawing.Size(502, 50);
            this.tableLayoutPanelNav.TabIndex = 8;
            // 
            // buttonFirst
            // 
            this.buttonFirst.BackColor = System.Drawing.Color.Transparent;
            this.buttonFirst.FlatAppearance.BorderSize = 0;
            this.buttonFirst.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.buttonFirst.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFirst.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonFirst.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonFirst.Location = new System.Drawing.Point(3, 3);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(94, 32);
            this.buttonFirst.TabIndex = 0;
            this.buttonFirst.Text = "<<";
            this.buttonFirst.UseVisualStyleBackColor = false;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.BackColor = System.Drawing.Color.Transparent;
            this.buttonPrevious.FlatAppearance.BorderSize = 0;
            this.buttonPrevious.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.buttonPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrevious.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPrevious.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonPrevious.Location = new System.Drawing.Point(103, 3);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(94, 32);
            this.buttonPrevious.TabIndex = 0;
            this.buttonPrevious.Text = "<";
            this.buttonPrevious.UseVisualStyleBackColor = false;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.Transparent;
            this.buttonNext.FlatAppearance.BorderSize = 0;
            this.buttonNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.buttonNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNext.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonNext.Location = new System.Drawing.Point(303, 3);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(94, 32);
            this.buttonNext.TabIndex = 0;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonLast
            // 
            this.buttonLast.BackColor = System.Drawing.Color.Transparent;
            this.buttonLast.FlatAppearance.BorderSize = 0;
            this.buttonLast.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.buttonLast.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLast.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLast.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonLast.Location = new System.Drawing.Point(403, 3);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(96, 32);
            this.buttonLast.TabIndex = 0;
            this.buttonLast.Text = ">>";
            this.buttonLast.UseVisualStyleBackColor = false;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // labelpage
            // 
            this.labelpage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelpage.AutoSize = true;
            this.labelpage.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.labelpage.Location = new System.Drawing.Point(232, 13);
            this.labelpage.Name = "labelpage";
            this.labelpage.Size = new System.Drawing.Size(35, 23);
            this.labelpage.TabIndex = 1;
            this.labelpage.Text = "0/0";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.Location = new System.Drawing.Point(982, 601);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 50);
            this.button1.TabIndex = 9;
            this.button1.Text = "Főoldal";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonUj
            // 
            this.buttonUj.BackColor = System.Drawing.Color.Transparent;
            this.buttonUj.FlatAppearance.BorderSize = 0;
            this.buttonUj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.buttonUj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonUj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUj.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUj.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonUj.Location = new System.Drawing.Point(24, 626);
            this.buttonUj.Name = "buttonUj";
            this.buttonUj.Size = new System.Drawing.Size(162, 42);
            this.buttonUj.TabIndex = 10;
            this.buttonUj.Text = "Új bejegyzés";
            this.buttonUj.UseVisualStyleBackColor = false;
            this.buttonUj.Click += new System.EventHandler(this.buttonUj_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label9.Location = new System.Drawing.Point(323, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(542, 45);
            this.label9.TabIndex = 14;
            this.label9.Text = "Szerviztevékenységek áttekintése";
            // 
            // buttonTorles
            // 
            this.buttonTorles.BackColor = System.Drawing.Color.Transparent;
            this.buttonTorles.FlatAppearance.BorderSize = 0;
            this.buttonTorles.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.buttonTorles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonTorles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTorles.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonTorles.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonTorles.Location = new System.Drawing.Point(192, 601);
            this.buttonTorles.Name = "buttonTorles";
            this.buttonTorles.Size = new System.Drawing.Size(220, 50);
            this.buttonTorles.TabIndex = 7;
            this.buttonTorles.Text = "Bejegyzés törlése";
            this.buttonTorles.UseVisualStyleBackColor = false;
            this.buttonTorles.Click += new System.EventHandler(this.buttonTorles_Click);
            // 
            // errorProviderErrorDB
            // 
            this.errorProviderErrorDB.ContainerControl = this;
            this.errorProviderErrorDB.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderErrorDB.Icon")));
            // 
            // errorProviderKeres
            // 
            this.errorProviderKeres.ContainerControl = this;
            this.errorProviderKeres.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderKeres.Icon")));
            // 
            // textBoxLeiras
            // 
            this.textBoxLeiras.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxLeiras.Location = new System.Drawing.Point(204, 254);
            this.textBoxLeiras.Multiline = true;
            this.textBoxLeiras.Name = "textBoxLeiras";
            this.textBoxLeiras.Size = new System.Drawing.Size(927, 341);
            this.textBoxLeiras.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Location = new System.Drawing.Point(293, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 1);
            this.panel1.TabIndex = 61;
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
            this.button2.Location = new System.Drawing.Point(1091, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 40);
            this.button2.TabIndex = 62;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SzervizekForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1150, 680);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxLeiras);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonUj);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonTorles);
            this.Controls.Add(this.tableLayoutPanelNav);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.listBoxRendszamok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1150, 680);
            this.MinimumSize = new System.Drawing.Size(1150, 680);
            this.Name = "SzervizekForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flotta - Szerviztevékenységek áttekintése";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanelNav.ResumeLayout(false);
            this.tableLayoutPanelNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderErrorDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderKeres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxRendszamok;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxRendszam;
        private System.Windows.Forms.TextBox textBoxGyartmany;
        private System.Windows.Forms.TextBox textBoxTipus;
        private System.Windows.Forms.TextBox textBoxKm;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxMuszaki;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxBizt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxIdopont;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxIdopont;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelNav;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Label labelpage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonUj;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonTorles;
        private System.Windows.Forms.ErrorProvider errorProviderErrorDB;
        private System.Windows.Forms.ErrorProvider errorProviderKeres;
        private System.Windows.Forms.TextBox textBoxLeiras;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
    }
}