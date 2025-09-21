using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace source.Models
{
    internal class TablesManagement {
        private List<Table> pTables;

        public List<Table> Tables {  get { return this.pTables; } set { this.pTables = value; } }
        public TablesManagement(int NumberOfTable)
        {
            if (NumberOfTable <= 0) throw new ArgumentException("Number of tables must be > 0");
            pTables = new List<Table>();
            for (int i = 1; i <= NumberOfTable; i++)
            {
                pTables.Add(new Table(i));
            }
        }
        //Them ban
        public void AddTable( int number)
        {
            if(number <= 0) throw new ArgumentException("Table number must be > 0");
            pTables.Add(new Table(number));
        }
        // Xoa ban
        public void RemoveTable(int number)
        {
            Table tableToRemove = pTables.FirstOrDefault(t => t.Number == number);
            if (tableToRemove != null)
            {
                pTables.Remove(tableToRemove);
            }
            else
            {
                throw new ArgumentException("Table not found.");
            }
        }
        // Lay thong tin ban tu số bàn
        public Table GetTableByNumber( int number)
        {
            if(number <= 0) throw new ArgumentException("Table number must be > 0");
            foreach( Table i in pTables)
            {
                if (i.Number == number) return i;
            }
            return null;
        }
        //Lay danh sach những bàn trống
        public List<Table> GetFreeTable()
        {
            List<Table> freeTables = new List<Table>();
            foreach( Table i in pTables)
            {
                if (i.Status == TableStatus.Free) freeTables.Add(i);
            }
            return freeTables;
        }
        // Giải phóng bàn
        public void RealeaseTable(int number)
        {
            Table table = GetTableByNumber(number);
            if(table == null) throw new ArgumentException("Table not found.");
            table.ClearTable();
        }
    }
}

