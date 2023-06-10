using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Data.SqlClient;


namespace Banka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        SqlConnection connection = new SqlConnection(" server= . ; initial catalog = Banka; integrated security = sspi ");
        public static int musteriID;
        public static string kullaniciAdi;
        public static string adSoyad;
        public static float musteriBakiye = 0.0f;

        private void Form1_Load(object sender, EventArgs e)
        {
            string wallpaperPath = Registry.GetValue(@"HKEY_CURRENT_USER\Control Panel\Desktop", "WallPaper", null).ToString();
            Image wallpaper = Image.FromFile(wallpaperPath);
            this.BackgroundImage = wallpaper;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            opacity(buttons,128);
            groupBoxGiris.Visible = false;
            groupBoxKayit.Visible = false;
            radioButton1.Checked = true;
        }
        

        private void opacity(GroupBox groupBox, int opacity)
        {

            groupBox.BackColor = Color.FromArgb(opacity, groupBox.BackColor);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            groupBoxGiris.Visible=true;
            btnKapat.Visible = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            groupBoxKayit.Visible = true;
            btnKapat.Visible = true;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            if (groupBoxGiris.Visible  || groupBoxKayit.Visible )
            {
                groupBoxGiris.Visible = false;
                groupBoxKayit.Visible = false;
                btnKapat.Visible=false;
            }
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
             kullaniciAdi = txtKullaniciAdi.Text;
            string parola = txtParola.Text;
            bool sonuc = false;

            if (radioButton2.Checked)
            {
                if (kullaniciAdi == "kivanc" && parola == "12345")
                {
                    adminPanel admin = new adminPanel();
                    admin.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı giriş denemesi", "Admin giriş İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                connection.Open();
                SqlCommand komut = new SqlCommand("select * from Musteriler where kullaniciAdi = @p1 and parola = @p2",connection);

                komut.Parameters.AddWithValue("@p1", kullaniciAdi);
                komut.Parameters.AddWithValue("@p2", parola);

                SqlDataReader dataReader = komut.ExecuteReader();
                while (dataReader.Read())
                {
                    kullaniciAdi = dataReader["kullaniciAdi"].ToString();
                    musteriID = int.Parse(dataReader["ID"].ToString());
                    musteriBakiye = float.Parse(dataReader["bakiye"].ToString());
                    adSoyad = dataReader["adSoyad"].ToString();
                    sonuc = true;
                }

                connection.Close();

                if (sonuc)
                {
                    sonuc = false;
                    musteriPanel mPanel = new musteriPanel();
                    mPanel.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı kullanıcı girişi", "kullanıcı giriş işlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            txtKullaniciAdi.Text = "";
            txtParola.Text = "";
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            SqlCommand kullaniciAdiKontrolKomutu = new SqlCommand("SELECT COUNT(*) FROM musteriler WHERE kullaniciAdi = @kullaniciAdi", connection);
            kullaniciAdiKontrolKomutu.Parameters.AddWithValue("@kullaniciAdi", kayitKullaniciAdi.Text);

            connection.Open();
            int kullaniciAdiKayitSayisi = (int)kullaniciAdiKontrolKomutu.ExecuteScalar();
            connection.Close();

            if (kullaniciAdiKayitSayisi > 0)
            {
                MessageBox.Show("Bu kullanıcı adı zaten kayıtlıdır.", "Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                temizle();
                return; 
            }


            SqlCommand komut = new SqlCommand("insert into musteriler (kullaniciAdi,tc,adSoyad,adres,telefon,email,cinsiyet,yas,parola,bakiye,aktif) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", connection);

            komut.Parameters.AddWithValue("@p1", kayitKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@p2", kayitTC.Text);
            komut.Parameters.AddWithValue("@p3", kayitAdSoyad.Text);
            komut.Parameters.AddWithValue("@p4", kayitAdres.Text);
            komut.Parameters.AddWithValue("@p5", kayitTel.Text);
            komut.Parameters.AddWithValue("@p6", kayitEmail.Text);

            if (radioErkek.Checked)
            {
                komut.Parameters.AddWithValue("@p7", "Erkek");
            }else if (radioKadın.Checked)
            {
                komut.Parameters.AddWithValue("@p7", "Kadın");
            }
            else
            {
                MessageBox.Show("Lütfen cinsiyetinizi seçiniz", "Kayıt işlemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            if(int.Parse(kayitYas.Text)>= 18)
            {
                komut.Parameters.AddWithValue("@p8", kayitYas.Text);
            }
            else
            {
                MessageBox.Show("18 yaşından küçük olan kişiler banka hesabı açamaz", "kayıt işlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                temizle();
                return;
            }
            

            if(kayitParola.Text == kayitParolaOnay.Text)
            {
                komut.Parameters.AddWithValue("@p9", kayitParola.Text);
            }else
            {
                MessageBox.Show("Parolalar eşleşmiyor", "Kayıt hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                kayitParola.Text = "";
                kayitParolaOnay.Text = "";
            }
          
            komut.Parameters.AddWithValue("@p10", 0);
            komut.Parameters.AddWithValue("@p11",1);

            if( kayitKullaniciAdi.Text == "" || kayitTC.Text == "" || kayitAdSoyad.Text == ""|| kayitAdres.Text == "" || kayitTel.Text == "" || kayitEmail.Text == "" || kayitYas.Text == "" ||kayitParola.Text == "")
            {
                MessageBox.Show("Tüm alanları doldurunuz", "Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (koumadimOnayladım.Checked)
                {
                    connection.Open();
                    int sonuc = komut.ExecuteNonQuery();
                    connection.Close();
                    if (sonuc == 1)
                    {
                        MessageBox.Show("Yeni Musteri Kaydı oluşturuldu", "musteri kaydı");
                        groupBoxKayit.Visible = false;
                        btnKapat.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Yeni Musteri Kaydı oluşturulamadı", "Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                       
                        
                    }

                    
                }
                else
                {
                    MessageBox.Show("Lütfen Okumadım,onayladım kısmını işaretleyiniz", "Kayıt işlemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

        }
        private void temizle()
        {
            kayitTC.Text = "";
            kayitAdSoyad.Text = "";
            kayitAdres.Text = "";
            kayitTel.Text = "";
            kayitParola.Text = "";
            kayitParolaOnay.Text = "";
            kayitEmail.Text = "";
            kayitKullaniciAdi.Text = "";
            kayitYas.Text = "";
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
