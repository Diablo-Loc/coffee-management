using System.Collections.Generic;
using System.Data.SQLite;
using source.Models;

namespace source.Data
{
    public class MenuItemInSQLite
    {
        private string connectionString = "Data Source=menu.db;Version=3;";

        public void CreateTable()
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string sql = @"
                CREATE TABLE IF NOT EXISTS MenuItem (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT,
                    Price REAL,
                    Category TEXT,
                    Description TEXT)";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
        }

        public void Add(MenuItem item)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO MenuItem (Name, Price, Category, Description) VALUES (@name, @price, @category, @desc)";
                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", item.Name);
                cmd.Parameters.AddWithValue("@price", item.Price);
                cmd.Parameters.AddWithValue("@category", item.Category);
                cmd.Parameters.AddWithValue("@desc", item.Description);
                cmd.ExecuteNonQuery();
            }
        }

        public List<MenuItem> GetAll()
        {
            var list = new List<MenuItem>();
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Name, Price, Category, Description FROM MenuItem";
                var cmd = new SQLiteCommand(query, conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string name = reader.GetString(0);
                    decimal price = reader.GetDecimal(1);
                    string category = reader.GetString(2);
                    string description = reader.GetString(3);
                    list.Add(new MenuItem(name, price, category, description));
                }
            }
            return list;
        }

        public void Update(MenuItem oldItem, MenuItem newItem)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE MenuItem SET Name = @newName, Price = @newPrice, Category = @newCategory, Description = @newDesc WHERE Name = @oldName AND Price = @oldPrice";
                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@newName", newItem.Name);
                cmd.Parameters.AddWithValue("@newPrice", newItem.Price);
                cmd.Parameters.AddWithValue("@newCategory", newItem.Category);
                cmd.Parameters.AddWithValue("@newDesc", newItem.Description);
                cmd.Parameters.AddWithValue("@oldName", oldItem.Name);
                cmd.Parameters.AddWithValue("@oldPrice", oldItem.Price);
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(MenuItem item)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM MenuItem WHERE Name = @name AND Price = @price";
                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", item.Name);
                cmd.Parameters.AddWithValue("@price", item.Price);
                cmd.ExecuteNonQuery();
            }
        }

        public List<MenuItem> Search(string keyword)
        {
            var list = new List<MenuItem>();
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Name, Price, Category, Description FROM MenuItem WHERE Name LIKE @kw OR Description LIKE @kw";
                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string name = reader.GetString(0);
                    decimal price = reader.GetDecimal(1);
                    string category = reader.GetString(2);
                    string description = reader.GetString(3);
                    list.Add(new MenuItem(name, price, category, description));
                }
            }
            return list;
        }
    }
}