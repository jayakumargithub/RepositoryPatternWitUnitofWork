using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using My.Domain;
using My.Domain.Interface;
using My.Domain.Models;
using My.Repositories.Context;

namespace My.Repositories.Repos
{
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        public CourseRepository(PlutoContext context) :base(context)
        {

        }
        public IEnumerable<Course> GetCourseWithoutAuthors(int pageIndex, int pageSize)
        {
            return PlutoContext.Courses
               .Include(c => c.Author)
               .OrderBy(c => c.Name)
               .Skip((pageIndex - 1) * pageSize)
               .Take(pageSize)
               .ToList();            
        }

        public IEnumerable<Course> GetTopSellingCourses(int count)
        {
            return PlutoContext.Courses.OrderByDescending(c => c.FullPrice).Take(count).ToList();
        } 
        
        public PlutoContext PlutoContext => Context as PlutoContext;
    }
}
