using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace source.Models
{
    internal class MenuItem: ItemBase
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
            this.sCategory = category;
            this.sDescription = description;

        }
        //method
        //hiển thị ra UI
        public override string DisplayInfo()
        {
            return this.Name + " - " + this.Price +"|"+this.sCategory+"|"+this.sDescription ;
        }
        //đổi mô tả
        public void ChangeDescription(string newdescrip)
        {

        }
        //thêm giảm giá %
        public void Applydiscount(decimal percent)
        {

        }
        //....
    }
}
