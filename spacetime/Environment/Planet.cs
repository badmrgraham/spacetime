using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceTime.Environment
{
    public class Planet
    {
        public string Name { get; set; }
        public SpaceTimeType Type { get; set; }
        public int Development { get; set; }

        public Planet(){}

        public static Planet RandomPlanet()
        {
            return new Planet() { Name = string.Format("planet {0}", Utility.Random.Next(300)), Type = ((SpaceTimeType)Utility.Random.Next(0, 2))};
        }
    }
}
