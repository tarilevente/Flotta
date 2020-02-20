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
            this.listBoxRendszamok = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxRendszam = new System.Windows.Forms.TextBox();
            this.textBoxGyartmany = new System.Windows.Forms.TextBox();
            this.textBoxTipus = new System.Windows.Forms.TextBox();
            this.textBoxKm = new System.Windows.Forms.TextBox();
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
            this.buttonKeres = new System.Windows.Forms.Button();
            this.tableLayoutPanelNav = new System.Windows.Forms.TableLayoutPanel();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.labelpage = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonUj = new System.Windows.Forms.Button();
            this.textBoxKeres = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonTorles = new System.Windows.Forms.Button();
            this.errorProviderErrorDB = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderKeres = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBoxLeiras = new System.Windows.Forms.TextBox();
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
            this.listBoxRendszamok.Location = new System.Drawing.Point(4, 81);
            this.listBoxRendszamok.Name = "listBoxRendszamok";
            this.listBoxRendszamok.Size = new System.Drawing.Size(166, 479);
            this.listBoxRendszamok.TabIndex = 2;
            this.listBoxRendszamok.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBoxRendszamok_MouseClick);
            this.listBoxRendszamok.SelectedIndexChanged += new System.EventHandler(this.listBoxRendszamok_SelectedIndexChanged);
            this.listBoxRendszamok.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listBoxRendszamok_KeyUp);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.54655F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.27207F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxRendszam, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxGyartmany, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxTipus, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxKm, 3, 1);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(176, 43);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(830, 71);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gyártmány";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rendszám";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(492, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Típus";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(708, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Km";
            // 
            // textBoxRendszam
            // 
            this.textBoxRendszam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxRendszam.Location = new System.Drawing.Point(3, 38);
            this.textBoxRendszam.Name = "textBoxRendszam";
            this.textBoxRendszam.ReadOnly = true;
            this.textBoxRendszam.Size = new System.Drawing.Size(198, 30);
            this.textBoxRendszam.TabIndex = 4;
            // 
            // textBoxGyartmany
            // 
            this.textBoxGyartmany.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxGyartmany.Location = new System.Drawing.Point(208, 38);
            this.textBoxGyartmany.Name = "textBoxGyartmany";
            this.textBoxGyartmany.ReadOnly = true;
            this.textBoxGyartmany.Size = new System.Drawing.Size(202, 30);
            this.textBoxGyartmany.TabIndex = 5;
            // 
            // textBoxTipus
            // 
            this.textBoxTipus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTipus.Location = new System.Drawing.Point(418, 38);
            this.textBoxTipus.Name = "textBoxTipus";
            this.textBoxTipus.ReadOnly = true;
            this.textBoxTipus.Size = new System.Drawing.Size(198, 30);
            this.textBoxTipus.TabIndex = 6;
            // 
            // textBoxKm
            // 
            this.textBoxKm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxKm.Location = new System.Drawing.Point(624, 38);
            this.textBoxKm.Name = "textBoxKm";
            this.textBoxKm.ReadOnly = true;
            this.textBoxKm.Size = new System.Drawing.Size(203, 30);
            this.textBoxKm.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxMuszaki, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxBizt, 3, 0);
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(176, 115);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(830, 41);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Műszaki érvényesség";
            // 
            // textBoxMuszaki
            // 
            this.textBoxMuszaki.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxMuszaki.Location = new System.Drawing.Point(210, 5);
            this.textBoxMuszaki.Name = "textBoxMuszaki";
            this.textBoxMuszaki.ReadOnly = true;
            this.textBoxMuszaki.Size = new System.Drawing.Size(201, 30);
            this.textBoxMuszaki.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(417, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Biztosítás érvényesség";
            // 
            // textBoxBizt
            // 
            this.textBoxBizt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxBizt.Location = new System.Drawing.Point(624, 5);
            this.textBoxBizt.Name = "textBoxBizt";
            this.textBoxBizt.ReadOnly = true;
            this.textBoxBizt.Size = new System.Drawing.Size(203, 30);
            this.textBoxBizt.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBoxIdopont, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label7, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.comboBoxIdopont, 3, 0);
            this.tableLayoutPanel3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(176, 159);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(830, 54);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 23);
            this.label8.TabIndex = 1;
            this.label8.Text = "Szervizelés időpontja";
            // 
            // textBoxIdopont
            // 
            this.textBoxIdopont.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxIdopont.Location = new System.Drawing.Point(210, 12);
            this.textBoxIdopont.Name = "textBoxIdopont";
            this.textBoxIdopont.ReadOnly = true;
            this.textBoxIdopont.Size = new System.Drawing.Size(201, 30);
            this.textBoxIdopont.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(417, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 23);
            this.label7.TabIndex = 3;
            this.label7.Text = "Ugrás időponthoz";
            // 
            // comboBoxIdopont
            // 
            this.comboBoxIdopont.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxIdopont.FormattingEnabled = true;
            this.comboBoxIdopont.Location = new System.Drawing.Point(624, 11);
            this.comboBoxIdopont.Name = "comboBoxIdopont";
            this.comboBoxIdopont.Size = new System.Drawing.Size(203, 31);
            this.comboBoxIdopont.TabIndex = 4;
            this.comboBoxIdopont.SelectedIndexChanged += new System.EventHandler(this.comboBoxIdopont_SelectedIndexChanged);
            // 
            // buttonKeres
            // 
            this.buttonKeres.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonKeres.Location = new System.Drawing.Point(4, 43);
            this.buttonKeres.Name = "buttonKeres";
            this.buttonKeres.Size = new System.Drawing.Size(166, 33);
            this.buttonKeres.TabIndex = 7;
            this.buttonKeres.Text = "Keres";
            this.buttonKeres.UseVisualStyleBackColor = true;
            this.buttonKeres.Click += new System.EventHandler(this.buttonKeres_Click);
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
            this.tableLayoutPanelNav.Location = new System.Drawing.Point(255, 516);
            this.tableLayoutPanelNav.Name = "tableLayoutPanelNav";
            this.tableLayoutPanelNav.RowCount = 1;
            this.tableLayoutPanelNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelNav.Size = new System.Drawing.Size(579, 38);
            this.tableLayoutPanelNav.TabIndex = 8;
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(3, 3);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(109, 32);
            this.buttonFirst.TabIndex = 0;
            this.buttonFirst.Text = "<<";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(118, 3);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(109, 32);
            this.buttonPrevious.TabIndex = 0;
            this.buttonPrevious.Text = "<";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(348, 3);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(109, 32);
            this.buttonNext.TabIndex = 0;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(463, 3);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(113, 32);
            this.buttonLast.TabIndex = 0;
            this.buttonLast.Text = ">>";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // labelpage
            // 
            this.labelpage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelpage.AutoSize = true;
            this.labelpage.Location = new System.Drawing.Point(270, 7);
            this.labelpage.Name = "labelpage";
            this.labelpage.Size = new System.Drawing.Size(35, 23);
            this.labelpage.TabIndex = 1;
            this.labelpage.Text = "0/0";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(879, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 34);
            this.button1.TabIndex = 9;
            this.button1.Text = "Főoldal";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonUj
            // 
            this.buttonUj.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUj.Location = new System.Drawing.Point(746, 3);
            this.buttonUj.Name = "buttonUj";
            this.buttonUj.Size = new System.Drawing.Size(127, 34);
            this.buttonUj.TabIndex = 10;
            this.buttonUj.Text = "Új bejegyzés";
            this.buttonUj.UseVisualStyleBackColor = true;
            this.buttonUj.Click += new System.EventHandler(this.buttonUj_Click);
            // 
            // textBoxKeres
            // 
            this.textBoxKeres.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxKeres.Location = new System.Drawing.Point(4, 6);
            this.textBoxKeres.Name = "textBoxKeres";
            this.textBoxKeres.Size = new System.Drawing.Size(166, 31);
            this.textBoxKeres.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(323, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(395, 32);
            this.label9.TabIndex = 14;
            this.label9.Text = "Szerviztevékenységek áttekintése";
            // 
            // buttonTorles
            // 
            this.buttonTorles.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonTorles.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonTorles.Location = new System.Drawing.Point(840, 519);
            this.buttonTorles.Name = "buttonTorles";
            this.buttonTorles.Size = new System.Drawing.Size(166, 32);
            this.buttonTorles.TabIndex = 7;
            this.buttonTorles.Text = "Aktuális törlése";
            this.buttonTorles.UseVisualStyleBackColor = false;
            // 
            // errorProviderErrorDB
            // 
            this.errorProviderErrorDB.ContainerControl = this;
            // 
            // errorProviderKeres
            // 
            this.errorProviderKeres.ContainerControl = this;
            // 
            // textBoxLeiras
            // 
            this.textBoxLeiras.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxLeiras.Location = new System.Drawing.Point(177, 220);
            this.textBoxLeiras.Multiline = true;
            this.textBoxLeiras.Name = "textBoxLeiras";
            this.textBoxLeiras.Size = new System.Drawing.Size(829, 296);
            this.textBoxLeiras.TabIndex = 15;
            // 
            // SzervizekForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 557);
            this.Controls.Add(this.textBoxLeiras);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxKeres);
            this.Controls.Add(this.buttonUj);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonTorles);
            this.Controls.Add(this.tableLayoutPanelNav);
            this.Controls.Add(this.buttonKeres);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.listBoxRendszamok);
            this.MaximumSize = new System.Drawing.Size(1030, 604);
            this.MinimumSize = new System.Drawing.Size(1030, 604);
            this.Name = "SzervizekForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flotta - Szerviztevékenységek áttekintése";
            this.Load += new System.EventHandler(this.SzervizekForm_Load);
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
        private System.Windows.Forms.Button buttonKeres;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelNav;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Label labelpage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonUj;
        private System.Windows.Forms.TextBox textBoxKeres;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonTorles;
        private System.Windows.Forms.ErrorProvider errorProviderErrorDB;
        private System.Windows.Forms.ErrorProvider errorProviderKeres;
        private System.Windows.Forms.TextBox textBoxLeiras;
    }
}