using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProjeErtev
{
    public class Db
    {
        public SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["ertevprojeDB"].ConnectionString);

        public void ac()
        {
            baglanti.Open();
        }

        public void kapat()
        {
            baglanti.Close();
        }
    }
}