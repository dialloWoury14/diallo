using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Activity activity1 = new Activity("Danse", false);
            Activity activity2 = new Activity("Basket", false);
            Activity activity3 = new Activity("Tennis", true);
            Activity activity4 = new Activity("Foot ball", true);

            Pupil pupil1 = new Pupil("DUPONT Anna", 18, 1);
            pupil1.AddActivity(activity1);
            pupil1.AddActivity(activity3);
            pupil1.AddEvaluation("Danse");

            System.Console.Write(pupil1 + " Tableau d'évaluation : \n");
            for (int i = 0; i < pupil1.LstActivities.Count(); i++)
            {
                if(!pupil1.TabEval[i].Equals(null))
                {
                    System.Console.Write("Activité" + (i + 1) + " : " + pupil1.TabEval[i]+"\n");
                }
            }


            System.Console.Read();
            


        }
    }
}
