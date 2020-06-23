using System;

namespace ExceptionExamples {
    class Program {
        static void Main(string[] args) {
            Run();
        }

        static void Run() {
            Test();
        }

        static void Test() {
            Divide();
        }

        static void Divide() {
            var num = 1;
            var denom = 0;
            var result = num / denom;
        }

    }
}
