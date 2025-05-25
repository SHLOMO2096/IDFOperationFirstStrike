using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDFOperationFirstStrike.RedSide;


namespace IDFOperationFirstStrike.BlueSide
{
    public class Aman
    {
        public Random random = new Random();
        public List<string> possibleLocations = new List<string> { "בבית", "במכונית", "בחוץ" };
        public List<string> possibleSources = new List<string> { "רחפן", "סוכן סמוי", "סייבר" };

        public List<IntelligenceReport> GenerateIntel(List<Terrorist> terrorists, int numberOfReports)
        {
            List<IntelligenceReport> reports = new List<IntelligenceReport>();

            for (int i = 0; i < numberOfReports; i++)
            {
                var terrorist = terrorists[random.Next(terrorists.Count)];
                var location = possibleLocations[random.Next(possibleLocations.Count)];
                var source = possibleSources[random.Next(possibleSources.Count)];
                var confidence = random.Next(50, 101); // ביטחון בין 50 ל-100

                reports.Add(new IntelligenceReport
                {
                    Target = terrorist,
                    LastKnownLocation = location,
                    Timestamp = DateTime.Now.AddHours(-random.Next(0, 30)), // טווח של 30 שעות אחורה
                    Confidence = confidence,
                    Source = source
                });
            }

            return reports;
        }
    }


}

