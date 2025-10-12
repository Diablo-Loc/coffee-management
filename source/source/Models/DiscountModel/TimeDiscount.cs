using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using source.Models.OrderModel;

namespace source.Models.DiscountModel
{
    public class TimeDiscount:Discount
    {
        private TimeSpan _StartTime;
        private TimeSpan _EndTime;
        public TimeSpan StartTime { get { return _StartTime; } set { _StartTime = value; } }
        public TimeSpan EndTime { get { return _EndTime; } set { _EndTime = value; } }  
        public TimeDiscount():base() {
            Type = "Time";
        }
        ~TimeDiscount() { }
        public override decimal Apply(Order order)
        {
            if (!IsActive || order == null) return 0m;
            var now = DateTime.Now.TimeOfDay;
            if (StartTime <= now && now <= EndTime)
            {
                return order.GetSubtotal() * Percent / 100m;
            }
            return 0m;
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Thời gian áp dụng: {StartTime:hh\\:mm} - {EndTime:hh\\:mm}, Giảm: {Percent}%");
        }
    }
}
