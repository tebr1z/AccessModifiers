
namespace AccessModife
{
    

    public class ChinaCity : City
    {
        public ChinaCity(string name, int population) : base(name, population)
        {
            if (population <= 100000)
            {
                Console.WriteLine("1.000.000 asagi deyer daxil etmeyin.");
                return;
            }
            else
            {
                Name = name;
                Population = population;
            }
        }
    }


}
