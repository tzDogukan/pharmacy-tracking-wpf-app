namespace pharmacytrackingwpf
{
    partial class frmÜrünListeleme
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.voMarka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.voKategori = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.voSatışFiyatı = new System.Windows.Forms.TextBox();
            this.voAlışFiyatı = new System.Windows.Forms.TextBox();
            this.voMiktarı = new System.Windows.Forms.TextBox();
            this.voÜrünAdı = new System.Windows.Forms.TextBox();
            this.voBarkodNo = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.barkodnoaramatxt = new System.Windows.Forms.Label();
            this.lblMiktari = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.kayıttarihi = new System.Windows.Forms.Label();
            this.katmargüncelle = new System.Windows.Forms.Button();
            this.combokategori = new System.Windows.Forms.ComboBox();
            this.combomarka = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Marka = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(253, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(477, 250);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // voMarka
            // 
            this.voMarka.Location = new System.Drawing.Point(78, 161);
            this.voMarka.Name = "voMarka";
            this.voMarka.ReadOnly = true;
            this.voMarka.Size = new System.Drawing.Size(134, 20);
            this.voMarka.TabIndex = 85;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 89;
            this.label1.Text = "Satış Fiyatı";
            // 
            // voKategori
            // 
            this.voKategori.Location = new System.Drawing.Point(78, 130);
            this.voKategori.Name = "voKategori";
            this.voKategori.ReadOnly = true;
            this.voKategori.Size = new System.Drawing.Size(134, 20);
            this.voKategori.TabIndex = 84;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 88;
            this.label2.Text = "Alış Fiyatı";
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(152, 325);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(60, 28);
            this.btnGüncelle.TabIndex = 74;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 87;
            this.label3.Text = "Marka";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 86;
            this.label4.Text = "Ürün Adı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 82;
            this.label5.Text = "Miktarı";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 128);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 81;
            this.label13.Text = "Kategori";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 103);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 80;
            this.label14.Text = "Barkod No";
            // 
            // voSatışFiyatı
            // 
            this.voSatışFiyatı.Location = new System.Drawing.Point(78, 267);
            this.voSatışFiyatı.Name = "voSatışFiyatı";
            this.voSatışFiyatı.Size = new System.Drawing.Size(134, 20);
            this.voSatışFiyatı.TabIndex = 79;
            // 
            // voAlışFiyatı
            // 
            this.voAlışFiyatı.Location = new System.Drawing.Point(78, 241);
            this.voAlışFiyatı.Name = "voAlışFiyatı";
            this.voAlışFiyatı.Size = new System.Drawing.Size(134, 20);
            this.voAlışFiyatı.TabIndex = 78;
            // 
            // voMiktarı
            // 
            this.voMiktarı.Location = new System.Drawing.Point(78, 215);
            this.voMiktarı.Name = "voMiktarı";
            this.voMiktarı.Size = new System.Drawing.Size(134, 20);
            this.voMiktarı.TabIndex = 77;
            // 
            // voÜrünAdı
            // 
            this.voÜrünAdı.Location = new System.Drawing.Point(78, 187);
            this.voÜrünAdı.Name = "voÜrünAdı";
            this.voÜrünAdı.Size = new System.Drawing.Size(134, 20);
            this.voÜrünAdı.TabIndex = 76;
            // 
            // voBarkodNo
            // 
            this.voBarkodNo.Location = new System.Drawing.Point(78, 103);
            this.voBarkodNo.Name = "voBarkodNo";
            this.voBarkodNo.ReadOnly = true;
            this.voBarkodNo.Size = new System.Drawing.Size(134, 20);
            this.voBarkodNo.TabIndex = 75;
            this.voBarkodNo.TextChanged += new System.EventHandler(this.voBarkodNo_TextChanged);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(745, 103);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(82, 25);
            this.btnSil.TabIndex = 91;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(503, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 20);
            this.textBox1.TabIndex = 92;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // barkodnoaramatxt
            // 
            this.barkodnoaramatxt.AutoSize = true;
            this.barkodnoaramatxt.Location = new System.Drawing.Point(409, 60);
            this.barkodnoaramatxt.Name = "barkodnoaramatxt";
            this.barkodnoaramatxt.Size = new System.Drawing.Size(91, 13);
            this.barkodnoaramatxt.TabIndex = 93;
            this.barkodnoaramatxt.Text = "BarkodNo Arama:";
            // 
            // lblMiktari
            // 
            this.lblMiktari.AutoSize = true;
            this.lblMiktari.Location = new System.Drawing.Point(87, 308);
            this.lblMiktari.Name = "lblMiktari";
            this.lblMiktari.Size = new System.Drawing.Size(0, 13);
            this.lblMiktari.TabIndex = 90;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 308);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 13);
            this.label15.TabIndex = 83;
            this.label15.Text = "Kayıt Tarihi:";
            // 
            // kayıttarihi
            // 
            this.kayıttarihi.AutoSize = true;
            this.kayıttarihi.Location = new System.Drawing.Point(87, 308);
            this.kayıttarihi.Name = "kayıttarihi";
            this.kayıttarihi.Size = new System.Drawing.Size(0, 13);
            this.kayıttarihi.TabIndex = 94;
            // 
            // katmargüncelle
            // 
            this.katmargüncelle.Location = new System.Drawing.Point(570, 382);
            this.katmargüncelle.Name = "katmargüncelle";
            this.katmargüncelle.Size = new System.Drawing.Size(97, 48);
            this.katmargüncelle.TabIndex = 95;
            this.katmargüncelle.Text = "Kategori - Marka Güncelle";
            this.katmargüncelle.UseVisualStyleBackColor = true;
            this.katmargüncelle.Click += new System.EventHandler(this.katmargüncelle_Click);
            // 
            // combokategori
            // 
            this.combokategori.FormattingEnabled = true;
            this.combokategori.Location = new System.Drawing.Point(453, 382);
            this.combokategori.Name = "combokategori";
            this.combokategori.Size = new System.Drawing.Size(99, 21);
            this.combokategori.TabIndex = 96;
            this.combokategori.SelectedIndexChanged += new System.EventHandler(this.combokategori_SelectedIndexChanged);
            // 
            // combomarka
            // 
            this.combomarka.FormattingEnabled = true;
            this.combomarka.Location = new System.Drawing.Point(453, 409);
            this.combomarka.Name = "combomarka";
            this.combomarka.Size = new System.Drawing.Size(99, 21);
            this.combomarka.TabIndex = 97;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(395, 385);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 98;
            this.label6.Text = "Kategori:";
            // 
            // Marka
            // 
            this.Marka.AutoSize = true;
            this.Marka.Location = new System.Drawing.Point(395, 412);
            this.Marka.Name = "Marka";
            this.Marka.Size = new System.Drawing.Size(40, 13);
            this.Marka.TabIndex = 99;
            this.Marka.Text = "Marka:";
            // 
            // frmÜrünListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(830, 476);
            this.Controls.Add(this.Marka);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.combomarka);
            this.Controls.Add(this.combokategori);
            this.Controls.Add(this.katmargüncelle);
            this.Controls.Add(this.kayıttarihi);
            this.Controls.Add(this.barkodnoaramatxt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblMiktari);
            this.Controls.Add(this.voMarka);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.voKategori);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.voSatışFiyatı);
            this.Controls.Add(this.voAlışFiyatı);
            this.Controls.Add(this.voMiktarı);
            this.Controls.Add(this.voÜrünAdı);
            this.Controls.Add(this.voBarkodNo);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmÜrünListeleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Listeleme Sayfası";
            this.Load += new System.EventHandler(this.frmÜrünListeleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox voMarka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox voKategori;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox voSatışFiyatı;
        private System.Windows.Forms.TextBox voAlışFiyatı;
        private System.Windows.Forms.TextBox voMiktarı;
        private System.Windows.Forms.TextBox voÜrünAdı;
        private System.Windows.Forms.TextBox voBarkodNo;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label barkodnoaramatxt;
        private System.Windows.Forms.Label lblMiktari;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label kayıttarihi;
        private System.Windows.Forms.Button katmargüncelle;
        private System.Windows.Forms.ComboBox combokategori;
        private System.Windows.Forms.ComboBox combomarka;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Marka;
    }
}