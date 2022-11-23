using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Randomizers;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Athlete2 : IAthlete, IHuman, IKati
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public int MyProperty { get; set; }
        public List<Score> Scores { get; set; }
        public Athlete2()
        {
            Id = (int)RandomizerFactory.GetRandomizer(new FieldOptionsInteger()).Generate();
            Name = RandomizerFactory.GetRandomizer(new FieldOptionsFullName()).Generate();
            Email = RandomizerFactory.GetRandomizer(new FieldOptionsEmailAddress()).Generate();
            Mobile = RandomizerFactory.GetRandomizer(new FieldOptionsText()).Generate();
            Scores = new List<Score>();
            Scores.Add(new Score());
            Scores.Add(new Score());
            Scores.Add(new Score());
        }

        public void RunForestGump()
        {
            throw new NotImplementedException();
        }

        public int Walk(int steps)
        {
            throw new NotImplementedException();
        }

        public float Walk(float kms)
        {
            throw new NotImplementedException();
        }

        public DateTimeOffset Walk(DateTimeOffset time)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Id}\t{Name}\t{Email}\t{Mobile}");
            foreach(var score in Scores)
            {
                sb.AppendLine(score.ToString());
            }
            return sb.ToString();
        }
    }
}
