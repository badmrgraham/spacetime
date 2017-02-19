using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceTime.Environment
{
    public class Reality
    {
        public List<Planet> Planets { get; set; }

        public Reality(){}

        public Reality(int numberOfPlanets)
        {
            Planets = new List<Planet>(numberOfPlanets);
            for (var n = 0; n < numberOfPlanets; n++)
            {
                Planets.Add(Planet.RandomPlanet());
            }
        }
    }
}
