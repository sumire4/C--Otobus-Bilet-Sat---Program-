﻿using System;
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
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand cmd;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_personel_Click(object sender, EventArgs e)
        {
            personelIslem personel = new personelIslem();
            personel.Show();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_musteri_Click(object sender, EventArgs e)
        {
            MusteriIslemleri musteriIslemleri = new MusteriIslemleri();
            musteriIslemleri.Show();
        }
    }
}
