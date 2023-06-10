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
    public partial class paraTransferi : Form
    {
        public paraTransferi()
        {
            InitializeComponent();
        }

        static string AdSoyad = "";

        private void paraTransferi_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }


        SqlConnection connection = new SqlConnection(" server= . ; initial catalog = Banka; integrated security = sspi  ");
        private void button1_Click(object sender, EventArgs e)
        {
            float sayi = float.Parse(txtMiktar.Text);

            if (sayi > Form1.musteriBakiye)
            {
                MessageBox.Show("Yetersiz bakiye", "Havale işlemi");
            }
            else
            {
                if(int.TryParse(txtNo.Text , out int deger))
                {
                    SqlCommand komut = new SqlCommand("update musteriler set bakiye= bakiye - @p1 where ID = @p2", connection);
                    komut.Parameters.AddWithValue("@p1", sayi);
                    komut.Parameters.AddWithValue("@p2", Form1.musteriID);



                    SqlCommand komut2 = new SqlCommand("update musteriler set bakiye = bakiye+@p3 where ID = @p4", connection);
                    komut2.Parameters.AddWithValue("@p3", txtMiktar.Text);
                    komut2.Parameters.AddWithValue("@p4", txtNo.Text);

                    if (sayi < 20)
                    {
                        MessageBox.Show("Lütfen 10 Tl ve üzeri giriniz!", "Düşük Miktar");
                    }
                    else
                    {
                        connection.Open();

                        int sonuc1 = komut2.ExecuteNonQuery();
                        connection.Close();
                        if (sonuc1 == 1)
                        {
                            connection.Open();

                            komut.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show("Havele işlemi gerçekleştirildi", "Havale / EFT", MessageBoxButtons.OK);
                            Form1.musteriBakiye -= sayi;
                            islemKaydet.kaydet(Form1.musteriID, (sayi + " $ Transfer Edildi"));
                            islemKaydet.kaydet(int.Parse(txtNo.Text), (sayi + " $ Para Geldi"));


                        }
                        else
                        {
                            MessageBox.Show("Alıcı Hesap No Hatalı !", "Havale / EFT hatası", MessageBoxButtons.OK);

                        }
                    }

                }
                else
                {
                    SqlCommand komut = new SqlCommand("update musteriler set bakiye= bakiye - @p1 where kullaniciAdi = @p2", connection);
                    komut.Parameters.AddWithValue("@p1", sayi);
                    komut.Parameters.AddWithValue("@p2", Form1.kullaniciAdi);



                    SqlCommand komut2 = new SqlCommand("update musteriler set bakiye = bakiye+@p3 where kullaniciAdi = @p4", connection);
                    komut2.Parameters.AddWithValue("@p3", txtMiktar.Text);
                    komut2.Parameters.AddWithValue("@p4", txtNo.Text);


                    if (sayi < 20)
                    {
                        MessageBox.Show("Lütfen 10 Tl ve üzeri giriniz!", "Düşük Miktar");
                    }
                    else
                    {
                        connection.Open();

                        int sonuc1 = komut2.ExecuteNonQuery();
                        connection.Close();
                        if (sonuc1 == 1)
                        {
                            connection.Open();

                            komut.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show("Havele işlemi gerçekleştirildi", "Havale / EFT", MessageBoxButtons.OK);
                            Form1.musteriBakiye -= sayi;
                            islemKaydet.kaydet(Form1.musteriID, (sayi + " $ Transfer Edildi"));
                            islemKaydet.kaydet(int.Parse(txtNo.Text), (sayi + " $ Para Geldi"));

                        }
                        else
                        {
                            MessageBox.Show("Alıcı Hesap No Hatalı !", "Havale / EFT hatası", MessageBoxButtons.OK);

                        }
                    }
                }






            }
            txtMiktar.Text = "";
            txtDogrula.Text = "";
            txtAdSoyad.Text = "";
            txtNo.Text = "";
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int id;
            string kullaniciAdi = txtNo.Text;

            if (int.TryParse(txtNo.Text, out id))
            {
                SqlCommand komut = new SqlCommand("SELECT * FROM musteriler WHERE ID = @p1 ", connection);
                komut.Parameters.AddWithValue("@p1", txtNo.Text);
            

                connection.Open();
                SqlDataReader dr = komut.ExecuteReader();

                if (dr.Read())
                {
                    AdSoyad = dr["adSoyad"].ToString();
                    txtAdSoyad.Text = SansurleIsim(dr["adSoyad"].ToString());
                }
                else
                {
                    MessageBox.Show("Kayıt bulunamadı", "Kayıt arama", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAdSoyad.Text = "";
                }

                connection.Close();
            }
            else if(!(int.TryParse(txtNo.Text, out id)))
            {
                SqlCommand komut = new SqlCommand("SELECT * FROM musteriler WHERE kullaniciAdi = @p1 ", connection);
                komut.Parameters.AddWithValue("@p1", txtNo.Text);


                connection.Open();
                SqlDataReader dr = komut.ExecuteReader();

                if (dr.Read())
                {
                    AdSoyad = dr["adSoyad"].ToString();
                    txtAdSoyad.Text = SansurleIsim(dr["adSoyad"].ToString());
                }
                else
                {
                    MessageBox.Show("Kayıt bulunamadı", "Kayıt arama", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAdSoyad.Text = "";
                }

                connection.Close();
            }
            else
            {

                MessageBox.Show("kayıt bulunamadı", "Kayıt arama", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtAdSoyad.Text = "";



            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtDogrula.Text == AdSoyad)
            {
                MessageBox.Show("Doğrulama Başarlı", "Doğrulama işlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button1.Enabled = true;
            }
            else
            {
                MessageBox.Show("Doğrulama işlemi başarısız hesap no veya ad soyadı Doğru girdiğinizden emin olunuz", "Doğrulama işlemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        static string SansurleIsim(string isim)
        {
            string[] kelimeler = isim.Split(' ');
            for (int i = 0; i < kelimeler.Length; i++)
            {
                string kelime = kelimeler[i];
                if (kelime.Length > 2)
                {
                    string sansurluKelime = $"{kelime.Substring(0, 1)}{'*'.ToString().PadRight(kelime.Length - 1, '*')}";
                    kelimeler[i] = sansurluKelime;
                }
            }
            return string.Join(" ", kelimeler);
        }
    }
}
