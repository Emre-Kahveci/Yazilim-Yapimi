﻿namespace DB
{
    partial class frmSinavCozum
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
            this.btnYeniSoru = new System.Windows.Forms.Button();
            this.PBSoru = new System.Windows.Forms.PictureBox();
            this.rTxtSoruMetin = new System.Windows.Forms.RichTextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtD = new System.Windows.Forms.TextBox();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblD = new System.Windows.Forms.Label();
            this.labelDurum = new System.Windows.Forms.Label();
            this.rBtnA = new System.Windows.Forms.RadioButton();
            this.rBtnB = new System.Windows.Forms.RadioButton();
            this.rBtnC = new System.Windows.Forms.RadioButton();
            this.rBtnD = new System.Windows.Forms.RadioButton();
            this.zamanlayici = new System.Windows.Forms.Timer(this.components);
            this.lblZaman = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PBSoru)).BeginInit();
            this.SuspendLayout();
            // 
            // btnYeniSoru
            // 
            this.btnYeniSoru.Location = new System.Drawing.Point(713, 218);
            this.btnYeniSoru.Name = "btnYeniSoru";
            this.btnYeniSoru.Size = new System.Drawing.Size(75, 23);
            this.btnYeniSoru.TabIndex = 0;
            this.btnYeniSoru.Text = "Yeni Soru";
            this.btnYeniSoru.UseVisualStyleBackColor = true;
            this.btnYeniSoru.Click += new System.EventHandler(this.btnYeniSoru_Click);
            // 
            // PBSoru
            // 
            this.PBSoru.Location = new System.Drawing.Point(467, 12);
            this.PBSoru.Name = "PBSoru";
            this.PBSoru.Size = new System.Drawing.Size(321, 200);
            this.PBSoru.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBSoru.TabIndex = 2;
            this.PBSoru.TabStop = false;
            // 
            // rTxtSoruMetin
            // 
            this.rTxtSoruMetin.Location = new System.Drawing.Point(34, 12);
            this.rTxtSoruMetin.Name = "rTxtSoruMetin";
            this.rTxtSoruMetin.ReadOnly = true;
            this.rTxtSoruMetin.Size = new System.Drawing.Size(346, 96);
            this.rTxtSoruMetin.TabIndex = 1;
            this.rTxtSoruMetin.Text = "";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(34, 114);
            this.txtA.Name = "txtA";
            this.txtA.ReadOnly = true;
            this.txtA.Size = new System.Drawing.Size(346, 20);
            this.txtA.TabIndex = 2;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(34, 140);
            this.txtB.Name = "txtB";
            this.txtB.ReadOnly = true;
            this.txtB.Size = new System.Drawing.Size(346, 20);
            this.txtB.TabIndex = 3;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(34, 166);
            this.txtC.Name = "txtC";
            this.txtC.ReadOnly = true;
            this.txtC.Size = new System.Drawing.Size(346, 20);
            this.txtC.TabIndex = 4;
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(34, 192);
            this.txtD.Name = "txtD";
            this.txtD.ReadOnly = true;
            this.txtD.Size = new System.Drawing.Size(346, 20);
            this.txtD.TabIndex = 5;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(11, 117);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(17, 13);
            this.lblA.TabIndex = 6;
            this.lblA.Text = "A)";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(11, 143);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(17, 13);
            this.lblB.TabIndex = 7;
            this.lblB.Text = "B)";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(11, 169);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(17, 13);
            this.lblC.TabIndex = 8;
            this.lblC.Text = "C)";
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Location = new System.Drawing.Point(11, 195);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(18, 13);
            this.lblD.TabIndex = 9;
            this.lblD.Text = "D)";
            // 
            // labelDurum
            // 
            this.labelDurum.AutoSize = true;
            this.labelDurum.Location = new System.Drawing.Point(405, 12);
            this.labelDurum.Name = "labelDurum";
            this.labelDurum.Size = new System.Drawing.Size(30, 13);
            this.labelDurum.TabIndex = 10;
            this.labelDurum.Text = "(0/0)";
            // 
            // rBtnA
            // 
            this.rBtnA.AutoSize = true;
            this.rBtnA.Location = new System.Drawing.Point(386, 117);
            this.rBtnA.Name = "rBtnA";
            this.rBtnA.Size = new System.Drawing.Size(75, 17);
            this.rBtnA.TabIndex = 11;
            this.rBtnA.TabStop = true;
            this.rBtnA.Text = "Cevap = A";
            this.rBtnA.UseVisualStyleBackColor = true;
            // 
            // rBtnB
            // 
            this.rBtnB.AutoSize = true;
            this.rBtnB.Location = new System.Drawing.Point(386, 143);
            this.rBtnB.Name = "rBtnB";
            this.rBtnB.Size = new System.Drawing.Size(75, 17);
            this.rBtnB.TabIndex = 12;
            this.rBtnB.TabStop = true;
            this.rBtnB.Text = "Cevap = B";
            this.rBtnB.UseVisualStyleBackColor = true;
            // 
            // rBtnC
            // 
            this.rBtnC.AutoSize = true;
            this.rBtnC.Location = new System.Drawing.Point(386, 169);
            this.rBtnC.Name = "rBtnC";
            this.rBtnC.Size = new System.Drawing.Size(75, 17);
            this.rBtnC.TabIndex = 13;
            this.rBtnC.TabStop = true;
            this.rBtnC.Text = "Cevap = C";
            this.rBtnC.UseVisualStyleBackColor = true;
            // 
            // rBtnD
            // 
            this.rBtnD.AutoSize = true;
            this.rBtnD.Location = new System.Drawing.Point(385, 195);
            this.rBtnD.Name = "rBtnD";
            this.rBtnD.Size = new System.Drawing.Size(76, 17);
            this.rBtnD.TabIndex = 14;
            this.rBtnD.TabStop = true;
            this.rBtnD.Text = "Cevap = D";
            this.rBtnD.UseVisualStyleBackColor = true;
            // 
            // zamanlayici
            // 
            this.zamanlayici.Interval = 60000;
            this.zamanlayici.Tick += new System.EventHandler(this.zamanlayici_Tick);
            // 
            // lblZaman
            // 
            this.lblZaman.AutoSize = true;
            this.lblZaman.Location = new System.Drawing.Point(383, 223);
            this.lblZaman.Name = "lblZaman";
            this.lblZaman.Size = new System.Drawing.Size(62, 13);
            this.lblZaman.TabIndex = 15;
            this.lblZaman.Text = "Kalan Süre:";
            // 
            // frmSinavCozum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 247);
            this.Controls.Add(this.lblZaman);
            this.Controls.Add(this.rBtnD);
            this.Controls.Add(this.rBtnC);
            this.Controls.Add(this.rBtnB);
            this.Controls.Add(this.rBtnA);
            this.Controls.Add(this.labelDurum);
            this.Controls.Add(this.lblD);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.txtD);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.rTxtSoruMetin);
            this.Controls.Add(this.PBSoru);
            this.Controls.Add(this.btnYeniSoru);
            this.Name = "frmSinavCozum";
            this.Text = "frmSinavCozum";
            ((System.ComponentModel.ISupportInitialize)(this.PBSoru)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYeniSoru;
        private System.Windows.Forms.PictureBox PBSoru;
        private System.Windows.Forms.RichTextBox rTxtSoruMetin;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.Label labelDurum;
        private System.Windows.Forms.RadioButton rBtnA;
        private System.Windows.Forms.RadioButton rBtnB;
        private System.Windows.Forms.RadioButton rBtnC;
        private System.Windows.Forms.RadioButton rBtnD;
        private System.Windows.Forms.Timer zamanlayici;
        private System.Windows.Forms.Label lblZaman;
    }
}