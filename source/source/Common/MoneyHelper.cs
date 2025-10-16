using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace source.Common
{
    public static class MoneyHelper
    {
        public static decimal IntoRawMoney(string raw)
        {
            if (string.IsNullOrWhiteSpace(raw))
                return 0;

            string clean = raw.Replace("đ", "")
                                .Replace("VND", "")
                                .Replace("VD", "")
                                .Replace(",", "")
                                .Replace(".", "")
                                .Trim();

            return decimal.TryParse(clean, out decimal result) ? result : 0;
        }
    }
}
