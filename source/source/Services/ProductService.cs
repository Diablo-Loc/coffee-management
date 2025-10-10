using source.Data;
using source.Models.Catalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace source.Services
{
    internal class ProductService
    {
        private ProductRepository _repo = new ProductRepository();
        private List<Product> _products;

        public ProductService()
        {
            _repo.CreateTable();
            _products = _repo.GetAll();
        }

        public List<Product> GetAll() => _products;

        public List<Product> Search(string keyword) =>
            _products.Where(p => p.Name.ToLower().Contains(keyword.ToLower())).ToList();

        public List<string> GetCategories() =>
            _products.Select(p => p.Category).Distinct().ToList();

        public void Add(Product p)
        {
            _repo.Add(p);
            _products.Add(p);
        }

        public void Update(Product old, Product updated)
        {
            _repo.Update(old, updated);
            int index = _products.IndexOf(old);
            if (index >= 0) _products[index] = updated;
        }

        public void Delete(Product p)
        {
            _repo.Delete(p);
            _products.Remove(p);
        }

    }
}
