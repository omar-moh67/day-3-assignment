using System;

namespace assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            Console.Write("enter num");
            int num1;
            int.TryParse(Console.ReadLine(),out  num1);
            if (num1%3==0 && num1%4==0)
            {
                Console.Write("yes");
            }
            else
            {
                Console.Write("no");
            }
            #endregion




        }
    }
}
