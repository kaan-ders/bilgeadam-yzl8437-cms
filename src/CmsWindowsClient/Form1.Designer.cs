namespace CmsWindowsClient
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbDergi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSayi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMakale = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMakale = new System.Windows.Forms.TextBox();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbDergi
            // 
            this.cbDergi.DisplayMember = "Name";
            this.cbDergi.FormattingEnabled = true;
            this.cbDergi.Location = new System.Drawing.Point(12, 41);
            this.cbDergi.Name = "cbDergi";
            this.cbDergi.Size = new System.Drawing.Size(627, 28);
            this.cbDergi.TabIndex = 0;
            this.cbDergi.ValueMember = "Id";
            this.cbDergi.SelectedIndexChanged += new System.EventHandler(this.cbDergi_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dergiler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sayılar";
            // 
            // cbSayi
            // 
            this.cbSayi.DisplayMember = "No";
            this.cbSayi.FormattingEnabled = true;
            this.cbSayi.Location = new System.Drawing.Point(12, 123);
            this.cbSayi.Name = "cbSayi";
            this.cbSayi.Size = new System.Drawing.Size(627, 28);
            this.cbSayi.TabIndex = 3;
            this.cbSayi.ValueMember = "Id";
            this.cbSayi.SelectedIndexChanged += new System.EventHandler(this.cbSayi_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Makaleler";
            // 
            // cbMakale
            // 
            this.cbMakale.DisplayMember = "Baslik";
            this.cbMakale.FormattingEnabled = true;
            this.cbMakale.Location = new System.Drawing.Point(13, 209);
            this.cbMakale.Name = "cbMakale";
            this.cbMakale.Size = new System.Drawing.Size(627, 28);
            this.cbMakale.TabIndex = 5;
            this.cbMakale.ValueMember = "Id";
            this.cbMakale.SelectedIndexChanged += new System.EventHandler(this.cbMakale_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Makale : ";
            // 
            // txtMakale
            // 
            this.txtMakale.Location = new System.Drawing.Point(16, 300);
            this.txtMakale.Multiline = true;
            this.txtMakale.Name = "txtMakale";
            this.txtMakale.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMakale.Size = new System.Drawing.Size(624, 239);
            this.txtMakale.TabIndex = 7;
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Location = new System.Drawing.Point(86, 264);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(39, 20);
            this.lblBaslik.TabIndex = 8;
            this.lblBaslik.Text = "-----";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 551);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.txtMakale);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbMakale);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbSayi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbDergi);
            this.Name = "Form1";
            this.Text = "Dergi Oku";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbDergi;
        private Label label1;
        private Label label2;
        private ComboBox cbSayi;
        private Label label3;
        private ComboBox cbMakale;
        private Label label4;
        private TextBox txtMakale;
        private Label lblBaslik;
    }
}