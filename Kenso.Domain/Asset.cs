namespace Kenso.Domain
{
    public class Asset
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string? Location { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
