using BusinessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasrafOtomasyonu
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (OnDenetleme() == true)
                return;
            PersonelIslemleri pi = new PersonelIslemleri();
            Personel personel = pi.KullaniciLogin(txtKullaniciAdi.Text, txtSifre.Text);

            if (personel!=null)
            {   //Basarili giris
                this.Hide();
                frmAnaForm frm = new frmAnaForm();
                frm.GirisYapanPersonel = personel;
                frm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı.","Hatalı Girişi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        
        }

        #region Metodlar

        private bool OnDenetleme()
        {
            bool result = false;
            errorProvider1.Clear();//Eger ekranda hata gosteriliyorsa temizler.
            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string sifre = txtSifre.Text.Trim();
            if (string.IsNullOrEmpty(kullaniciAdi))
            {
                errorProvider1.SetError(txtKullaniciAdi, "Kullanıcı adı boş geçilemez..");
                result = true;
            }
            if (string.IsNullOrEmpty(sifre))
            {
                errorProvider1.SetError(txtSifre, "Kullanıcı adı boş geçilemez..");
                result = true;
            }
            return result;
        }
        #endregion

        private void frmGiris_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtKullaniciAdi;
        }
    }
}
