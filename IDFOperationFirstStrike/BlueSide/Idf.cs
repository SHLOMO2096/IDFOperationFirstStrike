using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFOperationFirstStrike
{
    internal class Idf : Army
    {
        List<StrikeOptions> CollectionOfStrikeOptions;
        public Idf( string dateOfEstablishment, string currentCommander, List<StrikeOptions> collectionOfStrikeOptions) 
            :base (dateOfEstablishment, currentCommander)
        {
            CollectionOfStrikeOptions = collectionOfStrikeOptions;
        }
    }
}
