namespace PersonelTakip.UI
{
    partial class PersonelPanel
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
            this.panelIzinListe = new System.Windows.Forms.ListBox();
            this.baslangıcDTP = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.bitisDTP = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.izinTalepBtn = new System.Windows.Forms.Button();
            this.panelIzinTalep = new System.Windows.Forms.Panel();
            this.txtAcıklama = new System.Windows.Forms.TextBox();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.lblListe = new System.Windows.Forms.Label();
            this.dgvIzinler = new System.Windows.Forms.DataGridView();
            this.izinlerDGV = new System.Windows.Forms.DataGridView();
            this.panelIzinTalep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzinler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.izinlerDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panelIzinListe
            // 
            this.panelIzinListe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelIzinListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelIzinListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panelIzinListe.FormattingEnabled = true;
            this.panelIzinListe.ItemHeight = 22;
            this.panelIzinListe.Location = new System.Drawing.Point(0, 0);
            this.panelIzinListe.Name = "panelIzinListe";
            this.panelIzinListe.Size = new System.Drawing.Size(1030, 450);
            this.panelIzinListe.TabIndex = 0;
            // 
            // baslangıcDTP
            // 
            this.baslangıcDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslangıcDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.baslangıcDTP.Location = new System.Drawing.Point(393, 12);
            this.baslangıcDTP.Name = "baslangıcDTP";
            this.baslangıcDTP.Size = new System.Drawing.Size(247, 27);
            this.baslangıcDTP.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(240, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Başlangıç Tarihi";
            // 
            // bitisDTP
            // 
            this.bitisDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bitisDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.bitisDTP.Location = new System.Drawing.Point(393, 57);
            this.bitisDTP.Name = "bitisDTP";
            this.bitisDTP.Size = new System.Drawing.Size(247, 27);
            this.bitisDTP.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(280, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bitiş Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(293, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Açıklama";
            // 
            // izinTalepBtn
            // 
            this.izinTalepBtn.BackColor = System.Drawing.Color.DarkGreen;
            this.izinTalepBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.izinTalepBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.izinTalepBtn.ForeColor = System.Drawing.Color.White;
            this.izinTalepBtn.Location = new System.Drawing.Point(703, 142);
            this.izinTalepBtn.Name = "izinTalepBtn";
            this.izinTalepBtn.Size = new System.Drawing.Size(165, 38);
            this.izinTalepBtn.TabIndex = 7;
            this.izinTalepBtn.Text = "İzin Talebi Oluştur";
            this.izinTalepBtn.UseCompatibleTextRendering = true;
            this.izinTalepBtn.UseVisualStyleBackColor = false;
            this.izinTalepBtn.Click += new System.EventHandler(this.btnIzinTalep_Click);
            // 
            // panelIzinTalep
            // 
            this.panelIzinTalep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panelIzinTalep.Controls.Add(this.txtAcıklama);
            this.panelIzinTalep.Controls.Add(this.lblBaslik);
            this.panelIzinTalep.Controls.Add(this.baslangıcDTP);
            this.panelIzinTalep.Controls.Add(this.izinTalepBtn);
            this.panelIzinTalep.Controls.Add(this.label1);
            this.panelIzinTalep.Controls.Add(this.label3);
            this.panelIzinTalep.Controls.Add(this.label2);
            this.panelIzinTalep.Controls.Add(this.bitisDTP);
            this.panelIzinTalep.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelIzinTalep.Location = new System.Drawing.Point(0, 0);
            this.panelIzinTalep.Name = "panelIzinTalep";
            this.panelIzinTalep.Size = new System.Drawing.Size(1030, 180);
            this.panelIzinTalep.TabIndex = 8;
            // 
            // txtAcıklama
            // 
            this.txtAcıklama.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAcıklama.Location = new System.Drawing.Point(393, 105);
            this.txtAcıklama.Name = "txtAcıklama";
            this.txtAcıklama.Size = new System.Drawing.Size(247, 30);
            this.txtAcıklama.TabIndex = 9;
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.ForeColor = System.Drawing.Color.Black;
            this.lblBaslik.Location = new System.Drawing.Point(3, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(138, 25);
            this.lblBaslik.TabIndex = 8;
            this.lblBaslik.Text = "Yeni İzin Talebi";
            // 
            // lblListe
            // 
            this.lblListe.AutoSize = true;
            this.lblListe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblListe.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblListe.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblListe.Location = new System.Drawing.Point(0, 180);
            this.lblListe.Name = "lblListe";
            this.lblListe.Size = new System.Drawing.Size(150, 25);
            this.lblListe.TabIndex = 9;
            this.lblListe.Text = "Önceki İzinlerim";
            // 
            // dgvIzinler
            // 
            this.dgvIzinler.AllowUserToAddRows = false;
            this.dgvIzinler.AllowUserToDeleteRows = false;
            this.dgvIzinler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIzinler.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dgvIzinler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIzinler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIzinler.Location = new System.Drawing.Point(0, 205);
            this.dgvIzinler.Name = "dgvIzinler";
            this.dgvIzinler.ReadOnly = true;
            this.dgvIzinler.RowHeadersWidth = 51;
            this.dgvIzinler.RowTemplate.Height = 24;
            this.dgvIzinler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIzinler.Size = new System.Drawing.Size(1030, 245);
            this.dgvIzinler.TabIndex = 10;
            // 
            // izinlerDGV
            // 
            this.izinlerDGV.AllowUserToAddRows = false;
            this.izinlerDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.izinlerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.izinlerDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.izinlerDGV.Location = new System.Drawing.Point(0, 205);
            this.izinlerDGV.Name = "izinlerDGV";
            this.izinlerDGV.ReadOnly = true;
            this.izinlerDGV.RowHeadersVisible = false;
            this.izinlerDGV.RowHeadersWidth = 51;
            this.izinlerDGV.RowTemplate.Height = 24;
            this.izinlerDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.izinlerDGV.Size = new System.Drawing.Size(1030, 245);
            this.izinlerDGV.TabIndex = 11;
            // 
            // PersonelPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1030, 450);
            this.Controls.Add(this.izinlerDGV);
            this.Controls.Add(this.dgvIzinler);
            this.Controls.Add(this.lblListe);
            this.Controls.Add(this.panelIzinTalep);
            this.Controls.Add(this.panelIzinListe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PersonelPanel";
            this.Text = "Personel İzin İşlemleri";
            this.Load += new System.EventHandler(this.PersonelPanel_Load);
            this.panelIzinTalep.ResumeLayout(false);
            this.panelIzinTalep.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzinler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.izinlerDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.ListBox panelIzinListe;
        private System.Windows.Forms.DateTimePicker baslangıcDTP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker bitisDTP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button izinTalepBtn;
        private System.Windows.Forms.Panel panelIzinTalep;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblListe;
        private System.Windows.Forms.DataGridView dgvIzinler;
        private System.Windows.Forms.DataGridView izinlerDGV;
        private System.Windows.Forms.TextBox txtAcıklama;
    }
   

    }