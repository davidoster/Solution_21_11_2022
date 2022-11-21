using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    // συμπεριφορά των κλάσεων
    // εξαναγκάζω να δημιουργήσει η κλάση υλοποίηση
    internal interface IHuman
    {
        int MyProperty { get; set; }
        int Walk(int steps);
        float Walk(float kms);
        DateTimeOffset Walk(DateTimeOffset time);
    }
}
