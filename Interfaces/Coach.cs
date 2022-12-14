using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Randomizers;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Coach : ICoach, IHuman
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public TrainingProfession Profession { get; set; }
        public int MyProperty { get; set; }
        public Coach()
        {
            Id = (int)RandomizerFactory.GetRandomizer(new FieldOptionsInteger()).Generate();
            Name = RandomizerFactory.GetRandomizer(new FieldOptionsFullName()).Generate();
            Email = RandomizerFactory.GetRandomizer(new FieldOptionsEmailAddress()).Generate();
            Mobile = RandomizerFactory.GetRandomizer(new FieldOptionsText()).Generate();
            Profession = TrainingProfession.DIVING;
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
            return $"{Id}\t{Name}\t{Email}\t{Mobile}\t{Profession}";
        }
    }
}
