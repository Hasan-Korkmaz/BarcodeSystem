namespace MarketBarkod.Ui.Product
{
    partial class StockADD
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEntry = new System.Windows.Forms.Button();
            this.Miktar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NumericFiyat = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProductBarcode = new System.Windows.Forms.TextBox();
            this.rcManufacturer = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEntry);
            this.groupBox1.Controls.Add(this.Miktar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.NumericFiyat);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtProductBarcode);
            this.groupBox1.Controls.Add(this.rcManufacturer);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(357, 227);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stok Girin";
            // 
            // btnEntry
            // 
            this.btnEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.btnEntry.FlatAppearance.BorderSize = 0;
            this.btnEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntry.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntry.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEntry.Location = new System.Drawing.Point(150, 185);
            this.btnEntry.Margin = new System.Windows.Forms.Padding(2);
            this.btnEntry.Name = "btnEntry";
            this.btnEntry.Size = new System.Drawing.Size(198, 35);
            this.btnEntry.TabIndex = 19;
            this.btnEntry.Text = "Stoğa GİR";
            this.btnEntry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntry.UseVisualStyleBackColor = false;
            this.btnEntry.Click += new System.EventHandler(this.BtnEntry_Click);
            // 
            // Miktar
            // 
            this.Miktar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Miktar.Location = new System.Drawing.Point(150, 53);
            this.Miktar.Margin = new System.Windows.Forms.Padding(2);
            this.Miktar.Multiline = true;
            this.Miktar.Name = "Miktar";
            this.Miktar.Size = new System.Drawing.Size(198, 26);
            this.Miktar.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(79, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "Miktar :";
            // 
            // NumericFiyat
            // 
            this.NumericFiyat.DecimalPlaces = 2;
            this.NumericFiyat.Location = new System.Drawing.Point(150, 84);
            this.NumericFiyat.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.NumericFiyat.Name = "NumericFiyat";
            this.NumericFiyat.Size = new System.Drawing.Size(166, 27);
            this.NumericFiyat.TabIndex = 4;
            this.NumericFiyat.ThousandsSeparator = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(321, 86);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 22);
            this.label6.TabIndex = 16;
            this.label6.Text = "TL";
            // 
            // txtProductBarcode
            // 
            this.txtProductBarcode.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProductBarcode.Location = new System.Drawing.Point(150, 23);
            this.txtProductBarcode.Margin = new System.Windows.Forms.Padding(2);
            this.txtProductBarcode.Multiline = true;
            this.txtProductBarcode.Name = "txtProductBarcode";
            this.txtProductBarcode.Size = new System.Drawing.Size(198, 26);
            this.txtProductBarcode.TabIndex = 0;
            this.txtProductBarcode.TextChanged += new System.EventHandler(this.TxtProductBarcode_TextChanged);
            // 
            // rcManufacturer
            // 
            this.rcManufacturer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rcManufacturer.Location = new System.Drawing.Point(150, 116);
            this.rcManufacturer.Margin = new System.Windows.Forms.Padding(2);
            this.rcManufacturer.Name = "rcManufacturer";
            this.rcManufacturer.Size = new System.Drawing.Size(198, 65);
            this.rcManufacturer.TabIndex = 5;
            this.rcManufacturer.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(37, 133);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 21);
            this.label12.TabIndex = 11;
            this.label12.Text = "Ürün Satıcısı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(5, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Alış Fiyatı (ADET) :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(74, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Barkod :";
            // 
            // StockADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "StockADD";
            this.Size = new System.Drawing.Size(371, 266);
            this.Load += new System.EventHandler(this.StockADD_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericFiyat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Miktar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NumericFiyat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProductBarcode;
        private System.Windows.Forms.RichTextBox rcManufacturer;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEntry;
    }
}
