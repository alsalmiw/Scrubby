using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace scrubby_webapi.Models
{
    public class SelectedItemInSpaceModel
    {
        public int itemId { get; set; }
        public int SpaceId { get; set; }
        public bool isDeleted { get; set; }
        public SelectedItemInSpaceModel(){}
    }
}