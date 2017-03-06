using System.Collections.Generic;
using My.Domain.Models;

namespace My.Repositories.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<My.Repositories.Context.PlutoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(My.Repositories.Context.PlutoContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //



            IList<Author> defaultAuthors = new List<Author>();
            defaultAuthors.Add(new Author() { AuthorId = 1, Name = "Jayakumar", Courses = null });
            defaultAuthors.Add(new Author() { AuthorId = 2, Name = "John", Courses = null });

            foreach (var author in defaultAuthors)
            {
                context.Authors.AddOrUpdate(author);
            }

            IList<Course> defaultCourse = new List<Course>();
            defaultCourse.Add(new Course() { AuthorId = 1, CourseId = 1, Description = "Dot net course", FullPrice = 100, Level = 10, Name = "Become dotnet developer" });
            defaultCourse.Add(new Course() { AuthorId = 1, CourseId = 2, Description = "c# course", FullPrice = 300, Level = 20, Name = "Become c# developer" });
            defaultCourse.Add(new Course() { AuthorId = 2, CourseId = 3, Description = "Angular js course", FullPrice = 500, Level = 30, Name = "Become angularjs developer" });

            foreach (var course in defaultCourse)
            {
                context.Courses.AddOrUpdate(course);
            }
        }
    }
}
