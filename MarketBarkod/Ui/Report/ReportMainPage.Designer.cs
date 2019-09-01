namespace MarketBarkod.Ui.Report
{
    partial class ReportMainPage
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
            this.CustomerReport = new System.Windows.Forms.Button();
            this.SaleReport = new System.Windows.Forms.Button();
            this.ProductReport = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.CustomerReport);
            this.panel1.Controls.Add(this.SaleReport);
            this.panel1.Controls.Add(this.ProductReport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 526);
            this.panel1.TabIndex = 0;
            // 
            // CustomerReport
            // 
            this.CustomerReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.CustomerReport.FlatAppearance.BorderSize = 0;
            this.CustomerReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomerReport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerReport.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CustomerReport.Location = new System.Drawing.Point(2, 68);
            this.CustomerReport.Margin = new System.Windows.Forms.Padding(2);
            this.CustomerReport.Name = "CustomerReport";
            this.CustomerReport.Size = new System.Drawing.Size(149, 28);
            this.CustomerReport.TabIndex = 11;
            this.CustomerReport.Text = "Müşteri Raporları";
            this.CustomerReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CustomerReport.UseVisualStyleBackColor = false;
            this.CustomerReport.Click += new System.EventHandler(this.CustomerReport_Click);
            // 
            // SaleReport
            // 
            this.SaleReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.SaleReport.FlatAppearance.BorderSize = 0;
            this.SaleReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaleReport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaleReport.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SaleReport.Location = new System.Drawing.Point(2, 36);
            this.SaleReport.Margin = new System.Windows.Forms.Padding(2);
            this.SaleReport.Name = "SaleReport";
            this.SaleReport.Size = new System.Drawing.Size(149, 28);
            this.SaleReport.TabIndex = 10;
            this.SaleReport.Text = "Satış Raporları";
            this.SaleReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaleReport.UseVisualStyleBackColor = false;
            this.SaleReport.Click += new System.EventHandler(this.SaleReport_Click);
            // 
            // ProductReport
            // 
            this.ProductReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.ProductReport.FlatAppearance.BorderSize = 0;
            this.ProductReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductReport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductReport.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ProductReport.Location = new System.Drawing.Point(2, 4);
            this.ProductReport.Margin = new System.Windows.Forms.Padding(2);
            this.ProductReport.Name = "ProductReport";
            this.ProductReport.Size = new System.Drawing.Size(149, 28);
            this.ProductReport.TabIndex = 9;
            this.ProductReport.Text = "Ürün Raporları";
            this.ProductReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProductReport.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(156, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(824, 526);
            this.panel2.TabIndex = 1;
            // 
            // ReportMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ReportMainPage";
            this.Size = new System.Drawing.Size(980, 526);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CustomerReport;
        private System.Windows.Forms.Button SaleReport;
        private System.Windows.Forms.Button ProductReport;
        private System.Windows.Forms.Panel panel2;
    }
}
