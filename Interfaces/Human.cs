using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Human : IHuman, IKati
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public int MyProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Human()
        {

        }

        public Human(int id, string name, string email, string mobile)
        {
            Id = id;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Email = email ?? throw new ArgumentNullException(nameof(email));
            Mobile = mobile ?? throw new ArgumentNullException(nameof(mobile));
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

        // Walk, Run, Eat, Sleep
    }
}
