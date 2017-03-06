using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using My.Repositories.Context;
using My.Domain;
using My.Repositories.Repos;

namespace My.Client
{
    class Program
    {
        static void Main(string[] args)
        {


            var author = new AuthorRepository(new PlutoContext());
            var result = author.MultipleResultsAuthorAndCourse();
            //using (var unitOfWork = new UnitOfWork(new PlutoContext()))
            //{
            //    // var courses = unitOfWork.Courses.FindById(1);
            //    //var courses2 = unitOfWork.Courses.GetCourseWithoutAuthors(1, 4);
            //    //var author = unitOfWork.Authors.GetAuthorWithCourses(1);
            //    //unitOfWork.Courses.RemoveRange(author.Courses);
            //    //unitOfWork.Authors.Remove(author);
            //    //unitOfWork.Save();
            //    try
            //    {
            //        var author = unitOfWork.Authors.MultipleResultsAuthorAndCourse();
            //    }
            //    catch (Exception ex)
            //    {
            //      Console.Write(ex.Message);
            //    }
       
        }
    }
}
