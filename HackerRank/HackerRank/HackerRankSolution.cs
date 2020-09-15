using System;
namespace HackerRank
{
    public class HackerrankKangaroo
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
}
