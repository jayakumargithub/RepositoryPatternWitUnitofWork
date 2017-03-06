using System;
using My.Domain.Interface;
using My.Repositories.Repos;

namespace My.Repositories.Context
{
   
    public class UnitOfWork : IDisposable
    {
        private readonly PlutoContext _context;
        public UnitOfWork(PlutoContext context)
        {
            _context = context;
            Courses = new CourseRepository(_context);
            Authors = new AuthorRepository(_context);
                
        }

        public ICourseRepository Courses { get; private set; }
        public IAuthorRepository Authors { get; private set; }

        public int Save()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

      
    }
}
