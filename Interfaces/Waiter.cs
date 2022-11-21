using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Waiter : Human, IWaiter, IKati
    {
        public decimal Salary { get; set; }
        public Waiter() //: base() 
        {

        }

        public Waiter(int id, string name, string email, string mobile, decimal salary) 
            : base(id, name, email, mobile)
        {
            Salary = salary;
        }

        public int Work(int hours)
        {
            throw new NotImplementedException();
        }

        // Work
    }
}
