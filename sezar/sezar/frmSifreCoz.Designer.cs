
namespace sezar
{
    partial class frmSifreCoz
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
            this.txtSifreliMetin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMetin = new System.Windows.Forms.TextBox();
            this.txtOffset = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.chkOffsetDegeriBiliniyormu = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtSifreliMetin
            // 
            this.txtSifreliMetin.Location = new System.Drawing.Point(10, 74);
            this.txtSifreliMetin.Multiline = true;
            this.txtSifreliMetin.Name = "txtSifreliMetin";
            this.txtSifreliMetin.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtSifreliMetin.Size = new System.Drawing.Size(439, 135);
            this.txtSifreliMetin.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(452, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Şifresiz Metin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Şifreli Metin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Offset : ";
            // 
            // txtMetin
            // 
            this.txtMetin.Location = new System.Drawing.Point(455, 74);
            this.txtMetin.Multiline = true;
            this.txtMetin.Name = "txtMetin";
            this.txtMetin.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtMetin.Size = new System.Drawing.Size(439, 135);
            this.txtMetin.TabIndex = 10;
            // 
            // txtOffset
            // 
            this.txtOffset.Location = new System.Drawing.Point(10, 26);
            this.txtOffset.Name = "txtOffset";
            this.txtOffset.Size = new System.Drawing.Size(100, 20);
            this.txtOffset.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(374, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Şifreyi Çöz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chkOffsetDegeriBiliniyormu
            // 
            this.chkOffsetDegeriBiliniyormu.AutoSize = true;
            this.chkOffsetDegeriBiliniyormu.Location = new System.Drawing.Point(116, 29);
            this.chkOffsetDegeriBiliniyormu.Name = "chkOffsetDegeriBiliniyormu";
            this.chkOffsetDegeriBiliniyormu.Size = new System.Drawing.Size(148, 17);
            this.chkOffsetDegeriBiliniyormu.TabIndex = 15;
            this.chkOffsetDegeriBiliniyormu.Text = "Offset Değerini Bilmiyorum";
            this.chkOffsetDegeriBiliniyormu.UseVisualStyleBackColor = true;
            this.chkOffsetDegeriBiliniyormu.CheckedChanged += new System.EventHandler(this.chkOffsetDegeriBiliniyormu_CheckedChanged);
            // 
            // frmSifreCoz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 269);
            this.Controls.Add(this.chkOffsetDegeriBiliniyormu);
            this.Controls.Add(this.txtSifreliMetin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMetin);
            this.Controls.Add(this.txtOffset);
            this.Controls.Add(this.button1);
            this.Name = "frmSifreCoz";
            this.Text = "Şifre Çöz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSifreliMetin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMetin;
        private System.Windows.Forms.TextBox txtOffset;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chkOffsetDegeriBiliniyormu;
    }
}