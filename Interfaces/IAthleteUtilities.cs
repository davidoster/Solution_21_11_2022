using System.Collections.Generic;

namespace Interfaces
{
    internal interface IAthleteUtilities
    {
        // A. Find the athlete's best Performance
        // B. Sort the Scores per DateOfPerformance of all the athletes ASCending
        // C. Find the biggest / largest Athlete's Id

        // A. Athlete2 best Performance <---- athlete2.Scores[x].Performance
        decimal? FindBestPerformance(List<Score> scores);

        // B. Sort the Scores per DateOfPerformance of all the athletes ASCending
        void SortScoresPerDateOfPerformance(List<Athlete2> athletes, SortType sortType); //Property 
            // 1. List<Athlete2> λίστα από όλους τους αθλητές
            // 2. List<List<Score>> λίστα από λίστες των σκόρ των αθλητών 
            // 3. List<Score> λίστα από όλα τα σκορ όλων των αθλητών

        // C. Find the biggest / largest Athlete's Id
        int? FindHighestId(List<Athlete2> athletes);


    }
}