namespace AkbilYonetimiUI
{
    partial class FrmAkbiller
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.anasayfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cikisYAPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.cmbBoxAkbilTipleri = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxAkbilNo = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewAkbiller = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAkbiller)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anasayfaToolStripMenuItem,
            this.cikisYAPToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1047, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // anasayfaToolStripMenuItem
            // 
            this.anasayfaToolStripMenuItem.Name = "anasayfaToolStripMenuItem";
            this.anasayfaToolStripMenuItem.Size = new System.Drawing.Size(139, 34);
            this.anasayfaToolStripMenuItem.Text = "ANASAYFA";
            this.anasayfaToolStripMenuItem.Click += new System.EventHandler(this.anasayfaToolStripMenuItem_Click_1);
            // 
            // cikisYAPToolStripMenuItem
            // 
            this.cikisYAPToolStripMenuItem.Name = "cikisYAPToolStripMenuItem";
            this.cikisYAPToolStripMenuItem.Size = new System.Drawing.Size(129, 34);
            this.cikisYAPToolStripMenuItem.Text = "ÇIKIŞ YAP";
            this.cikisYAPToolStripMenuItem.Click += new System.EventHandler(this.cikisYAPToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.cmbBoxAkbilTipleri);
            this.groupBox1.Controls.Add(this.maskedTextBoxAkbilNo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(50, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(932, 199);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKaydet.Location = new System.Drawing.Point(710, 38);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(200, 149);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "YENİ AKBİL KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // cmbBoxAkbilTipleri
            // 
            this.cmbBoxAkbilTipleri.FormattingEnabled = true;
            this.cmbBoxAkbilTipleri.Items.AddRange(new object[] {
            "Öğrenci Akbili",
            "Tam Akbil",
            "Anne Kartı",
            "65+ Kart",
            "Öğretmen Kart"});
            this.cmbBoxAkbilTipleri.Location = new System.Drawing.Point(165, 121);
            this.cmbBoxAkbilTipleri.Name = "cmbBoxAkbilTipleri";
            this.cmbBoxAkbilTipleri.Size = new System.Drawing.Size(494, 40);
            this.cmbBoxAkbilTipleri.TabIndex = 3;
            // 
            // maskedTextBoxAkbilNo
            // 
            this.maskedTextBoxAkbilNo.Location = new System.Drawing.Point(165, 56);
            this.maskedTextBoxAkbilNo.Mask = "0000000000000000";
            this.maskedTextBoxAkbilNo.Name = "maskedTextBoxAkbilNo";
            this.maskedTextBoxAkbilNo.Size = new System.Drawing.Size(494, 39);
            this.maskedTextBoxAkbilNo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(30, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Akbil Tipi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(30, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Akbil No: ";
            // 
            // dataGridViewAkbiller
            // 
            this.dataGridViewAkbiller.AllowUserToAddRows = false;
            this.dataGridViewAkbiller.AllowUserToDeleteRows = false;
            this.dataGridViewAkbiller.AllowUserToOrderColumns = true;
            this.dataGridViewAkbiller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAkbiller.Location = new System.Drawing.Point(50, 299);
            this.dataGridViewAkbiller.Name = "dataGridViewAkbiller";
            this.dataGridViewAkbiller.ReadOnly = true;
            this.dataGridViewAkbiller.RowHeadersWidth = 62;
            this.dataGridViewAkbiller.RowTemplate.Height = 33;
            this.dataGridViewAkbiller.Size = new System.Drawing.Size(932, 287);
            this.dataGridViewAkbiller.TabIndex = 4;
            // 
            // FrmAkbiller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 611);
            this.Controls.Add(this.dataGridViewAkbiller);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAkbiller";
            this.Text = "FrmAkbiller";
            this.Load += new System.EventHandler(this.FrmAkbiller_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAkbiller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem anasayfaToolStripMenuItem;
        private ToolStripMenuItem cikisYAPToolStripMenuItem;
        private GroupBox groupBox1;
        private Button btnKaydet;
        private ComboBox cmbBoxAkbilTipleri;
        private MaskedTextBox maskedTextBoxAkbilNo;
        private Label label2;
        private Label label1;
        private DataGridView dataGridViewAkbiller;
    }
}