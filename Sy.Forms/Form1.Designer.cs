namespace Sy.Forms
{
    partial class Form1
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
            this.btnGrisiYap = new System.Windows.Forms.Button();
            this.gbGiris = new System.Windows.Forms.GroupBox();
            this.btnKayıtOl = new System.Windows.Forms.Button();
            this.lblGirisBilgi = new System.Windows.Forms.Label();
            this.gbGiris.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGrisiYap
            // 
            this.btnGrisiYap.Location = new System.Drawing.Point(8, 23);
            this.btnGrisiYap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGrisiYap.Name = "btnGrisiYap";
            this.btnGrisiYap.Size = new System.Drawing.Size(112, 71);
            this.btnGrisiYap.TabIndex = 0;
            this.btnGrisiYap.Text = "Giriş Yap";
            this.btnGrisiYap.UseVisualStyleBackColor = true;
            this.btnGrisiYap.Click += new System.EventHandler(this.btnGrisiYap_Click);
            // 
            // gbGiris
            // 
            this.gbGiris.Controls.Add(this.btnKayıtOl);
            this.gbGiris.Controls.Add(this.btnGrisiYap);
            this.gbGiris.Location = new System.Drawing.Point(16, 39);
            this.gbGiris.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbGiris.Name = "gbGiris";
            this.gbGiris.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbGiris.Size = new System.Drawing.Size(275, 119);
            this.gbGiris.TabIndex = 1;
            this.gbGiris.TabStop = false;
            this.gbGiris.Text = "Giriş";
            // 
            // btnKayıtOl
            // 
            this.btnKayıtOl.Location = new System.Drawing.Point(145, 23);
            this.btnKayıtOl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKayıtOl.Name = "btnKayıtOl";
            this.btnKayıtOl.Size = new System.Drawing.Size(112, 71);
            this.btnKayıtOl.TabIndex = 0;
            this.btnKayıtOl.Text = "Kayıt Ol";
            this.btnKayıtOl.UseVisualStyleBackColor = true;
            this.btnKayıtOl.Click += new System.EventHandler(this.btnKayıtOl_Click);
            // 
            // lblGirisBilgi
            // 
            this.lblGirisBilgi.AutoSize = true;
            this.lblGirisBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGirisBilgi.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblGirisBilgi.Location = new System.Drawing.Point(377, 26);
            this.lblGirisBilgi.Name = "lblGirisBilgi";
            this.lblGirisBilgi.Size = new System.Drawing.Size(190, 22);
            this.lblGirisBilgi.TabIndex = 2;
            this.lblGirisBilgi.Text = "Hoşgeldin Kamil Bey...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 242);
            this.Controls.Add(this.lblGirisBilgi);
            this.Controls.Add(this.gbGiris);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.gbGiris.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGrisiYap;
        private System.Windows.Forms.GroupBox gbGiris;
        private System.Windows.Forms.Button btnKayıtOl;
        private System.Windows.Forms.Label lblGirisBilgi;
    }
}

