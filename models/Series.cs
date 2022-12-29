namespace YourNamespace
{
    public class Series
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id { get; set; }

        [Required]
        public Guid TitleId { get; set; }

        [Required]
        public string? Trailer { get; set; }

        [Required]
        public int Sorting { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public DateTime UpdatedAt { get; set; }

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
