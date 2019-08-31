namespace MarketBarkod.Ui.Customer
{
    partial class CustomerEDIT
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.datagridview1 = new System.Windows.Forms.DataGridView();
            this.txtSoyisimSearch = new System.Windows.Forms.TextBox();
            this.txtisimSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtcustomerAccount = new System.Windows.Forms.NumericUpDown();
            this.txtcustomerTelephone = new System.Windows.Forms.MaskedTextBox();
            this.btncustomerDelete = new System.Windows.Forms.Button();
            this.cmbcustomerReference = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btncustomerEdit = new System.Windows.Forms.Button();
            this.rctxtcustomerDetails = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtCustomerSurname = new System.Windows.Forms.TextBox();
            this.txtcustomerName = new System.Windows.Forms.TextBox();
            this.txtcustomerOccupotion = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.rctxtcustomerAddress = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcustomerAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1235, 414);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.datagridview1);
            this.panel2.Controls.Add(this.txtSoyisimSearch);
            this.panel2.Controls.Add(this.txtisimSearch);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(435, 13);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 398);
            this.panel2.TabIndex = 47;
            // 
            // datagridview1
            // 
            this.datagridview1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.datagridview1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridview1.DefaultCellStyle = dataGridViewCellStyle2;
            this.datagridview1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.datagridview1.Location = new System.Drawing.Point(0, 49);
            this.datagridview1.Margin = new System.Windows.Forms.Padding(2);
            this.datagridview1.Name = "datagridview1";
            this.datagridview1.RowTemplate.Height = 24;
            this.datagridview1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridview1.Size = new System.Drawing.Size(800, 349);
            this.datagridview1.TabIndex = 44;
            this.datagridview1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Datagridview1_CellClick);
            // 
            // txtSoyisimSearch
            // 
            this.txtSoyisimSearch.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyisimSearch.Location = new System.Drawing.Point(466, 2);
            this.txtSoyisimSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoyisimSearch.Name = "txtSoyisimSearch";
            this.txtSoyisimSearch.Size = new System.Drawing.Size(172, 30);
            this.txtSoyisimSearch.TabIndex = 11;
            this.txtSoyisimSearch.TextChanged += new System.EventHandler(this.CustomerFind);
            // 
            // txtisimSearch
            // 
            this.txtisimSearch.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtisimSearch.Location = new System.Drawing.Point(138, 2);
            this.txtisimSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtisimSearch.Name = "txtisimSearch";
            this.txtisimSearch.Size = new System.Drawing.Size(172, 30);
            this.txtisimSearch.TabIndex = 10;
            this.txtisimSearch.TextChanged += new System.EventHandler(this.CustomerFind);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(314, 5);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 22);
            this.label6.TabIndex = 43;
            this.label6.Text = "Müşteri Soyadi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(15, 5);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 22);
            this.label5.TabIndex = 42;
            this.label5.Text = "Müşteri Adi :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtcustomerAccount);
            this.groupBox3.Controls.Add(this.txtcustomerTelephone);
            this.groupBox3.Controls.Add(this.btncustomerDelete);
            this.groupBox3.Controls.Add(this.cmbcustomerReference);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btncustomerEdit);
            this.groupBox3.Controls.Add(this.rctxtcustomerDetails);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.txtCustomerSurname);
            this.groupBox3.Controls.Add(this.txtcustomerName);
            this.groupBox3.Controls.Add(this.txtcustomerOccupotion);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.rctxtcustomerAddress);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(2, 2);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(428, 418);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Müşteri Ekle Düzenle";
            // 
            // txtcustomerAccount
            // 
            this.txtcustomerAccount.DecimalPlaces = 2;
            this.txtcustomerAccount.Location = new System.Drawing.Point(202, 186);
            this.txtcustomerAccount.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.txtcustomerAccount.Name = "txtcustomerAccount";
            this.txtcustomerAccount.Size = new System.Drawing.Size(186, 30);
            this.txtcustomerAccount.TabIndex = 5;
            this.txtcustomerAccount.ThousandsSeparator = true;
            // 
            // txtcustomerTelephone
            // 
            this.txtcustomerTelephone.BeepOnError = true;
            this.txtcustomerTelephone.Location = new System.Drawing.Point(202, 91);
            this.txtcustomerTelephone.Margin = new System.Windows.Forms.Padding(2);
            this.txtcustomerTelephone.Mask = "(999)000-00-00";
            this.txtcustomerTelephone.Name = "txtcustomerTelephone";
            this.txtcustomerTelephone.Size = new System.Drawing.Size(216, 30);
            this.txtcustomerTelephone.TabIndex = 2;
            // 
            // btncustomerDelete
            // 
            this.btncustomerDelete.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncustomerDelete.Location = new System.Drawing.Point(217, 367);
            this.btncustomerDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btncustomerDelete.Name = "btncustomerDelete";
            this.btncustomerDelete.Size = new System.Drawing.Size(206, 42);
            this.btncustomerDelete.TabIndex = 9;
            this.btncustomerDelete.Text = "Sil";
            this.btncustomerDelete.UseVisualStyleBackColor = true;
            this.btncustomerDelete.Click += new System.EventHandler(this.BtncustomerDelete_Click);
            // 
            // cmbcustomerReference
            // 
            this.cmbcustomerReference.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbcustomerReference.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbcustomerReference.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbcustomerReference.FormattingEnabled = true;
            this.cmbcustomerReference.Location = new System.Drawing.Point(202, 155);
            this.cmbcustomerReference.Margin = new System.Windows.Forms.Padding(2);
            this.cmbcustomerReference.Name = "cmbcustomerReference";
            this.cmbcustomerReference.Size = new System.Drawing.Size(216, 29);
            this.cmbcustomerReference.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(391, 190);
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
            this.label2.Location = new System.Drawing.Point(4, 188);
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
            this.label1.Location = new System.Drawing.Point(4, 157);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 22);
            this.label1.TabIndex = 22;
            this.label1.Text = "Müşterinin Referansi :";
            // 
            // btncustomerEdit
            // 
            this.btncustomerEdit.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncustomerEdit.Location = new System.Drawing.Point(4, 367);
            this.btncustomerEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btncustomerEdit.Name = "btncustomerEdit";
            this.btncustomerEdit.Size = new System.Drawing.Size(211, 42);
            this.btncustomerEdit.TabIndex = 8;
            this.btncustomerEdit.Text = "Düzenle";
            this.btncustomerEdit.UseVisualStyleBackColor = true;
            this.btncustomerEdit.Click += new System.EventHandler(this.BtncustomerEdit_Click);
            // 
            // rctxtcustomerDetails
            // 
            this.rctxtcustomerDetails.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rctxtcustomerDetails.Location = new System.Drawing.Point(202, 295);
            this.rctxtcustomerDetails.Margin = new System.Windows.Forms.Padding(2);
            this.rctxtcustomerDetails.Name = "rctxtcustomerDetails";
            this.rctxtcustomerDetails.Size = new System.Drawing.Size(218, 70);
            this.rctxtcustomerDetails.TabIndex = 7;
            this.rctxtcustomerDetails.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(3, 64);
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
            this.label13.Location = new System.Drawing.Point(4, 32);
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
            this.label19.Location = new System.Drawing.Point(4, 317);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(173, 22);
            this.label19.TabIndex = 17;
            this.label19.Text = "Müşterinin Detay :";
            // 
            // txtCustomerSurname
            // 
            this.txtCustomerSurname.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCustomerSurname.Location = new System.Drawing.Point(202, 60);
            this.txtCustomerSurname.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustomerSurname.Name = "txtCustomerSurname";
            this.txtCustomerSurname.Size = new System.Drawing.Size(216, 30);
            this.txtCustomerSurname.TabIndex = 1;
            // 
            // txtcustomerName
            // 
            this.txtcustomerName.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtcustomerName.Location = new System.Drawing.Point(202, 29);
            this.txtcustomerName.Margin = new System.Windows.Forms.Padding(2);
            this.txtcustomerName.Name = "txtcustomerName";
            this.txtcustomerName.Size = new System.Drawing.Size(216, 30);
            this.txtcustomerName.TabIndex = 0;
            // 
            // txtcustomerOccupotion
            // 
            this.txtcustomerOccupotion.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtcustomerOccupotion.Location = new System.Drawing.Point(202, 123);
            this.txtcustomerOccupotion.Margin = new System.Windows.Forms.Padding(2);
            this.txtcustomerOccupotion.Name = "txtcustomerOccupotion";
            this.txtcustomerOccupotion.Size = new System.Drawing.Size(216, 30);
            this.txtcustomerOccupotion.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(4, 95);
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
            this.label16.Location = new System.Drawing.Point(4, 126);
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
            this.label17.Location = new System.Drawing.Point(4, 245);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(172, 22);
            this.label17.TabIndex = 10;
            this.label17.Text = "Müşterinin Adresi :";
            // 
            // rctxtcustomerAddress
            // 
            this.rctxtcustomerAddress.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rctxtcustomerAddress.Location = new System.Drawing.Point(202, 227);
            this.rctxtcustomerAddress.Margin = new System.Windows.Forms.Padding(2);
            this.rctxtcustomerAddress.Name = "rctxtcustomerAddress";
            this.rctxtcustomerAddress.Size = new System.Drawing.Size(218, 70);
            this.rctxtcustomerAddress.TabIndex = 6;
            this.rctxtcustomerAddress.Text = "";
            // 
            // CustomerEDIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "CustomerEDIT";
            this.Size = new System.Drawing.Size(1241, 427);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcustomerAccount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSoyisimSearch;
        private System.Windows.Forms.TextBox txtisimSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown txtcustomerAccount;
        private System.Windows.Forms.MaskedTextBox txtcustomerTelephone;
        private System.Windows.Forms.Button btncustomerDelete;
        private System.Windows.Forms.ComboBox cmbcustomerReference;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncustomerEdit;
        private System.Windows.Forms.RichTextBox rctxtcustomerDetails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtCustomerSurname;
        private System.Windows.Forms.TextBox txtcustomerName;
        private System.Windows.Forms.TextBox txtcustomerOccupotion;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RichTextBox rctxtcustomerAddress;
        private System.Windows.Forms.DataGridView datagridview1;
    }
}
