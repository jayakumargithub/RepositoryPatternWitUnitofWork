using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using My.Domain;
using My.Domain.Models;
using My.Repositories.Context.Configurations;

namespace My.Repositories.Context
{
   public  class PlutoContext : DbContext
    {

        public PlutoContext() : base("name=PlutoContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
            Database.SetInitializer(new AuthorCourseDbInitializer());
        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }

        #region  
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CourseConfiguration());
           
        }


        //execute stored procedure
        public virtual ObjectResult<Author> GetAllAuthorAndCourse()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Author>("GetAllAuthorAndCourse");
        }
        #endregion
    }
}
