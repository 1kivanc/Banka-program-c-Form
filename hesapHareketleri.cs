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
    public partial class hesapHareketleri : Form
    {
        public hesapHareketleri()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(" server= . ; initial catalog = Banka; integrated security = sspi  ");
        private void hesapHareketleri_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from islemler where musteriID = @p1 ", connection);
            komut.Parameters.AddWithValue("@p1", Form1.musteriID);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            da.Fill(tablo);


            dataGridView1.DataSource = tablo;

            dataGridView1.CellFormatting += dataGridView1_CellFormatting;

        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "islem" && e.Value != null)
            {
                string hareket = e.Value.ToString();
                if (hareket.Contains("Para Geldi") || hareket.Contains("Para Yatırıldı"))
                {
                    e.CellStyle.ForeColor = Color.Green;
                }
                else if (hareket.Contains("Para Çekildi") || hareket.Contains("Transfer Edildi"))
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
            }
        }

    }
}
