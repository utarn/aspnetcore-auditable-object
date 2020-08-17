using aspnetcore_auditable.Interfaces;

namespace aspnetcore_auditable.Data
{
    public class Product : UserAuditable
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
    }
}