using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpaceTime.Bonuses;

namespace SpaceTime.Cards
{
    public class Card
    {
        public string Name { get; set; }
        public int LifeSpans { get; set; }
        public int FortuneCost { get; set; }
        public Tuple<SpaceTimeType, int> PreRequisiteCost { get; set; }
        public List<IBonus> Bonuses { get; set; }
    }
}
