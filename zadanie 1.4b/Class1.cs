using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_1._4b {
    class FunkcjaKwadratowa {
        private double a, b, c;
        public FunkcjaKwadratowa(double a, double b, double c) {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double CalkaOznaczona(double x1, double x2) {
            return ((((a * x2 / 3 + b / 2) * x2) + c) * x2 - (((a * x1 / 3 + b / 2) * x1) + c) * x1);
        }
    }

}
