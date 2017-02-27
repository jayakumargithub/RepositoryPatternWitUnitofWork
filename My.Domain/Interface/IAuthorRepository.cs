using My.Domain.Models;

namespace My.Domain.Interface
{
   public  interface IAuthorRepository : IRepository<Author>
    {
        Author GetAuthorWithCourses(int id);
    }
}
