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
    public partial class musteriSil : Form
    {
        public musteriSil()
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
                txtKAdi.Text = "";
                txtGender.Text = "";
                txtEmail.Text = "";
                txtAge.Text = "";
                



            }
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete musteriler  where kullaniciAdi=@p1", connection);
            komut.Parameters.AddWithValue("@p1", txtAra.Text);
           

            DialogResult onay = MessageBox.Show("Müşteri kaydını silmek istediğinizden eminmisiniz ?", "Silme onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (onay == DialogResult.No)
            {
                MessageBox.Show("Silme işlemi iptal edildi !", "Silme işlemi iptal");
            }
            else
            {
                connection.Open();

                int sonuc = komut.ExecuteNonQuery();
                if (sonuc == 1)
                {

                    MessageBox.Show("silme işlemi yapıldı", "Silme işlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


                else
                {

                    MessageBox.Show("Silme işlemi yapılamadı", "silme işlemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                }
                connection.Close();
                txtID.Text = "";
                txtTcNo.Text = "";
                txtAdres.Text = "";
                txtBakiye.Text = "";
                txtTel.Text = "";
                txtAdSoyad.Text = "";
                txtKAdi.Text = "";
                txtGender.Text = "";
                txtEmail.Text = "";
                txtAge.Text = "";

            }

        }
    }
}
