using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data
{
    public enum RoleCategory
    {
        [Description("Admin")]
        Admin = 1,
        [Description("User")]
        User
    }
}
