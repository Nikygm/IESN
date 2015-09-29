using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Pupil : Person
    {
        private int grade;

        public int Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        private List<Activity> listActivity;

        private Dictionary<String, char> pupAct = new Dictionary<string, char>();

        public Dictionary<String, char> PupAct
        {
            get { return pupAct; }
            set { pupAct = value; }
        }

        public List<Activity> ListActivity
        {
            get { return listActivity; }
            set { listActivity = value; }
        }

        private char[] pupilEvaluations;

        public char[] PupilEvaluations
        {
            get { return pupilEvaluations; }
            set { pupilEvaluations = value; }
        }

        public Pupil(String name, int age , int grade) : base (name,age)
        {
            Grade = grade;
            ListActivity = new List<Activity>();
            PupilEvaluations = new char[10];
        }

        public Pupil(String name, int age) : this(name,age,1)
        {

        }

        public void AddActivity(Activity act)
        {
            ListActivity.Add(act);
        }

        public void AddEvaluation(String title = null, char evaluation = 'S')
        {
            int i = 0;
            if (title != null)
            {
                foreach (Activity activity in ListActivity)
                {
                    if (activity.Title.Equals(title)) break;
                    i++;
                }
                PupilEvaluations[i] = evaluation;
            }
        }

        public char GetEvaluationFor(string title)
        {
            int i = 0;
            if (title != null)
            {
                foreach (Activity activity in ListActivity)
                {
                    if (activity.Title.Equals(title)) break;
                        i++;
                        
                }
                return PupilEvaluations[i];
            }
            throw new KeyNotFoundException(title);
        }

        public override string ToString()
        {
            string ch = Header();
            ch = PrintActivites(ch);
            return ch;
        }

        private String PrintActivites(string ch)
        {
            int i;
            for (i = 0; i < ListActivity.Count(); i++)
            {
                ch = ch + ListActivity.ElementAt(i).Title + " " + PupilEvaluations[i] + "\n";
            }
            return ch;
        }

        private string Header()
        {
            string ch = base.ToString() + ((ListActivity.Count() != 0) ? " a choisi ..." : "n'a pas encore choisi d'activité\n");
            return ch;
        }
    }
}
