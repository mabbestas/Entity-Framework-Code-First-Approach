
namespace Example2_AddProduct
{
    partial class Form3
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
            this.grpUrunEklemePaneli = new System.Windows.Forms.GroupBox();
            this.nmrStok = new System.Windows.Forms.NumericUpDown();
            this.nmrBirim = new System.Windows.Forms.NumericUpDown();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.cmbKategoriler = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.grpUrunler = new System.Windows.Forms.GroupBox();
            this.lstProducts = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnKategoriEkle = new System.Windows.Forms.Button();
            this.grpUrunEklemePaneli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrBirim)).BeginInit();
            this.grpUrunler.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpUrunEklemePaneli
            // 
            this.grpUrunEklemePaneli.Controls.Add(this.nmrStok);
            this.grpUrunEklemePaneli.Controls.Add(this.nmrBirim);
            this.grpUrunEklemePaneli.Controls.Add(this.txtUrunAdi);
            this.grpUrunEklemePaneli.Controls.Add(this.cmbKategoriler);
            this.grpUrunEklemePaneli.Controls.Add(this.label4);
            this.grpUrunEklemePaneli.Controls.Add(this.label3);
            this.grpUrunEklemePaneli.Controls.Add(this.label2);
            this.grpUrunEklemePaneli.Controls.Add(this.label1);
            this.grpUrunEklemePaneli.Location = new System.Drawing.Point(12, 12);
            this.grpUrunEklemePaneli.Name = "grpUrunEklemePaneli";
            this.grpUrunEklemePaneli.Size = new System.Drawing.Size(305, 149);
            this.grpUrunEklemePaneli.TabIndex = 0;
            this.grpUrunEklemePaneli.TabStop = false;
            this.grpUrunEklemePaneli.Text = "Ürün Ekleme Paneli";
            // 
            // nmrStok
            // 
            this.nmrStok.Location = new System.Drawing.Point(79, 107);
            this.nmrStok.Name = "nmrStok";
            this.nmrStok.Size = new System.Drawing.Size(193, 20);
            this.nmrStok.TabIndex = 3;
            // 
            // nmrBirim
            // 
            this.nmrBirim.Location = new System.Drawing.Point(79, 80);
            this.nmrBirim.Name = "nmrBirim";
            this.nmrBirim.Size = new System.Drawing.Size(193, 20);
            this.nmrBirim.TabIndex = 2;
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(79, 49);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(193, 20);
            this.txtUrunAdi.TabIndex = 1;
            // 
            // cmbKategoriler
            // 
            this.cmbKategoriler.FormattingEnabled = true;
            this.cmbKategoriler.Location = new System.Drawing.Point(79, 25);
            this.cmbKategoriler.Name = "cmbKategoriler";
            this.cmbKategoriler.Size = new System.Drawing.Size(193, 21);
            this.cmbKategoriler.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stok Miktarı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Birim Fiyatı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori Adı:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(339, 30);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(103, 28);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(339, 74);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(103, 33);
            this.btnGuncelle.TabIndex = 5;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(339, 121);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(103, 31);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // grpUrunler
            // 
            this.grpUrunler.Controls.Add(this.lstProducts);
            this.grpUrunler.Location = new System.Drawing.Point(12, 178);
            this.grpUrunler.Name = "grpUrunler";
            this.grpUrunler.Size = new System.Drawing.Size(430, 270);
            this.grpUrunler.TabIndex = 4;
            this.grpUrunler.TabStop = false;
            this.grpUrunler.Text = "Ürünler";
            // 
            // lstProducts
            // 
            this.lstProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lstProducts.FullRowSelect = true;
            this.lstProducts.GridLines = true;
            this.lstProducts.HideSelection = false;
            this.lstProducts.Location = new System.Drawing.Point(6, 19);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(418, 245);
            this.lstProducts.TabIndex = 0;
            this.lstProducts.UseCompatibleStateImageBehavior = false;
            this.lstProducts.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kategori Adı";
            this.columnHeader2.Width = 73;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ürün Adı";
            this.columnHeader3.Width = 72;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Birim Miktarı";
            this.columnHeader4.Width = 76;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Stok Miktarı";
            this.columnHeader5.Width = 71;
            // 
            // btnKategoriEkle
            // 
            this.btnKategoriEkle.Location = new System.Drawing.Point(12, 448);
            this.btnKategoriEkle.Name = "btnKategoriEkle";
            this.btnKategoriEkle.Size = new System.Drawing.Size(430, 41);
            this.btnKategoriEkle.TabIndex = 7;
            this.btnKategoriEkle.Text = "KATEGORİ EKLE";
            this.btnKategoriEkle.UseVisualStyleBackColor = true;
            this.btnKategoriEkle.Click += new System.EventHandler(this.btnKategoriEkle_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 491);
            this.Controls.Add(this.btnKategoriEkle);
            this.Controls.Add(this.grpUrunler);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.grpUrunEklemePaneli);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.grpUrunEklemePaneli.ResumeLayout(false);
            this.grpUrunEklemePaneli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrBirim)).EndInit();
            this.grpUrunler.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpUrunEklemePaneli;
        private System.Windows.Forms.NumericUpDown nmrBirim;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.ComboBox cmbKategoriler;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmrStok;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.GroupBox grpUrunler;
        private System.Windows.Forms.ListView lstProducts;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnKategoriEkle;
    }
}