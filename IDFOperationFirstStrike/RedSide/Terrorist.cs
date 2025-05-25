using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFOperationFirstStrike.RedSide
{
    public class Terrorist
    {
        public string Name;
        public int Rank;
        public bool IsAlive;
        public List<string> Weapens;

        public Terrorist(string name, int rank, bool isAlive, List<string> weapens)
        {
            Name = name;
            Rank = rank;
            IsAlive = isAlive;
            Weapens = weapens;
        }
    }
}
