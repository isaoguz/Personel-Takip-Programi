namespace Personel_Kayit
{
    partial class FrmKayitOl
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
            this.BtnKayit = new System.Windows.Forms.Button();
            this.TxtKayitSifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtKayitAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnKayit
            // 
            this.BtnKayit.Location = new System.Drawing.Point(200, 137);
            this.BtnKayit.Name = "BtnKayit";
            this.BtnKayit.Size = new System.Drawing.Size(131, 35);
            this.BtnKayit.TabIndex = 11;
            this.BtnKayit.Text = "Kayıt Ol";
            this.BtnKayit.UseVisualStyleBackColor = true;
            this.BtnKayit.Click += new System.EventHandler(this.BtnKayit_Click);
            // 
            // TxtKayitSifre
            // 
            this.TxtKayitSifre.Location = new System.Drawing.Point(200, 102);
            this.TxtKayitSifre.Name = "TxtKayitSifre";
            this.TxtKayitSifre.Size = new System.Drawing.Size(131, 29);
            this.TxtKayitSifre.TabIndex = 9;
            this.TxtKayitSifre.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Şifre: ";
            // 
            // TxtKayitAd
            // 
            this.TxtKayitAd.Location = new System.Drawing.Point(200, 50);
            this.TxtKayitAd.Name = "TxtKayitAd";
            this.TxtKayitAd.Size = new System.Drawing.Size(131, 29);
            this.TxtKayitAd.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kullanıcı Adı: ";
            // 
            // FrmKayitOl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(427, 232);
            this.Controls.Add(this.BtnKayit);
            this.Controls.Add(this.TxtKayitSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtKayitAd);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmKayitOl";
            this.Text = "FrmKayitOl";
            this.Load += new System.EventHandler(this.FrmKayitOl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnKayit;
        private System.Windows.Forms.TextBox TxtKayitSifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtKayitAd;
        private System.Windows.Forms.Label label1;
    }
}