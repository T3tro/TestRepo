using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaleriUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnuAc_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Galeri Aç";
            ofd.Filter = "Galeri Dosyalari(*.xenol)|*.xenol";
            ofd.FilterIndex = 1;
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] dosyalar = System.IO.File.ReadAllLines(ofd.FileName);
                flpResimPaneli.Controls.Clear();
                foreach (string item in dosyalar)
                {
                    PicturesBoxEkle(item);

                }
            }

        }  
             
        private void mnuKaydet_Click(object sender, EventArgs e)
        {
            List<string> kaydedilecekDosyaKonumlari = new List<string>();

            foreach (Panel item in flpResimPaneli.Controls)
            {
                PictureBox pbox = (PictureBox)item.Controls[0];
                kaydedilecekDosyaKonumlari.Add(pbox.ImageLocation);

            }
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Galeri Kaydet";
            sfd.Filter = "Galeri Dosyalari(*.xenol)|*.xenol";
            sfd.FilterIndex = 1;
            sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

            if (sfd.ShowDialog()==DialogResult.OK)
            {
                System.IO.File.WriteAllLines(sfd.FileName, kaydedilecekDosyaKonumlari);
                MessageBox.Show("Galeri Kaydedilmiştir.");
            }
        }       

        private void mnuEkle_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPEG Resimler(*.jpg;*.jpeg)|*.jpg;*.jpeg|PNG Resimler(*.png)|*.png|Tüm Dosyalar(*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
            ofd.FilterIndex = 3;
            ofd.Title = "Resimleri Seç";
            ofd.Multiselect = true;
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] dosyaKonumlari = ofd.FileNames;
                foreach (string item in dosyaKonumlari)
                {
                    PicturesBoxEkle(item);
                }
            }

        }
        private void mnuCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PicturesBoxEkle(string dosyaKonumu)
        {
            Panel pnl = new Panel();
            pnl.BorderStyle = BorderStyle.FixedSingle;
            pnl.Width = 75;
            pnl.Height = 75;
            PictureBox pb = new PictureBox();
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            pb.ImageLocation = dosyaKonumu;
            pb.Dock = DockStyle.Fill;

            pb.Click += Pb_Click;

            pnl.Controls.Add(pb);
            flpResimPaneli.Controls.Add(pnl);
        }
        private void Pb_Click(object sender, EventArgs e)
        {
            PictureBox pbox = (PictureBox)sender;

            Form frm = new Form();
            frm.Text = "Resim Önizleme";
            frm.Width = 300;
            frm.Height = 300;

            PictureBox pbnew = new PictureBox();
            pbnew.ImageLocation = pbox.ImageLocation;
            pbnew.SizeMode = pbox.SizeMode;
            pbnew.Dock = DockStyle.Fill;
            frm.Controls.Add(pbnew);
            frm.Show();
        }
    }
}
