using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Randomizers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Score
    {
        public int Id { get; set; }
        public decimal Performance { get; set; }
        public DateTime DateOfPerformance { get; set; }
        public int AthletesId { get; set; } // DON'T USE for 2nd way of Exercise 3
        private Random _random= new Random();

        public Score()
        {
            Id = (int)RandomizerFactory.GetRandomizer(new FieldOptionsInteger()).Generate();
            decimal result = (decimal)_random.NextDouble() * Id;
            //if (f > (float)decimal.MaxValue)
            //{
            //    result = decimal.MaxValue;
            //}
            //if(f < (float)decimal.MinValue) 
            //{ 
            //    result = decimal.MinValue;
            //}
            //if (f < (float)decimal.MaxValue && f > (float)decimal.MinValue)
            //{
            //    result = (decimal)f / Id;
            //}
            Performance = result;
            DateTime dateTime = new DateTime(_random.Next());
            DateOfPerformance = dateTime;
        }

        public Score(decimal performance, DateTime dateOfPerformance, int athletesId)
        {
            Performance = performance;
            DateOfPerformance = dateOfPerformance;
            AthletesId = athletesId;
        }

        public override string ToString()
        {
            return $"{Id}\t{Performance}\t{DateOfPerformance}{AthletesId}";
        }
    }
}
