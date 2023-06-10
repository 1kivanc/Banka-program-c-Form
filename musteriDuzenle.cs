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
    public partial class musteriDuzenle : Form
    {
        public musteriDuzenle()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(" server= . ; initial catalog = Banka; integrated security = sspi  ");

        private void btnAra_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from musteriler where kullaniciAdi=@p1 ", connection);
            komut.Parameters.AddWithValue("@p1", txtAra.Text);


            connection.Open();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                txtID.Text = dr["ID"].ToString();
                txtTcNo.Text = dr["tc"].ToString();
                txtAdSoyad.Text = dr["adSoyad"].ToString();
                txtAdres.Text = dr["adres"].ToString();
                txtTel.Text = dr["telefon"].ToString();
                txtEmail.Text = dr["email"].ToString();
                txtAge.Text = dr["yas"].ToString();
                txtGender.Text = dr["cinsiyet"].ToString();
                txtKAdi.Text = dr["kullaniciAdi"].ToString();
                txtBakiye.Text = dr["bakiye"].ToString();

            }


            else
            {

                MessageBox.Show(txtAra.Text + " Numaralı kayıt bulunamadı", "Kayıt arama", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtID.Text = "";
                txtTcNo.Text = "";
                txtAdres.Text = "";
                txtBakiye.Text = "";
                txtTel.Text = "";
                txtAdSoyad.Text = "";



            }
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update musteriler set adSoyad=@p1,adres=@p2 ,telefon=@p3, email=@p5 , kullaniciAdi=@p6  where kullaniciAdi=@p4 ", connection);
            komut.Parameters.AddWithValue("@p4", txtAra.Text);
            komut.Parameters.AddWithValue("@p1", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@p2", txtAdres.Text);
            komut.Parameters.AddWithValue("@p3", txtTel.Text);
            komut.Parameters.AddWithValue("@p5",txtEmail.Text);
            komut.Parameters.AddWithValue("@p6", txtKAdi.Text);


            connection.Open();
            int sonuc = komut.ExecuteNonQuery();
            if (sonuc == 1)
            {

                MessageBox.Show("kayıt güncellendi", "Kayıt güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


            else
            {

                MessageBox.Show(txtAra.Text + " Numaralı kayıt bulunamadı", "Kayıt arama", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtID.Text = "";
                txtTcNo.Text = "";
                txtAdres.Text = "";
                txtBakiye.Text = "";
                txtTel.Text = "";
                txtEmail.Text = "";
                txtAdSoyad.Text = "";



            }
            connection.Close();
        }
    }
}
