using System;
using System.Collections.Generic;
using System.Text;

namespace BestBuy
{
    public class CashRegister
    {
        public int CashRegisterSum(int[] num)
        {
            int sum = 0;
            foreach(int n in num)
            {
                sum += n;
            }
            return sum;
            
        }
    }
}
