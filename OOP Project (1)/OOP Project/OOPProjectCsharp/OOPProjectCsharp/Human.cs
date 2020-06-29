using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProjectCsharp
{
    [Serializable]
   abstract class Human
    {
        private string name;
        private string fatherName;
        private string username;
        private string password;
        private int dateOfBirth, monthOfBirth, yearOfBirth;
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        public string FatherName
        {
            set
            {
                fatherName = value;
            }
            get
            {
                return fatherName;
            }
        }
        public int DateOfBirth
        {
            set
            {
                if (value > 0 && value <= 31)
                    dateOfBirth = value;
                else
                    Console.WriteLine("Please enter a valid date of birth ");
            }
            get
            {
                return dateOfBirth;
            }
        }
        public int MonthOfBirth
        {
            set
            {
                if (value >= 1 && value <= 12)
                    monthOfBirth = value;
               else
                    Console.WriteLine("Please enter a valid date of birth ");
            }
            get
            {
                return monthOfBirth;
            }
        }
        public int YearOfBirth
        {
            set
            {
                yearOfBirth = value;
            }
            get
            {
                return yearOfBirth;
            }
        }
        public string Username
        {
            set
            {
                username = value;
            }
            get
            {
                return username;
            }
        }
        public string Password
        {
            set
            {
                password = value;
            }
            get
            {
                return password;
            }
        }
        public abstract void UseSystem();
        public virtual void PrintData()
        {
            Console.WriteLine("\n\n\t\tName :\t" + Name);
            Console.WriteLine("\n\n\t\tFather's Name :\t" + FatherName);
            Console.WriteLine("\n\n\t\tDate of birth :\t" + DateOfBirth+'/'+MonthOfBirth+'/'+YearOfBirth );
            Console.WriteLine("\n\n\t\tUsername :\t" + Username);
        }
    }
}
