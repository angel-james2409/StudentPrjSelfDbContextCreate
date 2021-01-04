using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Models;

namespace WebApplication4.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            context.Database.EnsureCreated();
            if (context.Students.Any())
            {
                return;
            }
            var students = new Student[]
            {
                new Student{FirstName="angel",LastName="james",EnrollmentDate=DateTime.Parse("2020-12-10")},
                 new Student{FirstName="Leona",LastName="Louis",EnrollmentDate=DateTime.Parse("2020-12-10")},
                 new Student{FirstName="Jannani",LastName="Ramesh",EnrollmentDate=DateTime.Parse("2020-12-10")}
            };
            foreach(Student s in students)
            {
                context.Students.Add(s);
            }
            context.SaveChanges();
            var courses = new Course[]
            {
                new Course{CourseId=101,Title="Chemistry",Credits=3},
                new Course{CourseId=102,Title="Botany",Credits=5},
                new Course{CourseId=103,Title="maths",Credits=2}
            };
            foreach (Course c in courses)
            {
                context.Courses.Add(c);
            }
            context.SaveChanges();
            var enrollments = new Enrollment[]
            {
                new Enrollment{StudentId=1,CourseId=101},
                  new Enrollment{StudentId=2,CourseId=102},
                    new Enrollment{StudentId=3,CourseId=103},

            };
            foreach (Enrollment e in enrollments)
            {
                context.Enrollments.Add(e);
            }
            context.SaveChanges();



        }
    }
}
