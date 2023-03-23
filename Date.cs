using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    public class Date
    {
        private static int[] MonthToYear = {0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
        private readonly int _day;
        private readonly int _month;
        private readonly int _year;

        //cannot access the readonly type expect if we use constructor
        public Date(int day, int month, int year)
        {
            var IsLeap = year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
          
            //for validate the year
            if(year >= 1 && year <= 9999)
            {
                if(month >= 1 && month <= 12)
                {
                    int[] Months = MonthToYear;
                    if (IsLeap)
                        Months[2] += 1;
                    if(day >= 1 && day <= Months[month])
                    {
                        this._day = day;
                        this._month = month;
                        this._year = year;

                    }
                    else
                    {
                        // just set the day to the initial value
                        this._day = 1;
                        this._month = month;
                        this._year = year;


                    }


                }
                else
                {
                    this._day = 1;
                    this._month = 1;
                    this._year = year;

                }
            }
            else
            {
                this._day = 1;
                this._month = 1;
                this._year = 1;

            }


        }

        public Date(int year) : this(01 , 01 , year)
        {

        }
        public Date(int month ,int year) : this(01, month, year)
        {

        }

        public string PrintDate()
        {
            return $"{_day.ToString().PadLeft(2 , '0')} /  {_month.ToString().PadLeft(2, '0')} /  {_year.ToString().PadLeft(4, '0')}";
        }

    }
}
