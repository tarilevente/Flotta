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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripTextBoxKeres = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonKeres = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.listBoxTelefon = new System.Windows.Forms.ListBox();
            this.listBoxSofor = new System.Windows.Forms.ListBox();
            this.listBoxVizsga = new System.Windows.Forms.ListBox();
            this.listBoxRendszam = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.labelpage = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxKeres,
            this.toolStripButtonKeres});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1012, 32);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripTextBoxKeres
            // 
            this.toolStripTextBoxKeres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBoxKeres.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolStripTextBoxKeres.Name = "toolStripTextBoxKeres";
            this.toolStripTextBoxKeres.Size = new System.Drawing.Size(158, 32);
            // 
            // toolStripButtonKeres
            // 
            this.toolStripButtonKeres.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolStripButtonKeres.Image = global::Flotta.Properties.Resources.profiling;
            this.toolStripButtonKeres.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonKeres.Name = "toolStripButtonKeres";
            this.toolStripButtonKeres.Size = new System.Drawing.Size(82, 29);
            this.toolStripButtonKeres.Text = "Keres";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.listBoxTelefon, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.listBoxSofor, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.listBoxVizsga, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.listBoxRendszam, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(7, 34);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 479F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1006, 479);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // listBoxTelefon
            // 
            this.listBoxTelefon.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxTelefon.FormattingEnabled = true;
            this.listBoxTelefon.ItemHeight = 25;
            this.listBoxTelefon.Location = new System.Drawing.Point(756, 2);
            this.listBoxTelefon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxTelefon.Name = "listBoxTelefon";
            this.listBoxTelefon.Size = new System.Drawing.Size(241, 454);
            this.listBoxTelefon.TabIndex = 3;
            // 
            // listBoxSofor
            // 
            this.listBoxSofor.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxSofor.FormattingEnabled = true;
            this.listBoxSofor.ItemHeight = 25;
            this.listBoxSofor.Location = new System.Drawing.Point(505, 2);
            this.listBoxSofor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxSofor.Name = "listBoxSofor";
            this.listBoxSofor.Size = new System.Drawing.Size(239, 454);
            this.listBoxSofor.TabIndex = 2;
            // 
            // listBoxVizsga
            // 
            this.listBoxVizsga.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxVizsga.FormattingEnabled = true;
            this.listBoxVizsga.ItemHeight = 25;
            this.listBoxVizsga.Location = new System.Drawing.Point(3, 2);
            this.listBoxVizsga.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxVizsga.Name = "listBoxVizsga";
            this.listBoxVizsga.Size = new System.Drawing.Size(239, 454);
            this.listBoxVizsga.TabIndex = 0;
            // 
            // listBoxRendszam
            // 
            this.listBoxRendszam.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxRendszam.FormattingEnabled = true;
            this.listBoxRendszam.ItemHeight = 25;
            this.listBoxRendszam.Location = new System.Drawing.Point(254, 2);
            this.listBoxRendszam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxRendszam.Name = "listBoxRendszam";
            this.listBoxRendszam.Size = new System.Drawing.Size(239, 454);
            this.listBoxRendszam.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 5;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.Controls.Add(this.buttonFirst, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.buttonPrevious, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.buttonNext, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.buttonLast, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.labelpage, 2, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(222, 513);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(579, 41);
            this.tableLayoutPanel5.TabIndex = 13;
            // 
            // buttonFirst
            // 
            this.buttonFirst.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonFirst.Location = new System.Drawing.Point(3, 3);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(109, 34);
            this.buttonFirst.TabIndex = 0;
            this.buttonFirst.Text = "<<";
            this.buttonFirst.UseVisualStyleBackColor = true;
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPrevious.Location = new System.Drawing.Point(118, 3);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(109, 34);
            this.buttonPrevious.TabIndex = 0;
            this.buttonPrevious.Text = "<";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNext.Location = new System.Drawing.Point(348, 3);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(109, 34);
            this.buttonNext.TabIndex = 0;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = true;
            // 
            // buttonLast
            // 
            this.buttonLast.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLast.Location = new System.Drawing.Point(463, 3);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(113, 34);
            this.buttonLast.TabIndex = 0;
            this.buttonLast.Text = ">>";
            this.buttonLast.UseVisualStyleBackColor = true;
            // 
            // labelpage
            // 
            this.labelpage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelpage.AutoSize = true;
            this.labelpage.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelpage.Location = new System.Drawing.Point(268, 8);
            this.labelpage.Name = "labelpage";
            this.labelpage.Size = new System.Drawing.Size(39, 25);
            this.labelpage.TabIndex = 1;
            this.labelpage.Text = "0/0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(422, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(257, 32);
            this.label14.TabIndex = 27;
            this.label14.Text = "Műszaki esedékesség";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(880, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 34);
            this.button1.TabIndex = 29;
            this.button1.Text = "Főoldal";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // MuszakiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 558);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1030, 605);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1030, 605);
            this.Name = "MuszakiForm";
            this.ShowIcon = false;
            this.Text = "Flotta - Műszaki esedékesség";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ListBox listBoxTelefon;
        private System.Windows.Forms.ListBox listBoxSofor;
        private System.Windows.Forms.ListBox listBoxRendszam;
        private System.Windows.Forms.ListBox listBoxVizsga;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxKeres;
        private System.Windows.Forms.ToolStripButton toolStripButtonKeres;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Label labelpage;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1;
    }
}