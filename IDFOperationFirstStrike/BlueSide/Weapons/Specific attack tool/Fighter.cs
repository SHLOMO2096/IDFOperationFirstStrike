using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFOperationFirstStrike.Specific_attack_tool
{
    internal class Fighter : StrikeOptions
    {
 
        protected string Operator;

        public Fighter(List<string> typesBooms, string operator1, string uniqueName, int ammunitionCapacity, int fuelSupply,  List<string> typeOfTarget)
            :base (uniqueName, ammunitionCapacity, fuelSupply, typeOfTarget, typesBooms)
        {
            Operator = operator1;
        }
    }
}
