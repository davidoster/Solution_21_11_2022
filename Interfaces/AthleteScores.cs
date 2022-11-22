using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    // Data Transfer Object - DTO
    internal class AthleteScores
    {
        // ASSOCIATION - AGGREGATION - COMPOSITION (σύνδεση αντικειμένων μεταξύ τους)
        public int SomeInt; // ASSOCIATION
        
        public Athlete Athlete { get; set; } // COMPOSITION (it is initialized on ctor)
        public List<Score> Scores { get; set; } // AGGREGATION (it is not initialized on ctor)

        public AthleteScores()
        {
            Athlete = new Athlete();
        }
        public AthleteScores(Athlete athlete)
        {
            Athlete = athlete;
        }



        // do the rest....????
    }
}
