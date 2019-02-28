using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_1._4 {
    class Program {
        static void Main(string[] args) {
            double a = double.Parse(args[0]);
            double b = double.Parse(args[1]);
            double c = double.Parse(args[2]);
            double x1 = double.Parse(args[3]);
            double x2 = double.Parse(args[4]);
            Console.WriteLine((((a * x2 / 3 + b / 2) * x2) + c) * x2 - (((a * x1 / 3 + b / 2) * x1) + c) * x1);
        }
    }
}
