namespace Sy.Forms
{
    partial class ProductForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUurnAdi = new System.Windows.Forms.TextBox();
            this.nUdFiyat = new System.Windows.Forms.NumericUpDown();
            this.nUdKritikStok = new System.Windows.Forms.NumericUpDown();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.lstUrunler = new System.Windows.Forms.ListBox();
            this.lblBilgi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nUdFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUdKritikStok)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fiyat :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kritik Stok :";
            // 
            // txtUurnAdi
            // 
            this.txtUurnAdi.Location = new System.Drawing.Point(169, 22);
            this.txtUurnAdi.Name = "txtUurnAdi";
            this.txtUurnAdi.Size = new System.Drawing.Size(215, 30);
            this.txtUurnAdi.TabIndex = 1;
            this.txtUurnAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nUdFiyat
            // 
            this.nUdFiyat.DecimalPlaces = 2;
            this.nUdFiyat.Location = new System.Drawing.Point(169, 65);
            this.nUdFiyat.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nUdFiyat.Name = "nUdFiyat";
            this.nUdFiyat.Size = new System.Drawing.Size(215, 30);
            this.nUdFiyat.TabIndex = 2;
            this.nUdFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nUdKritikStok
            // 
            this.nUdKritikStok.Location = new System.Drawing.Point(169, 106);
            this.nUdKritikStok.Name = "nUdKritikStok";
            this.nUdKritikStok.Size = new System.Drawing.Size(215, 30);
            this.nUdKritikStok.TabIndex = 2;
            this.nUdKritikStok.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(169, 142);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(215, 57);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(458, 20);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(250, 30);
            this.txtAra.TabIndex = 1;
            this.txtAra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAra.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAra_KeyUp);
            // 
            // lstUrunler
            // 
            this.lstUrunler.FormattingEnabled = true;
            this.lstUrunler.ItemHeight = 25;
            this.lstUrunler.Location = new System.Drawing.Point(458, 56);
            this.lstUrunler.Name = "lstUrunler";
            this.lstUrunler.Size = new System.Drawing.Size(250, 304);
            this.lstUrunler.TabIndex = 4;
            // 
            // lblBilgi
            // 
            this.lblBilgi.AutoSize = true;
            this.lblBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBilgi.ForeColor = System.Drawing.Color.Red;
            this.lblBilgi.Location = new System.Drawing.Point(45, 218);
            this.lblBilgi.Name = "lblBilgi";
            this.lblBilgi.Size = new System.Drawing.Size(318, 25);
            this.lblBilgi.TabIndex = 0;
            this.lblBilgi.Text = "Burada ürünlerin bilgisini vereceğiz:";
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 400);
            this.Controls.Add(this.lstUrunler);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.nUdKritikStok);
            this.Controls.Add(this.nUdFiyat);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.txtUurnAdi);
            this.Controls.Add(this.lblBilgi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            ((System.ComponentModel.ISupportInitialize)(this.nUdFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUdKritikStok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUurnAdi;
        private System.Windows.Forms.NumericUpDown nUdFiyat;
        private System.Windows.Forms.NumericUpDown nUdKritikStok;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.ListBox lstUrunler;
        private System.Windows.Forms.Label lblBilgi;
    }
}