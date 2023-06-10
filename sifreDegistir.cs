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
    public partial class sifreDegistir : Form
    {
        public sifreDegistir()
        {
            InitializeComponent();
        }


        SqlConnection connection = new SqlConnection(" server= . ; initial catalog = Banka; integrated security = sspi  ");

        static string eskiSifre = "";

        private void sifreDegistir_Load(object sender, EventArgs e)
        {
            load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtEski.Text == "" || txtYeni.Text == "")
            {
                MessageBox.Show("lütfen gerekli alanları boş bırakmayınız", "Şifre değiştirme işlemi");
            }
            else if (txtYeni.Text.Length < 4)
            {
                MessageBox.Show("En az 4 karakter uzunluğunda şifre belirleyiniz", "şifre değiştirme işlemi");
            }


            else
            {
                if (txtEski.Text == eskiSifre)
                {
                    SqlCommand komut = new SqlCommand("update musteriler set parola = @p1 where ID = @p2", connection);

                    komut.Parameters.AddWithValue("@p1", txtYeni.Text);
                    komut.Parameters.AddWithValue("@p2", Form1.musteriID);
                    connection.Open();

                    int sonuc = komut.ExecuteNonQuery();
                    if (sonuc == 1)
                    {
                        MessageBox.Show("Şifre değiştirme işlemi başarlı", "şifre değiştirme işlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        islemKaydet.kaydet(Form1.musteriID, "Şifre Değiştirildi");
                      

                    }
                    else
                    {
                        MessageBox.Show("Şifre değiştirme işlemi başarısız", "Para çekme işlemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    connection.Close();
                    txtEski.Text = "";
                    txtYeni.Text = "";
                    load();

                }
                else
                {
                    MessageBox.Show("Giridğin eski şifre mevcut şifre ile uyumsuz", "şifre değiştirme işlemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
        private void load()
        {
            SqlCommand komut = new SqlCommand("select * from musteriler where ID=@p1", connection);
            komut.Parameters.AddWithValue("@p1", Form1.musteriID);


            connection.Open();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                eskiSifre = dr["parola"].ToString();

            }

            else
            {

                MessageBox.Show("şifre alma başarısız");

            }
            connection.Close();
        }

    }
}
