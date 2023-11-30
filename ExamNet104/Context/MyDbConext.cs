using ExamNet104.Models;
using Microsoft.EntityFrameworkCore;

namespace ExamNet104.Context
{
    public class MyDbConext : DbContext
    {
        public MyDbConext(DbContextOptions options) : base(options)
        {

        }

        public MyDbConext()
        {
        }

        public DbSet<Movie> movies { get; set; }
    }
}
