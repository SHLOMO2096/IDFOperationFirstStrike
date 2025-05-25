using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFOperationFirstStrike.RedSide
{
    internal class Hamas : Army
    {
        List<Terrorist> ListOfTerrorists;
        public Hamas(DateTime dateOfEstablishment, string currentCommander, List<Terrorist> listOfTerrorists)
            :base(dateOfEstablishment, currentCommander)
        {
            ListOfTerrorists = listOfTerrorists;
        }
    }
}
