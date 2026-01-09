namespace PersonelTakip.UI
{
    partial class IKPerformansEkle
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.puanNUD = new System.Windows.Forms.NumericUpDown();
            this.personelCmb = new System.Windows.Forms.ComboBox();
            this.persKaydetBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.puanNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.puanNUD);
            this.panel1.Controls.Add(this.personelCmb);
            this.panel1.Controls.Add(this.persKaydetBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(196, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 240);
            this.panel1.TabIndex = 0;
            // 
            // puanNUD
            // 
            this.puanNUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.puanNUD.Location = new System.Drawing.Point(141, 116);
            this.puanNUD.Name = "puanNUD";
            this.puanNUD.Size = new System.Drawing.Size(206, 27);
            this.puanNUD.TabIndex = 4;
            // 
            // personelCmb
            // 
            this.personelCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personelCmb.FormattingEnabled = true;
            this.personelCmb.Location = new System.Drawing.Point(141, 54);
            this.personelCmb.Name = "personelCmb";
            this.personelCmb.Size = new System.Drawing.Size(206, 28);
            this.personelCmb.TabIndex = 3;
            // 
            // persKaydetBtn
            // 
            this.persKaydetBtn.BackColor = System.Drawing.Color.Green;
            this.persKaydetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.persKaydetBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.persKaydetBtn.Location = new System.Drawing.Point(232, 170);
            this.persKaydetBtn.Name = "persKaydetBtn";
            this.persKaydetBtn.Size = new System.Drawing.Size(115, 48);
            this.persKaydetBtn.TabIndex = 2;
            this.persKaydetBtn.Text = "Kaydet";
            this.persKaydetBtn.UseVisualStyleBackColor = false;
            this.persKaydetBtn.Click += new System.EventHandler(this.persKaydetBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(79, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Puan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(53, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "personel";
            // 
            // IKPerformansEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "IKPerformansEkle";
            this.Text = "IKPerformansEkle";
            this.Load += new System.EventHandler(this.IKPerformansEkle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.puanNUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown puanNUD;
        private System.Windows.Forms.ComboBox personelCmb;
        private System.Windows.Forms.Button persKaydetBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}