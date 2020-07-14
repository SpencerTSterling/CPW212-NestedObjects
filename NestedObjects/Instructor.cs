using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    /// <summary>
    /// Represents an individual instructor
    /// </summary>
    class Instructor
    {
        #region Properties
        /// <summary>
        /// Instructor's legal full name (first and last)
        /// ex. Jane Doe
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// Company email address
        /// ex. Jane.Doe@cptc.edu
        /// </summary>
        public string Email { get; set; }
        #endregion
    }
}
