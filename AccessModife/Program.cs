using System;

namespace AccessModife
{
    class Program
    {
        static double CalculateAveragePopulation(City[] cityArray)
        {
            int totPopulation = 0;
            foreach (City city in cityArray)
            {
                totPopulation += city.Population;
            }
            return cityArray.Length > 0 ? (double)totPopulation / cityArray.Length : 0;
        }

        static void Main(string[] args)
        {
            City[] chinaCityArray = new City[3];

            for (int i = 0; i < chinaCityArray.Length; i++)
            {
                string cityName;
                int population;
                bool validPopulation = false;

                do
                {
                    Console.WriteLine("=============================================");
                    Console.Write($"Sheher adini daxil edin {i + 1}: ");
                    cityName = Console.ReadLine();

                    Console.WriteLine("=============================================");
                    Console.Write($"Sheher ehali sayni daxil edin{i + 1}: ");
                    string populationInput = Console.ReadLine();

                    if (!int.TryParse(populationInput, out population) || population <= 0)
                    {
                     
                       Console.WriteLine("0 Ve Ya Daha asagi deyer daxil ede bilmezsiz");
                        Console.WriteLine("=============================================");
                    }

                    else
                    {
                        validPopulation = true;
                    }
                } while (!validPopulation);

                chinaCityArray[i] = new ChinaCity(cityName, population);
            }

            double averagePopulation = CalculateAveragePopulation(chinaCityArray);
            Console.WriteLine("Ehali sayi: " + averagePopulation);
        }
    }
}
