using ExceptionExamples.Exceptions;
using System;

namespace ExceptionExamples {
    class Program {

        static void Main(string[] args) {
            try {
            Run();
            } catch (UserException ex) {
                Console.WriteLine($"{ex.Message} number is {ex.NumberInError}");
            }catch (Exception ex) {
                Console.WriteLine($"{ex.Message}");
            }
            
        }

        static void Run() {
            Test();
            var ex = new UserException("This exception was forced by dev: "); //created exception
                ex.NumberInError = 42;
            throw ex;
        }

        static void Test() {
            Divide();
        }

        static void Divide() {
            try { //try this code
                var num = 1;
                var denom = 0;
                var result = num / denom;
            } catch (DivideByZeroException ex) { //catch exception named "" as var ex
                Console.WriteLine($"Exception Occurred: {ex.Message}");
                //throw;
            } catch (Exception ex) { //catch any exception
                Console.WriteLine($"General exception occurred: {ex.Message}");
            }
        }

    }
}
