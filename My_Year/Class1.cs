using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace My_Year
{
    public class My_Year_1
    {
        public string Year_find(string year)
        {
            if (Regex.IsMatch(year, "^[a-z]+$"))
            {
                return "ERROR: год состоит из целого числа";
            }

            int new_year = Convert.ToInt32(year);

            if (new_year < 0)
            {
                return "ERROR: год не может быть < 0";
            }
            else
            {
                if ((new_year % 4 == 0 && new_year % 100 != 0) || new_year % 400 == 0)
                {
                    return year + " - високосный";
                }
                else
                {
                    return year + " - не високосный";
                }
            }
        }
    }
}
