namespace Kenso.Domain
{
    public class Measurement
    {
        public Characteristic? Characteristic { get; set; }
        public decimal Value { get; set; }
        public decimal? Deviation { get; set; }
        public decimal? Nominal { get; set; }
        public DateTime DateTime { get; set; }
        public Operator? Operator { get; set; }
        public Asset? Asset { get; set; }
        public string? Serial { get; set; }
        public string? Tag { get; set; }
        public string? CreatedBy { get; set; }
    }
}
