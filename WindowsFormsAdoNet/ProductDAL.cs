using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace WindowsFormsAdoNet
{
    public class ProductDAL
    {
        SqlConnection _connection = new SqlConnection(@"server=(LocalDB)\MSSQLLocalDB; initial catalog=artfinder; Integrated Security=True");




        void ConnectionControl()
        {
            if(_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }

        }

        // add prod

        public void AddItem(Product item)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Insert Into Products values (@product_name,@product_price, @product_stock)", _connection);
            command.Parameters.AddWithValue("@product_name", item.product_name);
            command.Parameters.AddWithValue("@product_price", item.product_price);
            command.Parameters.AddWithValue("@product_stock", item.product_stock);
            command.ExecuteNonQuery();
            _connection.Close();
        }
        public void UpdateItem(int product_id, string product_name, decimal product_price, int product_stock)
        {
            ConnectionControl();
            // don't forget to use single quatation marks when giving a string variable.     sql needs them.
            SqlCommand command = new SqlCommand($"update products set product_name = '{product_name}', product_price = {product_price}, product_stock = {product_stock} where product_id = {product_id}", _connection);
     
            command.ExecuteNonQuery();
            _connection.Close();
        }
        public void DeleteItem(int selectedProductId)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand($"Delete From Products where product_id = {selectedProductId}", _connection);
            command.ExecuteNonQuery();
            _connection.Close();
        }
        public string getIdValue()
        {
            string idValue = "";
            int value = 0;
            ConnectionControl();
            SqlCommand command = new SqlCommand("select * from Products", _connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                value = Convert.ToInt32(reader["product_id"]) + 1;
                idValue = value.ToString();
            }
            reader.Close();
            _connection.Close();
            return idValue; 
        }

        public int getItemCount()
        {
            int count = 0;
            ConnectionControl();
            SqlCommand command = new SqlCommand("select * from Products", _connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                count++;
      
            }
            reader.Close();
            _connection.Close();
            return count;
        }
        public List<Product> GetProducts()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("select * from Products", _connection);

            SqlDataReader reader = command.ExecuteReader();
            List<Product> prodList = new List<Product>();

            while (reader.Read())
            {
                
                Product Products = new Product
                {
                    product_id = Convert.ToInt32(reader["product_id"]),
                    product_name = reader["product_name"].ToString(),
                    product_price = Convert.ToDecimal(reader["product_price"]),
                    product_stock = Convert.ToInt32(reader["product_stock"])

                };
                prodList.Add(Products);
            }
           
            
            reader.Close();
            _connection.Close();
            return prodList;
        }

      
    }

}
