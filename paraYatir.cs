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
    public partial class paraYatir : Form
    {
        public paraYatir()
        {
            InitializeComponent();
        }


        SqlConnection connection = new SqlConnection(" server= . ; initial catalog = Banka; integrated security = sspi ");

        private void button1_Click(object sender, EventArgs e)
        {
            float miktar = float.Parse(maskedTextBox1.Text);
            if( miktar < 5)
            {
                MessageBox.Show("Minimum yatırma tutarı 5$", "Para yatırma işlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SqlCommand komut = new SqlCommand("update musteriler set bakiye += @p1 where ID = @p2", connection);

                komut.Parameters.AddWithValue("@p1", miktar);
                komut.Parameters.AddWithValue("@p2", Form1.musteriID);
                connection.Open();

                int sonuc = komut.ExecuteNonQuery();
                if (sonuc == 1)
                {
                    MessageBox.Show(" Para yatırma işlemi yapıldı", "Para yatırma işlemi", MessageBoxButtons.OK);
                    Form1.musteriBakiye += miktar ;
                    islemKaydet.kaydet(Form1.musteriID, (miktar + " $ Para Yatırıldı"));
                }
                else
                {
                    MessageBox.Show("Para yatırma işlemi başarısız", "Para yatırma işlemi");
                }
                connection.Close();
                maskedTextBox1.Text = "";
            }
        }
    }
}
