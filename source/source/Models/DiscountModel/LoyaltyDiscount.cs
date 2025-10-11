using source.Models.OrderModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace source.Models.DiscountModel
{
    public class LoyaltyDiscount:Discount
    {
        private int _RequirePoint;
        private decimal _DiscountRate;
        public int RequirePoint { get { return _RequirePoint; } set { _RequirePoint = value; } }
        public decimal DiscountRate {  get { return _DiscountRate; } set {_DiscountRate = value; } }
        public LoyaltyDiscount() : base()
        {
            Type = "Loyalty";
        }
        public LoyaltyDiscount(string name, string type, decimal rate, int requirePoint) : base(name, type, rate)
        {
            _RequirePoint = requirePoint;
            _DiscountRate = rate;
        }
        public override decimal Apply(Order order)
        {
            return 0m;
        }
        public decimal Apply(int customerPoint, decimal subtotal)
        {
            if (!IsActive || customerPoint < RequirePoint) return 0m;
            return subtotal * DiscountRate / 100m;
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Yêu cầu điểm: {RequirePoint}, Giảm: {DiscountRate}%");
        }

    }
}
