using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AkbilYonetimiVeriKatmani;
using AkbilYonetimiIsKatmani;
using AkbilYonetimiVeriKatmani.Models;
using Microsoft.EntityFrameworkCore;

namespace AkbilYonetimiUI
{
    public partial class FrmKayitOl : Form
    {
        AkbildbContext context = new AkbildbContext();
        
        public FrmKayitOl()
        {
            InitializeComponent(); // İnşa etmek
        }

        private void FrmKayitOl_Load(object sender, EventArgs e)
        {
            #region Ayarlar
            txtSifre.PasswordChar = '*';
            dtpDogumTarihi.MaxDate = new DateTime(2016, 1, 1);
            dtpDogumTarihi.Value = new DateTime(2016, 1, 1);
            dtpDogumTarihi.Format = DateTimePickerFormat.Short;

            #endregion
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            try
            {
                btnKayitOl.Enabled = false;
                btnGirisYap.Enabled = false;

                foreach (var item in Controls)
                {
                    if (item is TextBox && string.IsNullOrEmpty(((TextBox)item).Text))
                    {
                        MessageBox.Show("Zorunlu alanları doldurunuz!");
                        btnKayitOl.Enabled = true;
                        btnGirisYap.Enabled = true;
                        return;
                    }
                } // foreach bitti

                // Bu emailden sistemde var mı ?

                if (context.Kullanicilars.FirstOrDefault(x=> x.Email==txtEmail.Text.Trim())!=null)
                {
                    MessageBox.Show("Bu emaille sistemde kayıt mevcuttur!");
                    btnKayitOl.Enabled = true;
                    btnGirisYap.Enabled = true;
                    return;
                }
                Kullanicilar yeniKullanici = new Kullanicilar()
                {
                    EklenmeTarihi=DateTime.Now,
                    Ad=txtIsim.Text.Trim(),
                    Soyad=txtSoyisim.Text.Trim(),
                    DogumTarihi=dtpDogumTarihi.Value,
                    Email=txtEmail.Text.Trim(),
                    Parola=GenelIslemler.MD5Encryption(txtSifre.Text.Trim())
                };
                context.Kullanicilars.Add(yeniKullanici);
                if (context.SaveChanges() > 0)
                {
                    MessageBox.Show("Kullanıcı eklendi!");
                    //temizlik
                    foreach (var item in Controls)
                    {
                        if (item is TextBox)
                        {
                            ((TextBox)item).Clear();
                        }
                        if (item is DateTimePicker)
                        {
                            ((DateTimePicker)item).Value = ((DateTimePicker)item).MaxDate;
                        }
                    } // foreach bitti

                  var cevap=  MessageBox.Show("Giriş sayfasına gitmek ister misiniz?","SORU", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if((int)cevap==6)  //(cevap==DialogResult.Yes)
                    {
                        FrmGiris frmg = new FrmGiris();
                        frmg.Email = txtEmail.Text.Trim();
                        this.Hide();
                        frmg.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı ekleme Başarısız oldu!");
                }

                btnKayitOl.Enabled = true;
                btnGirisYap.Enabled = true;
            }
            catch (Exception ex)
            {
                // ex log.txt'ye yazılanacak (loglama)
                MessageBox.Show("Beklenmedik bir hata oluştu! Lütfen tekrar deneyiniz !");
                btnKayitOl.Enabled = true;
                btnGirisYap.Enabled = true;
            }
        }

        private void GirisFormunaGit()
        {
            FrmGiris frmG = new FrmGiris();
            frmG.Email = txtEmail.Text.Trim();
            this.Hide();
            frmG.Show();
        }

        private void FrmKayitOl_FormClosed(object sender, FormClosedEventArgs e)
        {
            GirisFormunaGit();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            GirisFormunaGit();
        }
    }
}
