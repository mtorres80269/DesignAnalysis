using System;
using System.Collections.Generic;
using System.Text;

namespace DesignAnalysis.Core.Entities
{
    public class User: EntityBase<int>
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public long CreatedUnixTime { get; set; }
        public long? UpdatedUnixTime { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
