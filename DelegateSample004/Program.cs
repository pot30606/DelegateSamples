﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateSample004
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> source
               = new List<string> { "Bill", "John", "David", "Tom", "David" };

            MyCalss obj = new MyCalss();
            var result = obj.DoWhere(source,(x) => { return x == "David"; });

            //var result = obj.DoWhere(source,(x) => x == "David");

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
