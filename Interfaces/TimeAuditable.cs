using System;

namespace aspnetcore_auditable.Interfaces
{
    public abstract class TimeAuditable
    {
        public DateTime Created { get; set; }
        public DateTime? LastModified { get; set; }
    }
}