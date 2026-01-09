namespace PersonelTakip.UI
{
    partial class yöneticiPanel
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
            this.izinlerDGV = new System.Windows.Forms.DataGridView();
            this.onaylaBtn = new System.Windows.Forms.Button();
            this.reddetBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMaasRapor = new System.Windows.Forms.Button();
            this.btnMaas = new System.Windows.Forms.Button();
            this.btnDepartman = new System.Windows.Forms.Button();
            this.btnTümRaporlar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.izinlerDGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // izinlerDGV
            // 
            this.izinlerDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.izinlerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.izinlerDGV.Location = new System.Drawing.Point(34, 28);
            this.izinlerDGV.Name = "izinlerDGV";
            this.izinlerDGV.RowHeadersWidth = 51;
            this.izinlerDGV.RowTemplate.Height = 24;
            this.izinlerDGV.Size = new System.Drawing.Size(733, 195);
            this.izinlerDGV.TabIndex = 0;
            // 
            // onaylaBtn
            // 
            this.onaylaBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.onaylaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.onaylaBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.onaylaBtn.Location = new System.Drawing.Point(208, 229);
            this.onaylaBtn.Name = "onaylaBtn";
            this.onaylaBtn.Size = new System.Drawing.Size(112, 56);
            this.onaylaBtn.TabIndex = 1;
            this.onaylaBtn.Text = "Onayla";
            this.onaylaBtn.UseVisualStyleBackColor = false;
            this.onaylaBtn.Click += new System.EventHandler(this.onaylaBtn_Click);
            // 
            // reddetBtn
            // 
            this.reddetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.reddetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reddetBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.reddetBtn.Location = new System.Drawing.Point(462, 229);
            this.reddetBtn.Name = "reddetBtn";
            this.reddetBtn.Size = new System.Drawing.Size(119, 56);
            this.reddetBtn.TabIndex = 2;
            this.reddetBtn.Text = "Reddet";
            this.reddetBtn.UseVisualStyleBackColor = false;
            this.reddetBtn.Click += new System.EventHandler(this.reddetBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(335, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "İZİNLER LİSTESİ";
            // 
            // btnMaasRapor
            // 
            this.btnMaasRapor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnMaasRapor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaasRapor.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMaasRapor.ForeColor = System.Drawing.Color.White;
            this.btnMaasRapor.Location = new System.Drawing.Point(216, 15);
            this.btnMaasRapor.Name = "btnMaasRapor";
            this.btnMaasRapor.Size = new System.Drawing.Size(112, 71);
            this.btnMaasRapor.TabIndex = 4;
            this.btnMaasRapor.Text = "Maaş Raporları";
            this.btnMaasRapor.UseVisualStyleBackColor = false;
            this.btnMaasRapor.Click += new System.EventHandler(this.btnMaasRapor_Click);
            // 
            // btnMaas
            // 
            this.btnMaas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnMaas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaas.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMaas.ForeColor = System.Drawing.Color.White;
            this.btnMaas.Location = new System.Drawing.Point(27, 15);
            this.btnMaas.Name = "btnMaas";
            this.btnMaas.Size = new System.Drawing.Size(117, 71);
            this.btnMaas.TabIndex = 5;
            this.btnMaas.Text = "Maaş Hesapla";
            this.btnMaas.UseVisualStyleBackColor = false;
            this.btnMaas.Click += new System.EventHandler(this.btnMaas_Click);
            // 
            // btnDepartman
            // 
            this.btnDepartman.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnDepartman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartman.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDepartman.ForeColor = System.Drawing.Color.White;
            this.btnDepartman.Location = new System.Drawing.Point(396, 15);
            this.btnDepartman.Name = "btnDepartman";
            this.btnDepartman.Size = new System.Drawing.Size(114, 71);
            this.btnDepartman.TabIndex = 14;
            this.btnDepartman.Text = "Departman";
            this.btnDepartman.UseVisualStyleBackColor = false;
            this.btnDepartman.Click += new System.EventHandler(this.btnDepartman_Click);
            // 
            // btnTümRaporlar
            // 
            this.btnTümRaporlar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTümRaporlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTümRaporlar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTümRaporlar.ForeColor = System.Drawing.Color.White;
            this.btnTümRaporlar.Location = new System.Drawing.Point(590, 15);
            this.btnTümRaporlar.Name = "btnTümRaporlar";
            this.btnTümRaporlar.Size = new System.Drawing.Size(109, 71);
            this.btnTümRaporlar.TabIndex = 15;
            this.btnTümRaporlar.Text = "Bütün Maaş Raporları";
            this.btnTümRaporlar.UseVisualStyleBackColor = false;
            this.btnTümRaporlar.Click += new System.EventHandler(this.btnTümRaporlar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.btnMaas);
            this.panel1.Controls.Add(this.btnTümRaporlar);
            this.panel1.Controls.Add(this.btnMaasRapor);
            this.panel1.Controls.Add(this.btnDepartman);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 360);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 90);
            this.panel1.TabIndex = 16;
            // 
            // yöneticiPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reddetBtn);
            this.Controls.Add(this.onaylaBtn);
            this.Controls.Add(this.izinlerDGV);
            this.Name = "yöneticiPanel";
            this.Text = "yöneticiPanel";
            this.Load += new System.EventHandler(this.yöneticiPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.izinlerDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView izinlerDGV;
        private System.Windows.Forms.Button onaylaBtn;
        private System.Windows.Forms.Button reddetBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMaasRapor;
        private System.Windows.Forms.Button btnMaas;
        private System.Windows.Forms.Button btnDepartman;
        private System.Windows.Forms.Button btnTümRaporlar;
        private System.Windows.Forms.Panel panel1;
    }
}