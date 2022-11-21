using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            Waiter waiter = new Waiter();

            List<IHuman> list = new List<IHuman>();
            list.Add(human);

            IHuman human2  = new Human();
            IHuman human3 = new IHuman(); // this is not allowed!!!!!

            IHuman human4 = new Waiter();
            list.Add(human4);

            IHuman human5 = new Athlete();
            list.Add(human5);

        }
    }
}
