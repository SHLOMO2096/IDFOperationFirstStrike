using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFOperationFirstStrike
{
    internal class Army
    {
        protected string DateOfEstablishment;
        protected string CurrentCommander ;

        public Army(string dateOfEstablishment, string currentCommander)
        {
            DateOfEstablishment = dateOfEstablishment;
            CurrentCommander = currentCommander;
        }
    }
}
