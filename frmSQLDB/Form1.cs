using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace frmSQLDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Server = (localdb)\MSSQLLocalDB; Database = TestVeritabani; Trusted_Connection = True;");
        Random rnd = new Random();
        private void btnBaglan_Click(object sender, EventArgs e)
        {
                      
            conn.Open();
            MessageBox.Show("Baglanti Acildi");
            
            conn.Close();
            MessageBox.Show("Baglanti Kapatildi");
        }
        private void btnKisileriGetir_Click(object sender, EventArgs e)
        {
            ListelemeYap();
        }
        private void ListelemeYap()
        {
            SqlCommand cmd = new SqlCommand("SELECT ID,Adi,Soyadi,Yas FROM Kisi", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            listBox1.Items.Clear();
            foreach (DataRow item in dt.Rows)
            {
                listBox1.Items.Add(item["ID"].ToString() + "-" +
                item["Adi"].ToString() + " " +
                item["Soyadi"].ToString() + " " +
                item["Yas"].ToString());
                  
            }
        }
        private void SoyguyuCalistir(SqlCommand cmd)
        {
            conn.Open();
            int sonuc = cmd.ExecuteNonQuery();
            MessageBox.Show("Ilgili kayıt duzenlendi.."+ sonuc.ToString());
            conn.Close();
        }
        private void btnYeniKisiEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Kisi(Adi,Soyadi,Yas) VALUES (@Adi,@Soyadi,@Yas)", conn);
            cmd.Parameters.AddWithValue("@Adi", this.txtInsertAd.Text);
            cmd.Parameters.AddWithValue("@Soyadi", this.txtInsertSoyad.Text);
            cmd.Parameters.AddWithValue("@Yas", rnd.Next(0, 99));
            SoyguyuCalistir(cmd);
            ListelemeYap();
        }   
        private void btnKisiGuncelle_Click(object sender, EventArgs e)
        {
            string seciliKayit = this.listBox1.SelectedItem.ToString();
            int seciliKayitID = int.Parse(seciliKayit.Split('-')[0]);
            SqlCommand cmd = new SqlCommand("UPDATE [dbo].[Kisi] SET[Adi] = @Adi,[Soyadi] = @Soyadi WHERE ID = @ID", conn);
            cmd.Parameters.AddWithValue("@Adi", this.txtUpdateAd.Text);
            cmd.Parameters.AddWithValue("@Soyadi", this.txtUpdateSoyad.Text);
            cmd.Parameters.AddWithValue("@ID", seciliKayitID);

            SoyguyuCalistir(cmd);
            ListelemeYap();
        }
        private void btnKisiyiSil_Click(object sender, EventArgs e)
        {
            string seciliKayit = this.listBox1.SelectedItem.ToString();
            int seciliKayitID = int.Parse(seciliKayit.Split('-')[0]);
            SqlCommand cmd = new SqlCommand("DELETE FROM Kisi WHERE ID=@ID", conn);
            cmd.Parameters.AddWithValue("@ID", seciliKayitID);

            SoyguyuCalistir(cmd);
            ListelemeYap();
        }
    }
}
