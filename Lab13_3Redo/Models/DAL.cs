using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper;
using Dapper.Contrib.Extensions;

namespace Lab13_3Redo.Models
{
    public class DAL
    {

        //database connection
        public static MySqlConnection DB = new MySqlConnection("Server=localhost;Database=coffeeshop;Uid=root;Password=abc123");

        //create a function that lists all products 
        public static List<Product> GetAllProducts()
        {
            return DB.GetAll<Product>().ToList();
        }

        //create a function to read details of product by ID
        public static Product GetDetails(int id)
        {
            return DB.Get<Product>(id);
        }

        //delete product by id
        public static void Delete (int id)
        {
            Product pro = new Product();
            pro.id = id;
            DB.Delete<Product>(pro);
        }

        //insert a product

        public static void Insert(Product pro)
        {
            DB.Insert(pro);
        }

        //update product
        
        public static void Update(Product pro)
        {
            DB.Update(pro);

        }
    }
}
