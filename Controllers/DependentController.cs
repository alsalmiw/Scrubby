using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Scrubby_webApi.Services;
using Scrubby_webApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace Scrubby_webApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DependentController : ControllerBase
    {
        private readonly DependentService _data;
        public DependentController(DependentService dataFromDependentService)
        {
            _data = dataFromDependentService;
        }
        [HttpPost("AddDependent")]
        public bool AddDependent(DependentModel newDependent)
        {
            return _data.AddDependent(newDependent);
        }

        [HttpPost("UpdateDependent")]
        public bool UpdateDependent(DependentModel DependentUpdate)
        {
            return _data.UpdateDependent(DependentUpdate);
        }
    }
}