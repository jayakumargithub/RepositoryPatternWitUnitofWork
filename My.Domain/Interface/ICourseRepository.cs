using System.Collections.Generic;
using My.Domain.Models;

namespace My.Domain.Interface
{
    public interface ICourseRepository : IRepository<Course>
    {
        IEnumerable<Course> GetTopSellingCourses(int count);
        IEnumerable<Course> GetCourseWithoutAuthors(int pageIndex, int pageSize);
    }
}
