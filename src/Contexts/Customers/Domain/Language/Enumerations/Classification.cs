using SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Customers.Domain.Enumerations
{
    public class Classification : Enumeration
    {
        public static Classification Regular = new Classification(1, "Regular");
        public static Classification Starred = new Classification(2, "Starred");
        public static Classification Suspicious = new Classification(3, "Suspicious");

        public Classification(int id, string val) : base(id, val)
        {
        }
    }
}
