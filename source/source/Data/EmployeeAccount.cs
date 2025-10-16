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
                Password TEXT
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
                (Name, Email, Phone, Role, BaseSalary, Username, Password) 
                VALUES (@Name, @Email, @Phone, @Role, @BaseSalary, @Username, @Password)";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", emp.Name);
                    cmd.Parameters.AddWithValue("@Email", emp.Email);
                    cmd.Parameters.AddWithValue("@Phone", emp.Phone);
                    cmd.Parameters.AddWithValue("@Role", emp._Role);
                    cmd.Parameters.AddWithValue("@BaseSalary", emp.BaseSalary);
                    cmd.Parameters.AddWithValue("@Username", emp.Username);
                    cmd.Parameters.AddWithValue("@Password", emp.Password);
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
            Password = @Password
            WHERE Username = @Username"; // giả sử Username là duy nhất

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", emp.Name);
                    cmd.Parameters.AddWithValue("@Email", emp.Email);
                    cmd.Parameters.AddWithValue("@Phone", emp.Phone);
                    cmd.Parameters.AddWithValue("@Role", emp._Role);
                    cmd.Parameters.AddWithValue("@BaseSalary", emp.BaseSalary);
                    cmd.Parameters.AddWithValue("@Password", emp.Password);
                    cmd.Parameters.AddWithValue("@Username", emp.Username);

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
                                emp = new Manager();
                            else if (role == Role.Cashier)
                                emp = new Cashier();
                            else
                                emp = new Employee();

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
                            emp = new Manager();
                        else if (role == Role.Cashier)
                            emp = new Cashier();
                        else
                            emp = new Employee();

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
        public static void DeleteEmployee(int id)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Employees WHERE Id = @Id";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
