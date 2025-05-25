using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDFOperationFirstStrike.BlueSide;
using IDFOperationFirstStrike.RedSide;

namespace IDFOperationFirstStrike
{
    internal class Simulation
    {
        private Idf idf;
        private Hamas hamas;
        private Aman aman;
        private List<IntelligenceReport> reports;
        private string officerName;

        public Simulation()
        {
            idf = new Idf("1948", "הרצי הלוי");
            hamas = new Hamas("1987", "יחיא סנוואר");
            aman = new Aman();
            reports = new List<IntelligenceReport>();
        }
    }S
}
