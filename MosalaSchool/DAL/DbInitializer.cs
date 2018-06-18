using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MosalaSchool.Models;

namespace MosalaSchool.DAL
{
    public class DbInitializer: System.Data.Entity.DropCreateDatabaseIfModelChanges<DBContext>
    {
        protected override void Seed(DBContext context)
        {
            var student = new List<Student>
            {
                new Student {FirstName="Relebohile", LastName="Biza",EnrollmentDate=DateTime.Parse("2010-02-02") },
                new Student {FirstName="Ishmael", LastName="Biza",EnrollmentDate=DateTime.Parse("2010-02-05") },
                new Student {FirstName="Matlale", LastName="Biza",EnrollmentDate=DateTime.Parse("2010-02-02") },
                new Student {FirstName="Chuku", LastName="Biza",EnrollmentDate=DateTime.Parse("2010-02-05") },
            };
            student.ForEach(s => context.Student.Add(s));
            context.SaveChanges();

            var course = new List<Course>
            {
                new Course{Id=2001,Title="Physical Science",Credit=3},
                new Course{Id=2002,Title="Life Science",Credit=3},
                new Course{Id=2003,Title="Mathematics",Credit=5},
                new Course{Id=2011,Title="English",Credit=3},
                new Course{Id=2012,Title="Afrikaans",Credit=3},
                new Course{Id=2013,Title="Sesotho",Credit=3},
                new Course{Id=2021,Title="History",Credit=3},
                new Course{Id=2022,Title="Geography",Credit=3},
                new Course{Id=2023,Title="Business Study ",Credit=3},
                new Course{Id=2031,Title="Accounting",Credit=3},
                new Course{Id=2032,Title="Economics",Credit=3},
                new Course{Id=2033,Title="Maths Literacy",Credit=3},
            };
            course.ForEach(c => context.Course.Add(c));
            context.SaveChanges();

            var enrollment = new List<Enrollment>
            {
                new Enrollment{StudentID=1,CourseID=2001,Grade=Grade.A},
                new Enrollment{StudentID=1,CourseID=2003,Grade=Grade.B},
                new Enrollment{StudentID=2,CourseID=2011,Grade=Grade.A},
                new Enrollment{StudentID=2,CourseID=2013,Grade=Grade.B},
                new Enrollment{StudentID=2,CourseID=2021,Grade=Grade.A},
                new Enrollment{StudentID=3,CourseID=2001,Grade=Grade.F},
                new Enrollment{StudentID=3,CourseID=2011,Grade=Grade.D},
                new Enrollment{StudentID=4,CourseID=2031,Grade=Grade.A},
                new Enrollment{StudentID=1,CourseID=2032,Grade=Grade.C},
            };
            enrollment.ForEach(e => context.Enrollment.Add(e));
            context.SaveChanges();
            
        }
    }
}