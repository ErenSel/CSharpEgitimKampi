using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crud --> Create-Read-Update-Delete

            Console.WriteLine("***** Menü Sİpariş İşlem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("--------------------------------------------");
            #region Kategori ekleme işlemi

            //Console.Write("Eklemek İstediğiniz Kategori Adı: ");
            //String categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=ERENSEL\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.Write("Kategori başarıyla eklendi");
            #endregion

            #region Ürün ekleme işlemi
            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.Write("Ürün adı: ");
            //productName = Console.ReadLine();
            //Console.Write("Ürün fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());
            //SqlConnection connection = new SqlConnection("Data Source=ERENSEL\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName, ProductPrice,ProductStatus) values(@p1,@p2,@p3)", connection);
            //command.Parameters.AddWithValue("@p1", productName);
            //command.Parameters.AddWithValue("@p2", productPrice);
            //command.Parameters.AddWithValue("@p3", true);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.Write("Ürün eklemesi başarılı");

            #endregion

            #region Ürün Listeleme işlemi

            //SqlConnection connection = new SqlConnection("Data Source=ERENSEL\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Select * From TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows) { 
            //    foreach(var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();            
            //}





            //connection.Close();



            #endregion

            #region Ürün Silme İşlemi
            //Console.Write("Silinecek ürün ID: ");
            //int productID = int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=ERENSEL\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId = @productID",connection);
            //command.Parameters.AddWithValue("@productId", productID);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Silme işlemi yapıldı");


            #endregion


            #region Ürün Güncelleme işlemi

            Console.Write("Güncellenecek ürün ID: ");
            int productId = int.Parse(Console.ReadLine());
            Console.Write("Güncellenecek ürün adı: ");
            string productName = Console.ReadLine();
            Console.Write("Güncellenecek ürün fiyatı: ");
            decimal productPrice = decimal.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection("Data Source=ERENSEL\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
            connection.Open();

            SqlCommand command = new SqlCommand("Update TblProduct Set ProductName = @produtctNamei ProductPrice = @productPrice, Where ProductID = @productId", connection);
            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@productPrice", productPrice);
            command.Parameters.AddWithValue("@productId", productId);
            command.ExecuteNonQuery();
            

            connection.Close();

            Console.WriteLine("Güncelleme başarılı");



            #endregion
            Console.Read();
             
        }
    }
}
