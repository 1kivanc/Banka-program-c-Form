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
    public partial class paraCek : Form
    {
        public paraCek()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(" server= . ; initial catalog = Banka; integrated security = sspi  ");

        private void button1_Click(object sender, EventArgs e)
        {
            float miktar = float.Parse(maskedTextBox1.Text);
            if (miktar > Form1.musteriBakiye)
            {
                MessageBox.Show("Yetersiz bakiye", "Para çekme işlemi");
            }
            else
            {
                SqlCommand komut = new SqlCommand("update musteriler set bakiye -= @p1 where ID = @p2", connection);

                komut.Parameters.AddWithValue("@p1", miktar);
                komut.Parameters.AddWithValue("@p2", Form1.musteriID);
                connection.Open();

                int sonuc = komut.ExecuteNonQuery();
                if (sonuc == 1)
                {
                    MessageBox.Show(" Para cekme işlemi yapıldı", "Para çekme işlemi", MessageBoxButtons.OK);
                    Form1.musteriBakiye -= miktar;
                    islemKaydet.kaydet(Form1.musteriID, (miktar + " $ Para Çekildi"));


                }
                else
                {
                    MessageBox.Show("Para çekme işlemi başarısız", "Para çekme işlemi");
                }
                connection.Close();
                maskedTextBox1.Text = "";
            }
        }
    }
}
