using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using scrubby_webapi.Models;
using Microsoft.EntityFrameworkCore;

namespace scrubby_webapi.Services.Context
{
    public class DataContext :DbContext
    {
        public DbSet<DependentModel>? DependentInfo {get; set;}
        public DataContext(DbContextOptions options) : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}