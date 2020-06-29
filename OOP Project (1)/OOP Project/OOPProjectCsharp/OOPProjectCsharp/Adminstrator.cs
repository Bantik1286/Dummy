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
    class Adminstrator: Human
    {
        public void AddStudent()
        {
            int v = 0;
            Student obj = new Student();
            Console.Write("\n\n\n\t\t\t\tEnter the name of student ");
            obj.Name= Console.ReadLine();
            Console.Write("\n\n\t\t\t\tEnter Father's name of student ");
            obj.FatherName = Console.ReadLine();
             Console.Write("\n\n\t\t\t\tSection : ");
             obj.Section =Convert.ToChar(Console.ReadLine());   
            while (true)
            {
                Console.Write("\n\n\t\t\t\tEnter Roll no  : ");
                obj.RollNo = Console.ReadLine();
                obj.Username = obj.RollNo + "@nu.edu.pk";
                if (!CheckUsername(obj.Username))
                    break;
                Console.Write("\n\n\t\t\t\tThis Roll no Already exists please enter other roll no");
                Console.WriteLine("\n\n\t\t\t\tPress 1 for back or any key to try again ");
                v=Convert.ToInt32(Console.ReadLine());
                if(v==1)
                {
                    return;
                }
            }
            File.AppendAllText("Usernames.txt", obj.Username + "\n");
            Console.Write("\n\n\t\t\t\tStudent's Username is " + obj.RollNo + "@nu.edu.pk");
            Console.WriteLine("\n\n\t\t\t\tEnter date of birth (in int) : ");
            obj.DateOfBirth=Convert.ToInt32(Console.ReadLine());
            obj.MonthOfBirth = Convert.ToInt32(Console.ReadLine());
            obj.YearOfBirth = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\n\t\t\t\tEnter Password  : ");
            obj.Password=Console.ReadLine();
            Console.Write("\n\n\t\t\t\tEnter Semster of the student  : ");
            obj.Semster=Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\n\t\t\t\tEnter CGPA of the students (in double) : ");
            obj.CGPA = Convert.ToDouble(Console.ReadLine());
            BinaryFormatter formatter = new BinaryFormatter();
            string path = "Students.txt";
            Stream stream = new FileStream(path, FileMode.Append, FileAccess.Write);
            formatter.Serialize(stream, obj);
            stream.Close();
        }
        public void AddTeacher()
        {
            Teacher obj = new Teacher();
            Console.Write("\n\n\t\t\t\tEnter the name of teacher  : ");
            obj.Name = Console.ReadLine();
            Console.Write("\n\n\t\t\t\tEnter Father's name of teacher  : ");
            obj.FatherName = Console.ReadLine();
            Console.Write("\n\n\t\t\t\tEnter date of birth (in int)  : ");
            obj.DateOfBirth = Convert.ToInt32(Console.ReadLine());
            obj.MonthOfBirth = Convert.ToInt32(Console.ReadLine());
            obj.YearOfBirth = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                int v;
                Console.Write("\n\n\t\t\t\tEnter Username ");
                obj.Username = Console.ReadLine();
                if (!CheckUsername(obj.Username))
                    break;
                Console.WriteLine("\n\n\t\t\t\tThis Username Already exists please enter other username");
                Console.WriteLine("Press 1 for back or any key to try again ");
                v = Convert.ToInt32(Console.ReadLine());
                if (v == 1)
                    return;
            }
            File.AppendAllText("Usernames.txt", obj.Username + "\n");
            Console.Write("\n\n\t\t\t\tEnter Password  : ");
            obj.Password = Console.ReadLine();
            Console.WriteLine("\n\n\t\t\t\tEnter salary in double  : ");
            obj.Salary = Convert.ToDouble(Console.ReadLine());
            BinaryFormatter formatter = new BinaryFormatter();
            File.AppendAllText("Usernames.txt", obj.Username);
            string path = "Teachers.txt";
            Stream stream = new FileStream(path, FileMode.Append, FileAccess.Write);
            formatter.Serialize(stream, obj);
            stream.Close();
        }
        public void AddParents()
        {
            int v;
            Parents obj = new Parents();
            Console.Write("\n\n\t\t\t\tEnter the name  : ");
            obj.Name = Console.ReadLine();
            Console.Write("\n\n\t\t\t\tEnter Father's name  : ");
            obj.FatherName = Console.ReadLine();
            Console.Write("\n\n\t\t\t\tEnter date of birth DD/MM/YY  : ");
            obj.DateOfBirth = Convert.ToInt32(Console.ReadLine());
            obj.MonthOfBirth = Convert.ToInt32(Console.ReadLine());
            obj.YearOfBirth = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                Console.Write("\n\n\t\t\t\tEnter Username : ");
                obj.Username = Console.ReadLine();
                if (!CheckUsername(obj.Username))
                    break;
                Console.WriteLine("\n\n\t\t\t\tThis Username Already exists please enter other username");
                Console.WriteLine("\n\n\t\t\t\tPress 1 for back or any key to try again ");
                v = Convert.ToInt32(Console.ReadLine());
                if (v == 1)
                {
                    return;
                }

            }
            File.AppendAllText("Usernames.txt", obj.Username + "\n");
            Console.Write("\n\n\t\t\t\tEnter Password  : ");
            obj.Password = Console.ReadLine();
            Console.Write("\n\n\t\t\t\tEnter the roll no of child  : ");
           obj.ChildRollNo= Console.ReadLine();
            Console.Write("\n\n\t\t\t\tEnter relation with child  : ");
            obj.Relation = Console.ReadLine();
            BinaryFormatter formatter = new BinaryFormatter();
            string path = "Parents.txt";
            Stream stream = new FileStream(path, FileMode.Append, FileAccess.Write);
            formatter.Serialize(stream, obj);
            stream.Close();
        }
        public void AddAdmin()
        {
            int v;
            Adminstrator obj = new Adminstrator();
            Console.Write("\n\n\t\t\t\tEnter the name of admin  : ");
            obj.Name = Console.ReadLine();
            Console.Write("\n\n\t\t\t\tEnter Father's name of admin : ");
            obj.FatherName = Console.ReadLine();
            Console.Write("\n\n\t\t\t\tEnter date of birth (in int)  : ");
            obj.DateOfBirth = Convert.ToInt32(Console.ReadLine());
            obj.MonthOfBirth = Convert.ToInt32(Console.ReadLine());
            obj.YearOfBirth = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                Console.Write("\n\n\t\t\t\tEnter Username  : ");
                obj.Username = Console.ReadLine();
                if (!CheckUsername(obj.Username))
                    break;
                Console.WriteLine("\n\n\t\t\t\tThis Username Already exists please enter other username");
                Console.WriteLine("\n\n\t\t\t\tPress 1 for back or any key to try again ");
                v = Convert.ToInt32(Console.ReadLine());
                if (v == 1)
                {
                    return;
                }

            }
            File.AppendAllText("Usernames.txt", obj.Username + "\n");
            Console.Write("\n\n\t\t\t\tEnter Password : ");
            obj.Password = Console.ReadLine();
            BinaryFormatter formatter = new BinaryFormatter();
            string path = "Admins.txt";
            Stream stream = new FileStream(path, FileMode.Append, FileAccess.Write);
            formatter.Serialize(stream, obj);
            stream.Close();
        }
        public bool CheckUsername(string Username)
        {
            bool check=false;
            string [] lines = File.ReadAllLines("Usernames.txt");
            foreach(string line in lines)
            {
                if(Username==line)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
       public void RecoverStudentPassword(string Username)
        {
            Student obj = new Student();
            string path = "Students.txt";
            Stream stream = new FileStream(path,FileMode.Open,FileAccess.Read);
            IFormatter formatter = new BinaryFormatter();
            bool find=false;
            while(true)
            {
                try
                {
                    obj = (Student)formatter.Deserialize(stream);
                    if(obj.Username==Username)
                    {
                        find = true;
                        Console.WriteLine("Password is :\t"+obj.Password);
                        break; 
                    }
                }
                catch(Exception)
                {
                    break;
                }
            }
            if(!find)
            {
                Console.WriteLine("\n\n\t\t\tYour account is not registered in our portal\n");
            }
        }
        public override void UseSystem()
        {
            while (true)
            {
                Console.Clear();
                Console.Write("\n\n\t1\t\t\tAdd student \n\n\t2\t\t\t Add Teacher \n\n\t3\t\t\t Recover password of student \n\n\t4\t\t\t Show Detail of student \\n\n\t5\t\t\t Add Parents \n\n\t6\t\t\t Show my personal Data \n\n\t7\t\t\tReserve Room\n\n\t0\t\t\tExit \n\n\n Select : ");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Console.Clear();
                    AddStudent();
                    Console.Write("Press any key to continue ... ");
                    Console.ReadKey();
                }
                if (choice == 2)
                {
                    Console.Clear();
                    AddTeacher();
                    Console.Write("Press any key to continue ... ");
                    Console.ReadKey();
                }
                if (choice == 3)
                {
                    Console.Clear();
                    Console.Write("\n\n\t\t\tEnter Username of the student  : ");
                    string User = Console.ReadLine();
                    RecoverStudentPassword(User);
                    Console.Write("Press any key to continue ... ");
                    Console.ReadKey();
                }
                if (choice == 4)
                {
                    Console.Clear();
                    Console.WriteLine("Enter Roll no of the student  : ");
                    string User = Console.ReadLine();
                    showDataOfStudents(User);
                    Console.Write("Press any key to continue ... ");
                    Console.ReadKey();
                }
                if (choice == 5)
                {
                    Console.Clear();
                    AddParents();
                    Console.Write("Press any key to continue ... ");
                    Console.ReadKey();
                }
                if (choice == 6)
                {
                    Console.Clear();
                    PrintData();
                    Console.Write("Press any key to continue ... ");
                    Console.ReadKey();
                }
                if (choice == 7)
                {
                    Console.Clear();
                    Timetable obj = new Timetable();
                    obj.reserveRoom();
                    Console.Write("Press any key to continue ... ");
                    Console.ReadKey();
                }
                if (choice == 0)
                    break;
            }
        }
        public override void PrintData()
        {
            base.PrintData();
        }
        public void showDataOfStudents(string RollNo)
        {
            Student obj=new Student();
            string path = "Students.txt";
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
            while(true)
            {
                try
                {
                    obj = (Student)formatter.Deserialize(stream);
                    if (obj.RollNo == RollNo)
                    {
                        obj.PrintData();
                        break;
                    }
                }
                catch(Exception)
                {
                    break;
                }
            }
        }
    }
}
