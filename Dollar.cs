using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    public class Dollar
    {
        //backing field 
        private double _price;
        // the structure of the proberity (set and get) 
        public double Price
        {
         set
        {
          _price= SetValue(value);
        }
        get
        {
            return _price;
        }
         }

       //automatic proberety
       // public double Price { set; get; }
       

        private double SetValue(double value) =>  value > 0 ? _price : 0;
        
    }
}
