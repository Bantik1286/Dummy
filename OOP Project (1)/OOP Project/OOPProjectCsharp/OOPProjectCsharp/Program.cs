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
    class Program
    {
        static void Main(string[] args)
        {
            Student student;
            Teacher teacher;
            Director director;
            Parents parents;
            Adminstrator adminstrator;
            int opt;
            string path;
            string Username, Password;
            while (true)
            {
                Console.Clear();
                Console.Write("\n\n\n1\tStudent \n\n2\tTeacher \n\n3\tAdminstrator \n\n4\tDirector\n\n5\tParents\n\n0\tExit\n\n\n");
                Console.Write("Select  :\t");
                opt = Convert.ToInt32(Console.ReadLine());
                if (opt == 1)
                {
                    Console.Clear();
                    Console.Write("\n\n\n\n\t\t\t\tUsername:\t");
                    Username = Console.ReadLine();
                    Console.Write("\n\n\n\n\t\t\t\tPassword :\t");
                    Password = Console.ReadLine();
                    student = new Student();
                    path = "Students.txt";
                    IFormatter formatter = new BinaryFormatter();
                    Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
                    while (true)
                    {
                        try
                        {
                            student = (Student)formatter.Deserialize(stream);
                            if (student.Username == Username && student.Password == Password)
                            {
                                student.UseSystem();
                                break;
                            }
                        }
                        catch (Exception)
                        {
                            break;
                        }
                    }
                    stream.Close();
                }
                if (opt == 2)
                {
                    Console.Clear();
                    Console.Write("\n\n\n\n\t\t\t\tUsername:\t");
                    Username = Console.ReadLine();
                    Console.Write("\n\n\n\n\t\t\t\tPassword :\t");
                    Password = Console.ReadLine();
                    teacher = new Teacher();
                    path = "Teachers.txt";
                    IFormatter formatter = new BinaryFormatter();
                    Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
                    while (true)
                    {
                        try
                        {
                            teacher = (Teacher)formatter.Deserialize(stream);
                            if (teacher.Username == Username && teacher.Password == Password)
                            {
                                teacher.UseSystem();
                                break;
                            }
                        }
                        catch (Exception)
                        {
                            break;
                        }
                    }
                    stream.Close();
                }
                if (opt == 3)
                {
                    Console.Clear();
                    Console.Write("\n\n\t\t1\tLogin \n\n\n\t\t2\tRegistration  \n\n select :\t");
                    int iopt = Convert.ToInt32(Console.ReadLine());
                    if (iopt == 1)
                    {
                        Console.Clear();
                        Console.Write("\n\n\n\n\t\t\t\tUsername:\t");
                        Username = Console.ReadLine();
                        Console.Write("\n\n\n\n\t\t\t\tPassword :\t");
                        Password = Console.ReadLine();
                        adminstrator = new Adminstrator();
                        path = "Admins.txt";
                        IFormatter formatter = new BinaryFormatter();
                        Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
                        while (true)
                        {
                            try
                            {
                                adminstrator = (Adminstrator)formatter.Deserialize(stream);
                                if (adminstrator.Username == Username && adminstrator.Password == Password)
                                {
                                    adminstrator.UseSystem();
                                    break;
                                }
                            }
                            catch (Exception)
                            {
                                break;
                            }
                        }
                        stream.Close();
                    }
                    if (iopt == 2)
                    {
                        Console.Clear();
                        adminstrator = new Adminstrator();
                        adminstrator.AddAdmin();
                    }
                }
                if (opt == 4)
                {
                    Console.Clear();
                    Console.Write("\n\n\n\n\t\t\t\tUsername:\t");
                    Username = Console.ReadLine();
                    Console.Write("\n\n\n\n\t\t\t\tPassword :\t");
                    Password = Console.ReadLine();
                    director = new Director();
                    path = "Director.txt";
                    IFormatter formatter = new BinaryFormatter();
                    Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
                    while (true)
                    {
                        try
                        {
                            director = (Director)formatter.Deserialize(stream);
                            if (director.Username == Username && director.Password == Password)
                            {
                                director.UseSystem();
                                break;
                            }
                        }
                        catch (Exception)
                        {
                            break;
                        }
                    }
                    stream.Close();
                }
                if (opt == 5)
                {
                    Console.Clear();
                    Console.Write("\n\n\n\n\t\t\t\tUsername:\t");
                    Username = Console.ReadLine();
                    Console.Write("\n\n\n\n\t\t\t\tPassword :\t");
                    Password = Console.ReadLine();
                    parents = new Parents();
                    path = "Parents.txt";
                    IFormatter formatter = new BinaryFormatter();
                    Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
                    while (true)
                    {
                        try
                        {
                            parents = (Parents)formatter.Deserialize(stream);
                            if (parents.Username == Username && parents.Password == Password)
                            {
                                parents.UseSystem();
                                break;
                            }
                        }
                        catch (Exception)
                        {
                            break;
                        }
                    }
                    stream.Close();
                }
            }
        }
    }
}