namespace Proje
{
    partial class personelIslem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(personelIslem));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_personelKimlik = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_personelParola = new System.Windows.Forms.TextBox();
            this.btn_personelIlerle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_personelKimlik);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Location = new System.Drawing.Point(74, 253);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 48);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kimlik Numarası";
            // 
            // textBox_personelKimlik
            // 
            this.textBox_personelKimlik.BackColor = System.Drawing.Color.White;
            this.textBox_personelKimlik.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_personelKimlik.Location = new System.Drawing.Point(6, 19);
            this.textBox_personelKimlik.Name = "textBox_personelKimlik";
            this.textBox_personelKimlik.Size = new System.Drawing.Size(246, 23);
            this.textBox_personelKimlik.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_personelParola);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox2.Location = new System.Drawing.Point(74, 329);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 48);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parola";
            // 
            // textBox_personelParola
            // 
            this.textBox_personelParola.BackColor = System.Drawing.Color.White;
            this.textBox_personelParola.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_personelParola.Location = new System.Drawing.Point(6, 20);
            this.textBox_personelParola.Name = "textBox_personelParola";
            this.textBox_personelParola.PasswordChar = '•';
            this.textBox_personelParola.Size = new System.Drawing.Size(246, 23);
            this.textBox_personelParola.TabIndex = 0;
            // 
            // btn_personelIlerle
            // 
            this.btn_personelIlerle.BackColor = System.Drawing.Color.DarkRed;
            this.btn_personelIlerle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_personelIlerle.FlatAppearance.BorderSize = 0;
            this.btn_personelIlerle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_personelIlerle.ForeColor = System.Drawing.Color.White;
            this.btn_personelIlerle.Location = new System.Drawing.Point(129, 408);
            this.btn_personelIlerle.Name = "btn_personelIlerle";
            this.btn_personelIlerle.Size = new System.Drawing.Size(149, 46);
            this.btn_personelIlerle.TabIndex = 0;
            this.btn_personelIlerle.Text = "İLERLE";
            this.btn_personelIlerle.UseVisualStyleBackColor = false;
            this.btn_personelIlerle.Click += new System.EventHandler(this.btn_personelIlerle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(141, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // personelIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(411, 551);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_personelIlerle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "personelIslem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Giriş";
            this.Load += new System.EventHandler(this.personelIslem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_personelKimlik;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_personelParola;
        private System.Windows.Forms.Button btn_personelIlerle;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}