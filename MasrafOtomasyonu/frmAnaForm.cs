using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using Entities;
using Entities.Enums;

namespace MasrafOtomasyonu
{
    public partial class frmAnaForm : Form
    {
        public frmAnaForm()
        {
            InitializeComponent();
        }
        public Personel GirisYapanPersonel { get; internal set; }
        MasrafIslemleri MI = new MasrafIslemleri();
        PersonelIslemleri PI = new PersonelIslemleri();
        private void frmAnaForm_Load(object sender, EventArgs e)
        {
            mnuPersonelAdiSoyadi.Text = 
                string.Format("{0} {1} ({2})",
                GirisYapanPersonel.Adi, 
                GirisYapanPersonel.Soyadi,
                PersonelEnumHelper.GetPersonelText(GirisYapanPersonel.PersonelTurId));
            GetirPersonelMasraflari();
            GetirPersonelSorumluListe();
        }
        #region Metodlar
        private void GetirPersonelMasraflari()
        {
            if (cbMasrafSahibi.SelectedIndex>-1)
            {
                Personel per = cbMasrafSahibi.SelectedItem as Personel;
                List<Masraf> masraflar = MI.GetirMasraflar(per.Id);
                lstMasraflar.DataSource = masraflar;
            }
            
        }

        private void GetirPersonelSorumluListe()
        {
            List<Personel> masrafSahipleri = new List<Personel>();
            if (GirisYapanPersonel.PersonelTurId != (byte)PersonelTuruEnum.Muhasebe)
            {
                masrafSahipleri.Add(GirisYapanPersonel);
                masrafSahipleri.AddRange(PI.PersonelGetirBySorumluId(GirisYapanPersonel.Id));
            }
            else
            {
                masrafSahipleri.AddRange(PI.GetirTumPersonel());
            }
            cbMasrafSahibi.DataSource = masrafSahipleri;
        }
        #endregion
        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMasrafEkle_Click(object sender, EventArgs e)
        {
            //Masraf Eklenmesi..
            Masraf masraf = new Masraf()
            {
                Id = Guid.NewGuid(),
                Baslik = txtBaslik.Text,
                Tarih = dtpTarih.Value,
                Aciklama = txtAciklama.Text,
                Tutar = nudTutar.Value,
                DurumId = (byte)DurumEnum.OnayBekliyor,
                PersonelId = GirisYapanPersonel.Id
            };
            if (GirisYapanPersonel.PersonelTurId==(byte)PersonelTuruEnum.Yonetici)
            {
                masraf.DurumId = (byte)DurumEnum.Onaylandi;
            }
            int sonuc = MI.MasrafEkle(masraf);
            if (sonuc > 0)
            {
                GetirPersonelMasraflari();
            }
            else
            {
                MessageBox.Show("Masraf Eklenmedi");
            }
        }
        private void lstMasraflar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMasraflar.SelectedIndex == -1)
            {
                return;
            }
            Masraf masraf = lstMasraflar.SelectedItem as Masraf;
            if (masraf != null)
            {
                txtAciklama.Text = masraf.Aciklama;
                txtBaslik.Text = masraf.Baslik;
                dtpTarih.Value = masraf.Tarih;
                nudTutar.Value = masraf.Tutar;
                //bunu onay mekanizamasında yapacagiz
            }
            if (masraf.DurumId == (byte)DurumEnum.Reddedildi || masraf.DurumId == (byte)DurumEnum.Odendi)
            {
                btnMasrafKaydet.Enabled = false;
            }
            else
            { 
                btnMasrafKaydet.Enabled = true;
            }
            if (masraf.DurumId == (byte)DurumEnum.Odendi)
            {
                btnSil.Enabled = false;                
            }
            else
            {
                btnSil.Enabled = true;
            }
            if (masraf.DurumId == (byte)DurumEnum.Onaylandi)
            {
                cmnuMuhasebeOdendi.Enabled = true;
            }
            else
            {
                cmnuMuhasebeOdendi.Enabled = false;
            }
        }
        private void btnMasrafKaydet_Click(object sender, EventArgs e)
        {
            if (lstMasraflar.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen kaydetme işlemi için bir masraf seciniz");
                return;
            }
            Masraf masraf = lstMasraflar.SelectedItem as Masraf;
            masraf.Baslik = txtBaslik.Text;
            masraf.Aciklama = txtAciklama.Text;
            masraf.Tarih = dtpTarih.Value;
            masraf.Tutar = nudTutar.Value;
            masraf.DurumId = (byte)DurumEnum.OnayBekliyor;
            if (GirisYapanPersonel.PersonelTurId == (byte)PersonelTuruEnum.Yonetici)
            {
                masraf.DurumId = (byte)DurumEnum.Onaylandi;
            }
            if (MI.MasrafGuncelle(masraf) > 0)
                GetirPersonelMasraflari();
            else
                MessageBox.Show("Masraf güncellenemedi");
        }
        private void lstMasraflar_Format(object sender, ListControlConvertEventArgs e)
        {
            Masraf masraf = e.ListItem as Masraf;
            e.Value = string.Format("{0} ({1})", masraf.Baslik, DurumEnumHelper.GetDurumText(masraf.DurumId));
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstMasraflar.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen silme işlemi için bir masraf seciniz");
                return;
            }
            Masraf masraf = lstMasraflar.SelectedItem as Masraf;
            DialogResult sonuc = MessageBox.Show(masraf.Baslik+" başlıklı masraf silinsin mi?","Masraf Silme",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (sonuc==DialogResult.Yes)
            {
                if (MI.MasrafSil(masraf) > 0)
                    GetirPersonelMasraflari();    
            }
            else
                MessageBox.Show("Masraf Silinemedi");
        }
        private void cbMasrafSahibi_Format(object sender, ListControlConvertEventArgs e)
        {
            Personel per = e.ListItem as Personel;
            e.Value = string.Format("{0} {1}", per.Adi,per.Soyadi);
        }
        private void cbMasrafSahibi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMasrafSahibi.SelectedIndex > -1)
            {
                Personel per = cbMasrafSahibi.SelectedItem as Personel;
                if (per.Id==GirisYapanPersonel.Id)
                {
                    flpDugmeler.Enabled = true;
                    lstMasraflar.ContextMenuStrip = null;
                }
                else
                {
                    flpDugmeler.Enabled = false;
                    lstMasraflar.ContextMenuStrip = cmnuMasrafYonet;
                }
                if (GirisYapanPersonel.PersonelTurId==(byte)PersonelTuruEnum.Muhasebe)
                {
                    lstMasraflar.ContextMenuStrip = cmnuMuhasebe;
                }
                List<Masraf> masraflar = MI.GetirMasraflar(per.Id);
                lstMasraflar.DataSource = masraflar;
            }
        }
        private void cmnuOnayla_Click(object sender, EventArgs e)
        {
            if (lstMasraflar.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen onaylama işlemi için bir masraf seciniz");
                return;
            }
            Masraf masraf = lstMasraflar.SelectedItem as Masraf;            
            masraf.DurumId = (byte)DurumEnum.Onaylandi;
            if (MI.MasrafGuncelle(masraf) > 0)
                GetirPersonelMasraflari();
            else
                MessageBox.Show("Masraf Onaylanamadı");
        }   
        private void cmnuGuncelle_Click(object sender, EventArgs e)
        {
            if (lstMasraflar.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen güncelleme işlemi için bir masraf seciniz");
                return;
            }
            Masraf masraf = lstMasraflar.SelectedItem as Masraf;
            masraf.DurumId = (byte)DurumEnum.Duzeltilecek;
            if (MI.MasrafGuncelle(masraf) > 0)
                GetirPersonelMasraflari();
            else
                MessageBox.Show("Masraf Güncellenemedi");
        }
        private void cmnuReddet_Click(object sender, EventArgs e)
        {
            if (lstMasraflar.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen reddetme işlemi için bir masraf seciniz");
                return;
            }
            Masraf masraf = lstMasraflar.SelectedItem as Masraf;
            masraf.DurumId = (byte)DurumEnum.Reddedildi;
            if (MI.MasrafGuncelle(masraf) > 0)
                GetirPersonelMasraflari();
            else
                MessageBox.Show("Masraf Reddedilemedi");
        }

        private void cmnuMuhasebeOdendi_Click(object sender, EventArgs e)
        {
            if (lstMasraflar.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen ödeme onayı işlemi için bir masraf seciniz");
                return;
            }
            Masraf masraf = lstMasraflar.SelectedItem as Masraf;
            masraf.DurumId = (byte)DurumEnum.Odendi;
            if (MI.MasrafGuncelle(masraf) > 0)
                GetirPersonelMasraflari();
            else
                MessageBox.Show("Masraf durumu değiştirilemedi.");
        }
    }
}
