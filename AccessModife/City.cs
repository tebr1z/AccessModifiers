
namespace AccessModife
{
    public class City
    {
        private string name;
        private int population;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Population
        {
            get { return population; }
            set { population = value; }
        }

        public City(string name, int population)
        {
            Name = name;
            Population = population;
        }
    }
}
