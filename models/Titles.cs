namespace mahar.models
{
    public class Titles
    {
        [Key]
        [Required]
        public Guid Id { get; set; }
        [Required]
        [ForeignKey("Owners")]
        public Guid OwnerId { get; set; }
        [Required]
        [StringLength(255)]
        public string? TitleEn { get; set; }
        [StringLength(255)]
        public string? ShortMm { get; set; }
        [Required]
        [MaxLength]
        public string? DescriptionEn { get; set; }
        [Required]
        [StringLength(255)]
        public string? TitleMm { get; set; }
        [Required]
        [MaxLength]
        public string? DescriptionMm { get; set; }
        [Required]
        public TypeEnum Type { get; set; }
    }
    public enum TypeEnum
    {
        series,
        movie
    }
}