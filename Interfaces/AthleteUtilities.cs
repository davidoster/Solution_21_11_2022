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
            if (scores.Count > 0)
            {
                decimal? best = scores[0].Performance; // αυθαιρεσία
                for (int i = 1; i < scores.Count; i++)
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
            return null;
        }

        public int? FindHighestId(List<Athlete2> athletes)
        {
            int? highest = athletes[0].Id;
            for(int i = 1; i < athletes.Count; i++)
            {
                if (athletes[i].Id > highest)
                {
                    highest = athletes[i].Id;
                }
            }
            return highest;
        }

        // B. Sort the Scores per DateOfPerformance of all the athletes ASCending
        public void SortScoresPerDateOfPerformance(List<Athlete2> athletes, SortType sortType)
        {
            // list of athletes (inside each there are some scores)
            // list Athlete2
            //          list Score

            // Step 1. Create a new List<Score> sortedScores
            List<Score> sortedScores = new List<Score>();

            // Step 2. Iterate to each athlete
            for (int i = 0; i < athletes.Count; i++) // i iterates athletes
            {
                // Step 3. Iterate to each score of the athlete i
                for(int j = 0; j < athletes[i].Scores.Count; j++) // j iterates scores of athlete[i]
                {
                    // add the j score of the athlete i to sortedScores
                    sortedScores.Add(athletes[i].Scores[j]);
                }
            }
            Console.WriteLine("Original Scores");
            sortedScores.ForEach(Console.WriteLine);

            // Step 3. sort the sortedScores based on sortType
            for (int j = 0; j <= sortedScores.Count - 2; j++)
            {
                for (int i = 0; i <= sortedScores.Count - 2; i++)
                {
                    if (sortedScores[i].DateOfPerformance > sortedScores[i + 1].DateOfPerformance)
                    {
                        var temp = sortedScores[i + 1];
                        sortedScores[i + 1] = sortedScores[i];
                        sortedScores[i] = temp;
                    }
                }
            }
            if (sortType == SortType.DESCENDING)
            {
                sortedScores.Reverse();
            }
            Console.WriteLine("\nSorted Scores");
            sortedScores.ForEach(Console.WriteLine);
        }
    }
}
