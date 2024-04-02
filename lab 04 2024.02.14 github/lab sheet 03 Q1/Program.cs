using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_sheet_03_Q1
{
    public class Course
    {
        private string courseName;
        private string instructorName;
        private double grade;

        public Course(string courseName)
        {
            if (string.IsNullOrEmpty(courseName))
            {
                throw new ArgumentNullException("course name cannot be empty. ");
            }
            this.courseName = courseName;
        }


        public string CourseName => courseName; // read only property course

        public double Grade
        {
            get => grade;
            set
            {
                if (value >= 0 && value <= 100)
                {
                    grade = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Grade must be between 0 and 100");
                }
            }
        }


        public void SetInstructorName(string instructorName) //methode to get instructor
        {
            if (!string.IsNullOrEmpty(instructorName))
            {
                throw new ArgumentException("instructor Name");
            }
            this.instructorName = instructorName;
        }
        private string CalculateGrade()
        {
            if (grade >= 90)
            {
                return "A";
            }
            else if (grade >= 80)
            {
                return "B";
            }
            else if (grade >= 70)
            {
                return "C";
            }
            else if (grade >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }

        }
        public void PrintCourseInfo() //method to print course information
        {
            Console.WriteLine($"Course Name: {courseName} ");
            Console.WriteLine($"Instructor Name: {instructorName}");
            Console.WriteLine($"Letter Grade: {CalculateGrade()}");
        }

    }
}
