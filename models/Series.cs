namespace YourNamespace
{
    public class Series
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public Guid Id { get; set; }
        [ForeignKey("Titles")]
        [Required]
        public Guid TitleId { get; set; }
        [Required]
        [MaxLength(255)]
        public string? Trailer { get; set; }
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
