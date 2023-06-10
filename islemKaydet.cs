using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka
{
    internal class islemKaydet
    {
        public static void kaydet(int musteriID, string msj)
        {
            SqlConnection connection = new SqlConnection(" server= . ; initial catalog = Banka; integrated security = sspi  ");
            SqlCommand komut = new SqlCommand("insert into islemler (musteriID, islem, tarih ) values (@p1, @p2 , @p3) ", connection);
            komut.Parameters.AddWithValue("@p1", musteriID);
            komut.Parameters.AddWithValue("@p2", msj);
            komut.Parameters.AddWithValue("@p3", DateTime.Now);
            connection.Open();
            komut.ExecuteNonQuery();
            connection.Close();

        }
    }
}
