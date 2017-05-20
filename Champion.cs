using System.Diagnostics;

namespace ChampAdvisor
{
    public class Champion
    {
        int _ImpactRating;
        string[] Info;

        public Champion(string[] championInfo)
        {
            if (championInfo.Length == 12)
            {
                Info = championInfo;
            }
            else
            {
                Debug.Write("System Exception - Champion data array must contain 12 elements");
                throw new System.Exception("Champion data array must contain 12 elements");
            }
        }

        public int ImpactRating { get => _ImpactRating; set => _ImpactRating = value; }
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