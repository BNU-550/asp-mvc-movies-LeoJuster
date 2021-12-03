using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_RAZOR_CONTOSO.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime EnrollmentDate { get; set; }
       
        //Relationships or navigation properites
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
