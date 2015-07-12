using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework_EF.Models;

namespace Homework_EF.DataAccess
{
    class TestingDbContext : DbContext
    {
        public TestingDbContext()
            : base("TestingDatabase_Homework")
        {
            
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<TestResult> TestResults { get; set; }
        public DbSet<Lecture> Lectures { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Answer> Answers { get; set; }
    }
}
