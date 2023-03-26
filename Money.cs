using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    public class Money
    {
        private decimal amount; 
        public decimal Amount { get { return amount; } }
        public Money(decimal amount)
        {
            this.amount = amount;
        }
        public static Money operator +(Money m1 , Money m2)
        {
            return new Money(m1.Amount+ m2.Amount);

        }
        public static Money operator -(Money m1, Money m2)
        {
            return new Money(m1.Amount - m2.Amount);

        }
        public static bool operator >(Money m1, Money m2)
        {
            return (m1.Amount > m2.Amount);

        }
        public static bool operator <(Money m1, Money m2)
        {
            return (m1.Amount < m2.Amount);

        }

    }
}
