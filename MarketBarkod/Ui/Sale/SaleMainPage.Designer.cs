﻿namespace MarketBarkod.Ui.Sale
{
    partial class SaleMainPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtBarcodeSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnWaitListReturn = new System.Windows.Forms.Button();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.pnlPaymentMethod = new System.Windows.Forms.Panel();
            this.btnKredi = new System.Windows.Forms.Button();
            this.registeredCustomer = new System.Windows.Forms.Button();
            this.btnNakit = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnWaitList = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnTotaliskonto = new System.Windows.Forms.Button();
            this.btnProductDiscount = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlPaymentMethod.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Controls.Add(this.txtBarcodeSearch);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(769, 364);
            this.panel1.TabIndex = 46;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.Location = new System.Drawing.Point(260, 6);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(133, 22);
            this.lblName.TabIndex = 52;
            this.lblName.Text = "Ürün Adı : null";
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button10.Location = new System.Drawing.Point(124, 35);
            this.button10.Margin = new System.Windows.Forms.Padding(2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(17, 18);
            this.button10.TabIndex = 51;
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.Button10_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(2, 35);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 21);
            this.label4.TabIndex = 44;
            this.label4.Text = "Ürün Durumu :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 63);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(767, 299);
            this.dataGridView1.TabIndex = 43;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrice.Location = new System.Drawing.Point(260, 36);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(98, 22);
            this.lblPrice.TabIndex = 42;
            this.lblPrice.Text = "Fiyat : null";
            // 
            // txtBarcodeSearch
            // 
            this.txtBarcodeSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBarcodeSearch.Location = new System.Drawing.Point(74, 6);
            this.txtBarcodeSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtBarcodeSearch.Multiline = true;
            this.txtBarcodeSearch.Name = "txtBarcodeSearch";
            this.txtBarcodeSearch.Size = new System.Drawing.Size(183, 26);
            this.txtBarcodeSearch.TabIndex = 12;
            this.txtBarcodeSearch.TextChanged += new System.EventHandler(this.TxtBarcodeSearch_TextChanged);
            this.txtBarcodeSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtBarcodeSearch_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(2, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "Barkod :";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnWaitListReturn);
            this.panel2.Controls.Add(this.lblPaymentMethod);
            this.panel2.Controls.Add(this.pnlPaymentMethod);
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Controls.Add(this.btnWaitList);
            this.panel2.Controls.Add(this.btnSil);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnTotaliskonto);
            this.panel2.Controls.Add(this.btnProductDiscount);
            this.panel2.Location = new System.Drawing.Point(2, 372);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(769, 164);
            this.panel2.TabIndex = 52;
            // 
            // btnWaitListReturn
            // 
            this.btnWaitListReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.btnWaitListReturn.FlatAppearance.BorderSize = 0;
            this.btnWaitListReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWaitListReturn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWaitListReturn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnWaitListReturn.Location = new System.Drawing.Point(23, 84);
            this.btnWaitListReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnWaitListReturn.Name = "btnWaitListReturn";
            this.btnWaitListReturn.Size = new System.Drawing.Size(272, 32);
            this.btnWaitListReturn.TabIndex = 62;
            this.btnWaitListReturn.Text = "Beklemedekileri Getir";
            this.btnWaitListReturn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWaitListReturn.UseVisualStyleBackColor = false;
            this.btnWaitListReturn.Visible = false;
            this.btnWaitListReturn.Click += new System.EventHandler(this.BtnWaitListReturn_Click);
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPaymentMethod.Location = new System.Drawing.Point(528, 36);
            this.lblPaymentMethod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(106, 21);
            this.lblPaymentMethod.TabIndex = 52;
            this.lblPaymentMethod.Text = "Ödeme Şekli";
            // 
            // pnlPaymentMethod
            // 
            this.pnlPaymentMethod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPaymentMethod.Controls.Add(this.btnKredi);
            this.pnlPaymentMethod.Controls.Add(this.registeredCustomer);
            this.pnlPaymentMethod.Controls.Add(this.btnNakit);
            this.pnlPaymentMethod.Location = new System.Drawing.Point(422, 45);
            this.pnlPaymentMethod.Margin = new System.Windows.Forms.Padding(2);
            this.pnlPaymentMethod.Name = "pnlPaymentMethod";
            this.pnlPaymentMethod.Size = new System.Drawing.Size(326, 90);
            this.pnlPaymentMethod.TabIndex = 61;
            // 
            // btnKredi
            // 
            this.btnKredi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.btnKredi.FlatAppearance.BorderSize = 0;
            this.btnKredi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKredi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKredi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnKredi.Location = new System.Drawing.Point(7, 15);
            this.btnKredi.Margin = new System.Windows.Forms.Padding(2);
            this.btnKredi.Name = "btnKredi";
            this.btnKredi.Size = new System.Drawing.Size(154, 32);
            this.btnKredi.TabIndex = 60;
            this.btnKredi.Tag = "Kredi";
            this.btnKredi.Text = "Kredi";
            this.btnKredi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKredi.UseVisualStyleBackColor = false;
            this.btnKredi.Click += new System.EventHandler(this.ProccesFinish);
            // 
            // registeredCustomer
            // 
            this.registeredCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.registeredCustomer.FlatAppearance.BorderSize = 0;
            this.registeredCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registeredCustomer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registeredCustomer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.registeredCustomer.Location = new System.Drawing.Point(7, 50);
            this.registeredCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.registeredCustomer.Name = "registeredCustomer";
            this.registeredCustomer.Size = new System.Drawing.Size(154, 32);
            this.registeredCustomer.TabIndex = 62;
            this.registeredCustomer.Tag = "Musteri";
            this.registeredCustomer.Text = "Kayıtlı Müşteriye";
            this.registeredCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.registeredCustomer.UseVisualStyleBackColor = false;
            this.registeredCustomer.Click += new System.EventHandler(this.ProccesFinish);
            // 
            // btnNakit
            // 
            this.btnNakit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.btnNakit.FlatAppearance.BorderSize = 0;
            this.btnNakit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNakit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNakit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNakit.Location = new System.Drawing.Point(166, 15);
            this.btnNakit.Margin = new System.Windows.Forms.Padding(2);
            this.btnNakit.Name = "btnNakit";
            this.btnNakit.Size = new System.Drawing.Size(154, 32);
            this.btnNakit.TabIndex = 63;
            this.btnNakit.Tag = "Nakit";
            this.btnNakit.Text = "Nakit";
            this.btnNakit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNakit.UseVisualStyleBackColor = false;
            this.btnNakit.Click += new System.EventHandler(this.ProccesFinish);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotal.Location = new System.Drawing.Point(423, 0);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(299, 39);
            this.lblTotal.TabIndex = 55;
            this.lblTotal.Text = "Toplam Fiyat : null ";
            // 
            // btnWaitList
            // 
            this.btnWaitList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.btnWaitList.FlatAppearance.BorderSize = 0;
            this.btnWaitList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWaitList.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWaitList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnWaitList.Location = new System.Drawing.Point(2, 84);
            this.btnWaitList.Margin = new System.Windows.Forms.Padding(2);
            this.btnWaitList.Name = "btnWaitList";
            this.btnWaitList.Size = new System.Drawing.Size(154, 32);
            this.btnWaitList.TabIndex = 60;
            this.btnWaitList.Text = "Bekleme";
            this.btnWaitList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWaitList.UseVisualStyleBackColor = false;
            this.btnWaitList.Click += new System.EventHandler(this.BtnWaitList_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSil.Location = new System.Drawing.Point(2, 10);
            this.btnSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(154, 32);
            this.btnSil.TabIndex = 51;
            this.btnSil.Text = "SİL";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Location = new System.Drawing.Point(2, 45);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(154, 32);
            this.btnCancel.TabIndex = 52;
            this.btnCancel.Text = "İptal";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnTotaliskonto
            // 
            this.btnTotaliskonto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.btnTotaliskonto.FlatAppearance.BorderSize = 0;
            this.btnTotaliskonto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTotaliskonto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotaliskonto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTotaliskonto.Location = new System.Drawing.Point(161, 10);
            this.btnTotaliskonto.Margin = new System.Windows.Forms.Padding(2);
            this.btnTotaliskonto.Name = "btnTotaliskonto";
            this.btnTotaliskonto.Size = new System.Drawing.Size(154, 32);
            this.btnTotaliskonto.TabIndex = 53;
            this.btnTotaliskonto.Text = "Toplam İskonto";
            this.btnTotaliskonto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTotaliskonto.UseVisualStyleBackColor = false;
            this.btnTotaliskonto.Click += new System.EventHandler(this.BtnTotaliskonto_Click);
            // 
            // btnProductDiscount
            // 
            this.btnProductDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.btnProductDiscount.FlatAppearance.BorderSize = 0;
            this.btnProductDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductDiscount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductDiscount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProductDiscount.Location = new System.Drawing.Point(161, 45);
            this.btnProductDiscount.Margin = new System.Windows.Forms.Padding(2);
            this.btnProductDiscount.Name = "btnProductDiscount";
            this.btnProductDiscount.Size = new System.Drawing.Size(154, 32);
            this.btnProductDiscount.TabIndex = 54;
            this.btnProductDiscount.Text = "Ürün İskonto";
            this.btnProductDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductDiscount.UseVisualStyleBackColor = false;
            this.btnProductDiscount.Click += new System.EventHandler(this.BtnProductDiscount_Click);
            // 
            // SaleMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SaleMainPage";
            this.Size = new System.Drawing.Size(902, 538);
            this.Load += new System.EventHandler(this.SaleMainPage_Load);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.SaleMainPage_PreviewKeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlPaymentMethod.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtBarcodeSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnWaitListReturn;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.Panel pnlPaymentMethod;
        private System.Windows.Forms.Button btnKredi;
        private System.Windows.Forms.Button registeredCustomer;
        private System.Windows.Forms.Button btnNakit;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnWaitList;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnTotaliskonto;
        private System.Windows.Forms.Button btnProductDiscount;
    }
}
