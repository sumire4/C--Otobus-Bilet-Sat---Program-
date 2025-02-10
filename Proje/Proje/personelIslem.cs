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
    public partial class personelIslem : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-SF2B38F\\MSSQLSERVER03;Initial Catalog=proje;User ID=sa;Password=1;;Encrypt=False");
        
        public personelIslem()
        {
            InitializeComponent();
        }

        private void personelIslem_Load(object sender, EventArgs e)
        {

        }

        private void btn_personelIlerle_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Table_Personel WHERE kullaniciAdi = @kullaniciAdi AND parola = @parola", con);
            cmd.Parameters.AddWithValue("@kullaniciAdi", textBox_personelKimlik.Text);
            cmd.Parameters.AddWithValue("@parola", textBox_personelParola.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows) // Veri bulunduysa
            {
                while (dr.Read())
                {
                    KontrolPaneli kp = new KontrolPaneli();
                    kp.Show();
                    this.Hide();
                }
            }
            else // Veri bulunamadıysa
            {
                MessageBox.Show("Hatalı veya eksik giriş!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
    }
}
