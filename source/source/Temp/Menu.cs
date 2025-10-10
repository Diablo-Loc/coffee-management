using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace source.Temp
{
    public class Menu
    {
        private List<MenuItem> _items;

        public List<MenuItem> Items
        {
            get { return _items; }
            set { _items = value; }
        }
        public Menu()
        {
            _items =new List<MenuItem>();
        }
        public Menu(List<MenuItem> items)
        {
            Items =items;
        }
        //method
        //thêm sản phẩm
        public void AddItem(MenuItem item) 
        {
            if(item == null) {  throw new ArgumentNullException("item"); }
            _items.Add(item);
        }
        //xóa sản phẩm
        public void RemoveItem(MenuItem item) 
        {
            if (item == null || !_items.Remove(item))
            throw new Exception("Cannot delete item: data is invalid or does not exist.");
        }
    }
}
