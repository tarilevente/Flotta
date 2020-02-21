namespace Flotta.Views
{
    partial class UjSzerviz
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxLeiras = new System.Windows.Forms.TextBox();
            this.buttonVissza = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonFelv = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelRendsz = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonCasco = new System.Windows.Forms.RadioButton();
            this.radioButtonKot = new System.Windows.Forms.RadioButton();
            this.textBoxRendsz = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelCimke = new System.Windows.Forms.Label();
            this.errorProviderLeir = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderRendsz = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderIdop = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDB = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.labelIdop = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLeir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRendsz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderIdop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDB)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxLeiras);
            this.groupBox1.Controls.Add(this.buttonVissza);
            this.groupBox1.Controls.Add(this.buttonReset);
            this.groupBox1.Controls.Add(this.buttonFelv);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(713, 530);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBoxLeiras
            // 
            this.textBoxLeiras.Location = new System.Drawing.Point(8, 113);
            this.textBoxLeiras.Multiline = true;
            this.textBoxLeiras.Name = "textBoxLeiras";
            this.textBoxLeiras.Size = new System.Drawing.Size(687, 362);
            this.textBoxLeiras.TabIndex = 6;
            // 
            // buttonVissza
            // 
            this.buttonVissza.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonVissza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonVissza.Location = new System.Drawing.Point(570, 482);
            this.buttonVissza.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonVissza.Name = "buttonVissza";
            this.buttonVissza.Size = new System.Drawing.Size(125, 48);
            this.buttonVissza.TabIndex = 5;
            this.buttonVissza.Text = "Vissza";
            this.buttonVissza.UseVisualStyleBackColor = false;
            this.buttonVissza.Click += new System.EventHandler(this.buttonVissza_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonReset.Location = new System.Drawing.Point(8, 480);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(125, 48);
            this.buttonReset.TabIndex = 4;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonFelv
            // 
            this.buttonFelv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonFelv.Location = new System.Drawing.Point(232, 481);
            this.buttonFelv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFelv.Name = "buttonFelv";
            this.buttonFelv.Size = new System.Drawing.Size(249, 48);
            this.buttonFelv.TabIndex = 3;
            this.buttonFelv.Text = "Felvitel";
            this.buttonFelv.UseVisualStyleBackColor = true;
            this.buttonFelv.Click += new System.EventHandler(this.buttonFelv_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.67624F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.2468F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.07696F));
            this.tableLayoutPanel1.Controls.Add(this.labelIdop, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelRendsz, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.radioButtonCasco, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.radioButtonKot, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxRendsz, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker1, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 22);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(688, 85);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // labelRendsz
            // 
            this.labelRendsz.AutoSize = true;
            this.labelRendsz.Location = new System.Drawing.Point(127, 0);
            this.labelRendsz.Name = "labelRendsz";
            this.labelRendsz.Size = new System.Drawing.Size(0, 17);
            this.labelRendsz.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rendszám";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Időpont";
            // 
            // radioButtonCasco
            // 
            this.radioButtonCasco.AutoSize = true;
            this.radioButtonCasco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonCasco.Location = new System.Drawing.Point(469, 2);
            this.radioButtonCasco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonCasco.Name = "radioButtonCasco";
            this.radioButtonCasco.Size = new System.Drawing.Size(84, 28);
            this.radioButtonCasco.TabIndex = 9;
            this.radioButtonCasco.Text = "Casco";
            this.radioButtonCasco.UseVisualStyleBackColor = true;
            // 
            // radioButtonKot
            // 
            this.radioButtonKot.AutoSize = true;
            this.radioButtonKot.Checked = true;
            this.radioButtonKot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonKot.Location = new System.Drawing.Point(469, 34);
            this.radioButtonKot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonKot.Name = "radioButtonKot";
            this.radioButtonKot.Size = new System.Drawing.Size(184, 28);
            this.radioButtonKot.TabIndex = 10;
            this.radioButtonKot.TabStop = true;
            this.radioButtonKot.Text = "Kötelező biztosítás";
            this.radioButtonKot.UseVisualStyleBackColor = true;
            // 
            // textBoxRendsz
            // 
            this.textBoxRendsz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxRendsz.Location = new System.Drawing.Point(147, 2);
            this.textBoxRendsz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxRendsz.Name = "textBoxRendsz";
            this.textBoxRendsz.Size = new System.Drawing.Size(316, 28);
            this.textBoxRendsz.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker1.Location = new System.Drawing.Point(147, 34);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(316, 29);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // labelCimke
            // 
            this.labelCimke.AutoSize = true;
            this.labelCimke.Font = new System.Drawing.Font("Segoe UI Black", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCimke.Location = new System.Drawing.Point(213, 6);
            this.labelCimke.Name = "labelCimke";
            this.labelCimke.Size = new System.Drawing.Size(297, 45);
            this.labelCimke.TabIndex = 14;
            this.labelCimke.Text = "Új szerviz felvitel";
            // 
            // errorProviderLeir
            // 
            this.errorProviderLeir.ContainerControl = this;
            // 
            // errorProviderRendsz
            // 
            this.errorProviderRendsz.ContainerControl = this;
            // 
            // errorProviderIdop
            // 
            this.errorProviderIdop.ContainerControl = this;
            // 
            // errorProviderDB
            // 
            this.errorProviderDB.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "comboboxból kiválasztani??";
            // 
            // labelIdop
            // 
            this.labelIdop.AutoSize = true;
            this.labelIdop.Location = new System.Drawing.Point(127, 32);
            this.labelIdop.Name = "labelIdop";
            this.labelIdop.Size = new System.Drawing.Size(0, 17);
            this.labelIdop.TabIndex = 16;
            // 
            // UjSzerviz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 573);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelCimke);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(756, 620);
            this.MinimumSize = new System.Drawing.Size(756, 620);
            this.Name = "UjSzerviz";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flotta - Új szerviz";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLeir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRendsz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderIdop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxRendsz;
        private System.Windows.Forms.Button buttonVissza;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonFelv;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton radioButtonCasco;
        private System.Windows.Forms.RadioButton radioButtonKot;
        private System.Windows.Forms.Label labelCimke;
        private System.Windows.Forms.TextBox textBoxLeiras;
        private System.Windows.Forms.ErrorProvider errorProviderLeir;
        private System.Windows.Forms.ErrorProvider errorProviderRendsz;
        private System.Windows.Forms.ErrorProvider errorProviderIdop;
        private System.Windows.Forms.ErrorProvider errorProviderDB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelRendsz;
        private System.Windows.Forms.Label labelIdop;
    }
}