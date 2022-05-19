using System;
using System.Collections.Generic;
using System.Text;

namespace DesignAnalysis.Core.Entities
{
    public class Page: EntityBase<int>
    {
        public string UrlName { get; set; }
        public string Url { get; set; }
        public ICollection<RolePage> RolePages { get; set; }
    }
}
