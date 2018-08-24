using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionProgram
{
    public class SampleProgram
    {
        public int sum(int n1, int n2)
        {
            int c;
            c = n1 + n2;
            return c;
        }

        public static void Main(string[] args)
        {
            SampleProgram sp = new SampleProgram();
            Console.WriteLine("enter the number");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the number");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("the number is:{0}", sp.sum(x, y));

        }
    }
}

