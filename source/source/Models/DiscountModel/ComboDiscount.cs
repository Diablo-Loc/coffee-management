using source.Models.OrderModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace source.Models.DiscountModel
{
    public class ComboDiscount:Discount
    {
        public List<string> ComboItem { get; set; } = new List<string>();
        public ComboDiscount():base() 
        {
            Type = "Combo";
        }
        ~ComboDiscount() { }
        public override decimal Apply(Order order)
        {
            if (!IsActive || order == null) return 0m;

            var names = order.Items.Select(i => i.Item?.Name).ToList();
            bool containsAll = ComboItem.All(ci => names.Contains(ci));

            if (containsAll)
            {
                return Percent > 0 ? order.GetSubtotal() * Percent / 100m : 0m;
            }

            return 0m;
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Combo gồm: {string.Join(", ", ComboItem)}");
        }
    }
}
