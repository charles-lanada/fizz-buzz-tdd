using System;
using System.Linq;

namespace FizzBuzz
{
    public interface IFizzBuzzGenerator
    {
        string[] LoadFizzBuzz();
    }

    public class FizzBuzzGenerator : IFizzBuzzGenerator
    {
        public string[] LoadFizzBuzz() => ShouldReturn1To100().Select(x =>
        {
            if (IsFizzBuzz(x))
            {
                return "FizzBuzz";
            }

            if (IsDivisibleBy3(x))
            {
                return "Fizz";
            }

            if (IsDivisibleBy5(x))
            {
                return "Buzz";
            }

            return x.ToString();
        }).ToArray();

        public int[] ShouldReturn1To100()
        {
            return Enumerable.Range(1, 100).ToArray();
        }

        public bool IsDivisibleBy3(int input)
        {
            return input % 3 == 0;
        }

        public bool IsDivisibleBy5(int input)
        {
            return input % 5 == 0;
        }

        private bool IsFizzBuzz(int x)
        {
            return IsDivisibleBy3(x) && IsDivisibleBy5(x);
        }
    }
}