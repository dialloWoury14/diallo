using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo1
{
    public class Pupil : Person
    {
        private int grade;
        private List<Activity> lstActivities;
        private char[] tabEval;

        public int Grade
        { get { return grade; }
          set { grade = (value > 0) ? value : 1; }
        }

        public List<Activity> LstActivities
        {
            get;
            set;
        }

        public char[] TabEval
        {
            get;
            set;
        }

        public Pupil (String name, int age, int grade) : base(name, age)
        {
            Grade = grade;
            LstActivities = new List<Activity>();
            TabEval = new char[10];
        }
        public Pupil (string name, int age) : this(name,age,1) {}

        public void AddActivity(Activity newActivity)
        {
            LstActivities.Add(newActivity);
        }

        public override string ToString()
        {
            int cptActivity = LstActivities.Count();
            string ch;
            ch = base.ToString();
            if (cptActivity == 0)
                ch += " n'a pas encore choisi d'activité";
            else
            {
                ch += "a choisi : \n";
                foreach(Activity activity in LstActivities)
                {
                    ch += activity.ToString()+"\n";
                }
            }
            return ch;
        }
        
        public void AddEvaluation(String title = null, char evaluation = 'S')
        {
            int indActivity = 0;
            for(int i = 0; i < LstActivities.Count(); i++)
            {
                if(LstActivities[i].Title == title)
                    indActivity = i;
            }
            TabEval[indActivity] = evaluation;
        }
    }
}
