using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpaceTime.Cards;
using SpaceTime.Environment;
using SpaceTime.Bonuses;

namespace SpaceTime.Player
{
    public class Being
    {
        public string Name { get; set; }
        public Hand Hand { get; set; }
        public List<Card> FaceUp { get; set; }
        public List<Card> FaceDown { get; set; }
        public Form Form { get; set; }
        public SpaceTimeType Type { get; set; }
        public Reality CurrentReality { get; set; }
        public Planet CurrentPlanet { get; set; }
        public int CurrentTimeline { get; set; }

        public Dictionary<SpaceTimeType, int> GetStats()
        {
            var stats = new Dictionary<SpaceTimeType, int>{{SpaceTimeType.Tech, 0}, {SpaceTimeType.Mystic, 0}, {SpaceTimeType.Wisdom, 0}};

            Form.Bonuses.ForEach(b =>
                                     {
                                         if (b is TypedBonus)
                                         {
                                             stats[((TypedBonus) b).Bonus.Item1] += ((TypedBonus) b).Bonus.Item2;
                                         }
                                     });

            FaceUp.ForEach(fu => fu.Bonuses.ForEach(b =>
                                                        {
                                                            if (b is TypedBonus)
                                                            {
                                                                stats[((TypedBonus)b).Bonus.Item1] += ((TypedBonus)b).Bonus.Item2;
                                                            }
                                                        }));

            if (CurrentPlanet.Type != SpaceTimeType.Barren) stats[CurrentPlanet.Type] += CurrentPlanet.Development;
            
            return stats;
        }
    }
}
