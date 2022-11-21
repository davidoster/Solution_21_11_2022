using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Athlete : IAthlete, IHuman
    {
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
    }
}
