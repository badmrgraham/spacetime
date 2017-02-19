using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceTime.Environment
{
    public class Universe
    {
        public List<Reality> Reality { get; set; }
        
        public Universe() : this(Default.NumberOfRealities, Default.NumberOfPlanets)
        { }

        public Universe(int numberOfRealities, int numberOfPlanets)
        {
            Reality = new List<Reality>(numberOfRealities);
            for (var n = 0; n < numberOfRealities; n++)
            {
                Reality.Add(new Reality(numberOfPlanets));
            }
        }

        public IEnumerable<Planet> GetAllParalelPlanets(Planet planet)
        {
            var planets = new List<Planet>();

            var index = Reality.Where(r => r.Planets.Contains(planet)).First().Planets.IndexOf(planet);
            Reality.ForEach(r => planets.Add(r.Planets[index]));

            return planets;
        }
    }
}
