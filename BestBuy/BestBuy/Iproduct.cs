using System;
using System.Collections.Generic;
using System.Text;

namespace BestBuy
{
    interface Iproduct
    {
        string Name { get; set; }
        double Price { get; set; }
        double PriceWithTax();
    }
}
