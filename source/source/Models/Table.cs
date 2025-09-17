using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace source.Models
{
    internal class Table
    {
        private int pNum;
        private string pStatus; // Occupied, Empty (Có người/ trống )
        private int pTime;
        private List<Order> pOrders;
        private Bill pBill;


        public Table()
        {
            this.pNum = 0;
            this.pStatus = "Empty";
            this.pOrders = new List<Order>();
            this.pTime = 0;
            pBill = new Bill();
        }

        public Table(int num)
        {
            this.pNum = num;
            this.pStatus = "Empty";
            //  this.pTime =
            this.pOrders = new List<Order>();
            this.pBill = new Bill();

        }
        public int Number { get { return this.pNum; } set { this.pNum = value; } }
        public string Status { get { return pStatus; } set { pStatus = value; } }
        public List<Order> Orders { get { return pOrders; } set { pOrders = value; } }
        public Bill bill { get { return pBill; } set { pBill = value; } }


        public void getOrder() { }

        public void addOrder() { }

        public void printBill() { }
        ~Table() { }


    }



}