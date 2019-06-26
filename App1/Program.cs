using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1 {
    class Program {
        static void Main() {
            var matrix = new ulong[10, 10];

            FillMatrix(matrix);
            PrintMatrix(matrix);
            PrintMultiplesOf(5, matrix);

            Console.Write("Press any key to exit.");
            Console.ReadKey();
        }

        static void FillMatrix(ulong[,] matrix) {
            for (var i = 0; i < matrix.GetLength(0); i++) {
                for (var j = 0; j < matrix.GetLength(1); j++) {
                    matrix[i, j] = (ulong)Math.Pow(i + j, i);
                }
            }
        }

        static void PrintMatrix(ulong[,] matrix) {
            Console.WriteLine("Matrix:");
            for (var i = 0; i < matrix.GetLength(0); i++) {
                for (var j = 0; j < matrix.GetLength(1); j++) {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void PrintMultiplesOf(ulong n, ulong[,] matrix) {
            Console.WriteLine($"Multiples of {n}:");
            for (var i = 0; i < matrix.GetLength(0); i++) {
                Console.Write($"Row {i}: ");

                var max = ulong.MinValue;
                for (var j = 0; j < matrix.GetLength(1); j++) {
                    var m = matrix[i, j];
                    if (m % n == 0) {
                        Console.Write($"{m} ");
                        max = Math.Max(max, m);
                    }
                }

                if (max > ulong.MinValue) {
                    Console.WriteLine($"(max: {max})");
                }
                else {
                    Console.WriteLine($"no multiples of {n}");
                }
            }
            Console.WriteLine();
        }
    }
}
