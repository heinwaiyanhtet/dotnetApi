namespace mahar.models
{
    public class Credit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public Guid Id { get; set; }
        [ForeignKey("Actors")]
        public int Actor_id { get; set; }
        [ForeignKey("directors")]
        public int DirectorId { get; set; }
    }
}