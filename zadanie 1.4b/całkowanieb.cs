using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_1._4b {

    class całkowanieb {
        static void Main(string[] args) {
            FunkcjaKwadratowa f = new FunkcjaKwadratowa(double.Parse(args[0]), double.Parse(args[1]), double.Parse(args[2]));
            double x1 = double.Parse(args[3]);
            double x2 = double.Parse(args[4]);
            Console.WriteLine(f.CalkaOznaczona(x1, x2));
        }
    }
}
