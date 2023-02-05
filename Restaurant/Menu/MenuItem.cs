using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Menu
{
    class MenuItem
    {
        public Random Randomizer = new Random();
        // Mięso
        public string[] Proteins = { "Wołowina", "Salami", "Indyk", "Szynka", "Pastrami", "Tofu" };
        // Dodatki
        public string[] Condiments = { "musztarda zółta", "musztarda brązowa", "musztarda miodowa", "majonez", "przyprawy", "sos francuski" };
        // Pieczywo
        public string[] Breads = { "ryżowe", "białe", "pszenne", "pumpernikiel", "bułka" };
        
        // Opis
        public string Description = "";
        // Cena
        public string Price;

        public void Generate()
        {
            string randomProtein = Proteins[Randomizer.Next(Proteins.Length)];
            string randomCondiment = Condiments[Randomizer.Next(Condiments.Length)];
            string randomBreads = Breads[Randomizer.Next(Breads.Length)];

            Description = randomProtein + " i " + randomCondiment + ". Pieczywo: " + randomBreads + ".";

            decimal bucks = Randomizer.Next(2, 5);
            decimal cents = Randomizer.Next(1, 98);
            decimal price = bucks + (cents * 0.1M);
            Price = price.ToString("c");
        }
    }
}
