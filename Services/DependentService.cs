using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Scrubby_webApi.Models;
using Scrubby_webApi.Services.Context;

namespace Scrubby_webApi.Services
{
    public class DependentService
    {
        private readonly DataContext _context;
        public DependentService(DataContext context)
        {
            _context = context;
        }

        public bool AddDependent(DependentModel newDependent)
        {
            _context.Add(newDependent);
            return _context.SaveChanges() !=0;
        }
        public bool UpdateDependent(DependentModel DependentUpdate)
        {
            _context.Update<DependentModel>(DependentUpdate);
            return _context.SaveChanges() != 0;
        }
    }
}