namespace mahar.models
{
    public class Media
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id { get; set; }

        [ForeignKey("TitleId")]
        public Guid TitleId { get; set; }

        [ForeignKey("GenreId")]
        public Guid GenreId { get; set; }

        [ForeignKey("SeasonId")]
        public Guid SeasonId { get; set; }

        public ImageTypeEnum ImageType { get; set; }

        public string? Image { get; set; }
    }

    public enum ImageTypeEnum
    {
        // Add your enum values here
    }
}
