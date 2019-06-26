using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2 {
    class Program {
        static void Main(string[] args) {
            var matrix = new Matrix(2, 3);

            matrix.InputFromKeyboard();
            Console.WriteLine($"\nEntered:\n{matrix}");

            matrix.SortEachRowDescending();
            Console.WriteLine($"\nSorted:\n{matrix}");

            matrix++;
            Console.WriteLine($"\nAfter ++ operator:\n{matrix}");

            matrix--;
            Console.WriteLine($"\nAfter -- operator:\n{matrix}");

            Console.Write("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
