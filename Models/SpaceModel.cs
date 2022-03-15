using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace scrubby_webapi.Models
{
    public class SpaceModel
    {
        public int spaceId { get; set; }
        public string? spaceName { get; set; }
        public string? spaceCategory { get; set; }
        public int userId { get; set; }
        public SpaceModel(){}
    }
}