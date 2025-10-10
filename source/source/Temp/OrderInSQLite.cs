using source.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace source.Temp
{
    internal class OrderInSQLite
    {
        private string connectionString = "Data Source=order.db;Version=3;Journal Mode=WAL;";
        public void CreateOrderTables()
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string createOrders = @"
                    CREATE TABLE IF NOT EXISTS Orders (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        TableNumber INTEGER,
                        Date TEXT,
                        GuestCount INTEGER,
                        Total REAL
                    );";

                string createOrderItems = @"
                    CREATE TABLE IF NOT EXISTS OrderItems (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        OrderId INTEGER,
                        ItemName TEXT,
                        Quantity INTEGER,
                        Price REAL,
                        FOREIGN KEY(OrderId) REFERENCES Orders(Id)
                    );";

                new SQLiteCommand(createOrders, conn).ExecuteNonQuery();
                new SQLiteCommand(createOrderItems, conn).ExecuteNonQuery();
            }
        }
        public void SaveOrderToDatabase(Order1 order)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                using (var transaction = conn.BeginTransaction())
                {
                    using (var cmdOrder = new SQLiteCommand(conn))
                    {
                        cmdOrder.CommandText = "INSERT INTO Orders (TableNumber, Date, GuestCount, Total) VALUES (@table, @date, @guest, @total)";
                        cmdOrder.Parameters.AddWithValue("@table", order.TableNumber);
                        cmdOrder.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                        cmdOrder.Parameters.AddWithValue("@guest", order.GuestCount);
                        cmdOrder.Parameters.AddWithValue("@total", order.Total());
                        cmdOrder.ExecuteNonQuery();
                    }

                    long orderId = conn.LastInsertRowId;

                    foreach (var item in order.OrderItem)
                    {
                        using (var cmdItem = new SQLiteCommand(conn))
                        {
                            cmdItem.CommandText = "INSERT INTO OrderItems (OrderId, ItemName, Quantity, Price) VALUES (@orderId, @name, @qty, @price)";
                            cmdItem.Parameters.AddWithValue("@orderId", orderId);
                            cmdItem.Parameters.AddWithValue("@name", item.Item.Name);
                            cmdItem.Parameters.AddWithValue("@qty", item.Quantity);
                            cmdItem.Parameters.AddWithValue("@price", item.Item.Price);
                            cmdItem.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                }
            }
        }

        public (string Date, int GuestCount) GetOrderInfo(int tableNumber)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = @"
            SELECT Date, GuestCount 
            FROM Orders 
            WHERE TableNumber = @table 
            ORDER BY Date DESC 
            LIMIT 1";

                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@table", tableNumber);

                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string date = reader.GetString(0);
                    int guestCount = reader.GetInt32(1);
                    return (date, guestCount);
                }
            }

            return ("-", 0); // nếu không có đơn nào
        }
        public List<OrderItem> GetOrderItemsByTable(int tableNumber)
        {
            var list = new List<OrderItem>();

            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                // Lấy OrderId mới nhất của bàn
                string getOrderId = "SELECT Id FROM Orders WHERE TableNumber = @table ORDER BY Date DESC LIMIT 1";
                var cmdOrder = new SQLiteCommand(getOrderId, conn);
                cmdOrder.Parameters.AddWithValue("@table", tableNumber);
                var orderIdObj = cmdOrder.ExecuteScalar();

                if (orderIdObj == null) return list;

                long orderId = (long)orderIdObj;

                // Lấy các món từ OrderItems
                string query = "SELECT ItemName, Quantity, Price FROM OrderItems WHERE OrderId = @orderId";
                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@orderId", orderId);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string name = reader.GetString(0);
                    int quantity = reader.GetInt32(1);
                    decimal price = reader.GetDecimal(2);

                    var menuItem = new MenuItem(name, price, "", "");
                    list.Add(new OrderItem(menuItem, quantity));
                }
            }

            return list;
        }
        private List<OrderItem> GetOrderItemsByOrderId(int orderId)
{
    var items = new List<OrderItem>();
    using (var conn = new SQLiteConnection(connectionString))
    {
        conn.Open();
        string query = "SELECT ItemName, Quantity, Price FROM OrderItems WHERE OrderId = @orderId";
        var cmd = new SQLiteCommand(query, conn);
        cmd.Parameters.AddWithValue("@orderId", orderId);
        var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            string name = reader.GetString(0);
            int qty = reader.GetInt32(1);
            decimal price = reader.GetDecimal(2);
            items.Add(new OrderItem(new MenuItem(name, price, "", ""), qty));
        }
    }
    return items;
}
        public Order1? GetFullOrderByTable(int tableNumber)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = @"SELECT Id, Date, GuestCount, Total FROM Orders 
                 WHERE TableNumber = @table ORDER BY Date DESC LIMIT 1";
                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@table", tableNumber);
                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int orderId = reader.GetInt32(0);
                    string date = reader.GetString(1);
                    int guest = reader.GetInt32(2);
                    decimal total = reader.GetDecimal(3);

                    var order = new Order1(tableNumber)
                    {
                        GuestCount = guest,
                        CreatedAt = DateTime.Parse(date),
                        OrderId = orderId
                    };

                    order.OrderItem.AddRange(GetOrderItemsByOrderId(orderId));
                    return order;
                }
            }

            return null!;
        }
    }
}
