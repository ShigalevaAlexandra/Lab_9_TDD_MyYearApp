using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using My_Year;

namespace My_Year_app
{
    public class My_Year_app_1
    {
        static void Main()
        {
            Console.WriteLine("Введите год: ");

            var year = Console.ReadLine();

            My_Year_1 new_year = new My_Year_1();
            string res = new_year.Year_find(year);

            Console.WriteLine(res + "\n");
        }
    }
}