namespace aspnetcore_auditable.Interfaces
{
    public abstract class UserAuditable : TimeAuditable
    {
        public string? CreatedBy { get; set; }
        public string? LastModifiedBy { get; set; }
    }
}