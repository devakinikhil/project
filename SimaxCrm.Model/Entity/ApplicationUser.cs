using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace SimaxCrm.Model.Entity
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<ApplicationUserRole> UserRoles { get; set; }
        public string Name { get; set; }
        public int Tid { get; set; }
        public virtual List<Lead> Lead { get; set; }
        public virtual List<CallLog> CallLog { get; set; }
        public virtual List<UserLog> UserLog { get; set; }
        public virtual List<LeadAutoAssign> LeadAutoAssign { get; set; }
        public virtual List<LeadAutoAssignLog> LeadAutoAssignLog { get; set; }
    }
}
