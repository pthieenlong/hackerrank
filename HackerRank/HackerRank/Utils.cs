using System;
namespace HackerRank
{
    public class Utils
    {
        #region GCD & LCM
        // GCD de nhat
        public static int GetGCD(int num1, int num2)
        {
            while (num1 != num2)
            {
                if (num1 > num2)
                {
                    num1 -= num2;
                }
                if (num2 > num1)
                {
                    num2 -= num1;
                }
            }
            return num1;
        }
        // GCD De quy
        public static int GetGCDRecursive(int num1, int num2)
        {
            if (num1 == 0)
                return num2;
            if (num2 == 0)
                return num1;

            if (num1 > num2)
                return GetGCDRecursive(num1 % num2, num2);
            else
                return GetGCDRecursive(num1, num2 % num1);
        }
        // GCD ngan gon vcl, sai de quy
        public static int GetGCD_Ver2(int num1, int num2)
        {
            if (num2 == 0)
                return num1;
            return GetGCD_Ver2(num1, num1 % num2);
        }
        // LCM
        public static int GetLCM(int num1, int num2)
        {
            return (num1 * num2) / GetGCD(num1, num2);
        }
        #endregion GCM & LCM
    }
}
