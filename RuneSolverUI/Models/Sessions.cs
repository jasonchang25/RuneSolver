using System;
using System.Collections.Generic;

namespace RuneSolverUI.Models
{
    public partial class Sessions
    {
        public int PkSessionId { get; set; }
        public int FkUserId { get; set; }
        public string Guid { get; set; }

        public DateTime Expiry { get; set; } 

        public virtual Users FkUser { get; set; }
    }
}
