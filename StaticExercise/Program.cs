namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine($"It is {TempConverter.FahrenheitToCelsius(80)} degrees Celsius.");
            Console.WriteLine($"It is {TempConverter.CelsiusToFahrenheit(80)} degrees Fahrenheit.");

            
        }
    }
}
