using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using My.Domain;
using My.Domain.Interface;
using My.Domain.Models;
using My.Repositories.Context;

namespace My.Repositories.Repos
{
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        public AuthorRepository(PlutoContext context) : base(context)
        {
        }

        public Author GetAuthorWithCourses(int id)
        { 
            return PlutoContext.Authors.Include(a => a.Courses).SingleOrDefault(a => a.AuthorId == id);
        }

        public PlutoContext PlutoContext
        {
            get { return Context as PlutoContext; }
        }


        public List<IEnumerable>  MultipleResultsAuthorAndCourse()
        {
           return  Context.MultipleResults("[dbo].[GetAllAuthorAndCourse]").AddResult<Author>().AddResult<Course>().Execute();

        }
        
    }
}
