using System;

namespace Lecture2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(sum(2,"3"));

        }
        public static int sum(int a,int b)
        {
            return a + b;
        }
        public static int sum(double a, double b)
        {
            return Convert.ToInt32(a)+Convert.ToInt32(b);
        }
        public static int sum(float a, float b)
        {
            return Convert.ToInt32(a) + Convert.ToInt32(b);
        }

        public static int sum(int a,String b)
        {
            return a + (Convert.ToInt32(b));
        }
        public static int sum(String a, int b)
        {
            return Convert.ToInt32(a) + b;
        }
        public static int sum(String a, String b)
        {
            //sbcks
            return (Convert.ToInt32(a)) + (Convert.ToInt32(b));
        }

    }
}
