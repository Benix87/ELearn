using ELearn.DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearn.DataLayer.Context
{
    public class ELearnContext : DbContext
    {
        public ELearnContext(DbContextOptions<ELearnContext> options)
            : base(options)
        {

        }
        public DbSet<Course> Course { get; set; }
        public DbSet<CourseGroup> CourseGroups { get; set; }
        public DbSet<CourseSeason> CourseSeason { get; set; }
        public DbSet<Episode> Episode { get; set; }
    }
}