using System;
using System.Linq;
using FizzBuzz;

namespace FizzBuzzProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            var generator = GetGenerator();
            generator.LoadFizzBuzz().ToList().ForEach(Console.WriteLine);
        }

        private static IFizzBuzzGenerator GetGenerator()
        {
             return new FizzBuzzGenerator();
        }
    }
}
