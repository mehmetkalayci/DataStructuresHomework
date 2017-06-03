using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresHW
{
    public class Student
    {
        int number;
        string name;
        string surname;

        Student next;

        public int Number
        {
            get
            {
                return number;
            }

            set
            {
                number = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Surname
        {
            get
            {
                return surname;
            }

            set
            {
                surname = value;
            }
        }

        public Student Next
        {
            get
            {
                return next;
            }

            set
            {
                next = value;
            }
        }

        public Student(Student student)
        {
            this.Number = student.Number;
            this.Name = student.Name;
            this.Surname = student.Surname;
        }

        public Student(int number, string name, string surname)
        {
            this.Number = number;
            this.Name = name;
            this.Surname = surname;
        }

        public void DisplayLink()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return String.Format("Number:{0} \tName:{1} \tSurname:{2}", this.Number, this.Name, this.Surname);
        }
    }
}