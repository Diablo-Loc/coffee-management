using source.Models.PersonModel;
using source.Models.Catalog;
using source.Models.OrderModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace source.Models
{
    internal class CoffeeShop
    {
        private string _Name;
        private List<Employee> _Employees;
        private List<Customer> _Customers;
        private List<Product> _Products;
        private List<Order> _Orders;

        public string Name { get { return _Name; } set { _Name = value; } }
        public List<Employee> Employees { get { return _Employees; } set { this._Employees = value; } }
        public List<Customer> Customers { get { return _Customers; } set { this._Customers = value; } }
        public List<Product> Products { get { return _Products; } set { this._Products = value; } }
        public List<Order> Orders { get { return _Orders; } set { this._Orders = value; } }
        
        public CoffeeShop()
        {
            _Name = "Coffee Shop";
            _Employees = new List<Employee>();
            _Customers = new List<Customer>();
            _Products = new List<Product>();
            _Orders = new List<Order>();
        }
        public CoffeeShop(string name)
        {
            _Name = name;
            _Employees = new List<Employee>();
            _Customers = new List<Customer>();
            _Products = new List<Product>();
            _Orders = new List<Order>();
        }
        ~CoffeeShop() { }
        public void AddEmployee(Employee emp)
        {
            _Employees.Add(emp);
         
        }
        
        public void AddCustomer(Customer cus)
        {
            _Customers.Add(cus);
           
        }
        public void AddProduct(Product pro)
        {
            _Products.Add(pro);

        }
        public Product FindProduct(string name)
        {
            foreach (var product in _Products)
            {
                if (product.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    return product;
                }
            }

            Console.WriteLine("❌ Không tìm thấy sản phẩm.");
            return null;
        }


        public Customer FindCustomerByEmail(string email)
        {
            return _Customers.Find(c => c.Email == email);
        }
    }
}
