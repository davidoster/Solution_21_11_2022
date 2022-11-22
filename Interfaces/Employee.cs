using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Employee : IHuman, IKati
    {
        public int MyProperty { get; set;}
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }

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
    }
}
