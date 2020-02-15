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
            this.listBoxLeiras = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonVissza = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonFelv = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radioButtonCasco = new System.Windows.Forms.RadioButton();
            this.radioButtonKot = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxLeiras
            // 
            this.listBoxLeiras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxLeiras.FormattingEnabled = true;
            this.listBoxLeiras.ItemHeight = 20;
            this.listBoxLeiras.Location = new System.Drawing.Point(5, 112);
            this.listBoxLeiras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxLeiras.Name = "listBoxLeiras";
            this.listBoxLeiras.Size = new System.Drawing.Size(701, 364);
            this.listBoxLeiras.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonVissza);
            this.groupBox1.Controls.Add(this.buttonReset);
            this.groupBox1.Controls.Add(this.buttonFelv);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Controls.Add(this.listBoxLeiras);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(713, 530);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // buttonVissza
            // 
            this.buttonVissza.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonVissza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonVissza.Location = new System.Drawing.Point(581, 480);
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
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.21008F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.84874F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.94118F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.radioButtonCasco, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.radioButtonKot, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 22);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(688, 85);
            this.tableLayoutPanel1.TabIndex = 2;
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
            this.label2.Location = new System.Drawing.Point(3, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Időpont";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(176, 2);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(315, 28);
            this.textBox1.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker1.Location = new System.Drawing.Point(176, 44);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(315, 29);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // radioButtonCasco
            // 
            this.radioButtonCasco.AutoSize = true;
            this.radioButtonCasco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonCasco.Location = new System.Drawing.Point(498, 2);
            this.radioButtonCasco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonCasco.Name = "radioButtonCasco";
            this.radioButtonCasco.Size = new System.Drawing.Size(84, 28);
            this.radioButtonCasco.TabIndex = 9;
            this.radioButtonCasco.TabStop = true;
            this.radioButtonCasco.Text = "Casco";
            this.radioButtonCasco.UseVisualStyleBackColor = true;
            // 
            // radioButtonKot
            // 
            this.radioButtonKot.AutoSize = true;
            this.radioButtonKot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonKot.Location = new System.Drawing.Point(498, 44);
            this.radioButtonKot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonKot.Name = "radioButtonKot";
            this.radioButtonKot.Size = new System.Drawing.Size(184, 28);
            this.radioButtonKot.TabIndex = 10;
            this.radioButtonKot.TabStop = true;
            this.radioButtonKot.Text = "Kötelező biztosítás";
            this.radioButtonKot.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Black", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(213, 6);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(297, 45);
            this.label15.TabIndex = 14;
            this.label15.Text = "Új szerviz felvitel";
            // 
            // UjSzerviz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 573);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(756, 620);
            this.MinimumSize = new System.Drawing.Size(756, 620);
            this.Name = "UjSzerviz";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flotta - Új szerviz";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxLeiras;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonVissza;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonFelv;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton radioButtonCasco;
        private System.Windows.Forms.RadioButton radioButtonKot;
        private System.Windows.Forms.Label label15;
    }
}