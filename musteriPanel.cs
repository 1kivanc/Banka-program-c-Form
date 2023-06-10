using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Data.SqlClient;

namespace Banka
{
    public partial class musteriPanel : Form
    {
        public musteriPanel()
        {
            InitializeComponent();
        }

        private void musteriPanel_Load(object sender, EventArgs e)
        {
            string wallpaperPath = Registry.GetValue(@"HKEY_CURRENT_USER\Control Panel\Desktop", "WallPaper", null).ToString();
            Image wallpaper = Image.FromFile(wallpaperPath);
            this.BackgroundImage = wallpaper;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            hosgeldiniz.Text = "Hoşgeldiniz sayın " + " " + Form1.adSoyad;
            lblIBAN.Text = Form1.musteriID.ToString();
            lblkullanici.Text = Form1.kullaniciAdi;

            opacity(groupBox1, 128);
        }

        private void opacity(GroupBox groupBox, int opacity)
        {

            groupBox.BackColor = Color.FromArgb(opacity, groupBox.BackColor);

        }

        private void btnParaYatir_Click(object sender, EventArgs e)
        {
            paraYatir yatir = new paraYatir();
            yatir.Show();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            paraCek cek = new paraCek();
            cek.Show();
        }

        private void btnBakiye_Click(object sender, EventArgs e)
        {
            bakiye bakiye = new bakiye();
            bakiye.Show();
        }

        private void btnParaTransfer_Click(object sender, EventArgs e)
        {
            paraTransferi trasfer = new paraTransferi();
            trasfer.Show();
        }

        private void btnSifre_Click(object sender, EventArgs e)
        {
            sifreDegistir sifre = new sifreDegistir();
            sifre.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {

            Form frm = new Form1();
            frm.Show();
            this.Close();
        }

        private void btnHesapHareket_Click(object sender, EventArgs e)
        {
            hesapHareketleri hareket = new hesapHareketleri();
            hareket.Show();
        }
    }
}
