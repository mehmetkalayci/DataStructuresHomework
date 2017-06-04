using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresHW
{
    public class LinkedList
    {
        private Student first;

        public void LinkList()
        {
            first = null;
        }

        public bool IsEmpty()
        {
            return (first == null);
        }

        public void Insert(Student student)
        {
            if (!this.IsEmpty())
            {
                int i = 0;
                if (this.FindByStudentNumber(student.Number,out i) != null)
                {
                    return;
                }
            }

            Student newLink = new Student(student);
            Student previous = null;
            Student current = first;

            while (current != null && student.Number > current.Number)
            {
                previous = current;
                current = current.Next;
            }
            if (previous == null)
                first = newLink;
            else
                previous.Next = newLink;
            newLink.Next = current;
        }

        public Student Delete(int studentNumber)
        {
            Student current = first;
            Student previous = first;
            while (current.Number != studentNumber)
            {
                if (current.Next == null)
                    return null;
                else
                {
                    previous = current;
                    current = current.Next;
                }
            }
            if (current == first)
                first = first.Next;
            else
                previous.Next = current.Next;
            return current;
        }
        
        public int ListCount()
        {
            int count = 0;
            Student current = first;
            while (current != null)
            {
                count++;
                current = current.Next;
            }
            return count;

        }

        public void DisplayList()
        {
            Student current = first;
            while (current != null)
            {
                current.DisplayLink();
                current = current.Next;
            }
        }

        public Student FindByStudentNumber(int studentNumber, out int i)
        {
            int count = 0;

            Student currentStudent = first;
            while (currentStudent.Number != studentNumber)
            {
                count++;

                if (currentStudent.Next == null)
                {
                    i = -1;
                    return null;
                }
                else
                {
                    currentStudent = currentStudent.Next;
                }
            }
            i = count;
            return currentStudent;
        }

        public string FindByStudentSurname(string studentSurname, int studentCount)
        { 
                string students = "";
                Student currentStudent = first;
                for (int i = 1; i <= studentCount; i++)
                {
                    if (currentStudent.Surname == studentSurname)
                    {
                        students += currentStudent.Number + "                    " + currentStudent.Name + "                    " + currentStudent.Surname + "                    " + i + "\n";
                    }
                    currentStudent = currentStudent.Next;
                }
                return students;
            
        }

        public string FindByStudentName(string studentName, int studentCount)
        {
            string students = "";
            Student currentStudent = first;
            for (int i = 1; i <= studentCount; i++)
            {
                  if (currentStudent.Name == studentName)
                  {
                    students += currentStudent.Number + "                    " + currentStudent.Name + "                    " + currentStudent.Surname + "                    " + i + "\n";
                  }
                currentStudent = currentStudent.Next;
            }
            return students;
        }
    }
}