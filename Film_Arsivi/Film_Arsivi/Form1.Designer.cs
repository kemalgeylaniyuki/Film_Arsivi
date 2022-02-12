namespace Film_Arsivi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnCikis = new System.Windows.Forms.Button();
            this.BtnRenkDegistir = new System.Windows.Forms.Button();
            this.BtnHakkimizda = new System.Windows.Forms.Button();
            this.BtnTamEkran = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.TxtLink = new System.Windows.Forms.TextBox();
            this.TxtKategori = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtFilmAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.E = new System.Windows.Forms.GroupBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.E.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1273, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Jokerman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(377, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "SİNEMA KOLTUK YAZILIM ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1042, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.BtnKaydet);
            this.groupBox1.Controls.Add(this.TxtLink);
            this.groupBox1.Controls.Add(this.TxtKategori);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtFilmAd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 527);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "YENİ FİLM";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnCikis);
            this.groupBox3.Controls.Add(this.BtnRenkDegistir);
            this.groupBox3.Controls.Add(this.BtnHakkimizda);
            this.groupBox3.Controls.Add(this.BtnTamEkran);
            this.groupBox3.Location = new System.Drawing.Point(10, 243);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(233, 278);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İŞLEMLER";
            // 
            // BtnCikis
            // 
            this.BtnCikis.Location = new System.Drawing.Point(20, 216);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(189, 48);
            this.BtnCikis.TabIndex = 4;
            this.BtnCikis.Text = "ÇIKIŞ";
            this.BtnCikis.UseVisualStyleBackColor = true;
            this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // BtnRenkDegistir
            // 
            this.BtnRenkDegistir.Location = new System.Drawing.Point(20, 155);
            this.BtnRenkDegistir.Name = "BtnRenkDegistir";
            this.BtnRenkDegistir.Size = new System.Drawing.Size(189, 49);
            this.BtnRenkDegistir.TabIndex = 3;
            this.BtnRenkDegistir.Text = "RENK DEĞİŞTİR";
            this.BtnRenkDegistir.UseVisualStyleBackColor = true;
            // 
            // BtnHakkimizda
            // 
            this.BtnHakkimizda.Location = new System.Drawing.Point(20, 97);
            this.BtnHakkimizda.Name = "BtnHakkimizda";
            this.BtnHakkimizda.Size = new System.Drawing.Size(189, 46);
            this.BtnHakkimizda.TabIndex = 2;
            this.BtnHakkimizda.Text = "HAKKIMIZDA";
            this.BtnHakkimizda.UseVisualStyleBackColor = true;
            this.BtnHakkimizda.Click += new System.EventHandler(this.BtnHakkimizda_Click);
            // 
            // BtnTamEkran
            // 
            this.BtnTamEkran.Location = new System.Drawing.Point(20, 34);
            this.BtnTamEkran.Name = "BtnTamEkran";
            this.BtnTamEkran.Size = new System.Drawing.Size(189, 51);
            this.BtnTamEkran.TabIndex = 0;
            this.BtnTamEkran.Text = "TAM EKRAN";
            this.BtnTamEkran.UseVisualStyleBackColor = true;
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(90, 174);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(153, 31);
            this.BtnKaydet.TabIndex = 7;
            this.BtnKaydet.Text = "KAYDET";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // TxtLink
            // 
            this.TxtLink.Location = new System.Drawing.Point(90, 142);
            this.TxtLink.Name = "TxtLink";
            this.TxtLink.Size = new System.Drawing.Size(154, 26);
            this.TxtLink.TabIndex = 6;
            // 
            // TxtKategori
            // 
            this.TxtKategori.Location = new System.Drawing.Point(90, 104);
            this.TxtKategori.Name = "TxtKategori";
            this.TxtKategori.Size = new System.Drawing.Size(154, 26);
            this.TxtKategori.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Link :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kategori :";
            // 
            // TxtFilmAd
            // 
            this.TxtFilmAd.Location = new System.Drawing.Point(90, 62);
            this.TxtFilmAd.Name = "TxtFilmAd";
            this.TxtFilmAd.Size = new System.Drawing.Size(154, 26);
            this.TxtFilmAd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "FilmAd :";
            // 
            // E
            // 
            this.E.Controls.Add(this.webBrowser1);
            this.E.Location = new System.Drawing.Point(555, 106);
            this.E.Name = "E";
            this.E.Size = new System.Drawing.Size(712, 527);
            this.E.TabIndex = 2;
            this.E.TabStop = false;
            this.E.Text = "EKRAN";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 22);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(706, 502);
            this.webBrowser1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(268, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 527);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FİLM LİSTESİ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(275, 502);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1250, 644);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.E);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.E.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnCikis;
        private System.Windows.Forms.Button BtnRenkDegistir;
        private System.Windows.Forms.Button BtnHakkimizda;
        private System.Windows.Forms.Button BtnTamEkran;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.TextBox TxtLink;
        private System.Windows.Forms.TextBox TxtKategori;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtFilmAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox E;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

