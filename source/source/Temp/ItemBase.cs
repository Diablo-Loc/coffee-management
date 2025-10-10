using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace source.Temp
{
    public abstract class ItemBase
    {
        private string sname;
        private decimal sprice;

        public string Name { get { return sname; } set { sname = value; } }
        public decimal Price 
        { 
            get { return sprice; } 
            set 
            {
                if (value < 0) throw new ArgumentException("Price must be >= 0!");
                sprice = value; 
            } 
        }

        public ItemBase()
        {

        }

        public ItemBase(string name,decimal price)
        {
            sname = name;
            sprice = price;
        }

        ~ItemBase()
        {

        }
        //method
        //hiện thị tất cả mô tả về tên, giá hiện trong UI
        public virtual string DisplayInfo()
        {
            return sname+" - "+sprice;
        }
        //thay đổi giá
        public virtual void ChangePrice(decimal price)
        {
            if (price < 0) throw new ArgumentException("ERROR! Price must be >=0!");
            sprice = price;
        }
    }
}
