using System;
using System.Collections.Generic;
using System.Text;

namespace DesignAnalysis.Core.Entities
{
    public class Role: EntityBase<int>
    {
        public string Name { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
        public ICollection<RolePage> RolePages { get; set; }
    }
}
