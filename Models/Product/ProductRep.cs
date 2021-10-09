using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace ProductApp.Models.Product
{
    public static class ProductRep
    {

        private static string connStr = "Data Source = SQL5061.site4now.net; Initial Catalog = db_a7966a_ion; User Id = db_a7966a_ion_admin; Password=Gorb_bc24";

        public static string AddData(string name, double price)
        {
            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();
                try
                {
                    conn.Query<Product>("exec AddData @name, @price", new Product(name,price));
                }
                catch (Exception ex)
                {
                    return "Failed!";
                }
            }
            return "Success!";
        }

        public static List<Product> GetData()
        {
            List<Product> products = new List<Product>();
            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();
                try
                {
                    products = conn.Query<Product>("exec GetData").ToList();
                }
                catch (Exception ex)
                {
                    return products;
                }
            }
            return products;
        }

    }
}
