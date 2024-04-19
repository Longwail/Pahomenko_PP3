using System;

namespace ConsoleApp1
{

    struct Indications
    {
        public double Temperature { get; set; }
        public double Humidity { get; set; }
        public double Pressure { get; set; }
    }

    public class WeatherControl
    {
        private Indications[] indicationsArray;

        public WeatherControl(int size)
        {
            indicationsArray = new Indications[size];
        }

        public void FillArray()
        {
            for (int i = 0; i < indicationsArray.Length; i++)
            {
                Indications indications = new Indications();

                Console.WriteLine($"Enter temperature for indication {i + 1}:");
                indications.Temperature = double.Parse(Console.ReadLine());

                Console.WriteLine($"Enter humidity for indication {i + 1}:");
                indications.Humidity = double.Parse(Console.ReadLine());

                Console.WriteLine($"Enter pressure for indication {i + 1}:");
                indications.Pressure = double.Parse(Console.ReadLine());

                indicationsArray[i] = indications;
            }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
