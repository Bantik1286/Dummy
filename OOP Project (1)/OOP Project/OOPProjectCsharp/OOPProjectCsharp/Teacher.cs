using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
namespace OOPProjectCsharp
{
    [Serializable]
    class Teacher:Human
    {
        double salary;
        public double Salary
        {
            set
            {
                if (value > 0)
                    salary = value;
                else
                    salary = 0;
            }
            get
            {
                return salary;
            }
        }
        public void UploadMarks(string courseCode, string rollNo, char section, string marksTitle, double totalMarks, double obtainedMarks)
        {
            Marks obj = new Marks();
            obj.CourseCode = courseCode;
            obj.RollNo = rollNo;
            obj.Section = section;
            obj.MarksTitle = marksTitle;
            obj.TotalMarks = totalMarks;
            obj.ObtainedMarks = obtainedMarks;
            string path = "Marks.txt";
            BinaryFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(path, FileMode.Append, FileAccess.Write);
            formatter.Serialize(stream, obj);
            stream.Close();
        }
        public void MarkAttendance(char section,int date,int month,int year,string CourseCode)
        {
            Console.Clear();
            Attendance attendance=new Attendance();
            attendance.Section = section;
            attendance.Date = date;
            attendance.Month = month;
            attendance.Year = year;
            attendance.CourseCode=CourseCode;
            Student student = new Student();
            IFormatter formatter = new BinaryFormatter();
            string pathS = "Students.txt";
            string PathA = "Attendance.txt";
            Stream Std = new FileStream(pathS, FileMode.Open, FileAccess.Read);
            Stream Atd = new FileStream(PathA, FileMode.Append, FileAccess.Write);
            Console.WriteLine("\n\n\n\t\tDate : " + date + '/' + month + '/' + year + "/n/n");
            while (true) 
            {
                try
                {
                    student = (Student)formatter.Deserialize(Std);
                    if (student.Section == attendance.Section)
                    {
                        attendance.RollNo = student.RollNo;
                        Console.Write("\n\nRoll No : " + attendance.RollNo + "\tStatus : ");
                        attendance.Status = Convert.ToChar(Console.ReadLine());
                        if (attendance.Status == 'P' || attendance.Status == 'A' || attendance.Status == 'L')
                            formatter.Serialize(Atd, attendance);
                        else
                            break;
                    }
                }
                catch(Exception)
                {
                    break;
                }
            }
            Std.Close();
            Atd.Close();
        }
        public override void UseSystem()
        {
            int opt;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\n\n\n\t1\t\tMark attendance \n\n\n\t2\t\t Upload Marks\n\n\n\t3\t\tExit\n\n");
                Console.Write("\tSelect : \t");
                opt = Convert.ToInt32(Console.ReadLine());
                if (opt == 1)
                {
                    Console.Clear();
                    Console.Write("\n\n\n\n\n\t\t\t\t\t\tEnter section (in upper case) : ");
                    char Section = Convert.ToChar(Console.ReadLine());
                    int date, month, year;
                    Console.Write("\n\n\n\t\t\t\t\t\tEnter Date (in int)  : ");
                    date = Convert.ToInt32(Console.ReadLine());
                    month=Convert.ToInt32(Console.ReadLine());
                    year= Convert.ToInt32(Console.ReadLine());
                    Console.Write("\n\n\n\t\t\t\t\t\tEnter Course code : ");
                    string Course = Console.ReadLine();
                    if (month>=1 && month<=12 && date>=1 && date<=31)
                        MarkAttendance(Section,date,month,year,Course);
                    else
                    {
                        Console.WriteLine("Sorry entered date was not valid ");
                    }
                    Console.Write("\n\nPlease enter any to continue ... ");
                    Console.ReadKey();

                }
                if (opt == 2)
                {
                    Console.Clear();
                    Marks obj = new Marks();
                    Console.Write("\n\n\n\n\t\t\t\t\tEnter Cousrse code : ");
                    obj.CourseCode = Console.ReadLine();
                    Console.WriteLine("\n\n\t\t\t\t\tEnter roll no : ");
                    obj.RollNo = Console.ReadLine();
                    Console.WriteLine("\n\n\t\t\t\t\tEnter section : ");
                    obj.Section = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine("\n\n\t\t\t\t\tMarks title  : ");
                    obj.MarksTitle = Console.ReadLine();
                    Console.WriteLine("\n\n\t\t\t\t\tTotal Marks    : ");
                    obj.TotalMarks = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("\n\n\t\t\t\t\tObtained Marks    : ");
                    obj.ObtainedMarks = Convert.ToDouble(Console.ReadLine());
                     UploadMarks(obj.CourseCode,obj.RollNo,obj.Section,obj.MarksTitle,obj.TotalMarks,obj.ObtainedMarks);
                }
                if (opt == 3)
                {
                    break;
                }
            }
        }
        public override void PrintData()
        {
            base.PrintData();
            Console.WriteLine("\n\n\t\tSalary :\t" + Salary.ToString());
        }
    }
}
