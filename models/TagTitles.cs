namespace mahar.models
{
    public class TagTitles
    {
        [Required]
        public Guid TitleId { get; set; }

        [Required]
        public Guid TagId { get; set; }
    }
}