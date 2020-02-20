namespace Flotta.Views
{
    partial class LoginForm
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
            this.errorProviderLogin = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonBelep = new System.Windows.Forms.Button();
            this.textBoxJelsz = new System.Windows.Forms.TextBox();
            this.textBoxFelh = new System.Windows.Forms.TextBox();
            this.labelJelsz = new System.Windows.Forms.Label();
            this.labelFelh = new System.Windows.Forms.Label();
            this.buttonReg = new System.Windows.Forms.Button();
            this.buttonKilep = new System.Windows.Forms.Button();
            this.errorProviderDBError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLogin)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDBError)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProviderLogin
            // 
            this.errorProviderLogin.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonBelep);
            this.panel1.Controls.Add(this.textBoxJelsz);
            this.panel1.Controls.Add(this.textBoxFelh);
            this.panel1.Controls.Add(this.labelJelsz);
            this.panel1.Controls.Add(this.labelFelh);
            this.panel1.Controls.Add(this.buttonReg);
            this.panel1.Controls.Add(this.buttonKilep);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(483, 238);
            this.panel1.MinimumSize = new System.Drawing.Size(483, 238);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 238);
            this.panel1.TabIndex = 0;
            // 
            // buttonBelep
            // 
            this.buttonBelep.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonBelep.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBelep.Location = new System.Drawing.Point(171, 101);
            this.buttonBelep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBelep.Name = "buttonBelep";
            this.buttonBelep.Size = new System.Drawing.Size(274, 45);
            this.buttonBelep.TabIndex = 10;
            this.buttonBelep.Text = "Belépés";
            this.buttonBelep.UseVisualStyleBackColor = false;
            this.buttonBelep.Click += new System.EventHandler(this.ButtonBelep_Click_2);
            // 
            // textBoxJelsz
            // 
            this.textBoxJelsz.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxJelsz.Location = new System.Drawing.Point(171, 63);
            this.textBoxJelsz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxJelsz.Name = "textBoxJelsz";
            this.textBoxJelsz.Size = new System.Drawing.Size(273, 34);
            this.textBoxJelsz.TabIndex = 8;
            // 
            // textBoxFelh
            // 
            this.textBoxFelh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxFelh.Location = new System.Drawing.Point(171, 22);
            this.textBoxFelh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxFelh.Name = "textBoxFelh";
            this.textBoxFelh.Size = new System.Drawing.Size(273, 34);
            this.textBoxFelh.TabIndex = 9;
            // 
            // labelJelsz
            // 
            this.labelJelsz.AutoSize = true;
            this.labelJelsz.BackColor = System.Drawing.Color.LightGray;
            this.labelJelsz.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelJelsz.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelJelsz.Location = new System.Drawing.Point(102, 66);
            this.labelJelsz.Name = "labelJelsz";
            this.labelJelsz.Size = new System.Drawing.Size(63, 28);
            this.labelJelsz.TabIndex = 6;
            this.labelJelsz.Text = "Jelszó";
            // 
            // labelFelh
            // 
            this.labelFelh.AutoSize = true;
            this.labelFelh.BackColor = System.Drawing.Color.LightGray;
            this.labelFelh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFelh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelFelh.Location = new System.Drawing.Point(21, 25);
            this.labelFelh.Name = "labelFelh";
            this.labelFelh.Size = new System.Drawing.Size(144, 28);
            this.labelFelh.TabIndex = 7;
            this.labelFelh.Text = "Felhasználónév";
            // 
            // buttonReg
            // 
            this.buttonReg.BackColor = System.Drawing.Color.Cornsilk;
            this.buttonReg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonReg.Location = new System.Drawing.Point(171, 150);
            this.buttonReg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(136, 42);
            this.buttonReg.TabIndex = 4;
            this.buttonReg.Text = "Regisztráció";
            this.buttonReg.UseVisualStyleBackColor = false;
            this.buttonReg.Click += new System.EventHandler(this.buttonReg_Click);
            // 
            // buttonKilep
            // 
            this.buttonKilep.BackColor = System.Drawing.Color.Cornsilk;
            this.buttonKilep.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonKilep.Location = new System.Drawing.Point(308, 150);
            this.buttonKilep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonKilep.Name = "buttonKilep";
            this.buttonKilep.Size = new System.Drawing.Size(136, 42);
            this.buttonKilep.TabIndex = 5;
            this.buttonKilep.Text = "Kilépés";
            this.buttonKilep.UseVisualStyleBackColor = false;
            this.buttonKilep.Click += new System.EventHandler(this.buttonKilep_Click_1);
            // 
            // errorProviderDBError
            // 
            this.errorProviderDBError.ContainerControl = this;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.buttonBelep;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 250);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Belépés";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLogin)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDBError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProviderLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonBelep;
        private System.Windows.Forms.TextBox textBoxJelsz;
        private System.Windows.Forms.TextBox textBoxFelh;
        private System.Windows.Forms.Label labelJelsz;
        private System.Windows.Forms.Label labelFelh;
        private System.Windows.Forms.Button buttonReg;
        private System.Windows.Forms.Button buttonKilep;
        private System.Windows.Forms.ErrorProvider errorProviderDBError;
    }
}