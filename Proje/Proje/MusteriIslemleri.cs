using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Proje
{
    public partial class MusteriIslemleri : Form
    {
        public MusteriIslemleri()
        {
            InitializeComponent();
        }

        string connectionString = "Data Source=DESKTOP-SF2B38F\\MSSQLSERVER03;Initial Catalog=proje;User ID=sa;Password=1;Encrypt=False";

        private void Koltuk_Tıklama(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string koltukNo = clickedButton.Text;
                KayitliKoltuk(koltukNo);

                // Buton rengini değiştir ve devre dışı bırak
                clickedButton.BackColor = Color.Gray;
                clickedButton.Enabled = false;
            }
        }

        private void KayitliKoltuk(string KoltukNo)
        {

            string AdSoyad = textBox_adSoyad.Text;
            string TCKimlikNumarası = textBox_tcno.Text;
            string TelefonNumarası = maskedTextBox_telno.Text;
            string Nereden = comboBox_nereden.SelectedItem.ToString();
            string Nereye = comboBox_nereye.SelectedItem.ToString();


            string con = "Data Source=DESKTOP-SF2B38F\\MSSQLSERVER03;Initial Catalog=proje;User ID=sa;Password=1;;Encrypt=False";
            string query = "INSERT INTO Table_Musteri (AdSoyad, TCKimlikNumarası, TelefonNumarası, Nereden, Nereye, KoltukNo) VALUES (@AdSoyad, @TCKimlikNumarası, @TelefonNumarası, @Nereden, @Nereye, @KoltukNo)";

            using (SqlConnection conn = new SqlConnection(con))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@KoltukNo", KoltukNo);
                        command.Parameters.AddWithValue("@AdSoyad", AdSoyad);
                        command.Parameters.AddWithValue("@TCKimlikNumarası", TCKimlikNumarası);
                        command.Parameters.AddWithValue("@TelefonNumarası", TelefonNumarası);
                        command.Parameters.AddWithValue("@Nereden", Nereden);
                        command.Parameters.AddWithValue("@Nereye", Nereye);
                        


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
                KontrolPaneli kp = new KontrolPaneli();
                kp.LoadData2();
            }

        }





        private void button_degis_Click(object sender, EventArgs e)
        {
            string tmp = comboBox_nereden.SelectedItem.ToString();
            comboBox_nereden.SelectedItem = comboBox_nereye.SelectedItem;
            comboBox_nereye.SelectedItem = tmp;

        }

        private void button_ilerle_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}