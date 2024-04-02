using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_sheet_03_Q1
{
    internal class CourseClass
    {
        static void Main(string[] args)
        {
            Console.Write("enter course name:");
            string courseName = Console.ReadLine();

            Console.Write("Enter instructor name: ");
            string instructorName = Console.ReadLine();

            Console.WriteLine("Enter grade (0-100): ");
            double grade = double.Parse(Console.ReadLine());


            Course course = new Course(courseName);

            course.SetInstructorName(instructorName);
            course.Grade = grade;

            course.PrintCourseInfo();

            Console.ReadLine();


        }
    }

}
