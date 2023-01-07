
namespace Example2_AddProduct
{
    partial class Form2
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
            this.grpAddCategory = new System.Windows.Forms.GroupBox();
            this.txtCategoryDescription = new System.Windows.Forms.TextBox();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.grpCategories = new System.Windows.Forms.GroupBox();
            this.lstCategories = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.grpAddCategory.SuspendLayout();
            this.grpCategories.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAddCategory
            // 
            this.grpAddCategory.Controls.Add(this.txtCategoryDescription);
            this.grpAddCategory.Controls.Add(this.txtCategoryName);
            this.grpAddCategory.Controls.Add(this.label2);
            this.grpAddCategory.Controls.Add(this.label1);
            this.grpAddCategory.Location = new System.Drawing.Point(20, 16);
            this.grpAddCategory.Name = "grpAddCategory";
            this.grpAddCategory.Size = new System.Drawing.Size(392, 103);
            this.grpAddCategory.TabIndex = 0;
            this.grpAddCategory.TabStop = false;
            this.grpAddCategory.Text = "Kategori Ekleme Paneli";
            // 
            // txtCategoryDescription
            // 
            this.txtCategoryDescription.Location = new System.Drawing.Point(102, 56);
            this.txtCategoryDescription.Name = "txtCategoryDescription";
            this.txtCategoryDescription.Size = new System.Drawing.Size(210, 20);
            this.txtCategoryDescription.TabIndex = 1;
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(102, 25);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(210, 20);
            this.txtCategoryName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Açıklaması:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori Adı:";
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(21, 125);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(392, 46);
            this.btnAddCategory.TabIndex = 2;
            this.btnAddCategory.Text = "KATEGORİ EKLE";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // grpCategories
            // 
            this.grpCategories.Controls.Add(this.lstCategories);
            this.grpCategories.Location = new System.Drawing.Point(21, 177);
            this.grpCategories.Name = "grpCategories";
            this.grpCategories.Size = new System.Drawing.Size(392, 282);
            this.grpCategories.TabIndex = 2;
            this.grpCategories.TabStop = false;
            this.grpCategories.Text = "Kategoriler";
            // 
            // lstCategories
            // 
            this.lstCategories.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstCategories.GridLines = true;
            this.lstCategories.HideSelection = false;
            this.lstCategories.Location = new System.Drawing.Point(6, 19);
            this.lstCategories.Name = "lstCategories";
            this.lstCategories.Size = new System.Drawing.Size(380, 257);
            this.lstCategories.TabIndex = 0;
            this.lstCategories.UseCompatibleStateImageBehavior = false;
            this.lstCategories.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 38;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kategori Adı";
            this.columnHeader2.Width = 73;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Açıklama";
            this.columnHeader3.Width = 74;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(21, 462);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(392, 39);
            this.btnAddProduct.TabIndex = 3;
            this.btnAddProduct.Text = "ÜRÜN EKLE";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 511);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.grpCategories);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.grpAddCategory);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.grpAddCategory.ResumeLayout(false);
            this.grpAddCategory.PerformLayout();
            this.grpCategories.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAddCategory;
        private System.Windows.Forms.TextBox txtCategoryDescription;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.GroupBox grpCategories;
        private System.Windows.Forms.ListView lstCategories;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnAddProduct;
    }
}