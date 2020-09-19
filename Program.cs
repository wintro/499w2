using System;

namespace _499w2
{
    interface BinaryOperator<T> {
        T call(T a, T b);
    }

    class Add<T> : BinaryOperator<T> {
        public T call(T a, T b) {
            dynamic a1 = a;
            dynamic b1 = b;
            return (T)(a1 + b1);
        }
    }

    class Minus<T> : BinaryOperator<T> {
        public T call(T a, T b) {
            dynamic a1 = a;
            dynamic b1 = b;
            return (T)(a1 - b1);
        }
    }

    class Muliply<T> : BinaryOperator<T> {
        public T call(T a, T b) {
            throw new NotImplementedException("Fill it here");
        }
    }

    class Divide<T> : BinaryOperator<T> {
        public T call(T a, T b) {
            throw new NotImplementedException("Fill it here");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var addOp = new Add<int>();
            var minOp = new Minus<int>();
            // add test;

            Console.WriteLine("My add(Jimmy) works: " + addOp.call(1, 2));
            Console.WriteLine("My minus(Giles) works: " + minOp.call(4, 2));
            Console.WriteLine("Hello World!");
        }
    }
}
