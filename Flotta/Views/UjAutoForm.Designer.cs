namespace Flotta.Views
{
    partial class UjAutoForm
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
            this.buttonKilep = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonFelvitel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRendsz = new System.Windows.Forms.TextBox();
            this.textBoxKm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAlv = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBoxAutoR = new System.Windows.Forms.CheckBox();
            this.checkBoxVont = new System.Windows.Forms.CheckBox();
            this.textBoxGyart = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxTipus = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.checkBoxBikak = new System.Windows.Forms.CheckBox();
            this.checkBoxMento = new System.Windows.Forms.CheckBox();
            this.labelCimke = new System.Windows.Forms.Label();
            this.errorProviderRendszam = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderAlvazszam = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderKm = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderGyart = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderTipus = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDB = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRendszam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAlvazszam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderKm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderGyart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTipus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDB)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonKilep
            // 
            this.buttonKilep.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonKilep.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonKilep.Location = new System.Drawing.Point(574, 502);
            this.buttonKilep.Name = "buttonKilep";
            this.buttonKilep.Size = new System.Drawing.Size(126, 41);
            this.buttonKilep.TabIndex = 5;
            this.buttonKilep.Text = "Mégse";
            this.buttonKilep.UseVisualStyleBackColor = false;
            this.buttonKilep.Click += new System.EventHandler(this.buttonKilep_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonReset.Location = new System.Drawing.Point(32, 502);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(126, 41);
            this.buttonReset.TabIndex = 6;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonFelvitel
            // 
            this.buttonFelvitel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonFelvitel.Location = new System.Drawing.Point(229, 502);
            this.buttonFelvitel.Name = "buttonFelvitel";
            this.buttonFelvitel.Size = new System.Drawing.Size(249, 41);
            this.buttonFelvitel.TabIndex = 4;
            this.buttonFelvitel.Text = "Felvitel";
            this.buttonFelvitel.UseVisualStyleBackColor = true;
            this.buttonFelvitel.Click += new System.EventHandler(this.buttonFelvitel_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxRendsz, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxKm, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxAlv, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label10, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label11, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label15, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label8, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxAutoR, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxVont, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.textBoxGyart, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label13, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBoxTipus, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.label14, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxBikak, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxMento, 2, 8);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 49);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(714, 429);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rendszám (NKK-111)";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(137, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Km";
            // 
            // textBoxRendsz
            // 
            this.textBoxRendsz.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxRendsz.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxRendsz.Location = new System.Drawing.Point(28, 55);
            this.textBoxRendsz.Name = "textBoxRendsz";
            this.textBoxRendsz.Size = new System.Drawing.Size(259, 31);
            this.textBoxRendsz.TabIndex = 8;
            // 
            // textBoxKm
            // 
            this.textBoxKm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxKm.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxKm.Location = new System.Drawing.Point(28, 149);
            this.textBoxKm.Name = "textBoxKm";
            this.textBoxKm.Size = new System.Drawing.Size(259, 31);
            this.textBoxKm.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(399, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alvázszám (17 karakter)";
            // 
            // textBoxAlv
            // 
            this.textBoxAlv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAlv.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxAlv.Location = new System.Drawing.Point(379, 55);
            this.textBoxAlv.Name = "textBoxAlv";
            this.textBoxAlv.Size = new System.Drawing.Size(259, 31);
            this.textBoxAlv.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(308, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 38);
            this.label10.TabIndex = 13;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(659, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 38);
            this.label11.TabIndex = 13;
            this.label11.Text = "*";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(101, 197);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(113, 28);
            this.label15.TabIndex = 7;
            this.label15.Text = "Gyártmány ";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(399, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(219, 28);
            this.label8.TabIndex = 7;
            this.label8.Text = "Típus (Max. 20 karakter)";
            // 
            // checkBoxAutoR
            // 
            this.checkBoxAutoR.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxAutoR.AutoSize = true;
            this.checkBoxAutoR.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxAutoR.Location = new System.Drawing.Point(13, 336);
            this.checkBoxAutoR.Name = "checkBoxAutoR";
            this.checkBoxAutoR.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.checkBoxAutoR.Size = new System.Drawing.Size(158, 32);
            this.checkBoxAutoR.TabIndex = 14;
            this.checkBoxAutoR.Text = "   Autórádió";
            this.checkBoxAutoR.UseVisualStyleBackColor = true;
            // 
            // checkBoxVont
            // 
            this.checkBoxVont.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxVont.AutoSize = true;
            this.checkBoxVont.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxVont.Location = new System.Drawing.Point(364, 336);
            this.checkBoxVont.Name = "checkBoxVont";
            this.checkBoxVont.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.checkBoxVont.Size = new System.Drawing.Size(183, 32);
            this.checkBoxVont.TabIndex = 14;
            this.checkBoxVont.Text = "   Vontatókötél";
            this.checkBoxVont.UseVisualStyleBackColor = true;
            // 
            // textBoxGyart
            // 
            this.textBoxGyart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxGyart.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxGyart.Location = new System.Drawing.Point(28, 243);
            this.textBoxGyart.Name = "textBoxGyart";
            this.textBoxGyart.Size = new System.Drawing.Size(259, 31);
            this.textBoxGyart.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(308, 235);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 38);
            this.label13.TabIndex = 13;
            this.label13.Text = "*";
            // 
            // textBoxTipus
            // 
            this.textBoxTipus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTipus.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxTipus.Location = new System.Drawing.Point(379, 243);
            this.textBoxTipus.Name = "textBoxTipus";
            this.textBoxTipus.Size = new System.Drawing.Size(259, 31);
            this.textBoxTipus.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(659, 235);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 38);
            this.label14.TabIndex = 13;
            this.label14.Text = "*";
            // 
            // checkBoxBikak
            // 
            this.checkBoxBikak.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxBikak.AutoSize = true;
            this.checkBoxBikak.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxBikak.Location = new System.Drawing.Point(13, 386);
            this.checkBoxBikak.Name = "checkBoxBikak";
            this.checkBoxBikak.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.checkBoxBikak.Size = new System.Drawing.Size(152, 32);
            this.checkBoxBikak.TabIndex = 14;
            this.checkBoxBikak.Text = "   Bikakábel";
            this.checkBoxBikak.UseVisualStyleBackColor = true;
            // 
            // checkBoxMento
            // 
            this.checkBoxMento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxMento.AutoSize = true;
            this.checkBoxMento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxMento.Location = new System.Drawing.Point(364, 386);
            this.checkBoxMento.Name = "checkBoxMento";
            this.checkBoxMento.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.checkBoxMento.Size = new System.Drawing.Size(184, 32);
            this.checkBoxMento.TabIndex = 14;
            this.checkBoxMento.Text = "   Mentődoboz";
            this.checkBoxMento.UseVisualStyleBackColor = true;
            // 
            // labelCimke
            // 
            this.labelCimke.AutoSize = true;
            this.labelCimke.Font = new System.Drawing.Font("Segoe UI Black", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCimke.Location = new System.Drawing.Point(221, 1);
            this.labelCimke.Name = "labelCimke";
            this.labelCimke.Size = new System.Drawing.Size(261, 45);
            this.labelCimke.TabIndex = 13;
            this.labelCimke.Text = "Új autó felvitel";
            // 
            // errorProviderRendszam
            // 
            this.errorProviderRendszam.ContainerControl = this;
            // 
            // errorProviderAlvazszam
            // 
            this.errorProviderAlvazszam.ContainerControl = this;
            // 
            // errorProviderKm
            // 
            this.errorProviderKm.ContainerControl = this;
            // 
            // errorProviderGyart
            // 
            this.errorProviderGyart.ContainerControl = this;
            // 
            // errorProviderTipus
            // 
            this.errorProviderTipus.ContainerControl = this;
            // 
            // errorProviderDB
            // 
            this.errorProviderDB.ContainerControl = this;
            // 
            // UjAutoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 573);
            this.Controls.Add(this.labelCimke);
            this.Controls.Add(this.buttonKilep);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonFelvitel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(756, 620);
            this.MinimumSize = new System.Drawing.Size(756, 620);
            this.Name = "UjAutoForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flotta - Gépjármű nyilvántartás - Új autó felvitel";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRendszam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAlvazszam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderKm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderGyart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTipus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonKilep;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonFelvitel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRendsz;
        private System.Windows.Forms.TextBox textBoxKm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAlv;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxTipus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxGyart;
        private System.Windows.Forms.Label labelCimke;
        private System.Windows.Forms.CheckBox checkBoxAutoR;
        private System.Windows.Forms.CheckBox checkBoxVont;
        private System.Windows.Forms.CheckBox checkBoxMento;
        private System.Windows.Forms.CheckBox checkBoxBikak;
        private System.Windows.Forms.ErrorProvider errorProviderRendszam;
        private System.Windows.Forms.ErrorProvider errorProviderAlvazszam;
        private System.Windows.Forms.ErrorProvider errorProviderKm;
        private System.Windows.Forms.ErrorProvider errorProviderGyart;
        private System.Windows.Forms.ErrorProvider errorProviderTipus;
        private System.Windows.Forms.ErrorProvider errorProviderDB;
    }
}