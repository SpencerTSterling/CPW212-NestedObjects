using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //create instructor
            Instructor currProf = new Instructor()
            {
                FullName = "Homer Simpson",
                Email = "Homer.Simpson@cptc.edu"
            };

            //create some students
            Student stu1 = new Student()
            {
                FirstName = "Jim",
                LastName = "Halpert"
            };

            Student stu2 = new Student()
            {
                FirstName = "Creed",
                LastName = "Bratton"
            };

            Student stu3 = new Student()
            {
                FirstName = "Kelly",
                LastName = "Kapur"
            };

            //create a course
            Course testCourse = new Course();
            testCourse.Title = "CPW212 - Advanced .NET Programming";
            testCourse.Description = "Learn advanced .NET programming - " +
                "writing classes, working with indexers, overloading operators, and other advanced object-oriented concepts";
            testCourse.Credits = 5;

                //give course the current professor
            testCourse.CourseInstructor = currProf;

                //give course a roster of students
            testCourse.Roster = new List<Student>();

            testCourse.Roster.Add(stu1);
            testCourse.Roster.Add(stu2);
            testCourse.Roster.Add(stu3);


            // Show data

            Console.WriteLine(testCourse.Title);
            Console.WriteLine("is taught by " + testCourse.CourseInstructor.FullName);

            Console.WriteLine();

            Console.WriteLine("Currently entrolled students:");
            foreach(Student s in testCourse.Roster)
            {
                Console.WriteLine($"{s.FirstName} {s.LastName}");
            }

            // read key 
            Console.ReadKey();

        }
    }
}
