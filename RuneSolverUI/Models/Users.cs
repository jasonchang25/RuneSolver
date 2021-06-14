using System;
using System.Collections.Generic;

namespace RuneSolverUI.Models
{
    public partial class Users
    {
        public Users()
        {
            Sessions = new HashSet<Sessions>();
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime Expiry { get; set; }
        public int PkUserId { get; set; }
        public string Email { get; set; }
        public int? SessionCount { get; set; }

        public virtual ICollection<Sessions> Sessions { get; set; }
    }
}
