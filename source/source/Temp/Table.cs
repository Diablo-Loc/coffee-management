using source.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace source.Temp
{
    public enum TableStatus     // Trạng thái bàn
    {
       Free,
       Occupied,
       Reserved,
    }
   public class Table
    {
        private int pNum;
        private TableStatus pStatus; // Free, Occupied, Reserved,(Có người/ trống )
    
        private Order1 pCurrentOrder1;
        private Order1 pTempOrder1;
        private List<Order1> pListOrder1s; // Lish su Order1
        private Bill pBill;


        public Table()
        {
            pNum = 0;
            pStatus = TableStatus.Free;
            pListOrder1s = new List<Order1>();
            pCurrentOrder1 = null;
            pBill = null;
            pTempOrder1 = null;
        }

        public Table(int num)
        {
            if(num<0) throw new ArgumentException("Table number must be > 0");
            pNum = num;
            pStatus = TableStatus.Free;
            pListOrder1s = new List<Order1>();
            pBill = null;

        }
        public int Number { get { return pNum; } set { pNum = value; } }
        public TableStatus Status { get { return pStatus; } set { pStatus = value; } }
        public Order1 CurrentOrder1 { get { return pCurrentOrder1; } set { pCurrentOrder1 = value; } }
        public Order1 TempOrder1 { get { return pTempOrder1; } set { pTempOrder1 = value; } }
        public List<Order1> ListOrder1s { get { return pListOrder1s; } set { pListOrder1s = value; } }
        public Bill Bill { get { return pBill; } set { pBill = value; } }





        // Tao ra Order1 moi
        public void CreateOrder1() {
            if (pStatus == TableStatus.Occupied && pCurrentOrder1 != null)
                throw new InvalidOperationException("Table already has an active Order1.");

            pTempOrder1 = new Order1(pNum);
        }
        // Them / confirm -> send Order1 / cancel Order1 hien tai  / Tui ket noi voi Order1 qua class menu item 
        public void AddItemToTempOrder1(MenuItem item,int quantity)
        {
            if (pTempOrder1 == null)
                throw new InvalidOperationException("Create Order1 before");

            pTempOrder1.AddItem(item,quantity);
        }
        public void ConfirmOrder1()
        {
            if (pTempOrder1 == null)
                throw new InvalidOperationException("No temporary Order1 to confirm.");

            pCurrentOrder1 = pTempOrder1;
            pListOrder1s.Add(pCurrentOrder1);
            pStatus = TableStatus.Occupied;
            pTempOrder1 = null;
        }
        //Cancel Order1 hien tai 
        public void CancelOrder1()
        {
            pTempOrder1 = null;  // chỉ hủy temp, không ảnh hưởng current
        }
        
        // Reset bàn
        public void ClearTable()
        {
            CurrentOrder1 = null;
            Status = TableStatus.Free;
        }


        /*public Bill GenerateBill(Order1 Order1)
        {
           
            pBill = new Bill(Order1);
            CurrentOrder1 = null;
            Status = TableStatus.Free;

            return pBill;
        }*/



        ~Table() { }


    }



}