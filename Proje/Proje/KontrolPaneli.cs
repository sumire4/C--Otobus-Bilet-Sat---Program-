using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class KontrolPaneli : Form
    {
        string connectionString = "Data Source=DESKTOP-SF2B38F\\MSSQLSERVER03;Initial Catalog=proje;User ID=sa;Password=1;Encrypt=False";
        public KontrolPaneli()
        {
            InitializeComponent();

        }

        public void LoadData2()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Table_Musteri";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView_kntrlpanel.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
        public void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Table_Otobus"; 
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
        private void KontrolPaneli_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-SF2B38F\\MSSQLSERVER03;Initial Catalog=proje;User ID=sa;Password=1;Encrypt=False";
            string query = "SELECT * FROM Table_Musteri";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);

                
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                
                dataGridView_kntrlpanel.DataSource = dataTable;
            }

            string query2 = "SELECT * FROM Table_Otobus";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query2, connection);

                
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                
                dataGridView1.DataSource = dataTable;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime KalkisSaati = DateTime.Parse(maskedTextBox_kalkıssaat.Text);
            DateTime VarışSaati = DateTime.Parse(maskedTextBox_varis.Text);
            string KalkışKonumu = textBox_kalkiskonum.Text;
            string VarışKonumu = textBox_variskonumu.Text;

            string con = "Data Source=DESKTOP-SF2B38F\\MSSQLSERVER03;Initial Catalog=proje;User ID=sa;Password=1;Encrypt=False";
            string query = "INSERT INTO Table_Otobus (KalkisSaati, VarışSaati, KalkışKonumu, VarışKonumu) VALUES (@KalkisSaati, @VarışSaati, @KalkışKonumu, @VarışKonumu)";

            using (SqlConnection conn = new SqlConnection(con))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        
                        command.Parameters.AddWithValue("@KalkisSaati", KalkisSaati);
                        command.Parameters.AddWithValue("@VarışSaati", VarışSaati);
                        command.Parameters.AddWithValue("@KalkışKonumu", KalkışKonumu);
                        command.Parameters.AddWithValue("@VarışKonumu", VarışKonumu);

                        
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Kayıt başarıyla eklendi!");
                        }
                        else
                        {
                            MessageBox.Show("Kayıt eklenemedi.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
                LoadData();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button_seferiptal_Click(object sender, EventArgs e)
        {
            string id = textBox_seferiptal.Text;

            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Lütfen silmek istediğiniz ID'yi girin.");
                return;
            }

            string connectionString = "Data Source=DESKTOP-SF2B38F\\MSSQLSERVER03;Initial Catalog=proje;User ID=sa;Password=1;Encrypt=False";

            // Veritabanında ID'ye göre satırı sil
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "DELETE FROM Table_Otobus WHERE id = @id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Sefer başarıyla silindi.");
                        }
                        else
                        {
                            MessageBox.Show("Belirtilen Kimlik Numarasına sahip bir sefer bulunamadı.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
                LoadData();
            }
        }
    }
    
}
