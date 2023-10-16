namespace Kenso.Domain
{
    public class MeasurementRecord
    {
        public string? ModelName { get; set; }
        public string? PartName { get; set; }
        public string PartNumber { get; set; }
        public string? FeatureName { get; set; }
        public string CharacteristicName { get; set; }
        public decimal? Nominal { get; set; }
        public decimal? Usl { get; set; }
        public decimal? Lsl { get; set; }
        public decimal? UslWarn { get; set; }
        public decimal? LslWarn { get; set; }
        public string? Unit { get; set; }
        public DateTime MeasurementDate { get; set; }
        public decimal? MeasurementValue { get; set; }
        public decimal? Deviation { get; set; }
        public string? Device { get; set; }
        public string? Operator { get; set; }
    }
}

