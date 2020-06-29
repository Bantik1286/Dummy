using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace OOPProjectCsharp
{
    [Serializable]
    class Student : Human
    {
        private int semster;
        private string rollNo;
        private char section;
        private double cgpa;
        public Student()
        {
            semster = 0;
            rollNo = "";
            section = ' ';
            cgpa = 0.0;
        }
        public double CGPA
        {
            set
            {
                if (value >= 1.0 && value <= 4.0)
                    cgpa = value;
                else
                    cgpa = 0;
            }
            get
            {
                return cgpa;
            }
        }
        public int Semster
        {
            set
            {
                if (value >= 1 && value <= 8)
                    semster = value;
                else
                    semster = 1;
            }
            get
            {
                return semster;
            }
        }
        public string RollNo
        {
            set
            {
                rollNo = value;
            }
            get
            {
                return rollNo;
            }
        }
        public char Section
        {
            set
            {
                    if (value >= 'a' && value <= 'z')
                    {
                        section = Char.ToUpper(value);
                    }
                    if (value >= 'A' && value <= 'Z')
                        section = value;

            }
            get
            {
                return section;
            }
        }
        void ViewMarks(string rollNo, string courseCode, char section)
        {
            Marks obj = new Marks();
            obj.CheckMarks(rollNo, courseCode);
            
         
        }
    public override void UseSystem()
    {
            int opt;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\n\n\t1\t\tAttendance \n\n\t2\t\tMarks\n\n\t3\t\tDirect message to director \n\n\t4\t\t Weekly timetable\n\n\t5\t\t Personal detail\n\n\t0\t\tExit\n\n");
                Console.Write("Select :\t");
                opt = Convert.ToInt32(Console.ReadLine());
                if (opt == 1)
                {
                    Console.Clear();
                    Console.Write("\n\n\n\t\t\t\tEnter course code : ");
                    string Course = Console.ReadLine();
                    Attendance obj = new Attendance();
                    obj.CheckAttendance(this.RollNo, Course);
                    Console.Write("\n\nPress any key to continue ... ");
                    Console.ReadKey();
                }
                if (opt == 2)
                {
                    Console.Clear();
                    Marks obj = new Marks();
                    Console.Write("\n\n\n\t\t\t\tEnter Course code : ");
                    string Course = Console.ReadLine();
                    obj.CheckMarks(this.RollNo,Course);
                    Console.Write("\n\nPress any key to continue ... ");
                    Console.ReadKey();
                }
                if (opt == 3)
                {
                    Console.Clear();
                    Message o = new Message();
                    string msg;
                    string subj;
                    Console.Write("\n\n\n\t\t\tEnter subject of message : ");
                    subj=Console.ReadLine();
                    Console.Write("\n\n\n\t\t\tEnter  message : ");
                    msg = Console.ReadLine();
                    o.SendMessage(Username, "Director@nu.edu.pk", msg, subj);
                    Console.WriteLine("\n\n\n\t\t\tMessage sent successfully \n\n\n");
                    Console.Write("Press any key to continue ... ");
                    Console.ReadKey();
                }
              
                if (opt == 4)
                {
                    Console.Clear();
                    Timetable obj = new Timetable();
                    obj.viewTimetable(Section);
                    Console.Write("\n\nPress any key to continue ... ");
                    Console.ReadKey();
                }
                if (opt == 5)
                {
                    Console.Clear();
                    PrintData();
                    Console.Write("\n\nPress any key to continue ... ");
                    Console.ReadKey();
                }
                if (opt == 0)
                {
                    break;
                }
            }
    }
        public override void PrintData()
        {
            base.PrintData();
            Console.WriteLine("\n\n\t\tRoll no :\t" + RollNo);
            Console.WriteLine("\n\n\t\tSection :\t" + Section.ToString());
            Console.WriteLine("\n\n\t\tCGPA :\t" + CGPA.ToString());
            Console.WriteLine("\n\n\t\tSemster :\t" + Semster);
        }
    }
}
