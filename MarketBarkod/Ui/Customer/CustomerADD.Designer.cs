﻿namespace MarketBarkod.Ui.Customer
{
    partial class CustomerADD
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtcustomerAccount = new System.Windows.Forms.NumericUpDown();
            this.txtCustomerTelephone = new System.Windows.Forms.MaskedTextBox();
            this.cmbCustomerRefrence = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btncustomerInsert = new System.Windows.Forms.Button();
            this.rctxtcustomerDetail = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtcustomerName = new System.Windows.Forms.TextBox();
            this.txtcusomerOccupotion = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.rctxtcustomerAddress = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcustomerAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 430);
            this.panel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtcustomerAccount);
            this.groupBox3.Controls.Add(this.txtCustomerTelephone);
            this.groupBox3.Controls.Add(this.cmbCustomerRefrence);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btncustomerInsert);
            this.groupBox3.Controls.Add(this.rctxtcustomerDetail);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.txtSurname);
            this.groupBox3.Controls.Add(this.txtcustomerName);
            this.groupBox3.Controls.Add(this.txtcusomerOccupotion);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.rctxtcustomerAddress);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(2, 2);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(431, 410);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Müşteri Ekle Düzenle";
            // 
            // txtcustomerAccount
            // 
            this.txtcustomerAccount.DecimalPlaces = 2;
            this.txtcustomerAccount.Location = new System.Drawing.Point(203, 184);
            this.txtcustomerAccount.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.txtcustomerAccount.Name = "txtcustomerAccount";
            this.txtcustomerAccount.Size = new System.Drawing.Size(184, 30);
            this.txtcustomerAccount.TabIndex = 5;
            this.txtcustomerAccount.ThousandsSeparator = true;
            // 
            // txtCustomerTelephone
            // 
            this.txtCustomerTelephone.BeepOnError = true;
            this.txtCustomerTelephone.Location = new System.Drawing.Point(203, 89);
            this.txtCustomerTelephone.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustomerTelephone.Mask = "(999)000-00-00";
            this.txtCustomerTelephone.Name = "txtCustomerTelephone";
            this.txtCustomerTelephone.Size = new System.Drawing.Size(216, 30);
            this.txtCustomerTelephone.TabIndex = 2;
            // 
            // cmbCustomerRefrence
            // 
            this.cmbCustomerRefrence.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCustomerRefrence.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCustomerRefrence.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbCustomerRefrence.FormattingEnabled = true;
            this.cmbCustomerRefrence.Location = new System.Drawing.Point(203, 152);
            this.cmbCustomerRefrence.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCustomerRefrence.Name = "cmbCustomerRefrence";
            this.cmbCustomerRefrence.Size = new System.Drawing.Size(218, 29);
            this.cmbCustomerRefrence.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(392, 186);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 22);
            this.label3.TabIndex = 26;
            this.label3.Text = "TL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(4, 186);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 22);
            this.label2.TabIndex = 24;
            this.label2.Text = "Müşterinin Hesabı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(4, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 22);
            this.label1.TabIndex = 22;
            this.label1.Text = "Müşterinin Referansi :";
            // 
            // btncustomerInsert
            // 
            this.btncustomerInsert.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncustomerInsert.Location = new System.Drawing.Point(4, 361);
            this.btncustomerInsert.Margin = new System.Windows.Forms.Padding(2);
            this.btncustomerInsert.Name = "btncustomerInsert";
            this.btncustomerInsert.Size = new System.Drawing.Size(421, 42);
            this.btncustomerInsert.TabIndex = 8;
            this.btncustomerInsert.Text = "Ekle";
            this.btncustomerInsert.UseVisualStyleBackColor = true;
            this.btncustomerInsert.Click += new System.EventHandler(this.BtncustomerInsert_Click);
            // 
            // rctxtcustomerDetail
            // 
            this.rctxtcustomerDetail.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rctxtcustomerDetail.Location = new System.Drawing.Point(203, 288);
            this.rctxtcustomerDetail.Margin = new System.Windows.Forms.Padding(2);
            this.rctxtcustomerDetail.Name = "rctxtcustomerDetail";
            this.rctxtcustomerDetail.Size = new System.Drawing.Size(218, 70);
            this.rctxtcustomerDetail.TabIndex = 7;
            this.rctxtcustomerDetail.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(4, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Müşteri Soyadi :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(4, 30);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 22);
            this.label13.TabIndex = 5;
            this.label13.Text = "Müşteri Adi :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(5, 310);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(173, 22);
            this.label19.TabIndex = 17;
            this.label19.Text = "Müşterinin Detay :";
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSurname.Location = new System.Drawing.Point(203, 58);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(2);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(218, 30);
            this.txtSurname.TabIndex = 1;
            // 
            // txtcustomerName
            // 
            this.txtcustomerName.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtcustomerName.Location = new System.Drawing.Point(203, 26);
            this.txtcustomerName.Margin = new System.Windows.Forms.Padding(2);
            this.txtcustomerName.Name = "txtcustomerName";
            this.txtcustomerName.Size = new System.Drawing.Size(218, 30);
            this.txtcustomerName.TabIndex = 0;
            // 
            // txtcusomerOccupotion
            // 
            this.txtcusomerOccupotion.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtcusomerOccupotion.Location = new System.Drawing.Point(203, 121);
            this.txtcusomerOccupotion.Margin = new System.Windows.Forms.Padding(2);
            this.txtcusomerOccupotion.Name = "txtcusomerOccupotion";
            this.txtcusomerOccupotion.Size = new System.Drawing.Size(218, 30);
            this.txtcusomerOccupotion.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(4, 94);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(166, 22);
            this.label15.TabIndex = 8;
            this.label15.Text = "Müşteri Telefonu :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(4, 124);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(183, 22);
            this.label16.TabIndex = 9;
            this.label16.Text = "Müşterinin Mesleği :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(5, 239);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(172, 22);
            this.label17.TabIndex = 10;
            this.label17.Text = "Müşterinin Adresi :";
            // 
            // rctxtcustomerAddress
            // 
            this.rctxtcustomerAddress.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rctxtcustomerAddress.Location = new System.Drawing.Point(203, 215);
            this.rctxtcustomerAddress.Margin = new System.Windows.Forms.Padding(2);
            this.rctxtcustomerAddress.Name = "rctxtcustomerAddress";
            this.rctxtcustomerAddress.Size = new System.Drawing.Size(218, 70);
            this.rctxtcustomerAddress.TabIndex = 6;
            this.rctxtcustomerAddress.Text = "";
            // 
            // CustomerADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "CustomerADD";
            this.Size = new System.Drawing.Size(448, 430);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcustomerAccount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown txtcustomerAccount;
        private System.Windows.Forms.MaskedTextBox txtCustomerTelephone;
        private System.Windows.Forms.ComboBox cmbCustomerRefrence;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncustomerInsert;
        private System.Windows.Forms.RichTextBox rctxtcustomerDetail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtcustomerName;
        private System.Windows.Forms.TextBox txtcusomerOccupotion;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RichTextBox rctxtcustomerAddress;

    }
}
