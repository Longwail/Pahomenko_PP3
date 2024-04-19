using System;
using System.IO;

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

                Console.WriteLine($"Введите температуру для индикации {i + 1}:");
                indications.Temperature = double.Parse(Console.ReadLine());

                Console.WriteLine($"Введите влажность для индикации {i + 1}:");
                indications.Humidity = double.Parse(Console.ReadLine());

                Console.WriteLine($"Введите давление для индикации {i + 1}:");
                indications.Pressure = double.Parse(Console.ReadLine());

                indicationsArray[i] = indications;
            }
        }
        public void SortArray()
        {
            Array.Sort(indicationsArray, (x, y) =>
            {
                if (x.Temperature == y.Temperature)
                {
                    return y.Humidity.CompareTo(x.Humidity);
                }

                return x.Temperature.CompareTo(y.Temperature);
            });
        }

        public void SaveToFile(string filename)
        {
            using (StreamWriter sw = new StreamWriter(filename))
            {
                foreach (var indications in indicationsArray)
                {
                    sw.WriteLine($"Температура: {indications.Temperature}, Влажность: {indications.Humidity}, Давление: {indications.Pressure}");
                }
            }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
