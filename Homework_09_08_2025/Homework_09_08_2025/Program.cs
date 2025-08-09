using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_09_08_2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection(@"Data Source=EFE-S-TEMP-LAPT\SQLEXPRESS;Initial Catalog=NORTHWND;Integrated Security=True");
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select P.ProductID,P.ProductName, P.QuantityPerUnit, P.UnitPrice, P.UnitsInStock,C.CategoryID, C.CategoryName, S.CompanyName, S.ContactTitle + ' ' + S.ContactName, S.City  from Products as P join Categories as C on P.CategoryID = C.CategoryID join Suppliers as S on P.SupplierID = S.SupplierID ";
            con.Open();
            SqlDataReader DataReader = cmd.ExecuteReader();
            while(DataReader.Read())
            {
                int productId = DataReader.GetInt32(0);
                string productName = DataReader.GetString(1);
                string quantityPerUnit = DataReader.GetString(2);
                decimal unitPrice = DataReader.GetDecimal(3);
                short unitsInStock = DataReader.GetInt16(4);
                int categoryId = DataReader.GetInt32(5);
                string categoryName = DataReader.GetString(6);
                string companyName = DataReader.GetString(7);
                string contactInfo = DataReader.GetString(8);
                string city = DataReader.GetString(9);
                Console.WriteLine($"Product ID: {productId},\n Name: {productName},\n Quantity Per Unit: {quantityPerUnit},\n Unit Price: {unitPrice:C},\n Units In Stock: {unitsInStock},\n Category ID: {categoryId},\n\n Category Name: {categoryName},\n\n Supplier: {companyName},\n Contact Info: {contactInfo},\n City: {city}\n\n");
            }
        }
    }
}
