using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTesting
{
    public interface IMyConstants
    {
        // Constant variables in interface class
        string businessName { get; }
        string slogan { get; }
        int budget { get; }
    }
}
