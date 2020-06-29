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
    class Timetable
    {
        string room, date, course;
        char section;
        int from, to;
        public void reserveRoom()
        {
            Timetable obj = new Timetable();
            Console.Write("\n\t\t\t\tEnter room number: ");
            obj.room = Console.ReadLine();
            Console.Write("\n\t\t\t\tEnter date: ");
            obj.date = Console.ReadLine();
            Console.Write("\n\t\t\t\tEnter course code: ");
            obj.course = Console.ReadLine();
            Console.Write("\n\t\t\t\tEnter section: ");
            obj.section = Convert.ToChar(Console.ReadLine());
            Console.Write("\n\t\t\t\tEnter time from: ");
            obj.from = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\t\t\t\tEnter time to: ");
            obj.to = Convert.ToInt32(Console.ReadLine());
            string path = "Timetable.txt";
            Stream stream = new FileStream(path, FileMode.Append, FileAccess.Write);
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, obj);
            stream.Close();
        }
        public void viewTimetable(char section)
        {
            Timetable obj = new Timetable();
            string path = "Timetable.txt";
            Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
            IFormatter formatter = new BinaryFormatter();
            while (true)
            {
                try
                {
                    obj = (Timetable)formatter.Deserialize(stream);
                    if (section == obj.section)
                    {
                        Console.WriteLine("\n\nFrom: " + obj.from);
                        Console.WriteLine("To: " + obj.to);
                        Console.WriteLine("Course: " + obj.course);
                        Console.WriteLine("Room: " + obj.room);
                        Console.WriteLine("Date: " + obj.date);
                    }
                }
                catch(Exception)
                {
                    break;
                }
            }
            stream.Close();
        }
    }
}
