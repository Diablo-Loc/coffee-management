using source.Models.PersonModel;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Security.Cryptography;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using static source.Models.PersonModel.Employee;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace source.Data
{
    internal class EmployeeAccount
    {
        private static readonly string connectionString = "Data Source=employees.db";

        public static void InitializeDatabase()
        {
            using (var conn = new SQLiteConnection("Data Source=employees.db"))
            {
                conn.Open();
                string query = @"
            CREATE TABLE IF NOT EXISTS Employees (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Name TEXT,
                Email TEXT,
                Phone TEXT,
                Role TEXT,
                BaseSalary REAL,
                Username TEXT UNIQUE,
                Password TEXT,
                Allowance REAL,
                ResponsibilityRate REAL,
                WorkingHours INTEGER,
                HourRate REAL

            );";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static bool UsernameExists(string username)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Employees WHERE Username = @Username";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    long count = (long)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }
        public static void AddEmployee(Employee emp)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = @"INSERT INTO Employees 
                (Name, Email, Phone, Role, BaseSalary, Username, Password, Allowance, ResponsibilityRate, WorkingHours, HourRate) 
          VALUES (@Name, @Email, @Phone, @Role, @BaseSalary, @Username, @Password, @Allowance, @ResponsibilityRate, @WorkingHours, @HourRate)";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", emp.Name);
                    cmd.Parameters.AddWithValue("@Email", emp.Email);
                    cmd.Parameters.AddWithValue("@Phone", emp.Phone);
                    cmd.Parameters.AddWithValue("@Role", emp._Role);
                    cmd.Parameters.AddWithValue("@BaseSalary", emp.BaseSalary);
                    cmd.Parameters.AddWithValue("@Username", emp.Username);
                    cmd.Parameters.AddWithValue("@Password", emp.Password);
                    cmd.Parameters.AddWithValue("@Allowance", emp is Manager m ? m.Allowance : DBNull.Value);
                    cmd.Parameters.AddWithValue("@ResponsibilityRate", emp is Manager m2 ? m2.ReponsibleRate : DBNull.Value);
                    cmd.Parameters.AddWithValue("@WorkingHours", emp is Cashier c ? c.WorkHours : DBNull.Value);
                    cmd.Parameters.AddWithValue("@HourRate", emp is Cashier c2 ? c2.HourRate : DBNull.Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static void UpdateEmployee(Employee emp)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = @"UPDATE Employees SET 
            Name = @Name,
            Email = @Email,
            Phone = @Phone,
            Role = @Role,
            BaseSalary = @BaseSalary,
            Password = @Password,
            Allowance = @Allowance,
            ResponsibilityRate = @ResponsibilityRate,
            WorkingHours = @WorkingHours,
            HourRate = @HourRate
            WHERE Username = @Username";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", emp.Name);
                    cmd.Parameters.AddWithValue("@Email", emp.Email);
                    cmd.Parameters.AddWithValue("@Phone", emp.Phone);
                    cmd.Parameters.AddWithValue("@Role", emp._Role);
                    cmd.Parameters.AddWithValue("@BaseSalary", emp.BaseSalary);
                    cmd.Parameters.AddWithValue("@Password", emp.Password);
                    cmd.Parameters.AddWithValue("@Username", emp.Username);
                    cmd.Parameters.AddWithValue("@Allowance", emp is Manager m ? m.Allowance : DBNull.Value);
                    cmd.Parameters.AddWithValue("@ResponsibilityRate", emp is Manager m2 ? m2.ReponsibleRate : DBNull.Value);
                    cmd.Parameters.AddWithValue("@WorkingHours", emp is Cashier c ? c.WorkHours : DBNull.Value);
                    cmd.Parameters.AddWithValue("@HourRate", emp is Cashier c2 ? c2.HourRate : DBNull.Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static Employee Authenticate(string username, string hashedPassword)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Employees WHERE Username = @Username AND Password = @Password";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", hashedPassword);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Role role = Enum.Parse<Role>(reader["Role"].ToString());

                            Employee emp;

                            if (role == Role.Manager)
                            {
                                var manager = new Manager();
                                manager.Allowance = Convert.ToDecimal(reader["Allowance"]);
                                manager.ReponsibleRate = Convert.ToDecimal(reader["ResponsibilityRate"]);
                                emp = manager;
                            }
                            else if (role == Role.Cashier)
                            {
                                var cashier = new Cashier();
                                cashier.WorkHours = Convert.ToInt32(reader["WorkingHours"]);
                                cashier.HourRate = Convert.ToDecimal(reader["HourRate"]);
                                emp = cashier;
                            }
                            else
                            {
                                emp = new Employee();
                            }

                            emp.Id = Convert.ToInt32(reader["Id"]);
                            emp.Name = reader["Name"].ToString();
                            emp.Email = reader["Email"].ToString();
                            emp.Phone = reader["Phone"].ToString();
                            emp._Role = role;
                            emp.BaseSalary = Convert.ToDecimal(reader["BaseSalary"]);
                            emp.Username = reader["Username"].ToString();
                            emp.Password = reader["Password"].ToString();
                            return emp;
                        }
                    }
                }
            }
            return null;
        }

        public static List<Employee> GetAllEmployees()
        {
            var list = new List<Employee>();
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Employees";
                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Role role = Enum.Parse<Role>(reader["Role"].ToString());

                        Employee emp;

                        if (role == Role.Manager)
                        {
                            var manager = new Manager();
                            manager.Allowance = reader["Allowance"] != DBNull.Value ? Convert.ToDecimal(reader["Allowance"]) : 0;
                            manager.ReponsibleRate = reader["ResponsibilityRate"] != DBNull.Value ? Convert.ToDecimal(reader["ResponsibilityRate"]) : 0;
                            emp = manager;
                        }
                        else if (role == Role.Cashier)
                        {
                            var cashier = new Cashier();
                            cashier.WorkHours = reader["WorkingHours"] != DBNull.Value ? Convert.ToInt32(reader["WorkingHours"]) : 0;
                            cashier.HourRate = reader["HourRate"] != DBNull.Value ? Convert.ToDecimal(reader["HourRate"]) : 0;
                            emp = cashier;
                        }
                        else
                        {
                            emp = new Employee(); // ✅ fix lỗi ở đây
                        }

                        emp.Id = Convert.ToInt32(reader["Id"]);
                        emp.Name = reader["Name"].ToString();
                        emp.Email = reader["Email"].ToString();
                        emp.Phone = reader["Phone"].ToString();
                        emp._Role = role;
                        emp.BaseSalary = Convert.ToDecimal(reader["BaseSalary"]);
                        emp.Username = reader["Username"].ToString();
                        emp.Password = reader["Password"].ToString();

                        list.Add(emp);
                    }
                }
            }
            return list;
        }
        public static bool DeleteEmployee(int id)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                // Kiểm tra tồn tại
                string checkQuery = "SELECT COUNT(*) FROM Employees WHERE Id = @Id";
                using (var checkCmd = new SQLiteCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@Id", id);
                    long count = (long)checkCmd.ExecuteScalar();
                    if (count == 0)
                        return false; // Không tồn tại
                }

                // Thực hiện xóa
                string deleteQuery = "DELETE FROM Employees WHERE Id = @Id";
                using (var deleteCmd = new SQLiteCommand(deleteQuery, conn))
                {
                    deleteCmd.Parameters.AddWithValue("@Id", id);
                    deleteCmd.ExecuteNonQuery();
                }

                return true;
            }
        }
    }
}
