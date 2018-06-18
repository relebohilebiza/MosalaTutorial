using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MosalaSchool.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MosalaSchool.DAL
{
    public class DBContext :DbContext
    {
        public DBContext() : base("MosalaDbConnection")
        {
        }

        public DbSet<Student> Student { get; set;}
        public DbSet<Course> Course { get; set; }
        public DbSet<Enrollment> Enrollment { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}