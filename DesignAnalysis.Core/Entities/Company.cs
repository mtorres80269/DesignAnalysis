using System;
using System.Collections.Generic;
using System.Text;

namespace DesignAnalysis.Core.Entities
{
    public class Company: AuditableEntityBase<long>
    {
        public string CompanyName { get; set; }
        public string CompanySecondaryName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string ImageUrl { get; set; }
        public string FileName { get; set; }
        public Project Project { get; set; }
    }
}
