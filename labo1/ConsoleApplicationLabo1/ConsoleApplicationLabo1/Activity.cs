using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo1
{
    public class Activity
    {
        private String title;
        private Boolean compulsory;

        public string Title
        {
            get;
            set;
        }

        public bool Compulsory
        {
            get;
            set;
        }

        public Activity(String title, Boolean compulsory)
        {
            Title = title;
            Compulsory = compulsory;
        }

        public override string ToString()
        {
            if (Compulsory == true)
                return Title + " : Obligatoire";
            else
                return Title;

        }
    }
}
