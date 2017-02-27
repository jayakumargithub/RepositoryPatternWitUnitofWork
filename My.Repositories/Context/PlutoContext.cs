﻿using System.Data.Entity;
using My.Domain;
using My.Domain.Models;

namespace My.Repositories.Context
{
   public  class PlutoContext : DbContext
    {

        public PlutoContext() : base("name=PlutoContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
         // modelBuilder.Configurations.Add(new CourseConfiguration
        }

    }
}