using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
namespace HackerRank
{
    class Solution
    {
        static void Main(String[] args)
        {
            //Solution test = new Solution();
            int[] a = { 27, 45 };
            //getLCM(a);
            GetGCD(a[0], a[1]);
        }
        public static void GetGCD(int num1, int num2)
        {
            while (num1 != num2)
            {
                if (num1 > num2)
                {
                    num1 -= num2;
                    Console.WriteLine("number 1: " + num1);
                }
                if (num2 > num1)
                {
                    num2 -= num1;
                    Console.WriteLine("number 2: " + num2);
                }
            }
            //return num1;
            Console.WriteLine(num1 + " " + num2);
        }
    }
}