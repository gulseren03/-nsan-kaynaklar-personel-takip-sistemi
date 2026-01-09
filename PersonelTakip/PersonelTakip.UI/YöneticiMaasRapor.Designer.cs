namespace PersonelTakip.UI
{
    partial class YöneticiMaasRapor
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
            this.dgvMaaslar = new System.Windows.Forms.DataGridView();
            this.lblToplam = new System.Windows.Forms.Label();
            this.lblOrtalama = new System.Windows.Forms.Label();
            this.dgvOrtalamaMaas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaaslar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrtalamaMaas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMaaslar
            // 
            this.dgvMaaslar.BackgroundColor = System.Drawing.Color.White;
            this.dgvMaaslar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaaslar.Location = new System.Drawing.Point(145, 12);
            this.dgvMaaslar.Name = "dgvMaaslar";
            this.dgvMaaslar.RowHeadersWidth = 51;
            this.dgvMaaslar.RowTemplate.Height = 24;
            this.dgvMaaslar.Size = new System.Drawing.Size(621, 80);
            this.dgvMaaslar.TabIndex = 2;
            // 
            // lblToplam
            // 
            this.lblToplam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.lblToplam.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplam.ForeColor = System.Drawing.Color.White;
            this.lblToplam.Location = new System.Drawing.Point(12, 12);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(127, 80);
            this.lblToplam.TabIndex = 3;
            this.lblToplam.Text = "Ortalama Maaş";
            this.lblToplam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOrtalama
            // 
            this.lblOrtalama.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOrtalama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.lblOrtalama.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrtalama.ForeColor = System.Drawing.Color.White;
            this.lblOrtalama.Location = new System.Drawing.Point(12, 139);
            this.lblOrtalama.Name = "lblOrtalama";
            this.lblOrtalama.Size = new System.Drawing.Size(125, 77);
            this.lblOrtalama.TabIndex = 4;
            this.lblOrtalama.Text = "Toplam Maaş";
            this.lblOrtalama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvOrtalamaMaas
            // 
            this.dgvOrtalamaMaas.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrtalamaMaas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrtalamaMaas.Location = new System.Drawing.Point(145, 139);
            this.dgvOrtalamaMaas.Name = "dgvOrtalamaMaas";
            this.dgvOrtalamaMaas.RowHeadersWidth = 51;
            this.dgvOrtalamaMaas.RowTemplate.Height = 24;
            this.dgvOrtalamaMaas.Size = new System.Drawing.Size(621, 80);
            this.dgvOrtalamaMaas.TabIndex = 5;
            // 
            // YöneticiMaasRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(798, 447);
            this.Controls.Add(this.dgvOrtalamaMaas);
            this.Controls.Add(this.lblOrtalama);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.dgvMaaslar);
            this.Name = "YöneticiMaasRapor";
            this.Text = "YöneticiMaasRapor";
            this.Load += new System.EventHandler(this.YöneticiMaasRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaaslar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrtalamaMaas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMaaslar;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Label lblOrtalama;
        private System.Windows.Forms.DataGridView dgvOrtalamaMaas;
    }
}