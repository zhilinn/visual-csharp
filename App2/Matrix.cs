using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2 {
    class Matrix {
        readonly double[,] values;
        readonly int n, m;

        public Matrix(int n, int m) : this(new double[n, m]) {}

        public Matrix(int n, int m, Random random) : this(new double[n, m]) {
            for (var i = 0; i < n; i++) {
                for (var j = 0; j < m; j++) {
                    values[i, j] = random.NextDouble();
                }
            }
        }

        public Matrix(double[,] values) {
            n = values.GetLength(0);
            m = values.GetLength(1);
            this.values = values;
        }

        public static Matrix operator *(Matrix lhs, Matrix rhs) {
            var matrix = new Matrix(lhs.n, rhs.m);
            for (var i = 0; i < matrix.n; i++) {
                for (var j = 0; j < matrix.m; j++) {
                    for (var k = 0; k < lhs.m; k++) {
                        matrix.values[i, j] += lhs.values[i, k] * rhs.values[k, j];
                    }
                }
            }
            return matrix;
        }

        public static Matrix operator +(Matrix lhs, double rhs) {
            var matrix = new Matrix(lhs.n, lhs.m);
            for (var i = 0; i < matrix.n; i++) {
                for (var j = 0; j < matrix.m; j++) {
                    matrix.values[i, j] = lhs.values[i, j] + rhs;
                }
            }
            return matrix;
        }

        public static Matrix operator -(Matrix lhs, double rhs) {
            return lhs + -rhs;
        }

        public static Matrix operator ++(Matrix matrix) {
            return matrix += 1.0;
        }

        public static Matrix operator --(Matrix matrix) {
            return matrix -= 1.0;
        }

        public void InputFromKeyboard() {
            Console.WriteLine($"Enter {n}x{m} matrix:");
            for (var i = 0; i < n; i++) {
                Console.WriteLine($"\nRow {i + 1}:");
                for (var j = 0; j < m; j++) {
                    values[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }
        }

        public void SortEachRowDescending() {
            for (var i = 0; i < n; i++) {
                for (var j = 0; j < m - 1; j++) {
                    for (var k = j + 1; k < m; k++) {
                        if (values[i, j] < values[i, k]) {
                            var tmp = values[i, j];
                            values[i, j] = values[i, k];
                            values[i, k] = tmp;
                        }
                    }
                }
            }
        }

        public override string ToString() {
            var str = "";
            for (var i = 0; i < n; i++) {
                str += "  ";
                for (var j = 0; j < m; j++) {
                    str += $"{values[i, j]} ";
                }
                str += "\n";
            }
            return str.Substring(0, str.Length - 1);
        }
    }
}
