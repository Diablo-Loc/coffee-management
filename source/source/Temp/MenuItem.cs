using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace source.Temp
{
    public class MenuItem: ItemBase
    {
        
        private string sCategory;
        private string sDescription;

        public string Category
        {
            get { return sCategory; }
            set { sCategory = value; }
        }
        public string Description
        {
            get { return sDescription; }
            set { sDescription = value; }
        }

        public MenuItem():base()
        {
        }
        public MenuItem(string name, decimal price, string category,string description): base(name,price)
        {
            sCategory = category;
            sDescription = description;

        }
        //method
        //hiển thị ra UI
        public override string DisplayInfo()
        {
            return Name + " - " + Price +"|"+sCategory+"|"+sDescription ;
        }
        //đổi mô tả
        public void ChangeDescription(string newdescrip)
        {
            sDescription = newdescrip;
        }
        //thêm giảm giá %
        public void Applydiscount(decimal percent)
        {
            if (percent < 0 || percent > 100)
                throw new ArgumentException("The discount percentage must be between 0 and 100.");
            Price = Price * (1 - percent / 100);
        }
        //hiển thị để debug
        public override string ToString()
        {
            return $"{Name} ({Category}) - {Price:N0} ₫";
        }
    }
}
