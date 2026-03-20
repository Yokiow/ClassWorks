using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW5.Variant00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1.Number number = new Task1.Number(5);
            Task1.Number number1 = new Task1.Number(10);

            number.Sum(number1);
            Console.WriteLine(number.Real);
            number.Sub(number1);
            Console.WriteLine(number.Real);
            number.Mul(number1);
            Console.WriteLine(number.Real);
            number.Div(number1);
            Console.WriteLine(number.Real);
            number.Neg();
            Console.WriteLine(number.Real);
        }
    }
}
