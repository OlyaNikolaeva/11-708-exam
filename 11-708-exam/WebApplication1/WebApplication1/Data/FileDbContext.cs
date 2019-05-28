using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class FileDbContext : DbContext
    {
        public FileDbContext (DbContextOptions<FileDbContext> options)
            : base(options)
        {
        }

        public DbSet<FileScr> Files { get; set; }
    }
}
