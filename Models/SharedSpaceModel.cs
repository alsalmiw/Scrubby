using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace scrubby_webapi.Models
{
    public class SharedSpaceModel
    {
        public int SpaceId { get; set; }
        public int UserId { get; set; }
        public SharedSpaceModel(){}
    }
}