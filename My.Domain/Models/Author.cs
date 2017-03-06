using System;
using System.Collections.Generic;
using My.Domain.Interface;

namespace My.Domain.Models
{
    public class Author  
    {
        public Author()
        {
            Courses = new HashSet<Course>();
        }

        public int AuthorId { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
        public string Salute { get; set; }
        
    }
}
