using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using direktoriStudent.Models;

namespace direktoriStudent.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<direktoriStudent.Models.Student> Student { get; set; }
        public DbSet<direktoriStudent.Models.Lecturer> Lecturer { get; set; }
    }
}
