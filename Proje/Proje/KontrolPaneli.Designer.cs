namespace Proje
{
    partial class KontrolPaneli
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
            this.dataGridView_kntrlpanel = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox_varis = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_kalkıssaat = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_variskonumu = new System.Windows.Forms.TextBox();
            this.textBox_kalkiskonum = new System.Windows.Forms.TextBox();
            this.label_kalkıskonum = new System.Windows.Forms.Label();
            this.label_variskonum = new System.Windows.Forms.Label();
            this.label_kalkıssaat = new System.Windows.Forms.Label();
            this.label_varıssaati = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button_seferiptal = new System.Windows.Forms.Button();
            this.textBox_seferiptal = new System.Windows.Forms.TextBox();
            this.label_seferiptal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_kntrlpanel)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_kntrlpanel
            // 
            this.dataGridView_kntrlpanel.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_kntrlpanel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_kntrlpanel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_kntrlpanel.Location = new System.Drawing.Point(7, 21);
            this.dataGridView_kntrlpanel.Name = "dataGridView_kntrlpanel";
            this.dataGridView_kntrlpanel.RowHeadersWidth = 51;
            this.dataGridView_kntrlpanel.RowTemplate.Height = 24;
            this.dataGridView_kntrlpanel.Size = new System.Drawing.Size(900, 349);
            this.dataGridView_kntrlpanel.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.dataGridView_kntrlpanel);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(923, 379);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox2.Location = new System.Drawing.Point(951, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(851, 379);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seferler";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(742, 352);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.maskedTextBox_varis);
            this.groupBox3.Controls.Add(this.maskedTextBox_kalkıssaat);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.textBox_variskonumu);
            this.groupBox3.Controls.Add(this.textBox_kalkiskonum);
            this.groupBox3.Controls.Add(this.label_kalkıskonum);
            this.groupBox3.Controls.Add(this.label_variskonum);
            this.groupBox3.Controls.Add(this.label_kalkıssaat);
            this.groupBox3.Controls.Add(this.label_varıssaati);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox3.Location = new System.Drawing.Point(12, 425);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(488, 237);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sefer Ekleme";
            // 
            // maskedTextBox_varis
            // 
            this.maskedTextBox_varis.Location = new System.Drawing.Point(186, 90);
            this.maskedTextBox_varis.Mask = "00/00/0000 90:00";
            this.maskedTextBox_varis.Name = "maskedTextBox_varis";
            this.maskedTextBox_varis.Size = new System.Drawing.Size(120, 30);
            this.maskedTextBox_varis.TabIndex = 6;
            this.maskedTextBox_varis.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox_kalkıssaat
            // 
            this.maskedTextBox_kalkıssaat.Location = new System.Drawing.Point(186, 49);
            this.maskedTextBox_kalkıssaat.Mask = "00/00/0000 90:00";
            this.maskedTextBox_kalkıssaat.Name = "maskedTextBox_kalkıssaat";
            this.maskedTextBox_kalkıssaat.Size = new System.Drawing.Size(120, 30);
            this.maskedTextBox_kalkıssaat.TabIndex = 6;
            this.maskedTextBox_kalkıssaat.ValidatingType = typeof(System.DateTime);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(333, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 57);
            this.button1.TabIndex = 3;
            this.button1.Text = "TAMAMLA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_variskonumu
            // 
            this.textBox_variskonumu.Location = new System.Drawing.Point(186, 160);
            this.textBox_variskonumu.Name = "textBox_variskonumu";
            this.textBox_variskonumu.Size = new System.Drawing.Size(120, 30);
            this.textBox_variskonumu.TabIndex = 2;
            // 
            // textBox_kalkiskonum
            // 
            this.textBox_kalkiskonum.Location = new System.Drawing.Point(186, 124);
            this.textBox_kalkiskonum.Name = "textBox_kalkiskonum";
            this.textBox_kalkiskonum.Size = new System.Drawing.Size(120, 30);
            this.textBox_kalkiskonum.TabIndex = 2;
            // 
            // label_kalkıskonum
            // 
            this.label_kalkıskonum.AutoSize = true;
            this.label_kalkıskonum.Location = new System.Drawing.Point(27, 127);
            this.label_kalkıskonum.Name = "label_kalkıskonum";
            this.label_kalkıskonum.Size = new System.Drawing.Size(129, 23);
            this.label_kalkıskonum.TabIndex = 0;
            this.label_kalkıskonum.Text = "Kalkış Konumu";
            // 
            // label_variskonum
            // 
            this.label_variskonum.AutoSize = true;
            this.label_variskonum.Location = new System.Drawing.Point(33, 163);
            this.label_variskonum.Name = "label_variskonum";
            this.label_variskonum.Size = new System.Drawing.Size(120, 23);
            this.label_variskonum.TabIndex = 0;
            this.label_variskonum.Text = "Varış Konumu";
            // 
            // label_kalkıssaat
            // 
            this.label_kalkıssaat.AutoSize = true;
            this.label_kalkıssaat.Location = new System.Drawing.Point(35, 52);
            this.label_kalkıssaat.Name = "label_kalkıssaat";
            this.label_kalkıssaat.Size = new System.Drawing.Size(121, 23);
            this.label_kalkıssaat.TabIndex = 0;
            this.label_kalkıssaat.Text = "Kalkış Zamanı";
            // 
            // label_varıssaati
            // 
            this.label_varıssaati.AutoSize = true;
            this.label_varıssaati.Location = new System.Drawing.Point(44, 93);
            this.label_varıssaati.Name = "label_varıssaati";
            this.label_varıssaati.Size = new System.Drawing.Size(112, 23);
            this.label_varıssaati.TabIndex = 0;
            this.label_varıssaati.Text = "Varış Zamanı";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button_seferiptal);
            this.groupBox4.Controls.Add(this.textBox_seferiptal);
            this.groupBox4.Controls.Add(this.label_seferiptal);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.groupBox4.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox4.Location = new System.Drawing.Point(539, 425);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(523, 237);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sefer İptal Etme";
            // 
            // button_seferiptal
            // 
            this.button_seferiptal.BackColor = System.Drawing.Color.DarkRed;
            this.button_seferiptal.ForeColor = System.Drawing.Color.White;
            this.button_seferiptal.Location = new System.Drawing.Point(210, 146);
            this.button_seferiptal.Name = "button_seferiptal";
            this.button_seferiptal.Size = new System.Drawing.Size(119, 57);
            this.button_seferiptal.TabIndex = 2;
            this.button_seferiptal.Text = "TAMAMLA";
            this.button_seferiptal.UseVisualStyleBackColor = false;
            this.button_seferiptal.Click += new System.EventHandler(this.button_seferiptal_Click);
            // 
            // textBox_seferiptal
            // 
            this.textBox_seferiptal.Location = new System.Drawing.Point(256, 86);
            this.textBox_seferiptal.Name = "textBox_seferiptal";
            this.textBox_seferiptal.Size = new System.Drawing.Size(140, 30);
            this.textBox_seferiptal.TabIndex = 1;
            // 
            // label_seferiptal
            // 
            this.label_seferiptal.AutoSize = true;
            this.label_seferiptal.Location = new System.Drawing.Point(90, 89);
            this.label_seferiptal.Name = "label_seferiptal";
            this.label_seferiptal.Size = new System.Drawing.Size(133, 23);
            this.label_seferiptal.TabIndex = 0;
            this.label_seferiptal.Text = "Sefer Numarası";
            // 
            // KontrolPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1814, 690);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "KontrolPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kontrol Paneli";
            this.Load += new System.EventHandler(this.KontrolPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_kntrlpanel)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_kntrlpanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label_kalkıskonum;
        private System.Windows.Forms.Label label_variskonum;
        private System.Windows.Forms.Label label_kalkıssaat;
        private System.Windows.Forms.Label label_varıssaati;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_variskonumu;
        private System.Windows.Forms.TextBox textBox_kalkiskonum;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button_seferiptal;
        private System.Windows.Forms.TextBox textBox_seferiptal;
        private System.Windows.Forms.Label label_seferiptal;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_varis;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_kalkıssaat;
    }
}