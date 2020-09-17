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
    /*
     * ==============================================================
     * https://www.hackerrank.com/challenges/kangaroo/problem
     * ==============================================================
     */
    public class CKangaroo
    {
        public static string Kangaroo(int x1, int v1, int x2, int v2)
        {
            if (v1 > v2)
            {

                float remainder = ((x1 - x2) % (v1 - v2));
                if (remainder == 0)
                {
                    return "YES";
                }
                else return "NO";
            }
            else return "NO";
        }
    }
    /*
     * ==============================================================
     * https://www.hackerrank.com/challenges/between-two-sets/problem
     * ==============================================================
     */
    public class BetweenTwoSet
    {
        public static int GetTotalX(List<int> a, List<int> b)
        {
            int aNum1 = a[0];
            for(int i = 1; i < a.Count; i++)
            {
                aNum1 = GetLCM(aNum1, a[i]);
            }

            int bNum1 = b[0];
            for(int i = 1; i < b.Count; i++)
            {
                bNum1 = GetGCD(bNum1, b[i]);
            }

            List<int> list = new List<int>();

            int temp = aNum1;

            while(temp < bNum1)
            {
                list.Add(temp);
                temp += aNum1;
            }

            int counter = 0;
            foreach(int f in list)
            {
                bool mul = true;
                foreach(int g in b){
                    if (g % f != 0)
                        mul = false;
                    break;
                }
                if (mul) counter++;
            }
            return 0;
        }
        public static int GetGCD(int num1, int num2)
        {
            if (num2 == 0)
                return num1;
            return GetGCD(num1, num1 % num2);
        }        public static int GetLCM(int num1, int num2)
        {
            return (num1 * num2) / GetGCD(num1, num2);
        }    }
}
