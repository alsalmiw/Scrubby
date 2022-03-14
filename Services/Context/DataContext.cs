using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace scrubby_webapi.Services.Context
{
    public class DataContext :DbContext
    {
        public DbSet<DependentModel> DependentInfo {get; set;}
    }
}