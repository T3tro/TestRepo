namespace MasrafOtomasyonu
{
    partial class frmAnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.flpDugmeler = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMasrafEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnMasrafKaydet = new System.Windows.Forms.Button();
            this.nudTutar = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBaslik = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstMasraflar = new System.Windows.Forms.ListBox();
            this.cmnuMasrafYonet = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmnuOnayla = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuGuncelle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmnuReddet = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.cbMasrafSahibi = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuPersonelAdiSoyadi = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuMuhasebe = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmnuMuhasebeOdendi = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flpDugmeler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTutar)).BeginInit();
            this.panel1.SuspendLayout();
            this.cmnuMasrafYonet.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.cmnuMuhasebe.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(10);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.menuStrip1);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.splitContainer1.Size = new System.Drawing.Size(619, 517);
            this.splitContainer1.SplitterDistance = 271;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAciklama);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.flpDugmeler);
            this.groupBox1.Controls.Add(this.nudTutar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBaslik);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpTarih);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(251, 497);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Masraf Detayları";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAciklama.Location = new System.Drawing.Point(10, 159);
            this.txtAciklama.MaxLength = 150;
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAciklama.Size = new System.Drawing.Size(231, 229);
            this.txtAciklama.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(10, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Açıklama :";
            // 
            // flpDugmeler
            // 
            this.flpDugmeler.Controls.Add(this.btnMasrafEkle);
            this.flpDugmeler.Controls.Add(this.btnSil);
            this.flpDugmeler.Controls.Add(this.btnMasrafKaydet);
            this.flpDugmeler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpDugmeler.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpDugmeler.Location = new System.Drawing.Point(10, 388);
            this.flpDugmeler.Name = "flpDugmeler";
            this.flpDugmeler.Size = new System.Drawing.Size(231, 99);
            this.flpDugmeler.TabIndex = 6;
            // 
            // btnMasrafEkle
            // 
            this.btnMasrafEkle.Image = global::MasrafOtomasyonu.Properties.Resources.check_1_icon_kucuk;
            this.btnMasrafEkle.Location = new System.Drawing.Point(128, 3);
            this.btnMasrafEkle.Name = "btnMasrafEkle";
            this.btnMasrafEkle.Size = new System.Drawing.Size(100, 42);
            this.btnMasrafEkle.TabIndex = 5;
            this.btnMasrafEkle.Text = "Ekle";
            this.btnMasrafEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMasrafEkle.UseVisualStyleBackColor = true;
            this.btnMasrafEkle.Click += new System.EventHandler(this.btnMasrafEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Image = global::MasrafOtomasyonu.Properties.Resources._73030_no_entry_icon__1__kucuk;
            this.btnSil.Location = new System.Drawing.Point(22, 3);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(100, 42);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "Sil";
            this.btnSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnMasrafKaydet
            // 
            this.btnMasrafKaydet.Location = new System.Drawing.Point(128, 51);
            this.btnMasrafKaydet.Name = "btnMasrafKaydet";
            this.btnMasrafKaydet.Size = new System.Drawing.Size(100, 42);
            this.btnMasrafKaydet.TabIndex = 2;
            this.btnMasrafKaydet.Text = "Kaydet";
            this.btnMasrafKaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMasrafKaydet.UseVisualStyleBackColor = true;
            this.btnMasrafKaydet.Click += new System.EventHandler(this.btnMasrafKaydet_Click);
            // 
            // nudTutar
            // 
            this.nudTutar.DecimalPlaces = 2;
            this.nudTutar.Dock = System.Windows.Forms.DockStyle.Top;
            this.nudTutar.Location = new System.Drawing.Point(10, 120);
            this.nudTutar.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudTutar.Name = "nudTutar";
            this.nudTutar.Size = new System.Drawing.Size(231, 22);
            this.nudTutar.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(10, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tutar :";
            // 
            // txtBaslik
            // 
            this.txtBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtBaslik.Location = new System.Drawing.Point(10, 81);
            this.txtBaslik.MaxLength = 50;
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.Size = new System.Drawing.Size(231, 22);
            this.txtBaslik.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(10, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Başlık :";
            // 
            // dtpTarih
            // 
            this.dtpTarih.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTarih.Location = new System.Drawing.Point(10, 42);
            this.dtpTarih.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dtpTarih.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(231, 22);
            this.dtpTarih.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tarih :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lstMasraflar);
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 479);
            this.panel1.TabIndex = 1;
            // 
            // lstMasraflar
            // 
            this.lstMasraflar.ContextMenuStrip = this.cmnuMasrafYonet;
            this.lstMasraflar.FormattingEnabled = true;
            this.lstMasraflar.ItemHeight = 16;
            this.lstMasraflar.Location = new System.Drawing.Point(3, 40);
            this.lstMasraflar.Name = "lstMasraflar";
            this.lstMasraflar.Size = new System.Drawing.Size(321, 436);
            this.lstMasraflar.TabIndex = 1;
            this.lstMasraflar.SelectedIndexChanged += new System.EventHandler(this.lstMasraflar_SelectedIndexChanged);
            this.lstMasraflar.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.lstMasraflar_Format);
            // 
            // cmnuMasrafYonet
            // 
            this.cmnuMasrafYonet.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmnuMasrafYonet.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmnuOnayla,
            this.cmnuGuncelle,
            this.toolStripSeparator1,
            this.cmnuReddet});
            this.cmnuMasrafYonet.Name = "cmnuMasrafYonet";
            this.cmnuMasrafYonet.Size = new System.Drawing.Size(173, 82);
            // 
            // cmnuOnayla
            // 
            this.cmnuOnayla.Name = "cmnuOnayla";
            this.cmnuOnayla.Size = new System.Drawing.Size(172, 24);
            this.cmnuOnayla.Text = "Onayla";
            this.cmnuOnayla.Click += new System.EventHandler(this.cmnuOnayla_Click);
            // 
            // cmnuGuncelle
            // 
            this.cmnuGuncelle.Name = "cmnuGuncelle";
            this.cmnuGuncelle.Size = new System.Drawing.Size(172, 24);
            this.cmnuGuncelle.Text = "Güncellenmeli";
            this.cmnuGuncelle.Click += new System.EventHandler(this.cmnuGuncelle_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(169, 6);
            // 
            // cmnuReddet
            // 
            this.cmnuReddet.Name = "cmnuReddet";
            this.cmnuReddet.Size = new System.Drawing.Size(172, 24);
            this.cmnuReddet.Text = "Reddet";
            this.cmnuReddet.Click += new System.EventHandler(this.cmnuReddet_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.cbMasrafSahibi);
            this.flowLayoutPanel2.Controls.Add(this.label5);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(321, 34);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // cbMasrafSahibi
            // 
            this.cbMasrafSahibi.FormattingEnabled = true;
            this.cbMasrafSahibi.Location = new System.Drawing.Point(130, 3);
            this.cbMasrafSahibi.Name = "cbMasrafSahibi";
            this.cbMasrafSahibi.Size = new System.Drawing.Size(188, 24);
            this.cbMasrafSahibi.TabIndex = 6;
            this.cbMasrafSahibi.SelectedIndexChanged += new System.EventHandler(this.cbMasrafSahibi_SelectedIndexChanged);
            this.cbMasrafSahibi.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cbMasrafSahibi_Format);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label5.Size = new System.Drawing.Size(107, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "Masraf Sahibi";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPersonelAdiSoyadi,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(10, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(324, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuPersonelAdiSoyadi
            // 
            this.mnuPersonelAdiSoyadi.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuPersonelAdiSoyadi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mnuPersonelAdiSoyadi.Name = "mnuPersonelAdiSoyadi";
            this.mnuPersonelAdiSoyadi.Size = new System.Drawing.Size(155, 24);
            this.mnuPersonelAdiSoyadi.Text = "[PersonelAdSoyad]";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // cmnuMuhasebe
            // 
            this.cmnuMuhasebe.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmnuMuhasebe.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmnuMuhasebeOdendi});
            this.cmnuMuhasebe.Name = "cmnuMuhasebe";
            this.cmnuMuhasebe.Size = new System.Drawing.Size(128, 28);
            // 
            // cmnuMuhasebeOdendi
            // 
            this.cmnuMuhasebeOdendi.Name = "cmnuMuhasebeOdendi";
            this.cmnuMuhasebeOdendi.Size = new System.Drawing.Size(127, 24);
            this.cmnuMuhasebeOdendi.Text = "Ödendi";
            this.cmnuMuhasebeOdendi.Click += new System.EventHandler(this.cmnuMuhasebeOdendi_Click);
            // 
            // frmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 517);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Masraf Otomasyonu : Masraflar";
            this.Load += new System.EventHandler(this.frmAnaForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flpDugmeler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudTutar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.cmnuMasrafYonet.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.cmnuMuhasebe.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flpDugmeler;
        private System.Windows.Forms.Button btnMasrafEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnMasrafKaydet;
        private System.Windows.Forms.NumericUpDown nudTutar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBaslik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lstMasraflar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.ComboBox cbMasrafSahibi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem mnuPersonelAdiSoyadi;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmnuMasrafYonet;
        private System.Windows.Forms.ToolStripMenuItem cmnuOnayla;
        private System.Windows.Forms.ToolStripMenuItem cmnuGuncelle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cmnuReddet;
        private System.Windows.Forms.ContextMenuStrip cmnuMuhasebe;
        private System.Windows.Forms.ToolStripMenuItem cmnuMuhasebeOdendi;
    }
}