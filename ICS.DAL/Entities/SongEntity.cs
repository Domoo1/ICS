namespace ICS.DAL.Entities;

public class SongEntity : IEntity
{
    public Guid Id { get; init; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Size { get; set; }
    public int Length { get; set; }
    public string Author { get; set; }

}