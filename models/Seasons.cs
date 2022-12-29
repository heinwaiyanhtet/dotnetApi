namespace mahar.models
{
    public class Seasons
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public Guid Id { get; set; }
        [MaxLength(255)]
        public string? Title { get; set; }
        [Column(TypeName = "int(11)")]
        [Required]
        [DefaultValue(0)]
        public int Sorting { get; set; }
        [DefaultValue(null)]
        public DateTime? PublishDate { get; set; }
    }
}