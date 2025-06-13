using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CommercialAutomation
{
    internal class SqlBaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan =
                new SqlConnection(
                    @"Data Source=SABBATH\SQLEXPRESS;Initial Catalog=DboCommericalAutomation;Integrated Security=True;Encrypt=False");
            baglan.Open();
            return baglan;
        }

    }
}
