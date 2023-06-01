using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deligets
{
    public class ShoppingCartModel
    {
        public delegate void MentionDiscount(decimal sutTotal);
        public List<ProductModel> items { get; set; } = new List<ProductModel>();
        public decimal GenarateTotal(MentionDiscount mentionSubTotal,Func<List<ProductModel>,decimal,decimal> calculateDiscountTotal,Action<string> tellUserWeAreDiscounting)
        {
            decimal subTotal = items.Sum(p => p.Price);

            mentionSubTotal(subTotal);

            tellUserWeAreDiscounting("We are applying your discount.");

            return calculateDiscountTotal(items, subTotal);
        }

        public double Calculation(Func<double, double, double,double> qty)
        {
            return qty(5.0, 10.0,16.8);
        }


    }
}
