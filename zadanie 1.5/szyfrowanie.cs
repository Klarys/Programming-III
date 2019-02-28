using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_1._5 {
    class szyfrowanie {
        static void Main(string[] args) {

            string Source = Console.ReadLine();
            string Result = "";

            for (int i = 0; i < Source.Length; i++) {
                char character = Source[i];
                char resultcharacter = (char)(character ^ (character & 15));

                char first = (char)(character & 1);
                char second = (char)(character & 2);
                char third = (char)(character & 4);
                char fourth = (char)(character & 8);
                first = (char)(first << 1);
                second = (char)(second >> 1);
                third = (char)(third << 1);
                fourth = (char)(fourth >> 1);

                character = (char)(character >> 4);
                character = (char)(character << 4);

                resultcharacter = (char)(character | first | second | third | fourth);
                Result += resultcharacter;

            }
            Console.WriteLine(Result);
        }
    }
}
