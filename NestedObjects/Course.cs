using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    /// <summary>
    /// Represents an individual course
    /// </summary>
    class Course
    {
        #region Properties
        /// <summary>
        /// The full title of the course (including course code). 
        /// Ex. CPW 212 - Advanced .NET Programming
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// The offical course description from catalog.
        /// ex. Learn advanced .NET programming - 
        /// writing classes, working with indexers, overloading operators, and other advanced object-oriented concepts. 
        /// Work with databases using ADO. NET, databinding, and object-relational mappers. 
        /// Learn techniques for working non-relational data storage.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// The number of college credits awarded for completing the course.
        /// ex. 5
        /// </summary>
        public byte Credits { get; set; }
        /// <summary>
        /// The instructor that teaches the course
        /// </summary>
        public Instructor CourseInstructor { get; set; }
        /// <summary>
        /// All the students currently enrolled in the class
        /// </summary>
        public List<Student> Roster { get; set; }
        #endregion 
    }
}
