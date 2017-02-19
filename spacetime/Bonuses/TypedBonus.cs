using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceTime.Bonuses
{
    public class TypedBonus : IBonus
    {
        public Tuple<SpaceTimeType, int> Bonus { get; set; }
    }
}
