using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace IDFOperationFirstStrike
{
    internal abstract class StrikeOptions
    {
        protected string UniqueName;
        protected int AmmunitionCapacity;
        protected int FuelSupply;
        protected List<string> TypeBombs;
        protected List<string> TypeOfTarget;

        public StrikeOptions(string uniqueName, int ammunitionCapacity, int fuelSupply, List<string> typeBombs,  List<string> typeOfTarget )
        {
            UniqueName = uniqueName;
            AmmunitionCapacity = ammunitionCapacity;
            FuelSupply = fuelSupply;
            TypeOfTarget = typeOfTarget;
            TypeBombs = typeBombs;

        }
    }
}
