using source.Models;
using source.Models.Catalog;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace source.Data
{
    internal class ProductRepository
    {
        private string _connectionString = "Data Source=Menu.db";

        public void CreateTable()
        {
            using var conn = new SQLiteConnection(_connectionString);
            conn.Open();
            string query = @"CREATE TABLE IF NOT EXISTS Products (
                        Name TEXT,
                        Price REAL,
                        Category TEXT,
                        Description TEXT,
                        Size TEXT,
                        IsHot INTEGER,
                        IsVegetarian INTEGER,
                        Topping TEXT,
                        IsCold INTEGER,
                        Flavor TEXT,
                        Decoration TEXT
                    )";
            using var cmd = new SQLiteCommand(query, conn);
            cmd.ExecuteNonQuery();
        }

        public List<Product> GetAll()
        {
            var list = new List<Product>();
            using var conn = new SQLiteConnection(_connectionString);
            conn.Open();
            string query = "SELECT * FROM Products";
            using var cmd = new SQLiteCommand(query, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string name = reader.GetString(0);
                decimal price = reader.GetDecimal(1);
                string category = reader.GetString(2);
                string description = reader.GetString(3);

                // Các cột riêng cho từng loại (nếu có)
                string size = reader["Size"] is DBNull ? "" : reader["Size"].ToString();
                bool isHot = reader["IsHot"] is DBNull ? false : Convert.ToBoolean(reader["IsHot"]);
                bool isVegetarian = reader["IsVegetarian"] is DBNull ? false : Convert.ToBoolean(reader["IsVegetarian"]);
                string topping = reader["Topping"] is DBNull ? "" : reader["Topping"].ToString();
                bool isCold = reader["IsCold"] is DBNull ? false : Convert.ToBoolean(reader["IsCold"]);
                string flavor = reader["Flavor"] is DBNull ? "" : reader["Flavor"].ToString();
                string decoration = reader["Decoration"] is DBNull ? "" : reader["Decoration"].ToString();

                // 👉 Đây là nơi bạn đặt đoạn switch
                switch (category)
                {
                    case "Drink":
                        list.Add(new Drink(size, isHot, name, price, description));
                        break;
                    case "Food":
                        list.Add(new Food(isVegetarian, topping, name, price, description));
                        break;
                    case "Dessert":
                        list.Add(new Dessert(isCold, flavor, decoration, name, price, description));
                        break;
                    default:
                        break;
                }
            }

            return list;
        }

        public void Add(Product p)
        {
            using var conn = new SQLiteConnection(_connectionString);
            conn.Open();
            string query = @"INSERT INTO Products 
        (Name, Price, Category, Description, Size, IsHot, IsVegetarian, Topping, IsCold, Flavor, Decoration) 
        VALUES 
        (@name, @price, @cat, @desc, @size, @hot, @veg, @top, @cold, @flavor, @decor)";
            using var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", p.Name);
            cmd.Parameters.AddWithValue("@price", p.Price);
            cmd.Parameters.AddWithValue("@cat", p.Category);
            cmd.Parameters.AddWithValue("@desc", p.Description);
            if (p is Drink d)
            {
                cmd.Parameters.AddWithValue("@size", d.Size);
                cmd.Parameters.AddWithValue("@hot", d.IsHot);
            }
            else
            {
                cmd.Parameters.AddWithValue("@size", DBNull.Value);
                cmd.Parameters.AddWithValue("@hot", DBNull.Value);
            }

            if (p is Food f)
            {
                cmd.Parameters.AddWithValue("@veg", f.IsVegetarian);
                cmd.Parameters.AddWithValue("@top", f.Topping);
            }
            else
            {
                cmd.Parameters.AddWithValue("@veg", DBNull.Value);
                cmd.Parameters.AddWithValue("@top", DBNull.Value);
            }

            if (p is Dessert ds)
            {
                cmd.Parameters.AddWithValue("@cold", ds.IsCold);
                cmd.Parameters.AddWithValue("@flavor", ds.Flavor);
                cmd.Parameters.AddWithValue("@decor", ds.Decoration);
            }
            else
            {
                cmd.Parameters.AddWithValue("@cold", DBNull.Value);
                cmd.Parameters.AddWithValue("@flavor", DBNull.Value);
                cmd.Parameters.AddWithValue("@decor", DBNull.Value);
            }

            cmd.ExecuteNonQuery();
        }

        public void Update(Product old, Product updated)
        {
            using var conn = new SQLiteConnection(_connectionString);
            conn.Open();

            string query = @"UPDATE Products SET 
                        Name = @name,
                        Price = @price,
                        Category = @cat,
                        Description = @desc,
                        Size = @size,
                        IsHot = @hot,
                        IsVegetarian = @veg,
                        Topping = @top,
                        IsCold = @cold,
                        Flavor = @flavor,
                        Decoration = @decor
                    WHERE Name = @oldName AND Price = @oldPrice";

            using var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", updated.Name);
            cmd.Parameters.AddWithValue("@price", updated.Price);
            cmd.Parameters.AddWithValue("@cat", updated.Category);
            cmd.Parameters.AddWithValue("@desc", updated.Description);

            // Gán giá trị theo loại
            if (updated is Drink d)
            {
                cmd.Parameters.AddWithValue("@size", d.Size);
                cmd.Parameters.AddWithValue("@hot", d.IsHot);
            }
            else
            {
                cmd.Parameters.AddWithValue("@size", DBNull.Value);
                cmd.Parameters.AddWithValue("@hot", DBNull.Value);
            }

            if (updated is Food f)
            {
                cmd.Parameters.AddWithValue("@veg", f.IsVegetarian);
                cmd.Parameters.AddWithValue("@top", f.Topping);
            }
            else
            {
                cmd.Parameters.AddWithValue("@veg", DBNull.Value);
                cmd.Parameters.AddWithValue("@top", DBNull.Value);
            }

            if (updated is Dessert ds)
            {
                cmd.Parameters.AddWithValue("@cold", ds.IsCold);
                cmd.Parameters.AddWithValue("@flavor", ds.Flavor);
                cmd.Parameters.AddWithValue("@decor", ds.Decoration);
            }
            else
            {
                cmd.Parameters.AddWithValue("@cold", DBNull.Value);
                cmd.Parameters.AddWithValue("@flavor", DBNull.Value);
                cmd.Parameters.AddWithValue("@decor", DBNull.Value);
            }

            // Điều kiện WHERE để xác định đúng sản phẩm cần sửa
            cmd.Parameters.AddWithValue("@oldName", old.Name);
            cmd.Parameters.AddWithValue("@oldPrice", old.Price);

            cmd.ExecuteNonQuery();
        }

        public void Delete(Product p)
        {
            using var conn = new SQLiteConnection(_connectionString);
            conn.Open();
            string query = "DELETE FROM Products WHERE Name=@name";
            using var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", p.Name);
            cmd.ExecuteNonQuery();
        }
        public List<Product> Search(string keyword)
        {
            var list = new List<Product>();
            using var conn = new SQLiteConnection(_connectionString);
            conn.Open();
            string query = "SELECT * FROM Products WHERE Name LIKE @kw OR Description LIKE @kw";
            using var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string name = reader.GetString(0);
                decimal price = reader.GetDecimal(1);
                string category = reader.GetString(2);
                string description = reader.GetString(3);

                // Các cột riêng cho từng loại (nếu có)
                string size = reader["Size"] is DBNull ? "" : reader["Size"].ToString();
                bool isHot = reader["IsHot"] is DBNull ? false : Convert.ToBoolean(reader["IsHot"]);
                bool isVegetarian = reader["IsVegetarian"] is DBNull ? false : Convert.ToBoolean(reader["IsVegetarian"]);
                string topping = reader["Topping"] is DBNull ? "" : reader["Topping"].ToString();
                bool isCold = reader["IsCold"] is DBNull ? false : Convert.ToBoolean(reader["IsCold"]);
                string flavor = reader["Flavor"] is DBNull ? "" : reader["Flavor"].ToString();
                string decoration = reader["Decoration"] is DBNull ? "" : reader["Decoration"].ToString();

                // 👉 Đây là nơi bạn đặt đoạn switch
                switch (category)
                {
                    case "Drink":
                        list.Add(new Drink(size, isHot, name, price, description));
                        break;
                    case "Food":
                        list.Add(new Food(isVegetarian, topping, name, price, description));
                        break;
                    case "Dessert":
                        list.Add(new Dessert(isCold, flavor, decoration, name, price, description));
                        break;
                    default:
                        break;
                }
            }

            return list;
        }
        public List<(string Name, decimal Price, string Category)> GetAllRaw()
        {
            var list = new List<(string, decimal, string)>();
            using var conn = new SQLiteConnection(_connectionString);
            conn.Open();

            var cmd = new SQLiteCommand("SELECT Name, Price, Category FROM Products", conn);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string name = reader.GetString(0);
                decimal price = reader.GetDecimal(1);
                string category = reader.GetString(2);
                list.Add((name, price, category));
            }

            return list;
        }
        public List<Product> GetAllProducts()
        {
            var products = new List<Product>();
            using var conn = new SQLiteConnection(_connectionString);
            conn.Open();

            var cmd = new SQLiteCommand("SELECT Name, Price, Category FROM Products", conn);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string name = reader.GetString(0);
                decimal price = reader.GetDecimal(1);
                string category = reader.GetString(2);

                Product product = category switch
                {
                    "Drink" => new Drink { Name = name, Price = price, Category = category },
                    "Food" => new Food { Name = name, Price = price, Category = category },
                    "Dessert" => new Dessert { Name = name, Price = price, Category = category },
                    //_ => new Product { Name = name, Price = price, Category = category }
                };

                products.Add(product);
            }

            return products;
        }
    }
}
