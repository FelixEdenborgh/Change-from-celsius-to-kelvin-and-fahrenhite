using System;

namespace Change_from_celsius_to_kelvin__and_fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            float celsiusf, kalvin, fahrenheit;
            Console.WriteLine("Enter how worm its out side in celsius : ");
            celsiusf = Convert.ToSingle(Console.ReadLine());

            kalvin = celsiusf + 273;
            fahrenheit = celsiusf + 32;

            Console.WriteLine(celsiusf + " Celsius convert to Kalvin is = :" + kalvin);
            Console.WriteLine(celsiusf + " Celsius converted to Fahrenheit is = :" + fahrenheit);
        }
    }
}
