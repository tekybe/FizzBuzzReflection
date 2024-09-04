using FizzBuzzReflection.Services;

namespace FizzBuzzReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of FizzBuzz
            var fizzBuzz = new FizzBuzz();

            // Generate and print results for numbers 1 to 100
            var results = fizzBuzz.Generate(1, 100);
            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }
    }
}
