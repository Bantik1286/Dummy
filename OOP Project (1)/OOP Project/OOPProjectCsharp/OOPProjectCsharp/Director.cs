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
    class Director:Human
    {
        public void checkInbox()
        {
            Message obj = new Message();
            string path = "Messages.txt";
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
            while(true)
            {
                try
                {
                    obj = (Message)formatter.Deserialize(stream);
                    if (obj.To == this.Username)
                    {
                        Console.Write("\n\nFrom : " + obj.From +"\t\t\t"+ "Subject : " + obj.Subject);
                        Console.WriteLine("\n\nMessage : " + obj._Message + "\n\n");
                    }

                }
                catch(Exception)
                {
                    break;
                }
            }
            stream.Close();
        }

        public override void UseSystem()
        {
            while (true)
            {
                Console.Clear();
                Console.Write("\n\n\n\t1\t\tCheck Inbox \n\n\n\t2\t\t Update Account \n\n\n\t3\t\t Send Message \n\n\n\t4\t\t Show my data\n\n\n\t0\t\t Exit \nSelect : ");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Console.Clear();
                    checkInbox();
                    Console.Write("\n\nPlease enter any key to continue ... ");
                    Console.ReadKey();
                }
                if (choice == 2)
                {
                    Console.Clear();
                    UpdateAccount();
                    Console.Write("\n\nPlease enter any key to continue ... ");
                    Console.ReadKey();
                }
                if (choice == 3)
                {
                    Console.Clear();
                    Message obj = new Message();
                    Console.Write("\n\n\t\t\t\tEnter Username to send message : ");
                    string User = Console.ReadLine();
                    Console.Write("\n\n\t\t\t\tEnter Subject of message  : ");
                    string Subject = Console.ReadLine();
                    Console.Write("\n\n\t\t\t\tEnter message : ");
                    string msg = Console.ReadLine();
                    obj.SendMessage(Username, User, msg, Subject);
                    Console.Write("\n\nPlease enter any key to continue ... ");
                    Console.ReadKey();
                }
                if (choice == 4)
                {
                    Console.Clear();
                    PrintData();
                    Console.Write("\n\nPlease enter any key to continue ... ");
                    Console.ReadKey();
                }
                if(choice==0)
                {
                    break;
                }
            }
        }
        public override void PrintData()
        {
            base.PrintData();
        }
        public void UpdateAccount()
        {
            Console.Write("\n\n\t\t\t\tEnter Name : ");
            this.Name = Console.ReadLine();
            Console.Write("\n\n\t\t\t\tEnter Father's name : ");
            FatherName = Console.ReadLine();
            Username = "Director@nu.edu.pk";
            File.AppendAllText("Usernames.txt", Username);
            Console.WriteLine("\n\n\t\t\t\tYour Username is : " + Username);
            Console.Write("\n\n\t\t\t\tEnter Password  : ");
            Password = Console.ReadLine();
            Console.Write("\n\n\t\t\t\tEnter Date of Birth (in int) :  ");
            DateOfBirth = Convert.ToInt32(Console.ReadLine());
            MonthOfBirth = Convert.ToInt32(Console.ReadLine());
            YearOfBirth = Convert.ToInt32(Console.ReadLine());
            string path = "Director.txt";
            Stream stream = new FileStream(path,FileMode.Create,FileAccess.Write);
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, this);
            stream.Close();
        }
    }
}
