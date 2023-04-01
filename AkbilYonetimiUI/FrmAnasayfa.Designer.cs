namespace AkbilYonetimiUI
{
    partial class FrmAnasayfa
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
            this.btnAkbil = new System.Windows.Forms.Button();
            this.btnTalimat = new System.Windows.Forms.Button();
            this.btnAyarlar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAkbil
            // 
            this.btnAkbil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAkbil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAkbil.ForeColor = System.Drawing.Color.White;
            this.btnAkbil.Location = new System.Drawing.Point(90, 37);
            this.btnAkbil.Name = "btnAkbil";
            this.btnAkbil.Size = new System.Drawing.Size(151, 84);
            this.btnAkbil.TabIndex = 0;
            this.btnAkbil.Text = "AKBİL İŞLEMLERİ";
            this.btnAkbil.UseVisualStyleBackColor = false;
            this.btnAkbil.Click += new System.EventHandler(this.btnAkbil_Click);
            // 
            // btnTalimat
            // 
            this.btnTalimat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTalimat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTalimat.ForeColor = System.Drawing.Color.White;
            this.btnTalimat.Location = new System.Drawing.Point(90, 145);
            this.btnTalimat.Name = "btnTalimat";
            this.btnTalimat.Size = new System.Drawing.Size(151, 84);
            this.btnTalimat.TabIndex = 1;
            this.btnTalimat.Text = "TALİMAT İŞLEMLERİ";
            this.btnTalimat.UseVisualStyleBackColor = false;
            this.btnTalimat.Click += new System.EventHandler(this.btnTalimat_Click);
            // 
            // btnAyarlar
            // 
            this.btnAyarlar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAyarlar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAyarlar.ForeColor = System.Drawing.Color.White;
            this.btnAyarlar.Location = new System.Drawing.Point(90, 255);
            this.btnAyarlar.Name = "btnAyarlar";
            this.btnAyarlar.Size = new System.Drawing.Size(151, 84);
            this.btnAyarlar.TabIndex = 2;
            this.btnAyarlar.Text = "AYARLAR";
            this.btnAyarlar.UseVisualStyleBackColor = false;
            this.btnAyarlar.Click += new System.EventHandler(this.btnAyarlar_Click);
            // 
            // FrmAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 390);
            this.Controls.Add(this.btnAyarlar);
            this.Controls.Add(this.btnTalimat);
            this.Controls.Add(this.btnAkbil);
            this.Name = "FrmAnasayfa";
            this.Text = "FrmAnasayfa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAnasayfa_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAkbil;
        private Button btnTalimat;
        private Button btnAyarlar;
    }
}