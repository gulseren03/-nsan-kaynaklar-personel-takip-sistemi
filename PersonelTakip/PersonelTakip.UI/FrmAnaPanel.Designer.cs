namespace PersonelTakip.UI
{
    partial class FrmAnaPanel
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnRapor = new System.Windows.Forms.Button();
            this.btnMaas = new System.Windows.Forms.Button();
            this.btnPerformans = new System.Windows.Forms.Button();
            this.btnDepartman = new System.Windows.Forms.Button();
            this.btnPersonel = new System.Windows.Forms.Button();
            this.btnIzin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlMenu.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.pnlMenu.Controls.Add(this.btnCikis);
            this.pnlMenu.Controls.Add(this.btnRapor);
            this.pnlMenu.Controls.Add(this.btnMaas);
            this.pnlMenu.Controls.Add(this.btnPerformans);
            this.pnlMenu.Controls.Add(this.btnDepartman);
            this.pnlMenu.Controls.Add(this.btnPersonel);
            this.pnlMenu.Controls.Add(this.btnIzin);
            this.pnlMenu.Controls.Add(this.label1);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.ForeColor = System.Drawing.Color.White;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(220, 446);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.DarkRed;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Location = new System.Drawing.Point(3, 389);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(200, 45);
            this.btnCikis.TabIndex = 7;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click_1);
            // 
            // btnRapor
            // 
            this.btnRapor.BackColor = System.Drawing.Color.Transparent;
            this.btnRapor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRapor.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRapor.Location = new System.Drawing.Point(3, 338);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(200, 45);
            this.btnRapor.TabIndex = 6;
            this.btnRapor.Text = "Raporlar";
            this.btnRapor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRapor.UseVisualStyleBackColor = false;
            this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click_1);
            // 
            // btnMaas
            // 
            this.btnMaas.BackColor = System.Drawing.Color.Transparent;
            this.btnMaas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaas.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMaas.Location = new System.Drawing.Point(3, 287);
            this.btnMaas.Name = "btnMaas";
            this.btnMaas.Size = new System.Drawing.Size(200, 45);
            this.btnMaas.TabIndex = 5;
            this.btnMaas.Text = "Maaş Hesaplama";
            this.btnMaas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaas.UseVisualStyleBackColor = false;
            this.btnMaas.Click += new System.EventHandler(this.btnMaas_Click_1);
            // 
            // btnPerformans
            // 
            this.btnPerformans.BackColor = System.Drawing.Color.Transparent;
            this.btnPerformans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerformans.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPerformans.Location = new System.Drawing.Point(3, 236);
            this.btnPerformans.Name = "btnPerformans";
            this.btnPerformans.Size = new System.Drawing.Size(200, 45);
            this.btnPerformans.TabIndex = 4;
            this.btnPerformans.Text = "Performans";
            this.btnPerformans.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerformans.UseVisualStyleBackColor = false;
            this.btnPerformans.Click += new System.EventHandler(this.btnPerformans_Click_1);
            // 
            // btnDepartman
            // 
            this.btnDepartman.BackColor = System.Drawing.Color.Transparent;
            this.btnDepartman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartman.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDepartman.Location = new System.Drawing.Point(3, 185);
            this.btnDepartman.Name = "btnDepartman";
            this.btnDepartman.Size = new System.Drawing.Size(200, 45);
            this.btnDepartman.TabIndex = 3;
            this.btnDepartman.Text = "Departmanlar";
            this.btnDepartman.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepartman.UseVisualStyleBackColor = false;
            this.btnDepartman.Click += new System.EventHandler(this.btnDepartman_Click_1);
            // 
            // btnPersonel
            // 
            this.btnPersonel.BackColor = System.Drawing.Color.Transparent;
            this.btnPersonel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonel.Location = new System.Drawing.Point(3, 134);
            this.btnPersonel.Name = "btnPersonel";
            this.btnPersonel.Size = new System.Drawing.Size(200, 45);
            this.btnPersonel.TabIndex = 2;
            this.btnPersonel.Text = "Personel Yönetimi";
            this.btnPersonel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonel.UseVisualStyleBackColor = false;
            this.btnPersonel.Click += new System.EventHandler(this.btnPersonel_Click_1);
            // 
            // btnIzin
            // 
            this.btnIzin.BackColor = System.Drawing.Color.Transparent;
            this.btnIzin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIzin.Location = new System.Drawing.Point(3, 83);
            this.btnIzin.Name = "btnIzin";
            this.btnIzin.Size = new System.Drawing.Size(200, 45);
            this.btnIzin.TabIndex = 1;
            this.btnIzin.Text = "İzin İşlemleri";
            this.btnIzin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIzin.UseVisualStyleBackColor = false;
            this.btnIzin.Click += new System.EventHandler(this.btnIzin_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "ANA MENÜ";
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnlContent.Controls.Add(this.label2);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(220, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(496, 446);
            this.pnlContent.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label2.Location = new System.Drawing.Point(131, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 45);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hoş Geldiniz!";
            // 
            // FrmAnaPanel
            // 
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(716, 446);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FrmAnaPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Takip Sistemi";
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnIzin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnRapor;
        private System.Windows.Forms.Button btnMaas;
        private System.Windows.Forms.Button btnPerformans;
        private System.Windows.Forms.Button btnDepartman;
        private System.Windows.Forms.Button btnPersonel;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label label2;
        #endregion
    }
}
