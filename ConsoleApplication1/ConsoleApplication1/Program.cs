using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class square
    {
        int a;
        public void func()
        {
            Console.Write("введите длину:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Площадь квадрата:" + (a * a).ToString());
            Console.Read();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            square S = new square();
            S.func();
        }
    }
}
