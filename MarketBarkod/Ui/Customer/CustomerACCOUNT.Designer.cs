﻿namespace MarketBarkod.Ui.Customer
{
    partial class CustomerACCOUNT
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.datagridview1 = new System.Windows.Forms.DataGridView();
            this.txtSoyisimSearch = new System.Windows.Forms.TextBox();
            this.txtisimSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numericMiktar = new System.Windows.Forms.NumericUpDown();
            this.btnOK = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbProccesType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtcustomerSurname = new System.Windows.Forms.TextBox();
            this.txtcustomerName = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMiktar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.datagridview1);
            this.panel3.Controls.Add(this.txtSoyisimSearch);
            this.panel3.Controls.Add(this.txtisimSearch);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(386, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(842, 271);
            this.panel3.TabIndex = 3;
            // 
            // datagridview1
            // 
            this.datagridview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.datagridview1.Location = new System.Drawing.Point(0, 44);
            this.datagridview1.Margin = new System.Windows.Forms.Padding(2);
            this.datagridview1.Name = "datagridview1";
            this.datagridview1.RowTemplate.Height = 24;
            this.datagridview1.Size = new System.Drawing.Size(842, 227);
            this.datagridview1.TabIndex = 42;
            this.datagridview1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Datagridview1_CellClick);
            // 
            // txtSoyisimSearch
            // 
            this.txtSoyisimSearch.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyisimSearch.Location = new System.Drawing.Point(463, 11);
            this.txtSoyisimSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoyisimSearch.Name = "txtSoyisimSearch";
            this.txtSoyisimSearch.Size = new System.Drawing.Size(172, 30);
            this.txtSoyisimSearch.TabIndex = 6;
            this.txtSoyisimSearch.TextChanged += new System.EventHandler(this.FindCustomer);
            // 
            // txtisimSearch
            // 
            this.txtisimSearch.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtisimSearch.Location = new System.Drawing.Point(134, 11);
            this.txtisimSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtisimSearch.Name = "txtisimSearch";
            this.txtisimSearch.Size = new System.Drawing.Size(172, 30);
            this.txtisimSearch.TabIndex = 5;
            this.txtisimSearch.TextChanged += new System.EventHandler(this.FindCustomer);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(310, 13);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 22);
            this.label6.TabIndex = 47;
            this.label6.Text = "Müşteri Soyadi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(11, 13);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 22);
            this.label5.TabIndex = 46;
            this.label5.Text = "Müşteri Adi :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.numericMiktar);
            this.panel2.Controls.Add(this.btnOK);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cmbProccesType);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txtcustomerSurname);
            this.panel2.Controls.Add(this.txtcustomerName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(386, 271);
            this.panel2.TabIndex = 2;
            // 
            // numericMiktar
            // 
            this.numericMiktar.DecimalPlaces = 2;
            this.numericMiktar.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericMiktar.Location = new System.Drawing.Point(160, 104);
            this.numericMiktar.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numericMiktar.Name = "numericMiktar";
            this.numericMiktar.Size = new System.Drawing.Size(186, 28);
            this.numericMiktar.TabIndex = 3;
            this.numericMiktar.ThousandsSeparator = true;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOK.Location = new System.Drawing.Point(231, 145);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(139, 34);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "Onay";
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(349, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "TL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(2, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ödeme Miktarı :";
            // 
            // cmbProccesType
            // 
            this.cmbProccesType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbProccesType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProccesType.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbProccesType.FormattingEnabled = true;
            this.cmbProccesType.Location = new System.Drawing.Point(160, 74);
            this.cmbProccesType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbProccesType.Name = "cmbProccesType";
            this.cmbProccesType.Size = new System.Drawing.Size(216, 29);
            this.cmbProccesType.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(2, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ödeme Tipi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(2, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Müşteri Soyadi :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(2, 9);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 22);
            this.label13.TabIndex = 7;
            this.label13.Text = "Müşteri Adi :";
            // 
            // txtcustomerSurname
            // 
            this.txtcustomerSurname.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtcustomerSurname.Location = new System.Drawing.Point(160, 42);
            this.txtcustomerSurname.Margin = new System.Windows.Forms.Padding(2);
            this.txtcustomerSurname.Name = "txtcustomerSurname";
            this.txtcustomerSurname.Size = new System.Drawing.Size(216, 30);
            this.txtcustomerSurname.TabIndex = 1;
            // 
            // txtcustomerName
            // 
            this.txtcustomerName.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtcustomerName.Location = new System.Drawing.Point(160, 10);
            this.txtcustomerName.Margin = new System.Windows.Forms.Padding(2);
            this.txtcustomerName.Name = "txtcustomerName";
            this.txtcustomerName.Size = new System.Drawing.Size(216, 30);
            this.txtcustomerName.TabIndex = 0;
            // 
            // CustomerACCOUNT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "CustomerACCOUNT";
            this.Size = new System.Drawing.Size(1228, 271);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMiktar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView datagridview1;
        private System.Windows.Forms.TextBox txtSoyisimSearch;
        private System.Windows.Forms.TextBox txtisimSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbProccesType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtcustomerSurname;
        private System.Windows.Forms.TextBox txtcustomerName;
        private System.Windows.Forms.NumericUpDown numericMiktar;
    }
}
