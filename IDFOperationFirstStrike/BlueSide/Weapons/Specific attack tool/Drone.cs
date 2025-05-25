using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFOperationFirstStrike.Specific_attack_tool
{
    internal class Drone : StrikeOptions
    {

        public Drone (List<string> typesBooms, string uniqueName, int ammunitionCapacity, int fuelSupply, List<string> typeOfTarget)
            :base (uniqueName, ammunitionCapacity, fuelSupply, typeOfTarget, typesBooms)
        { 
        }
    }
}
