namespace YemekMenusu
{
    partial class Form1
    {
       
        private System.ComponentModel.IContainer components = null;

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
            this.cmbYiyecekTuru = new System.Windows.Forms.ComboBox();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.txtKdv = new System.Windows.Forms.TextBox();
            this.txtKalori = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.lstMenu = new System.Windows.Forms.ListBox();
            this.yiyecekSecLabel = new System.Windows.Forms.Label();
            this.adiLabel = new System.Windows.Forms.Label();
            this.cinsiLabel = new System.Windows.Forms.Label();
            this.fiyatiLabel = new System.Windows.Forms.Label();
            this.kdvLabel = new System.Windows.Forms.Label();
            this.kaloriLabel = new System.Windows.Forms.Label();
            this.txtCins = new System.Windows.Forms.TextBox();
            this.siparismenusuLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbYiyecekTuru
            // 
            this.cmbYiyecekTuru.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbYiyecekTuru.BackColor = System.Drawing.SystemColors.Info;
            this.cmbYiyecekTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbYiyecekTuru.FormattingEnabled = true;
            this.cmbYiyecekTuru.Location = new System.Drawing.Point(306, 42);
            this.cmbYiyecekTuru.Name = "cmbYiyecekTuru";
            this.cmbYiyecekTuru.Size = new System.Drawing.Size(121, 33);
            this.cmbYiyecekTuru.TabIndex = 0;
            this.cmbYiyecekTuru.Text = " ";
            this.cmbYiyecekTuru.SelectedIndexChanged += new System.EventHandler(this.cmbYiyecekTuru_SelectedIndexChanged);
            // 
            // txtAdi
            // 
            this.txtAdi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAdi.BackColor = System.Drawing.SystemColors.Info;
            this.txtAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdi.Location = new System.Drawing.Point(306, 91);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(121, 30);
            this.txtAdi.TabIndex = 1;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFiyat.BackColor = System.Drawing.SystemColors.Info;
            this.txtFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFiyat.Location = new System.Drawing.Point(306, 183);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(121, 30);
            this.txtFiyat.TabIndex = 2;
            // 
            // txtKdv
            // 
            this.txtKdv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKdv.BackColor = System.Drawing.SystemColors.Info;
            this.txtKdv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKdv.Location = new System.Drawing.Point(306, 235);
            this.txtKdv.Name = "txtKdv";
            this.txtKdv.Size = new System.Drawing.Size(121, 30);
            this.txtKdv.TabIndex = 3;
            // 
            // txtKalori
            // 
            this.txtKalori.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKalori.BackColor = System.Drawing.SystemColors.Info;
            this.txtKalori.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKalori.Location = new System.Drawing.Point(306, 283);
            this.txtKalori.Name = "txtKalori";
            this.txtKalori.Size = new System.Drawing.Size(121, 30);
            this.txtKalori.TabIndex = 4;
            // 
            // btnEkle
            // 
            this.btnEkle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(287, 337);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(140, 37);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(485, 232);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 37);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lstMenu
            // 
            this.lstMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstMenu.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lstMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstMenu.FormattingEnabled = true;
            this.lstMenu.ItemHeight = 25;
            this.lstMenu.Location = new System.Drawing.Point(485, 59);
            this.lstMenu.Name = "lstMenu";
            this.lstMenu.Size = new System.Drawing.Size(499, 154);
            this.lstMenu.TabIndex = 7;
            this.lstMenu.SelectedIndexChanged += new System.EventHandler(this.lstMenu_SelectedIndexChanged);
            // 
            // yiyecekSecLabel
            // 
            this.yiyecekSecLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.yiyecekSecLabel.AutoSize = true;
            this.yiyecekSecLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.yiyecekSecLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yiyecekSecLabel.Location = new System.Drawing.Point(152, 50);
            this.yiyecekSecLabel.Name = "yiyecekSecLabel";
            this.yiyecekSecLabel.Size = new System.Drawing.Size(127, 25);
            this.yiyecekSecLabel.TabIndex = 8;
            this.yiyecekSecLabel.Text = "Yiyecek Seç:";
            // 
            // adiLabel
            // 
            this.adiLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.adiLabel.AutoSize = true;
            this.adiLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.adiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adiLabel.Location = new System.Drawing.Point(152, 91);
            this.adiLabel.Name = "adiLabel";
            this.adiLabel.Size = new System.Drawing.Size(47, 25);
            this.adiLabel.TabIndex = 9;
            this.adiLabel.Text = "Adı:";
            // 
            // cinsiLabel
            // 
            this.cinsiLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cinsiLabel.AutoSize = true;
            this.cinsiLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cinsiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cinsiLabel.Location = new System.Drawing.Point(152, 136);
            this.cinsiLabel.Name = "cinsiLabel";
            this.cinsiLabel.Size = new System.Drawing.Size(62, 25);
            this.cinsiLabel.TabIndex = 10;
            this.cinsiLabel.Text = "Cinsi:";
            // 
            // fiyatiLabel
            // 
            this.fiyatiLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fiyatiLabel.AutoSize = true;
            this.fiyatiLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.fiyatiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fiyatiLabel.Location = new System.Drawing.Point(152, 183);
            this.fiyatiLabel.Name = "fiyatiLabel";
            this.fiyatiLabel.Size = new System.Drawing.Size(64, 25);
            this.fiyatiLabel.TabIndex = 11;
            this.fiyatiLabel.Text = "Fiyatı:";
            // 
            // kdvLabel
            // 
            this.kdvLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kdvLabel.AutoSize = true;
            this.kdvLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.kdvLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kdvLabel.Location = new System.Drawing.Point(152, 235);
            this.kdvLabel.Name = "kdvLabel";
            this.kdvLabel.Size = new System.Drawing.Size(113, 25);
            this.kdvLabel.TabIndex = 12;
            this.kdvLabel.Text = "KDV Oranı:";
            // 
            // kaloriLabel
            // 
            this.kaloriLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kaloriLabel.AutoSize = true;
            this.kaloriLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.kaloriLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaloriLabel.Location = new System.Drawing.Point(152, 283);
            this.kaloriLabel.Name = "kaloriLabel";
            this.kaloriLabel.Size = new System.Drawing.Size(68, 25);
            this.kaloriLabel.TabIndex = 13;
            this.kaloriLabel.Text = "Kalori:";
            // 
            // txtCins
            // 
            this.txtCins.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCins.BackColor = System.Drawing.SystemColors.Info;
            this.txtCins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCins.Location = new System.Drawing.Point(306, 136);
            this.txtCins.Name = "txtCins";
            this.txtCins.Size = new System.Drawing.Size(121, 30);
            this.txtCins.TabIndex = 14;
            // 
            // siparismenusuLabel
            // 
            this.siparismenusuLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.siparismenusuLabel.AutoSize = true;
            this.siparismenusuLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.siparismenusuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.siparismenusuLabel.Location = new System.Drawing.Point(480, 20);
            this.siparismenusuLabel.Name = "siparismenusuLabel";
            this.siparismenusuLabel.Size = new System.Drawing.Size(181, 25);
            this.siparismenusuLabel.TabIndex = 15;
            this.siparismenusuLabel.Text = "SİPARİŞ MENÜSÜ";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(485, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 37);
            this.button1.TabIndex = 16;
            this.button1.Text = "ONAYLA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1024, 425);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.siparismenusuLabel);
            this.Controls.Add(this.txtCins);
            this.Controls.Add(this.kaloriLabel);
            this.Controls.Add(this.kdvLabel);
            this.Controls.Add(this.fiyatiLabel);
            this.Controls.Add(this.cinsiLabel);
            this.Controls.Add(this.adiLabel);
            this.Controls.Add(this.yiyecekSecLabel);
            this.Controls.Add(this.lstMenu);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtKalori);
            this.Controls.Add(this.txtKdv);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.cmbYiyecekTuru);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbYiyecekTuru;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.TextBox txtKdv;
        private System.Windows.Forms.TextBox txtKalori;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ListBox lstMenu;
        private System.Windows.Forms.Label yiyecekSecLabel;
        private System.Windows.Forms.Label adiLabel;
        private System.Windows.Forms.Label cinsiLabel;
        private System.Windows.Forms.Label fiyatiLabel;
        private System.Windows.Forms.Label kdvLabel;
        private System.Windows.Forms.Label kaloriLabel;
        private System.Windows.Forms.TextBox txtCins;
        private System.Windows.Forms.Label siparismenusuLabel;
        private System.Windows.Forms.Button button1;
    }
}

