using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace source.Models
{
    internal class TablesManagement {
        private List<Table> pTables;


        public TablesManagement()
        {

        }
        public List<Table> Tables { get { return pTables; } set { pTables = value; } }


    }
}
}
