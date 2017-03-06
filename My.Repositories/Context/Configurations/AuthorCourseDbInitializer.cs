using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using My.Domain.Models;

namespace My.Repositories.Context.Configurations
{
    public class AuthorCourseDbInitializer :DropCreateDatabaseAlways<PlutoContext>
    {
        protected override void Seed(PlutoContext context)
        {


          
            IList<Author> defaultAuthors = new List<Author>();
            defaultAuthors.Add(new Author() {AuthorId = 1, Name = "Jayakumar", Courses = null});
            defaultAuthors.Add(new Author() {AuthorId = 2, Name="John", Courses = null}); 

            foreach (var author in defaultAuthors)
            {
                context.Authors.Add(author);
            }

            IList<Course> defaultCourse = new List<Course>();
            defaultCourse.Add(new Course() {AuthorId =1, CourseId = 1,Description = "Dot net course",FullPrice=100,Level=10,Name="Become dotnet developer"});
            defaultCourse.Add(new Course() { AuthorId = 1, CourseId = 2, Description = "c# course", FullPrice = 300, Level = 20, Name = "Become c# developer" });
            defaultCourse.Add(new Course() { AuthorId = 2, CourseId = 3, Description = "Angular js course", FullPrice = 500, Level = 30, Name = "Become angularjs developer" });

            foreach(var course in defaultCourse)
            {
                context.Courses.Add(course);
            }
            base.Seed(context);
        }
    }
}
