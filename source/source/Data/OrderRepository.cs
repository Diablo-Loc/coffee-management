using source.Models.OrderModel;
using source.Models.Catalog;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace source.Data
{
    internal class OrderRepository
    {
        private string connectionString = "Data Source=Order.db;Version=3;Journal Mode=WAL;";

        public void CreateTables()
        {
            using var conn = new SQLiteConnection(connectionString);
            conn.Open();

            string createOrders = @"
                CREATE TABLE IF NOT EXISTS Orders (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Date TEXT,
                    GuestCount INTEGER,
                    Total REAL,
                    TableNumber INTEGER,
                    Status TEXT
                );";

            string createItems = @"
                CREATE TABLE IF NOT EXISTS OrderItems (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    OrderId INTEGER,
                    ProductName TEXT,
                    Quantity INTEGER,
                    Price REAL,
                    Category TEXT,
                    FOREIGN KEY(OrderId) REFERENCES Orders(Id)
                );";

            new SQLiteCommand(createOrders, conn).ExecuteNonQuery();
            new SQLiteCommand(createItems, conn).ExecuteNonQuery();
        }

        public void Save(Order order)
        {
            using var conn = new SQLiteConnection(connectionString);
            conn.Open();

            if (order.Id > 0)
            {
                // Xóa toàn bộ món cũ trước khi ghi lại
                var deleteCmd = new SQLiteCommand("DELETE FROM OrderItems WHERE OrderId = @id", conn);
                deleteCmd.Parameters.AddWithValue("@id", order.Id);
                deleteCmd.ExecuteNonQuery();

                // Cập nhật thông tin đơn nếu cần
                var updateCmd = new SQLiteCommand("UPDATE Orders SET GuestCount = @guest, Date = @date, TableNumber = @table WHERE Id = @id", conn);
                updateCmd.Parameters.AddWithValue("@guest", order.GuestCount);
                updateCmd.Parameters.AddWithValue("@date", order.CreatedAt.ToString("yyyy-MM-dd HH:mm:ss"));
                updateCmd.Parameters.AddWithValue("@table", order.TableNumber);
                updateCmd.Parameters.AddWithValue("@id", order.Id);
                updateCmd.ExecuteNonQuery();
            }
            else
            {
                // Tạo đơn mới
                var insertCmd = new SQLiteCommand("INSERT INTO Orders (Date, GuestCount, TableNumber) VALUES (@date, @guest, @table)", conn);
                insertCmd.Parameters.AddWithValue("@date", order.CreatedAt.ToString("yyyy-MM-dd HH:mm:ss"));
                insertCmd.Parameters.AddWithValue("@guest", order.GuestCount);
                insertCmd.Parameters.AddWithValue("@table", order.TableNumber);
                insertCmd.ExecuteNonQuery();

                order.Id = (int)conn.LastInsertRowId;
            }

            // Ghi lại danh sách món mới
            foreach (var item in order.Items)
            {
                var cmd = new SQLiteCommand("INSERT INTO OrderItems (OrderId, ProductName, Quantity, Price, Category) VALUES (@orderId, @name, @qty, @price, @category)", conn); cmd.Parameters.AddWithValue("@orderId", order.Id);
                cmd.Parameters.AddWithValue("@name", item.Item.Name);
                cmd.Parameters.AddWithValue("@qty", item.Quantity);
                cmd.Parameters.AddWithValue("@price", item.Item.Price);
                cmd.Parameters.AddWithValue("@category", item.Item.Category);
                cmd.ExecuteNonQuery();
            }
        }

        public Order? GetLatestOrder()
        {
            using var conn = new SQLiteConnection(connectionString);
            conn.Open();

            string query = "SELECT Id, Date, GuestCount, Total, TableNumber FROM Orders ORDER BY Date DESC LIMIT 1;"; var cmd = new SQLiteCommand(query, conn);
            var reader = cmd.ExecuteReader();

            if (!reader.Read()) return null;

            int id = reader.GetInt32(0);
            string date = reader.GetString(1);
            int guest = reader.GetInt32(2);
            int tableNumber = reader.GetInt32(4);

            var order = new Order
            {
                Id = id,
                CreatedAt = DateTime.Parse(date),
                GuestCount = guest,
                TableNumber = tableNumber
            };

            order.Items.AddRange(GetItemsByOrderId(id));
            return order;
        }

        public Order? GetFullOrderByTable(int tableNumber)
        {
            using var conn = new SQLiteConnection(connectionString);
            conn.Open();

            string queryOrder = "SELECT Id, Date, GuestCount, Total FROM Orders WHERE TableNumber = @table ORDER BY Date DESC LIMIT 1";
            var cmdOrder = new SQLiteCommand(queryOrder, conn);
            cmdOrder.Parameters.AddWithValue("@table", tableNumber);

            var reader = cmdOrder.ExecuteReader();
            if (!reader.Read()) return null;

            int id = reader.GetInt32(0);
            string date = reader.GetString(1);
            int guest = reader.GetInt32(2);

            var order = new Order
            {
                Id = id,
                CreatedAt = DateTime.Parse(date),
                GuestCount = guest,
                TableNumber = tableNumber
            };

            order.Items.AddRange(GetItemsByOrderId(id));
            return order;
        }

        public List<OrderItem> GetItemsByOrderId(int orderId)
        {
            var items = new List<OrderItem>();
            using var conn = new SQLiteConnection(connectionString);
            conn.Open();

            string query = "SELECT ProductName, Quantity, Price, Category FROM OrderItems WHERE OrderId = @id";
            var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", orderId);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string name = reader.GetString(0);
                int qty = reader.GetInt32(1);
                decimal price = reader.GetDecimal(2);
                string category = reader.IsDBNull(3) ? "" : reader.GetString(3);


                Product product = category switch
                {
                    "Drink" => new Drink { Name = name, Price = price, Category = category },
                    "Food" => new Food { Name = name, Price = price, Category = category },
                    "Dessert" => new Dessert { Name = name, Price = price, Category = category },
                    _ => new Drink { Name = name, Price = price, Category = "Drink" } // fallback
                };
                items.Add(new OrderItem(product, qty));
            }

            return items;
        }

        public void Delete(int orderId)
        {
            using var conn = new SQLiteConnection(connectionString);
            conn.Open();

            var cmd1 = new SQLiteCommand("DELETE FROM OrderItems WHERE OrderId = @id", conn);
            cmd1.Parameters.AddWithValue("@id", orderId);
            cmd1.ExecuteNonQuery();

            var cmd2 = new SQLiteCommand("DELETE FROM Orders WHERE Id = @id", conn);
            cmd2.Parameters.AddWithValue("@id", orderId);
            cmd2.ExecuteNonQuery();
        }

        public List<Order> GetAllActiveOrders()
        {
            var orders = new List<Order>();
            using var conn = new SQLiteConnection(connectionString);
            conn.Open();

            string query = "SELECT Id, Date, GuestCount, TableNumber FROM Orders";
            var cmd = new SQLiteCommand(query, conn);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                var order = new Order
                {
                    Id = reader.GetInt32(0),
                    CreatedAt = DateTime.Parse(reader.GetString(1)),
                    GuestCount = reader.GetInt32(2),
                    TableNumber = reader.GetInt32(3)
                };
                order.Items.AddRange(GetItemsByOrderId(order.Id));

                orders.Add(order);
            }
            return orders;
        }


        public List<Order> GetAllOrders()
        {
            var orders = new List<Order>();
            using var conn = new SQLiteConnection(connectionString);
            conn.Open();

            string query = "SELECT Id, Date, GuestCount, TableNumber FROM Orders ORDER BY Date DESC";
            var cmd = new SQLiteCommand(query, conn);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                var order = new Order
                {
                    Id = reader.GetInt32(0),
                    CreatedAt = DateTime.Parse(reader.GetString(1)),
                    GuestCount = reader.GetInt32(2),
                    TableNumber = reader.GetInt32(3)
                };

                order.Items.AddRange(GetItemsByOrderId(order.Id));
                orders.Add(order);
            }

            return orders;
        }
    }
}