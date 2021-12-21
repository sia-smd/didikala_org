using System;
using System.Data.SqlClient;
using Dapper;
using System.Linq;

namespace Product
{
    public class Db_Product
    {
        static string a = "Data Source =.; Initial Catalog = Didikala; Integrated Security = True";
        public static List<VM_Product> Select()
        {
            using (SqlConnection db = new SqlConnection(a))
            {
                var list = db.Query<VM_Product>("Select * from product where active = 1").ToList();
                return list;
            }
        }
    }
    public class VM_Product
    {
        public int Productid { get; set; }
        public string Product_name { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
        public string Product_desc { get; set; }
        public string Img_url { get; set; }
        public int Categoryid { get; set; }
        public int Active { get; set; }
    }
}