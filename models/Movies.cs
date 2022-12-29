namespace YourNamespace
{
    public class Movie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public Guid Id { get; set; }

        [Required]
        [ForeignKey("Titles")]
        public Guid TitleId { get; set; }

        [Required]
        public int Duration { get; set; }
       
        [StringLength(50)]
        [DefaultValue(null)]
        public string? FullhdFileSize { get; set; }
        [StringLength(50)]
        [DefaultValue(null)]
        public string? HdFileSize { get; set; }
        [StringLength(50)]
        [DefaultValue(null)]
        public string? SdFileSize { get; set; }
        [Required]
        [StringLength(255)]
        public string? Trailer { get; set; }
        [Required]
        [StringLength(255)]
        public string? StreamingUrl { get; set; }
        [StringLength(255)]
        [Required]
        public string? DownloadUrl { get; set; }
        [Column(TypeName = "int(11)")]
        [Required]
        [DefaultValue(0)]
        public int Sorting { get; set; }
        [Required]
        [DefaultValue("0000-00-00 00:00:00")]
        public DateTime CreatedAt { get; set; }
        [Required]
        [DefaultValue("0000-00-00 00:00:00")]
        public DateTime UpdatedAt { get; set; }
        [DefaultValue(0)]
        public byte IsCinema { get; set; }
        [Column(TypeName = "int(11)")]
        [Required]
        public int Price { get; set; }
        [Column(TypeName = "int(11)")]
        [Required]
        public int DiscountPrice { get; set; }
        [Required]
        public bool IsExclusive { get; set; }

        [Required]
        public bool Status { get; set; }

        [DefaultValue(null)]
        public DateTime? StartDate { get; set; }

        [Required]
        public DateTime ExpireDate { get; set; }
        [DefaultValue(null)]
        public DateTime? PublishDate { get; set; }
    }
}
