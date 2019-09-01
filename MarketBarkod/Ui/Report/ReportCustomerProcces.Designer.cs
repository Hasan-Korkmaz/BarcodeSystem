namespace MarketBarkod.Ui.Report
{
    partial class ReportCustomerProcces
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
            this.AccountReport = new System.Windows.Forms.Button();
            this.btnBuyReport = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.AccountReport);
            this.panel1.Controls.Add(this.btnBuyReport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 175);
            this.panel1.TabIndex = 14;
            // 
            // AccountReport
            // 
            this.AccountReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.AccountReport.FlatAppearance.BorderSize = 0;
            this.AccountReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountReport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountReport.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AccountReport.Location = new System.Drawing.Point(2, 33);
            this.AccountReport.Margin = new System.Windows.Forms.Padding(2);
            this.AccountReport.Name = "AccountReport";
            this.AccountReport.Size = new System.Drawing.Size(175, 28);
            this.AccountReport.TabIndex = 15;
            this.AccountReport.Text = "Ödeme Dökümü";
            this.AccountReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AccountReport.UseVisualStyleBackColor = false;
            this.AccountReport.Click += new System.EventHandler(this.AccountReport_Click);
            // 
            // btnBuyReport
            // 
            this.btnBuyReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.btnBuyReport.FlatAppearance.BorderSize = 0;
            this.btnBuyReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuyReport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuyReport.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuyReport.Location = new System.Drawing.Point(2, 4);
            this.btnBuyReport.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuyReport.Name = "btnBuyReport";
            this.btnBuyReport.Size = new System.Drawing.Size(175, 28);
            this.btnBuyReport.TabIndex = 14;
            this.btnBuyReport.Text = "Satın Alma Dökümü";
            this.btnBuyReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuyReport.UseVisualStyleBackColor = false;
            this.btnBuyReport.Click += new System.EventHandler(this.BtnBuyReport_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(183, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1378, 175);
            this.panel2.TabIndex = 15;
            // 
            // ReportCustomerProcces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ReportCustomerProcces";
            this.Size = new System.Drawing.Size(1561, 175);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AccountReport;
        private System.Windows.Forms.Button btnBuyReport;
        private System.Windows.Forms.Panel panel2;
    }
}
