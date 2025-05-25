using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDFOperationFirstStrike.RedSide;

namespace IDFOperationFirstStrike
{
    public class IntelligenceReport
    {
        public Terrorist Target { get; set; }
        public string LastKnownLocation { get; set; }
        public DateTime Timestamp { get; set; }
        public int Confidence { get; set; }
        public string Source { get; set; }

        public override string ToString()
        {
            return $"מודיעין על {Target.Name} - מיקום: {LastKnownLocation}, זמן: {Timestamp}, מקור: {Source}, ביטחון: {Confidence}%";
        }

    }
}
 

    
