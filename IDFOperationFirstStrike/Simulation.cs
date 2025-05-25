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
            idf = new Idf("1948", "הרצי הלוי", new List<StrikeOptions>());
            hamas = new Hamas("1987", "יחיא סנוואר", new List<Terrorist>());
            aman = new Aman();
            reports = new List<IntelligenceReport>();
        }

        public void Run()
        {
            Console.Write("הכנס את שם הקצין האחראי: ");
            officerName = Console.ReadLine();

            InitializeEntities();
            ShowMainMenu();
        }

        private void InitializeEntities()
        {

        }


        private void ShowMainMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===== תפריט ראשי =====");
                Console.WriteLine("1. ניתוח מודיעין");
                Console.WriteLine("2. זמינות תקיפה");
                Console.WriteLine("3. קביעת מטרה עיקרית");
                Console.WriteLine("4. ביצוע תקיפה");
                Console.WriteLine("0. יציאה");

                Console.Write("בחר פעולה: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AnalyzeIntel();
                        break;
                    case "2":
                        ShowAttackAvailability();
                        break;
                    case "3":
                        ShowTopTarget();
                        break;
                    case "4":
                        PerformAttack();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("בחירה לא חוקית.");
                        Console.ReadKey();
                        break;
                }
            }

        }





        private void AnalyzeIntel()
        {
            
        }

        private void ShowAttackAvailability()
        {
            
        }

        private void ShowTopTarget()
        {
            
        }

        private void PerformAttack()
        {
            
        }
    





    }
}
