using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace source.Models
{
    public enum TableStatus     // Trạng thái bàn
    {
       Free,
       Occupied,
       Reserved,
    }
    internal class Table
    {
        private int pNum;
        private TableStatus pStatus; // Free, Occupied, Reserved,(Có người/ trống )
    
        private Order pCurrentOrder;
        private Order pTempOrder;
        private List<Order> pListOrders; // Lish su order
        private Bill pBill;


        public Table()
        {
            this.pNum = 0;
            this.pStatus = TableStatus.Free;
            this.pListOrders = new List<Order>();
            this.pCurrentOrder = null;
            this.pBill = null;
            this.pTempOrder = null;
        }

        public Table(int num)
        {
            if(num<0) throw new ArgumentException("Table number must be > 0");
            this.pNum = num;
            this.pStatus = TableStatus.Free;
            this.pListOrders = new List<Order>();
            this.pBill = null;

        }
        public int Number { get { return this.pNum; } set { this.pNum = value; } }
        public TableStatus Status { get { return this.pStatus; } set { this.pStatus = value; } }
        public Order CurrentOrder { get { return this.pCurrentOrder; } set { this.pCurrentOrder = value; } }
        public Order TempOrder { get { return this.pTempOrder; } set { this.pTempOrder = value; } }
        public List<Order> ListOrders { get { return this.pListOrders; } set { this.pListOrders = value; } }
        public Bill Bill { get { return this.pBill; } set { this.pBill = value; } }





        // Tao ra order moi
        public void CreateOrder() {
            if (this.pStatus == TableStatus.Occupied && pCurrentOrder != null)
                throw new InvalidOperationException("Table already has an active order.");

            this.pTempOrder = new Order(pNum);
        }
        // Them / confirm -> send order / cancel order hien tai  / Tui ket noi voi order qua class menu item 
        public void AddItemToTempOrder(MenuItem item)
        {
            if (this.pTempOrder == null)
                throw new InvalidOperationException("Create order before");

            this.pTempOrder.AddItem(item);
        }
        public void ConfirmOrder()
        {
            if (this.pTempOrder == null)
                throw new InvalidOperationException("No temporary order to confirm.");

            this.pCurrentOrder = this.pTempOrder;
            this.pListOrders.Add(pCurrentOrder);
            this.pStatus = TableStatus.Occupied;
            this.pTempOrder = null;
        }
        //Cancel order hien tai 
        public void CancelOrder()
        {
            pTempOrder = null;  // chỉ hủy temp, không ảnh hưởng current
        }
        
        // Reset bàn
        public void ClearTable()
        {
            this.CurrentOrder = null;
            this.Status = TableStatus.Free;
        }


        public Bill GenerateBill(Order order)
        {
           
            this.pBill = new Bill(order);
            this.CurrentOrder = null;
            this.Status = TableStatus.Free;

            return this.pBill;
        }



        ~Table() { }


    }



}