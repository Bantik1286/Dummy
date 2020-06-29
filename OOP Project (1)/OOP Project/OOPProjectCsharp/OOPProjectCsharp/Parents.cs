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
    class Parents:Human
    {
        private string relation;
        private string childRollNo;
        public string  Relation
        {
            set
            {
                relation = value;
            }
            get
            {
                return relation;
            }
        }
        public string ChildRollNo
        {
            set
            {
                childRollNo = value;
            }
            get
            {
                return childRollNo;
            }
        }
        void viewMaksOfYourChild(string CourseCode)
        {
            Marks obj = new Marks();
            obj.CheckMarks(this.childRollNo, CourseCode);
        }
        public override void UseSystem()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\n\n\n\t\t\t\t1\t Check your Child marks \n\n\t\t\t\t2\t View Personal data\n\n\t\t\t\t3\t Exit");
                Console.Write("\n\n\t\t\tSelect :\t");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Console.Clear();
                    Console.Write("\n\n\n\t\t\tEnter course code :\t");
                    string Course = Console.ReadLine();
                    this.viewMaksOfYourChild(Course);
                    Console.Write("Press any key to continue ... ");
                    Console.ReadKey();
                }
                if (choice == 2)
                {
                    PrintData();
                    Console.Write("Press any key to continue ... ");
                    Console.ReadKey();
                }
                if (choice == 3)
                {
                    break;
                }
            }
        }
        public override void PrintData()
        {
            base.PrintData();
            Console.WriteLine("\n\n\t\t\t\tChild Roll no :\t" + ChildRollNo);
            Console.WriteLine("\n\n\t\t\t\tRelation with child" + Relation);
        }
    }
}
