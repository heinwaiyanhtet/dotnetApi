namespace YourNamespace
{
    public class Movie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id { get; set; }

        [Required]
        public Guid TitleId { get; set; }

        [Required]
        public int Duration { get; set; }

        public string? FullhdFileSize { get; set; }

        public string? HdFileSize { get; set; }

        public string? SdFileSize { get; set; }

        [Required]
        public string? Trailer { get; set; }

        [Required]
        public string? StreamingUrl { get; set; }

        [Required]
        public string? DownloadUrl { get; set; }

        [Required]
        public int Sorting { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public DateTime UpdatedAt { get; set; }

        public bool IsCinema { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        public int DiscountPrice { get; set; }

        [Required]
        public bool IsExclusive { get; set; }

        [Required]
        public bool Status { get; set; }

        public DateTime? StartDate { get; set; }

        [Required]
        public DateTime ExpireDate { get; set; }

        public DateTime? PublishDate { get; set; }
    }
}
