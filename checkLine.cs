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
            Console.WriteLine("Enter a1 :- ");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a2 :- ");
            int a2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b1 :- ");
            int b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b2 :- ");
            int b2 = Convert.ToInt32(Console.ReadLine());

            double Length1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Length of First line is  :- " + Length1);

            double Length2 = Math.Sqrt(Math.Pow(a2 - a1, 2) + Math.Pow(b2 - b1, 2));
            Console.WriteLine("Length of Second line is  :- " + Length2);

            // Console.WriteLine(System.Object.ReferenceEquals(Length1, Length2));
            //Console.WriteLine("Equals = "+ (Length1==Length2));
            Console.WriteLine("Equals = " + Length1.Equals(Length2));
        }
    }
}