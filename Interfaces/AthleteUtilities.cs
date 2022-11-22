using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class AthleteUtilities : IAthleteUtilities
    {
        public decimal? FindBestPerformance(List<Score> scores)
        {
            decimal? best = scores[0].Performance;
            for(int i = 1; i < scores.Count; i++)
            {
                if (scores[i].Performance > best)
                {
                    best = scores[i].Performance;
                }
                //else
                //{
                //    best = null;
                //}
            }
            return best;
        }

        public int? FindHighestId(List<Athlete2> athletes)
        {
            int? highest = null;

            return highest;
        }

        public void SortScoresPerDateOfPerformance(List<Athlete2> athletes, SortType sortType)
        {

        }
    }
}
