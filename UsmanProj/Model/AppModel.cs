using Microsoft.EntityFrameworkCore;
using UsmanProj.Data;

namespace UsmanProj.Model
{
    public class AppModel:DbContext
    {
        public AppModel(DbContextOptions<AppModel> options):base(options) 
        { 

        }
        public DbSet<Classs> classses  { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<Faculty> faculty { get; set; }
        public DbSet<Enrolled> enrolled { get; set; }

    }

    }

