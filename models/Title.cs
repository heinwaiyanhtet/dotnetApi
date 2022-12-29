namespace mahar.models
{
    public class Title
    {
        public Guid Id { get; set; }
        public Guid OwnerId { get; set; }
        public string? TitleEn { get; set; }
        public string? ShortMm { get; set; }
        public string? DescriptionEn { get; set; }
        public string? TitleMm { get; set; }
        public string? DescriptionMm { get; set; }
        public TypeEnum Type { get; set; }
    }
    public enum TypeEnum
    {
        series,
        movie
    }
}