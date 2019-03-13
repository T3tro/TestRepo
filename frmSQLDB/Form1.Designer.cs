namespace frmSQLDB
{
    partial class Form1
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtUpdateSoyad = new System.Windows.Forms.TextBox();
            this.txtUpdateAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnKisiGuncelle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtInsertSoyad = new System.Windows.Forms.TextBox();
            this.txtInsertAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnYeniKisiEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKisiyiSil = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnKisileriGetir = new System.Windows.Forms.Button();
            this.btnBaglan = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtUpdateSoyad);
            this.groupBox2.Controls.Add(this.txtUpdateAd);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnKisiGuncelle);
            this.groupBox2.Location = new System.Drawing.Point(295, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 104);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update";
            // 
            // txtUpdateSoyad
            // 
            this.txtUpdateSoyad.Location = new System.Drawing.Point(116, 64);
            this.txtUpdateSoyad.Name = "txtUpdateSoyad";
            this.txtUpdateSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtUpdateSoyad.TabIndex = 3;
            // 
            // txtUpdateAd
            // 
            this.txtUpdateAd.Location = new System.Drawing.Point(116, 22);
            this.txtUpdateAd.Name = "txtUpdateAd";
            this.txtUpdateAd.Size = new System.Drawing.Size(100, 22);
            this.txtUpdateAd.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Soyad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ad";
            // 
            // btnKisiGuncelle
            // 
            this.btnKisiGuncelle.Location = new System.Drawing.Point(222, 22);
            this.btnKisiGuncelle.Name = "btnKisiGuncelle";
            this.btnKisiGuncelle.Size = new System.Drawing.Size(101, 52);
            this.btnKisiGuncelle.TabIndex = 4;
            this.btnKisiGuncelle.Text = "Kisileri Guncelle";
            this.btnKisiGuncelle.UseVisualStyleBackColor = true;
            this.btnKisiGuncelle.Click += new System.EventHandler(this.btnKisiGuncelle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtInsertSoyad);
            this.groupBox1.Controls.Add(this.txtInsertAd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnYeniKisiEkle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(295, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 104);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insert";
            // 
            // txtInsertSoyad
            // 
            this.txtInsertSoyad.Location = new System.Drawing.Point(116, 48);
            this.txtInsertSoyad.Name = "txtInsertSoyad";
            this.txtInsertSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtInsertSoyad.TabIndex = 3;
            // 
            // txtInsertAd
            // 
            this.txtInsertAd.Location = new System.Drawing.Point(116, 22);
            this.txtInsertAd.Name = "txtInsertAd";
            this.txtInsertAd.Size = new System.Drawing.Size(100, 22);
            this.txtInsertAd.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad";
            // 
            // btnYeniKisiEkle
            // 
            this.btnYeniKisiEkle.Location = new System.Drawing.Point(222, 22);
            this.btnYeniKisiEkle.Name = "btnYeniKisiEkle";
            this.btnYeniKisiEkle.Size = new System.Drawing.Size(101, 36);
            this.btnYeniKisiEkle.TabIndex = 3;
            this.btnYeniKisiEkle.Text = "Yeni Kisi Ekle";
            this.btnYeniKisiEkle.UseVisualStyleBackColor = true;
            this.btnYeniKisiEkle.Click += new System.EventHandler(this.btnYeniKisiEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // btnKisiyiSil
            // 
            this.btnKisiyiSil.Location = new System.Drawing.Point(517, 245);
            this.btnKisiyiSil.Name = "btnKisiyiSil";
            this.btnKisiyiSil.Size = new System.Drawing.Size(101, 36);
            this.btnKisiyiSil.TabIndex = 10;
            this.btnKisiyiSil.Text = "Kisiyi Sil";
            this.btnKisiyiSil.UseVisualStyleBackColor = true;
            this.btnKisiyiSil.Click += new System.EventHandler(this.btnKisiyiSil_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(270, 244);
            this.listBox1.TabIndex = 9;
            // 
            // btnKisileriGetir
            // 
            this.btnKisileriGetir.Location = new System.Drawing.Point(12, 262);
            this.btnKisileriGetir.Name = "btnKisileriGetir";
            this.btnKisileriGetir.Size = new System.Drawing.Size(270, 36);
            this.btnKisileriGetir.TabIndex = 8;
            this.btnKisileriGetir.Text = "Kisileri Getir";
            this.btnKisileriGetir.UseVisualStyleBackColor = true;
            this.btnKisileriGetir.Click += new System.EventHandler(this.btnKisileriGetir_Click);
            // 
            // btnBaglan
            // 
            this.btnBaglan.Location = new System.Drawing.Point(288, 262);
            this.btnBaglan.Name = "btnBaglan";
            this.btnBaglan.Size = new System.Drawing.Size(168, 36);
            this.btnBaglan.TabIndex = 13;
            this.btnBaglan.Text = "Baglan";
            this.btnBaglan.UseVisualStyleBackColor = true;
            this.btnBaglan.Click += new System.EventHandler(this.btnBaglan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 314);
            this.Controls.Add(this.btnBaglan);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnKisiyiSil);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnKisileriGetir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtUpdateSoyad;
        private System.Windows.Forms.TextBox txtUpdateAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnKisiGuncelle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtInsertSoyad;
        private System.Windows.Forms.TextBox txtInsertAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnYeniKisiEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKisiyiSil;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnKisileriGetir;
        private System.Windows.Forms.Button btnBaglan;
    }
}

