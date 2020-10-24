using System;

namespace FacFab
{
    public class MyDLLClass
    {
        public static long fac(long num)
        {
            if (num < 0) return -1;
            long result = 1;
            for (int i = 1; i <= num; i++)
                result = result * i;
            return result;
        }
        public static long fab(long num)
        {
            if (num < 0) return -1;
            if (num == 0) return 0;
            if (num == 1) return 1;
            int first = 0;
            int second = 1;
            int result = second;
            for (int i = 1; i < num; i++)
            {
                result = first + second;
                first = second;
                second = result;
            }
            return result;
        }
    }
}
