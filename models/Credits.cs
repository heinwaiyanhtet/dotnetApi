namespace mahar.models
{
    public class Credit
    {
        [Key]
        public Guid Id { get; set; }
        public int Actor_id { get; set; }
        public int director_id { get; set; }
    }

}