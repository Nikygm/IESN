using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Pupil p = new Pupil("Arthur",18,4);
            Pupil p1 = new Pupil("Berangere", 18);
            Pupil p2 = new Pupil("Coco", 5);
            Pupil p3 = new Pupil("Dalton", 7);
            Pupil p4 = new Pupil("Eurythe", 12);
            Pupil p5 = new Pupil("Falcon", 18);*/

            List<Pupil> listPup = new List<Pupil>() { 
                new Pupil("Arthur",18,4),
                new Pupil("Berangere",12,2),
                new Pupil("Cardon",15,3),
                new Pupil("Drute",5),
            };

            List<Person> listPers = new List<Person>()
            {
                new Person("Alex",6),
                new Person("Boris",7),
                new Person("Charmander",10),
                new Person("Dodrio",18),

            };
            var listFusion = listPers.Union(listPup);

            foreach (var e in listFusion)
            {
                System.Console.Write(e.ToString());
            }

            List<Pupil> listPupDubs = new List<Pupil>() { 
                new Pupil("Alakazham",18),
                new Pupil("Alakazham",18),
                new Pupil("Beaver",18),
                new Pupil("Beaver",5),
            };
            



            /*listPup.Add(p);
            listPup.Add(p1);
            listPup.Add(p2);
            listPup.Add(p3);
            listPup.Add(p4);
            listPup.Add(p5);*/
            //Bonne méthode aussi
            /*var pupilGrade1Plus6 = from pupil in listPup
                                   where pupil.Grade == 1 && pupil.Age > 6
                                   select pupil;
            */
            /*var pupilGrade1Plus6 = listPup.Where(pupil => (pupil.Grade == 1 && pupil.Age > 6));
            if (pupilGrade1Plus6 != null)
            {
                foreach (var pupil in pupilGrade1Plus6)
                {
                    System.Console.Write(pupil.ToString());
                }

            }*/


            System.Console.Read();
        }
    }
}
