﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LineComparison
{
    public class LineComparison
    {
        public static void checkLine()
        {
            Console.WriteLine("Enter x1 :- ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter x2 :- ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y1 :- ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y2 :- ");
            int y2 = Convert.ToInt32(Console.ReadLine());

            double Length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine("Length of line is  :- " + Length);
        }
    }
}