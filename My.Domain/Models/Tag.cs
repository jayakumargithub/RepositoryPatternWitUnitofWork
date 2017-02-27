using System.Collections.Generic;

namespace My.Domain.Models
{
   public class Tag
    {
        
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Course> Courses { get; set; } = new HashSet<Course>();
    }
}
