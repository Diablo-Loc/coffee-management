using source.Models.OrderModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace source.Services
{ 
    internal class TableService
    {
        public List<(int Number, string Status, int GuestCount, decimal Total)> Tables { get; private set; }
        public TableService(int total) {
            Tables = new();
            for (int i = 1; i <= total; i++)
            {
                Tables.Add((i, "Free", 0, 0));
            }
        }
        
        public void UpdateTablesStatus(List<Order> active)
        {
            for (int i = 0; i < Tables.Count; i++)
            {
                Tables[i] = (Tables[i].Number, "Free", 0, 0);
            }
            foreach (var order in active)
            {
                int index = Tables.FindIndex(t => t.Number == order.TableNumber);
                if (index != -1)
                {
                    Tables[index] = (order.TableNumber, "Occupied", order.GuestCount, order.Total());
                }
            }
        }
    }
}
