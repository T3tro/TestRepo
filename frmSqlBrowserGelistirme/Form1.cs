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

namespace frmSqlBrowserGelistirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }
        string connectionString = string.Empty;
        private void btnBaglan_Click(object sender, EventArgs e)
        {
            this.BaglantiSozcuguYarat("Master");
            try
            {
                this.cmbDatabases.Items.Clear();
                SqlHelper helper = new SqlHelper(connectionString);
                helper.Command.CommandText = "SELECT name FROM SYS.DATABASES";
                List<string> databases = helper.VeriGetirList();
                foreach (var item in databases)
                {
                    this.cmbDatabases.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txtServerName.Text = @"(localdb)\MSSQLLocalDB";
        }
        private void cmbDatabases_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dbName = cmbDatabases.Text;
            this.BaglantiSozcuguYarat(dbName);
            try
            {
                this.cmbTables.Items.Clear();
                SqlHelper helper = new SqlHelper(connectionString);
                helper.Command.CommandText = "Select name from sys.tables";
                List<string> tables = helper.VeriGetirList();
                foreach (var item in tables)                
                    cmbTables.Items.Add(item);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cmbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dbName = cmbDatabases.Text;
            try
            {
                clbColumns.Items.Clear();
                string tableName = cmbTables.Text;
                SqlHelper helper = new SqlHelper(connectionString);
                helper.Command.CommandText= string.Format("SELECT COLUMN_NAME FROM {0}.INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME=@TableName", dbName);
                helper.Command.Parameters.AddWithValue("@TableName", tableName);
                List<string> columns = helper.VeriGetirList();
                foreach (var item in columns)
                    clbColumns.Items.Add(item);
                // Seçili tabloya select atılarak verileri elde ediyoruz..
                helper = new SqlHelper(connectionString);
                helper.Command.CommandText= string.Format("SELECT * FROM {0}", tableName);
                
                txtQuery.Text = helper.Command.CommandText;
                DataTable dt = helper.DataTableVerisiniGetir();
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnCalistir_Click(object sender, EventArgs e)
        {
            string dbName = cmbDatabases.Text;
            
            try
            {
                SqlHelper helper = new SqlHelper(connectionString);
                helper.Command.CommandText = txtQuery.Text;
                DataTable dt = helper.DataTableVerisiniGetir();
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void clbColumns_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ItemCheck olayında check özelligi cok sacma, isaretlememize ragmen isaretlenmemis gibi gorunuyor. bu yuzden hata alıyoruz. selected check list box in properties ten checkonclick ozelligini true yapiyoruz.

            //bool check = false;
            //check = (e.NewValue == CheckState.Checked) ? true : false;
            //clbColumns.SetItemChecked(e.Index, check);
            string tableName = cmbTables.Text;
            try
            {
               
                string sorgu = string.Empty;
                string kolonlar = string.Empty;
                if (clbColumns.CheckedItems.Count > 0)
                {
                    foreach (object item in clbColumns.CheckedItems)
                    {
                        kolonlar += string.Format("[{0}],", item.ToString());
                    }
                    kolonlar = kolonlar.TrimEnd(',');
                }
                else
                {
                    kolonlar = "*";
                }
                SqlHelper helper = new SqlHelper(connectionString);
                helper.Command.CommandText= string.Format("SELECT {0} FROM {1}", kolonlar, tableName);
                txtQuery.Text = helper.Command.CommandText;
                DataTable dt = helper.DataTableVerisiniGetir();
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BaglantiSozcuguYarat(string dbName)
        {
            if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Text))
                //sql authentication..
                connectionString = string.Format("Server={0};Database={1};User Id={2};Password={3};", txtServerName.Text, dbName, txtUsername.Text, txtPassword.Text);
            else
                //windows authentication..
                connectionString = string.Format("Server={0};Database={1};Integrated Security=True;", txtServerName.Text, dbName);            
        }
    }
}
