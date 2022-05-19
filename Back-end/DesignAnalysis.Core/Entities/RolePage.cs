using System;
using System.Collections.Generic;
using System.Text;

namespace DesignAnalysis.Core.Entities
{
    public class RolePage: EntityBase<int>
    {
        public int RoleId { get; set; }
        public int PageId { get; set; }
        public Role Role { get; set; }
        public Page Page { get; set; }
    }
}
