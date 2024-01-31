namespace Kenso.Domain
{
    public class MeasurementRecord
    {
        public string? ModelName { get; set; }
        public long? ModelId { get; set; }
        public string? PartName { get; set; }
        public long? PartId { get; set; }
        public string? PartNumber { get; set; }
        public string? FeatureName { get; set; }
        public long? FeatureId { get; set; }
        public string? CharacteristicName { get; set; }
        public long? CharacteristicId { get; set; }
        public decimal? Nominal { get; set; }
        public decimal? Usl { get; set; }
        public decimal? Lsl { get; set; }
        public decimal? UslWarn { get; set; }
        public decimal? LslWarn { get; set; }
        public string? Unit { get; set; }
        public DateTime MeasurementDate { get; set; }
        public decimal? MeasurementValue { get; set; }
        public decimal? Deviation { get; set; }
        public long? AssetId { get; set; }
        public string? AssetName { get; set; }
        public string? AssetLocation { get; set; }
        public long? OperatorId { get; set; }
        public string? OperatorName { get; set; }
        public string? Serial { get; set;}
        public string? Tag { get; set;}
    }
}

