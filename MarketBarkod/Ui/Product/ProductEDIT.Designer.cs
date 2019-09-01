namespace MarketBarkod.Ui.Product
{
    partial class ProductEDIT
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
        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSearchBarkod = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.datagridview1 = new System.Windows.Forms.DataGridView();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NumericSatisFiyat = new System.Windows.Forms.NumericUpDown();
            this.btnProductDELETE = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbProductCategory = new System.Windows.Forms.ComboBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductBarcode = new System.Windows.Forms.TextBox();
            this.btnProductEDIT = new System.Windows.Forms.Button();
            this.rctxtProductDetails = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericSatisFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtSearchBarkod);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.datagridview1);
            this.groupBox2.Controls.Add(this.txtSearchName);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(328, 2);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(789, 309);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün Sayfasi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(289, 21);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 23);
            this.label8.TabIndex = 42;
            this.label8.Text = "VEYA";
            // 
            // txtSearchBarkod
            // 
            this.txtSearchBarkod.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearchBarkod.Location = new System.Drawing.Point(76, 20);
            this.txtSearchBarkod.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchBarkod.Multiline = true;
            this.txtSearchBarkod.Name = "txtSearchBarkod";
            this.txtSearchBarkod.Size = new System.Drawing.Size(206, 26);
            this.txtSearchBarkod.TabIndex = 7;
            this.txtSearchBarkod.TextChanged += new System.EventHandler(this.FindProduct);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(5, 24);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 21);
            this.label7.TabIndex = 18;
            this.label7.Text = "Barkod :";
            // 
            // datagridview1
            // 
            this.datagridview1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.datagridview1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.datagridview1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.datagridview1.Location = new System.Drawing.Point(2, 54);
            this.datagridview1.Margin = new System.Windows.Forms.Padding(2);
            this.datagridview1.Name = "datagridview1";
            this.datagridview1.RowTemplate.Height = 24;
            this.datagridview1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridview1.Size = new System.Drawing.Size(785, 253);
            this.datagridview1.TabIndex = 41;
            this.datagridview1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Datagridview1_CellClick);
            // 
            // txtSearchName
            // 
            this.txtSearchName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearchName.Location = new System.Drawing.Point(428, 20);
            this.txtSearchName.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchName.Multiline = true;
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(206, 26);
            this.txtSearchName.TabIndex = 8;
            this.txtSearchName.TextChanged += new System.EventHandler(this.FindProduct);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(346, 24);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 21);
            this.label9.TabIndex = 4;
            this.label9.Text = "Ürün Adı :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NumericSatisFiyat);
            this.groupBox1.Controls.Add(this.btnProductDELETE);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbProductCategory);
            this.groupBox1.Controls.Add(this.txtProductName);
            this.groupBox1.Controls.Add(this.txtProductBarcode);
            this.groupBox1.Controls.Add(this.btnProductEDIT);
            this.groupBox1.Controls.Add(this.rctxtProductDetails);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(322, 309);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Detay";
            // 
            // NumericSatisFiyat
            // 
            this.NumericSatisFiyat.DecimalPlaces = 2;
            this.NumericSatisFiyat.Location = new System.Drawing.Point(110, 111);
            this.NumericSatisFiyat.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.NumericSatisFiyat.Name = "NumericSatisFiyat";
            this.NumericSatisFiyat.Size = new System.Drawing.Size(176, 27);
            this.NumericSatisFiyat.TabIndex = 3;
            this.NumericSatisFiyat.ThousandsSeparator = true;
            // 
            // btnProductDELETE
            // 
            this.btnProductDELETE.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProductDELETE.Location = new System.Drawing.Point(158, 259);
            this.btnProductDELETE.Margin = new System.Windows.Forms.Padding(2);
            this.btnProductDELETE.Name = "btnProductDELETE";
            this.btnProductDELETE.Size = new System.Drawing.Size(157, 41);
            this.btnProductDELETE.TabIndex = 6;
            this.btnProductDELETE.Text = "Sil";
            this.btnProductDELETE.UseVisualStyleBackColor = true;
            this.btnProductDELETE.Click += new System.EventHandler(this.BtnProductDELETE_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(291, 113);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 22);
            this.label6.TabIndex = 16;
            this.label6.Text = "TL";
            // 
            // cmbProductCategory
            // 
            this.cmbProductCategory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbProductCategory.FormattingEnabled = true;
            this.cmbProductCategory.Location = new System.Drawing.Point(110, 80);
            this.cmbProductCategory.Margin = new System.Windows.Forms.Padding(2);
            this.cmbProductCategory.Name = "cmbProductCategory";
            this.cmbProductCategory.Size = new System.Drawing.Size(206, 29);
            this.cmbProductCategory.TabIndex = 2;
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProductName.Location = new System.Drawing.Point(110, 50);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(2);
            this.txtProductName.Multiline = true;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(206, 26);
            this.txtProductName.TabIndex = 1;
            // 
            // txtProductBarcode
            // 
            this.txtProductBarcode.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProductBarcode.Location = new System.Drawing.Point(110, 23);
            this.txtProductBarcode.Margin = new System.Windows.Forms.Padding(2);
            this.txtProductBarcode.Multiline = true;
            this.txtProductBarcode.Name = "txtProductBarcode";
            this.txtProductBarcode.Size = new System.Drawing.Size(206, 26);
            this.txtProductBarcode.TabIndex = 0;
            // 
            // btnProductEDIT
            // 
            this.btnProductEDIT.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProductEDIT.Location = new System.Drawing.Point(9, 259);
            this.btnProductEDIT.Margin = new System.Windows.Forms.Padding(2);
            this.btnProductEDIT.Name = "btnProductEDIT";
            this.btnProductEDIT.Size = new System.Drawing.Size(145, 41);
            this.btnProductEDIT.TabIndex = 5;
            this.btnProductEDIT.Text = "Düzenle";
            this.btnProductEDIT.UseVisualStyleBackColor = true;
            this.btnProductEDIT.Click += new System.EventHandler(this.BtnProductEDIT_Click);
            // 
            // rctxtProductDetails
            // 
            this.rctxtProductDetails.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rctxtProductDetails.Location = new System.Drawing.Point(110, 143);
            this.rctxtProductDetails.Margin = new System.Windows.Forms.Padding(2);
            this.rctxtProductDetails.Name = "rctxtProductDetails";
            this.rctxtProductDetails.Size = new System.Drawing.Size(208, 79);
            this.rctxtProductDetails.TabIndex = 4;
            this.rctxtProductDetails.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(6, 173);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 21);
            this.label12.TabIndex = 11;
            this.label12.Text = "Ürün Detayi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Satıs Fiyati :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(5, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kategorisi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(5, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ürün Adı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(5, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Barkod :";
            // 
            // ProductEDIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProductEDIT";
            this.Size = new System.Drawing.Size(1131, 314);
            this.Load += new System.EventHandler(this.ProductEDIT_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericSatisFiyat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSearchBarkod;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView datagridview1;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnProductDELETE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbProductCategory;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductBarcode;
        private System.Windows.Forms.Button btnProductEDIT;
        private System.Windows.Forms.RichTextBox rctxtProductDetails;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NumericSatisFiyat;
    }
}
