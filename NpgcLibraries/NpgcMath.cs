using System;

namespace NpgcLibraries {
    public class NpgcMath {
        public static int Max(int first, int second) {
            return first > second ? first : second;
        }


        public static long Max(long first, long second) {
            return first > second ? first : second;
        }

        public static double Max(double first, double second) {
            return first > second ? first : second;
        }


        public static int Min(int first, int second) {
            return first < second ? first : second;
        }

        public static long Min(long first, long second) {
            return first < second ? first : second;
        }

        public static double Min(double first, double second) {
            return first < second ? first : second;
        }


        public static int Abs(int num) {
            return num >= 0 ? num : -num;
        }

        public static long Abs(long num) {
            return num >= 0 ? num : -num;
        }

        public static double Abs(double num) {
            return num >= 0 ? num : -num;
        }

        public static int Ceiling(double num) {
            if (num % 1 == 0) {
                //that means the number is integer already
                return (int) num;
            }

            return num >= 0 ? ((int) num) + 1 : (int) num;
        }

        public static int Floor(double num) {
            if (num % 1 == 0) {
                //that means the number is integer already
                return (int) num;
            }

            return num >= 0 ? ((int) num) : (int) num - 1;
        }
    }

    class Test1 {
        public static void Main(string[] args) {
            long a = 437368726582;
            //max min abs round ceil floor

            

            Console.WriteLine(NpgcMath.Floor(0.7));
            Console.WriteLine(NpgcMath.Floor(2.0000000001));
            Console.WriteLine(NpgcMath.Floor(-1.1));
            Console.WriteLine(NpgcMath.Floor(-19.9));


            Console.WriteLine(Math.Floor(-19.9));
        }
    }
}