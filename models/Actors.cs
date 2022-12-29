namespace mahar.models
{
    public class Actors
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid id { get; set; }
    }

}