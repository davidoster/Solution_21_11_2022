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
        int Id { get; set; }  
        string Name { get; set; }
        string Email { get; set; }
        string Mobile { get; set; }
        int MyProperty { get; set; }
        int Walk(int steps);
        float Walk(float kms);
        DateTimeOffset Walk(DateTimeOffset time);

        
    }
}
