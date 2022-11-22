using System.Collections.Generic;

namespace Interfaces
{
    internal interface IAthleteUtilities
    {
        // A. Find the athlete's best Performance
        // B. Sort the Scores per DateOfPerformance of all the athletes ASCending
        // C. Find the biggest / largest Athlete's Id

        // A. Athlete2 best Performance <---- athlete2.Scores[x].Performance
        decimal FindBestPerformance(List<Score> scores);

        // B. Sort the Scores per DateOfPerformance of all the athletes ASCending


        // C. Find the biggest / largest Athlete's Id
        int FindHighestId(List<Athlete2> athletes);


    }
}