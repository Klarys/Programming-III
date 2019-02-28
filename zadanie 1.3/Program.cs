using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_1._3 {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(args[0]);
            for(int i=1; i<=n; i++) {
                for(int j=1; j<=n; j++) {
                    Console.Write("{0,5}",i * j);
               
                }
                Console.WriteLine();
            }

        }
    }
}
