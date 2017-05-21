using System.Collections.Generic;
using System.Diagnostics;

namespace ChampAdvisor
{
    public class Champion
    {
        byte _ImpactRating;
        Dictionary<string, string[]> _Info;

        public Champion(Dictionary<string, string[]> championInfo)
        {
            if (championInfo.Count == 12)
            {
                _Info = championInfo;
            }
            else
            {
                Debug.Write("System Exception - Champion data must contain 12 elements");
                throw new System.Exception("Champion data must contain 12 elements");
            }
        }

        public byte ImpactRating { get => _ImpactRating; set => _ImpactRating = value; }
    }
}
/*
 Champion Data must contain the following
 Name
 Score
 Aspects (Initiation, Engage, Haste, Sustain, Diver, Tank, Disengage)
 Ideal ally comps
 Ideal lane partner
 Ideal enemy laner
 Ideal enemy comp
 Ideal enemy aspects (Spike Damage, Multiple Divers, Tanks, AD Heavy)
 Unfavorable lane opponent
 Unfavorable enemy champions
 Unfavorable enemy comp
 Unfavorable enemy aspects
*/