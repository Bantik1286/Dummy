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
    class Attendance
    {
        private string courseCode;
        private string rollNo;
        private char section;
        private int date, month, year;
        private char status;
        public Attendance()
        {
            rollNo = "";
            section = ' ';
            date = 0;
            month = 0;
            year = 0;
            Status = 'p';
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
        public char Section
        {
            set
            {
                if (value >= 'a' && value <= 'z')
                    section = Char.ToUpper(value);
                if (value > 'A' && value <= 'Z')
                    section = value;
                else
                    Console.WriteLine("Please enter a valid Section ");
            }
            get
            {
                return section;
            }
        }
        public int Date
        {
            set
            {
                if (value >= 1 && value <= 31)
                    date = value;
                else
                    Console.WriteLine("Please enter a valid date ");
            }
            get
            {
                return date;
            }
        }
        public int Month
        {
            set
            {
                if (value >= 1 & value <= 12)
                    month = value;
                else
                    Console.WriteLine("Please enter a valid month");
            }
            get
            {
                return month;
            }
        }
        public int Year
        {
            set
            {
                    year = value;
            }
            get
            {
                return year;
            }
        }
        public char Status
        {
            set
            {
                if (value == 'a' || value == 'p' || value == 'l')
                    status = Char.ToUpper(value);
                if (value == 'A' || value == 'P' || value == 'L')  // A for absent, P for present , L for leave
                    status = value;
            }
            get
            {
                return status;
            }
        }
        public void CheckAttendance(string RollNo, string CourseCode)
        {
            string path = "Attendance.txt";
            Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
            IFormatter formatter = new BinaryFormatter();
            Attendance obj = new Attendance();
            Console.WriteLine("Roll no\tDate \tStatus\n\n");
            while(true)
            {
                try
                {
                    obj = (Attendance)formatter.Deserialize(stream);
                    if(obj.RollNo==RollNo && obj.CourseCode==CourseCode)
                    Console.WriteLine(obj.RollNo + "\t" + obj.Date + '/' + obj.Month + '/' + obj.Year +'\t'+obj.Status);
                }
                catch(Exception)
                {
                    stream.Close();
                    break;
                }
            }
        }
    }
}