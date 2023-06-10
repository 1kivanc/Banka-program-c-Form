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

namespace Banka
{
    public partial class musteriOlustur : Form
    {
        public musteriOlustur()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(" server= . ; initial catalog = Banka; integrated security = sspi  ");
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into musteriler (tc,adSoyad,adres,telefon,parola,bakiye,aktif,email,cinsiyet,yas,kullaniciAdi ) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", connection);
            komut.Parameters.AddWithValue("@p1", txtTcNo.Text);
            komut.Parameters.AddWithValue("@p2", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@p3", txtAdres.Text);
            komut.Parameters.AddWithValue("@p4", txtTel.Text);
            string password = GeneratePassword();
            komut.Parameters.AddWithValue("@p5", password);
            komut.Parameters.AddWithValue("@p6", 0);
            komut.Parameters.AddWithValue("@p7", 1);
            komut.Parameters.AddWithValue("@p8", txtEmail.Text);
            komut.Parameters.AddWithValue("@p9", txtGender.Text);
            komut.Parameters.AddWithValue("@p10", int.Parse(txtAge.Text));
            komut.Parameters.AddWithValue("@p11", txtKAdi.Text);


            if (txtTcNo.Text == "" || txtAdSoyad.Text == "" || txtAdres.Text == "" || txtTel.Text == "" )
            {
                MessageBox.Show("Tüm alanları doldurunuz", "Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                connection.Open();
                int sonuc = komut.ExecuteNonQuery();
                connection.Close();
                if (sonuc == 1)
                {
                    MessageBox.Show("Yeni Musteri Kaydı oluşturuldu tek kullanımlık parola: "+password, "musteri kaydı");
                    geciciParola.Text = "Geçiçi parolanız : "+password;

                }
                else
                {
                    MessageBox.Show("Yeni Musteri Kaydı oluşturulamadı", "Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }


            txtAge.Text = "";
            txtEmail.Text = "";
            txtGender.Text = "";
            txtKAdi.Text = "";
            txtTcNo.Text = "";
            txtAdSoyad.Text = "";
            txtAdres.Text = "";
            txtTel.Text = "";
           

        }
        private string GeneratePassword()
        {
            Random random = new Random();
            const string chars = "0123456789";
            string password = new string(Enumerable.Repeat(chars, 4)
              .Select(s => s[random.Next(s.Length)]).ToArray());
            return password;
        }

       
    }
    }

