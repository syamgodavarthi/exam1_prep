using System;

namespace exam1_prep
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = 281;
            Console.WriteLine(GetMean(n));
        }

        public static int GetMean(int n)
        {
            int sum = 0;
            string n1 = n.ToString();
            int count = 0;
            int m = 0;
            while (n != 0)
            {
                sum += n % 10;
                count += 1;

                n = n / 10;
            }
            Console.WriteLine(m);
            m = sum / count;
            return m;
        }
    }
}
