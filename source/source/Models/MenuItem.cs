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
        public MenuItem(string category,string description): base()
        {
            this.sCategory = category;
            this.sDescription = description;

        }
        //method
    }
}
