using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTesting
{
    public class BusinessInfo : IMyConstants
    {
        // Assigning values to the constant variables
        public string businessName { get { return "Space Travelers"; } }
        public string slogan { get { return "Speeding into the unknown"; } }
        public int budget { get { return 1000000000; } }

    }
}
