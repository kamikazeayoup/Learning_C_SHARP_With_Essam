using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    public class Stock
    {
        private string name;
        private decimal price;
        //public event StockPriceChangeHandler OnPriceChanged; //event with delegate 
        public string Name => this.name;
        public decimal Price { get { return price; } set { price = value; } }

        public Stock(string name)
        {
             this.name = name; 
        }
        public void ChangePriceBy(decimal percent)
        {
            var oldprice = this.price;
            this.price += (Math.Round(this.price * percent , 2 ));
           // Console.WriteLine($"The new price = {this.price} after adding {percent * 100}%");
            //if (OnPriceChanged != null) // chack from the subscirber 
            //{
            //    OnPriceChanged(this, oldprice); //firing the event
            //}
            
        }

        
    }
}
