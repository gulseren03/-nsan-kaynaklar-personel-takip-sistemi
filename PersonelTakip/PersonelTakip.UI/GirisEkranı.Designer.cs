namespace PersonelTakip.UI
{
    partial class GirisEkranı
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button girisYapBtn;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.girisYapBtn = new System.Windows.Forms.Button();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAdi.Location = new System.Drawing.Point(133, 23);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(200, 27);
            this.txtKullaniciAdi.TabIndex = 0;
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(133, 81);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(200, 27);
            this.txtSifre.TabIndex = 1;
            // 
            // girisYapBtn
            // 
            this.girisYapBtn.BackColor = System.Drawing.Color.DarkGreen;
            this.girisYapBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.girisYapBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisYapBtn.Location = new System.Drawing.Point(167, 206);
            this.girisYapBtn.Name = "girisYapBtn";
            this.girisYapBtn.Size = new System.Drawing.Size(133, 38);
            this.girisYapBtn.TabIndex = 2;
            this.girisYapBtn.Text = "Giriş Yap";
            this.girisYapBtn.UseVisualStyleBackColor = false;
            this.girisYapBtn.Click += new System.EventHandler(this.girisYapBtn_Click);
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(31, 26);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(96, 20);
            this.lblAd.TabIndex = 3;
            this.lblAd.Text = "Kullanıcı Adı";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.Location = new System.Drawing.Point(86, 88);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(41, 20);
            this.lblSifre.TabIndex = 4;
            this.lblSifre.Text = "Şifre";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRol.Location = new System.Drawing.Point(95, 146);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(32, 20);
            this.lblRol.TabIndex = 5;
            this.lblRol.Text = "Rol";
            // 
            // cmbRol
            // 
            this.cmbRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Items.AddRange(new object[] {
            "yönetici",
            "personel",
            "İK"});
            this.cmbRol.Location = new System.Drawing.Point(133, 143);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(200, 28);
            this.cmbRol.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.girisYapBtn);
            this.panel1.Controls.Add(this.lblAd);
            this.panel1.Controls.Add(this.cmbRol);
            this.panel1.Controls.Add(this.txtKullaniciAdi);
            this.panel1.Controls.Add(this.lblRol);
            this.panel1.Controls.Add(this.lblSifre);
            this.panel1.Controls.Add(this.txtSifre);
            this.panel1.Location = new System.Drawing.Point(58, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 271);
            this.panel1.TabIndex = 7;
            // 
            // GirisEkranı
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.panel1);
            this.Name = "GirisEkranı";
            this.Text = "Giriş Ekranı";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Panel panel1;
    }
}

