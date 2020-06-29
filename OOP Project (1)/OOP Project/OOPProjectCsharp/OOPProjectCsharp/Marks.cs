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
    class Marks
    {
        private string courseCode;
        private string rollNo;
        private char section;
        private string marksTitle;
        private double totalMarks;
        private double obtainedMarks;
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
       public double TotalMarks
        {
            set
            {
                if (value > 0)
                    totalMarks = value;
                else
                    Console.WriteLine("Please Reenter the valid total marks ");
            }
            get
            {
                return totalMarks;
            }
        }
        public double ObtainedMarks
        {
            set
            {
                if (value <= totalMarks) 
                {
                    obtainedMarks = value;
                }
            }
            get
            {
                return obtainedMarks;
            }
        }
        public string CourseCode
        {
            set
            {
                courseCode = value;
            }
            get
            {
                return courseCode;
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
        public string MarksTitle
        {
            set
            {
                marksTitle = value;
            }
            get
            {
                return marksTitle;
            }
        }
        public void CheckMarks(string RollNo,string CourseCode)
        {
            string path = "Marks.txt";
            double Total = 0;
            double obtained = 0;
            Marks obj = new Marks();
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
            Console.WriteLine("Marks title\tObtained marks\tTotal marks");
            while(true)
            {
                try
                {
                    obj = (Marks)formatter.Deserialize(stream);
                    if (obj.RollNo == RollNo && obj.CourseCode==CourseCode)
                    {
                        Console.WriteLine(obj.MarksTitle + "\t" + obj.ObtainedMarks + "\t" + obj.TotalMarks);
                        Total += obj.TotalMarks;
                        obtained += obj.ObtainedMarks;
                    }    
                }
                catch(Exception)
                {
                    Console.WriteLine("\n\t\t\t\tGrand total marks");
                    Console.WriteLine("\n\n\t\tTotal  Marks : " + Total);
                    Console.WriteLine("\n\n\t\tObtained Marks : " + obtained);
                    stream.Close();
                    break;
                }
            }
        }
    }
}
