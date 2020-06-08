namespace Flotta.Views
{
    partial class ProfilAdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfilAdminForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonFooldal = new System.Windows.Forms.Button();
            this.buttonMod = new System.Windows.Forms.Button();
            this.labelCimke = new System.Windows.Forms.Label();
            this.buttonTorles = new System.Windows.Forms.Button();
            this.labelModositottam = new System.Windows.Forms.Label();
            this.labelToroltem = new System.Windows.Forms.Label();
            this.errorProviderDB = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelNevlista = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.dataGridViewNevek = new System.Windows.Forms.DataGridView();
            this.textBoxSof = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxAutoja = new System.Windows.Forms.ComboBox();
            this.buttonSofAutMent = new System.Windows.Forms.Button();
            this.buttonTorlesKapcs = new System.Windows.Forms.Button();
            this.errorProviderMentKapcs = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderTorles = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.buttonFriss = new System.Windows.Forms.Button();
            this.textBoxKeres = new System.Windows.Forms.TextBox();
            this.buttonKeres = new System.Windows.Forms.Button();
            this.errorProviderKeres = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonVissza = new System.Windows.Forms.Button();
            this.comboBoxKeres = new System.Windows.Forms.ComboBox();
            this.errorProviderSearchCat = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBoxAutoja = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonTorlesVegl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNevek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMentKapcs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTorles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderKeres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSearchCat)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFooldal
            // 
            this.buttonFooldal.BackColor = System.Drawing.Color.Transparent;
            this.buttonFooldal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFooldal.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonFooldal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.buttonFooldal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonFooldal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFooldal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonFooldal.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonFooldal.Location = new System.Drawing.Point(1013, 618);
            this.buttonFooldal.Name = "buttonFooldal";
            this.buttonFooldal.Size = new System.Drawing.Size(125, 50);
            this.buttonFooldal.TabIndex = 8;
            this.buttonFooldal.Text = "Főoldal";
            this.buttonFooldal.UseVisualStyleBackColor = false;
            this.buttonFooldal.Click += new System.EventHandler(this.buttonKilep_Click);
            // 
            // buttonMod
            // 
            this.buttonMod.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonMod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMod.FlatAppearance.BorderSize = 0;
            this.buttonMod.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.buttonMod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMod.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.buttonMod.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonMod.Location = new System.Drawing.Point(898, 537);
            this.buttonMod.Name = "buttonMod";
            this.buttonMod.Size = new System.Drawing.Size(205, 38);
            this.buttonMod.TabIndex = 10;
            this.buttonMod.Text = "Módosítás!";
            this.buttonMod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonMod.UseVisualStyleBackColor = true;
            this.buttonMod.Click += new System.EventHandler(this.buttonMod_Click);
            // 
            // labelCimke
            // 
            this.labelCimke.AutoSize = true;
            this.labelCimke.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCimke.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.labelCimke.Location = new System.Drawing.Point(457, 9);
            this.labelCimke.Name = "labelCimke";
            this.labelCimke.Size = new System.Drawing.Size(216, 45);
            this.labelCimke.TabIndex = 11;
            this.labelCimke.Text = "Profilkezelés";
            // 
            // buttonTorles
            // 
            this.buttonTorles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTorles.FlatAppearance.BorderSize = 0;
            this.buttonTorles.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.buttonTorles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonTorles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTorles.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.buttonTorles.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonTorles.Location = new System.Drawing.Point(15, 511);
            this.buttonTorles.Name = "buttonTorles";
            this.buttonTorles.Size = new System.Drawing.Size(192, 38);
            this.buttonTorles.TabIndex = 10;
            this.buttonTorles.Text = "Kijelölt törlése";
            this.buttonTorles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTorles.UseVisualStyleBackColor = true;
            this.buttonTorles.Click += new System.EventHandler(this.buttonTorles_Click_1);
            // 
            // labelModositottam
            // 
            this.labelModositottam.AutoSize = true;
            this.labelModositottam.Location = new System.Drawing.Point(771, 13);
            this.labelModositottam.Name = "labelModositottam";
            this.labelModositottam.Size = new System.Drawing.Size(0, 17);
            this.labelModositottam.TabIndex = 42;
            // 
            // labelToroltem
            // 
            this.labelToroltem.AutoSize = true;
            this.labelToroltem.Location = new System.Drawing.Point(321, 13);
            this.labelToroltem.Name = "labelToroltem";
            this.labelToroltem.Size = new System.Drawing.Size(0, 17);
            this.labelToroltem.TabIndex = 42;
            // 
            // errorProviderDB
            // 
            this.errorProviderDB.ContainerControl = this;
            this.errorProviderDB.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderDB.Icon")));
            // 
            // labelNevlista
            // 
            this.labelNevlista.AutoSize = true;
            this.labelNevlista.Location = new System.Drawing.Point(262, 26);
            this.labelNevlista.Name = "labelNevlista";
            this.labelNevlista.Size = new System.Drawing.Size(0, 17);
            this.labelNevlista.TabIndex = 43;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(168, -2);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(0, 17);
            this.labelID.TabIndex = 44;
            // 
            // dataGridViewNevek
            // 
            this.dataGridViewNevek.AllowUserToAddRows = false;
            this.dataGridViewNevek.AllowUserToDeleteRows = false;
            this.dataGridViewNevek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewNevek.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewNevek.Location = new System.Drawing.Point(10, 119);
            this.dataGridViewNevek.Name = "dataGridViewNevek";
            this.dataGridViewNevek.RowTemplate.Height = 24;
            this.dataGridViewNevek.Size = new System.Drawing.Size(1126, 386);
            this.dataGridViewNevek.TabIndex = 46;
            this.dataGridViewNevek.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNevek_CellClick);
            this.dataGridViewNevek.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewNevek_ColumnHeaderMouseClick);
            this.dataGridViewNevek.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridViewNevek_KeyUp);
            // 
            // textBoxSof
            // 
            this.textBoxSof.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSof.Location = new System.Drawing.Point(15, 614);
            this.textBoxSof.Name = "textBoxSof";
            this.textBoxSof.ReadOnly = true;
            this.textBoxSof.Size = new System.Drawing.Size(306, 30);
            this.textBoxSof.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Location = new System.Drawing.Point(12, 584);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 23);
            this.label1.TabIndex = 48;
            this.label1.Text = "Sofőr";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Location = new System.Drawing.Point(334, 584);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 23);
            this.label2.TabIndex = 48;
            this.label2.Text = "Autója";
            // 
            // comboBoxAutoja
            // 
            this.comboBoxAutoja.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxAutoja.FormattingEnabled = true;
            this.comboBoxAutoja.Location = new System.Drawing.Point(487, 613);
            this.comboBoxAutoja.Name = "comboBoxAutoja";
            this.comboBoxAutoja.Size = new System.Drawing.Size(212, 31);
            this.comboBoxAutoja.TabIndex = 49;
            // 
            // buttonSofAutMent
            // 
            this.buttonSofAutMent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSofAutMent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSofAutMent.FlatAppearance.BorderSize = 0;
            this.buttonSofAutMent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.buttonSofAutMent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonSofAutMent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSofAutMent.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.buttonSofAutMent.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonSofAutMent.Location = new System.Drawing.Point(725, 617);
            this.buttonSofAutMent.Name = "buttonSofAutMent";
            this.buttonSofAutMent.Size = new System.Drawing.Size(125, 30);
            this.buttonSofAutMent.TabIndex = 10;
            this.buttonSofAutMent.Text = "Mentés";
            this.buttonSofAutMent.UseVisualStyleBackColor = true;
            this.buttonSofAutMent.Click += new System.EventHandler(this.buttonSofAutMent_Click);
            // 
            // buttonTorlesKapcs
            // 
            this.buttonTorlesKapcs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTorlesKapcs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTorlesKapcs.FlatAppearance.BorderSize = 0;
            this.buttonTorlesKapcs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.buttonTorlesKapcs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonTorlesKapcs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTorlesKapcs.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonTorlesKapcs.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonTorlesKapcs.Location = new System.Drawing.Point(487, 615);
            this.buttonTorlesKapcs.Name = "buttonTorlesKapcs";
            this.buttonTorlesKapcs.Size = new System.Drawing.Size(212, 31);
            this.buttonTorlesKapcs.TabIndex = 10;
            this.buttonTorlesKapcs.Text = "Kapcsolat törlése";
            this.buttonTorlesKapcs.UseVisualStyleBackColor = true;
            this.buttonTorlesKapcs.Click += new System.EventHandler(this.buttonTorlesKapcs_Click);
            // 
            // errorProviderMentKapcs
            // 
            this.errorProviderMentKapcs.ContainerControl = this;
            this.errorProviderMentKapcs.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderMentKapcs.Icon")));
            // 
            // errorProviderTorles
            // 
            this.errorProviderTorles.ContainerControl = this;
            this.errorProviderTorles.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderTorles.Icon")));
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.Location = new System.Drawing.Point(721, 511);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(382, 23);
            this.label3.TabIndex = 50;
            this.label3.Text = "A cellák tartalmának módosítása után mentés itt:";
            // 
            // buttonFriss
            // 
            this.buttonFriss.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonFriss.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFriss.FlatAppearance.BorderSize = 0;
            this.buttonFriss.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.buttonFriss.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonFriss.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFriss.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.buttonFriss.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonFriss.Location = new System.Drawing.Point(213, 511);
            this.buttonFriss.Name = "buttonFriss";
            this.buttonFriss.Size = new System.Drawing.Size(108, 38);
            this.buttonFriss.TabIndex = 10;
            this.buttonFriss.Text = "Frissítés";
            this.buttonFriss.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFriss.UseVisualStyleBackColor = true;
            this.buttonFriss.Click += new System.EventHandler(this.buttonFriss_Click);
            // 
            // textBoxKeres
            // 
            this.textBoxKeres.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxKeres.Location = new System.Drawing.Point(13, 82);
            this.textBoxKeres.Name = "textBoxKeres";
            this.textBoxKeres.Size = new System.Drawing.Size(287, 30);
            this.textBoxKeres.TabIndex = 51;
            // 
            // buttonKeres
            // 
            this.buttonKeres.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonKeres.BackColor = System.Drawing.Color.Transparent;
            this.buttonKeres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonKeres.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonKeres.FlatAppearance.BorderSize = 0;
            this.buttonKeres.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.buttonKeres.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonKeres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKeres.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.buttonKeres.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonKeres.Location = new System.Drawing.Point(497, 83);
            this.buttonKeres.Name = "buttonKeres";
            this.buttonKeres.Size = new System.Drawing.Size(103, 30);
            this.buttonKeres.TabIndex = 52;
            this.buttonKeres.Text = "Keres";
            this.buttonKeres.UseVisualStyleBackColor = false;
            this.buttonKeres.Click += new System.EventHandler(this.buttonKeres_Click);
            // 
            // errorProviderKeres
            // 
            this.errorProviderKeres.ContainerControl = this;
            this.errorProviderKeres.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderKeres.Icon")));
            // 
            // buttonVissza
            // 
            this.buttonVissza.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonVissza.BackColor = System.Drawing.Color.Transparent;
            this.buttonVissza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVissza.FlatAppearance.BorderSize = 0;
            this.buttonVissza.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.buttonVissza.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonVissza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVissza.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.buttonVissza.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonVissza.Location = new System.Drawing.Point(606, 83);
            this.buttonVissza.Name = "buttonVissza";
            this.buttonVissza.Size = new System.Drawing.Size(103, 30);
            this.buttonVissza.TabIndex = 52;
            this.buttonVissza.Text = "Vissza";
            this.buttonVissza.UseVisualStyleBackColor = false;
            this.buttonVissza.Click += new System.EventHandler(this.buttonVissza_Click);
            // 
            // comboBoxKeres
            // 
            this.comboBoxKeres.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxKeres.FormattingEnabled = true;
            this.comboBoxKeres.Location = new System.Drawing.Point(303, 82);
            this.comboBoxKeres.Name = "comboBoxKeres";
            this.comboBoxKeres.Size = new System.Drawing.Size(188, 31);
            this.comboBoxKeres.TabIndex = 54;
            // 
            // errorProviderSearchCat
            // 
            this.errorProviderSearchCat.ContainerControl = this;
            this.errorProviderSearchCat.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderSearchCat.Icon")));
            // 
            // textBoxAutoja
            // 
            this.textBoxAutoja.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxAutoja.Location = new System.Drawing.Point(338, 615);
            this.textBoxAutoja.Name = "textBoxAutoja";
            this.textBoxAutoja.Size = new System.Drawing.Size(127, 30);
            this.textBoxAutoja.TabIndex = 55;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Location = new System.Drawing.Point(324, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 1);
            this.panel1.TabIndex = 56;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(1097, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 57;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonTorlesVegl
            // 
            this.buttonTorlesVegl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTorlesVegl.FlatAppearance.BorderSize = 0;
            this.buttonTorlesVegl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.buttonTorlesVegl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonTorlesVegl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTorlesVegl.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.buttonTorlesVegl.ForeColor = System.Drawing.Color.LightCoral;
            this.buttonTorlesVegl.Location = new System.Drawing.Point(16, 543);
            this.buttonTorlesVegl.Name = "buttonTorlesVegl";
            this.buttonTorlesVegl.Size = new System.Drawing.Size(192, 38);
            this.buttonTorlesVegl.TabIndex = 10;
            this.buttonTorlesVegl.Text = "Törlés!";
            this.buttonTorlesVegl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTorlesVegl.UseVisualStyleBackColor = true;
            this.buttonTorlesVegl.Visible = false;
            this.buttonTorlesVegl.Click += new System.EventHandler(this.buttonTorles_Click);
            // 
            // ProfilAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1150, 680);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxAutoja);
            this.Controls.Add(this.comboBoxKeres);
            this.Controls.Add(this.buttonVissza);
            this.Controls.Add(this.buttonKeres);
            this.Controls.Add(this.textBoxKeres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxAutoja);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSof);
            this.Controls.Add(this.dataGridViewNevek);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelNevlista);
            this.Controls.Add(this.labelToroltem);
            this.Controls.Add(this.labelModositottam);
            this.Controls.Add(this.labelCimke);
            this.Controls.Add(this.buttonFooldal);
            this.Controls.Add(this.buttonTorlesVegl);
            this.Controls.Add(this.buttonTorles);
            this.Controls.Add(this.buttonTorlesKapcs);
            this.Controls.Add(this.buttonSofAutMent);
            this.Controls.Add(this.buttonFriss);
            this.Controls.Add(this.buttonMod);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1150, 680);
            this.MinimumSize = new System.Drawing.Size(1150, 680);
            this.Name = "ProfilAdminForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flotta - Profilkezelés ";
            this.Load += new System.EventHandler(this.ProfilAdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNevek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMentKapcs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTorles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderKeres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSearchCat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFooldal;
        private System.Windows.Forms.Button buttonMod;
        private System.Windows.Forms.Label labelCimke;
        private System.Windows.Forms.Button buttonTorles;
        private System.Windows.Forms.Label labelModositottam;
        private System.Windows.Forms.Label labelToroltem;
        private System.Windows.Forms.ErrorProvider errorProviderDB;
        private System.Windows.Forms.Label labelNevlista;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.DataGridView dataGridViewNevek;
        private System.Windows.Forms.ComboBox comboBoxAutoja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSof;
        private System.Windows.Forms.Button buttonSofAutMent;
        private System.Windows.Forms.Button buttonTorlesKapcs;
        private System.Windows.Forms.ErrorProvider errorProviderMentKapcs;
        private System.Windows.Forms.ErrorProvider errorProviderTorles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonFriss;
        private System.Windows.Forms.Button buttonKeres;
        private System.Windows.Forms.TextBox textBoxKeres;
        private System.Windows.Forms.ErrorProvider errorProviderKeres;
        private System.Windows.Forms.Button buttonVissza;
        private System.Windows.Forms.ComboBox comboBoxKeres;
        private System.Windows.Forms.ErrorProvider errorProviderSearchCat;
        private System.Windows.Forms.TextBox textBoxAutoja;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonTorlesVegl;
    }
}