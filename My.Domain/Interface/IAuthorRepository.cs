using System.Collections;
using System.Collections.Generic;
using My.Domain.Models;

namespace My.Domain.Interface
{
   public  interface IAuthorRepository : IRepository<Author>
    {
        Author GetAuthorWithCourses(int id);
        List<IEnumerable> MultipleResultsAuthorAndCourse();
    }
}
