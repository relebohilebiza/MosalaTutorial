using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace MosalaSchool.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public String Title { get; set; }
        public int Credit { get; set; }
        
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}