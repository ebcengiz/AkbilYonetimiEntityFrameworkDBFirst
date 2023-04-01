namespace AkbilYonetimiUI
{
    partial class FrmTalimatlar
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.anaMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cikisYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbBoxAkbiller = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYuklenecekTutar = new System.Windows.Forms.TextBox();
            this.btnTalimatKaydet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBekleyenTalimat = new System.Windows.Forms.Label();
            this.checkBoxTumunuGoster = new System.Windows.Forms.CheckBox();
            this.dataGridViewTalimatlar = new System.Windows.Forms.DataGridView();
            this.timerBekleyenTalimat = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.talimatiYukleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.talimatiIptalEtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxYukleme = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTalimatlar)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBoxYukleme.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anaMenuToolStripMenuItem,
            this.cikisYapToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1415, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // anaMenuToolStripMenuItem
            // 
            this.anaMenuToolStripMenuItem.Name = "anaMenuToolStripMenuItem";
            this.anaMenuToolStripMenuItem.Size = new System.Drawing.Size(134, 34);
            this.anaMenuToolStripMenuItem.Text = "Ana Menü";
            this.anaMenuToolStripMenuItem.Click += new System.EventHandler(this.anaMenuToolStripMenuItem_Click);
            // 
            // cikisYapToolStripMenuItem
            // 
            this.cikisYapToolStripMenuItem.Name = "cikisYapToolStripMenuItem";
            this.cikisYapToolStripMenuItem.Size = new System.Drawing.Size(120, 34);
            this.cikisYapToolStripMenuItem.Text = "Çıkış Yap";
            this.cikisYapToolStripMenuItem.Click += new System.EventHandler(this.cikisYapToolStripMenuItem_Click);
            // 
            // cmbBoxAkbiller
            // 
            this.cmbBoxAkbiller.FormattingEnabled = true;
            this.cmbBoxAkbiller.Location = new System.Drawing.Point(53, 91);
            this.cmbBoxAkbiller.Name = "cmbBoxAkbiller";
            this.cmbBoxAkbiller.Size = new System.Drawing.Size(670, 40);
            this.cmbBoxAkbiller.TabIndex = 1;
            this.cmbBoxAkbiller.SelectedIndexChanged += new System.EventHandler(this.cmbBoxAkbiller_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Yüklenecek Tutar:";
            // 
            // txtYuklenecekTutar
            // 
            this.txtYuklenecekTutar.Location = new System.Drawing.Point(230, 41);
            this.txtYuklenecekTutar.Name = "txtYuklenecekTutar";
            this.txtYuklenecekTutar.Size = new System.Drawing.Size(203, 39);
            this.txtYuklenecekTutar.TabIndex = 3;
            // 
            // btnTalimatKaydet
            // 
            this.btnTalimatKaydet.Location = new System.Drawing.Point(455, 41);
            this.btnTalimatKaydet.Name = "btnTalimatKaydet";
            this.btnTalimatKaydet.Size = new System.Drawing.Size(209, 39);
            this.btnTalimatKaydet.TabIndex = 4;
            this.btnTalimatKaydet.Text = "TALİMATI KAYDET";
            this.btnTalimatKaydet.UseVisualStyleBackColor = true;
            this.btnTalimatKaydet.Click += new System.EventHandler(this.btnTalimatKaydet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(1004, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bekleyen Talimat";
            // 
            // lblBekleyenTalimat
            // 
            this.lblBekleyenTalimat.AutoSize = true;
            this.lblBekleyenTalimat.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBekleyenTalimat.ForeColor = System.Drawing.Color.Red;
            this.lblBekleyenTalimat.Location = new System.Drawing.Point(1082, 156);
            this.lblBekleyenTalimat.Name = "lblBekleyenTalimat";
            this.lblBekleyenTalimat.Size = new System.Drawing.Size(58, 67);
            this.lblBekleyenTalimat.TabIndex = 6;
            this.lblBekleyenTalimat.Text = "0";
            // 
            // checkBoxTumunuGoster
            // 
            this.checkBoxTumunuGoster.AutoSize = true;
            this.checkBoxTumunuGoster.Location = new System.Drawing.Point(53, 260);
            this.checkBoxTumunuGoster.Name = "checkBoxTumunuGoster";
            this.checkBoxTumunuGoster.Size = new System.Drawing.Size(206, 36);
            this.checkBoxTumunuGoster.TabIndex = 7;
            this.checkBoxTumunuGoster.Text = "Tümünü Göster";
            this.checkBoxTumunuGoster.UseVisualStyleBackColor = true;
            this.checkBoxTumunuGoster.CheckedChanged += new System.EventHandler(this.checkBoxTumunuGoster_CheckedChanged);
            // 
            // dataGridViewTalimatlar
            // 
            this.dataGridViewTalimatlar.AllowUserToAddRows = false;
            this.dataGridViewTalimatlar.AllowUserToDeleteRows = false;
            this.dataGridViewTalimatlar.AllowUserToOrderColumns = true;
            this.dataGridViewTalimatlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTalimatlar.Location = new System.Drawing.Point(43, 321);
            this.dataGridViewTalimatlar.Name = "dataGridViewTalimatlar";
            this.dataGridViewTalimatlar.ReadOnly = true;
            this.dataGridViewTalimatlar.RowHeadersWidth = 62;
            this.dataGridViewTalimatlar.RowTemplate.Height = 33;
            this.dataGridViewTalimatlar.Size = new System.Drawing.Size(1360, 218);
            this.dataGridViewTalimatlar.TabIndex = 8;
            // 
            // timerBekleyenTalimat
            // 
            this.timerBekleyenTalimat.Tick += new System.EventHandler(this.timerBekleyenTalimat_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.talimatiYukleToolStripMenuItem,
            this.talimatiIptalEtToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(249, 101);
            // 
            // talimatiYukleToolStripMenuItem
            // 
            this.talimatiYukleToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.talimatiYukleToolStripMenuItem.Image = global::AkbilYonetimiUI.Properties.Resources.tick;
            this.talimatiYukleToolStripMenuItem.Name = "talimatiYukleToolStripMenuItem";
            this.talimatiYukleToolStripMenuItem.Size = new System.Drawing.Size(248, 32);
            this.talimatiYukleToolStripMenuItem.Text = "Talimatı Yükle";
            this.talimatiYukleToolStripMenuItem.Click += new System.EventHandler(this.talimatiYukleToolStripMenuItem_Click);
            // 
            // talimatiIptalEtToolStripMenuItem
            // 
            this.talimatiIptalEtToolStripMenuItem.Image = global::AkbilYonetimiUI.Properties.Resources.iptal;
            this.talimatiIptalEtToolStripMenuItem.Name = "talimatiIptalEtToolStripMenuItem";
            this.talimatiIptalEtToolStripMenuItem.Size = new System.Drawing.Size(248, 32);
            this.talimatiIptalEtToolStripMenuItem.Text = "Talimatı İptal Et";
            this.talimatiIptalEtToolStripMenuItem.Click += new System.EventHandler(this.talimatiIptalEtToolStripMenuItem_Click);
            // 
            // groupBoxYukleme
            // 
            this.groupBoxYukleme.Controls.Add(this.label1);
            this.groupBoxYukleme.Controls.Add(this.txtYuklenecekTutar);
            this.groupBoxYukleme.Controls.Add(this.btnTalimatKaydet);
            this.groupBoxYukleme.Location = new System.Drawing.Point(53, 146);
            this.groupBoxYukleme.Name = "groupBoxYukleme";
            this.groupBoxYukleme.Size = new System.Drawing.Size(670, 97);
            this.groupBoxYukleme.TabIndex = 10;
            this.groupBoxYukleme.TabStop = false;
            // 
            // FrmTalimatlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 576);
            this.Controls.Add(this.groupBoxYukleme);
            this.Controls.Add(this.dataGridViewTalimatlar);
            this.Controls.Add(this.checkBoxTumunuGoster);
            this.Controls.Add(this.lblBekleyenTalimat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbBoxAkbiller);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmTalimatlar";
            this.Text = "FrmTalimatlar";
            this.Load += new System.EventHandler(this.FrmTalimatlar_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTalimatlar)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBoxYukleme.ResumeLayout(false);
            this.groupBoxYukleme.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem anaMenuToolStripMenuItem;
        private ToolStripMenuItem cikisYapToolStripMenuItem;
        private ComboBox cmbBoxAkbiller;
        private Label label1;
        private TextBox txtYuklenecekTutar;
        private Button btnTalimatKaydet;
        private Label label2;
        private Label lblBekleyenTalimat;
        private CheckBox checkBoxTumunuGoster;
        private DataGridView dataGridViewTalimatlar;
        private System.Windows.Forms.Timer timerBekleyenTalimat;
        private ContextMenuStrip contextMenuStrip1;
        private GroupBox groupBoxYukleme;
        private ToolStripMenuItem talimatiYukleToolStripMenuItem;
        private ToolStripMenuItem talimatiIptalEtToolStripMenuItem;
    }
}