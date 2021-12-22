using System;
using System.Data.SqlClient;
using Dapper;
using System.Linq;

namespace Product
{
    public class Db_Product
    {
        static string a = "Data Source =.; Initial Catalog = Digikala; Integrated Security = True";
        public static List<VM_Product> Select()
        {
            using (SqlConnection db = new SqlConnection(a))
            {
                var list = db.Query<VM_Product>("SELECT p.Productid,p.Product_name,p.Price,p.Count,p.Product_desc,p.Img_url,p.Categoryid,p.Active,c.Category_name FROM Product p INNER JOIN Category c ON c.Categoryid = p.Categoryid").ToList();
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
        public string Category_name { get; set; }
    }
}