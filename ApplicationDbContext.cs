using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CRUDHW3._0.Data;

namespace CRUDHW3._0.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<CRUDHW3._0.Data.Auto> Auto { get; set; }
        public DbSet<CRUDHW3._0.Data.Manufactures> Manufactures { get; set; }
    }
}
