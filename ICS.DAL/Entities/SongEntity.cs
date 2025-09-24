namespace ICS.DAL.Entities;

public class SongEntity : IEntity
{
    public Guid Id { get; init; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public required string Size { get; set; }
    public int Length { get; set; }
    public string Author { get; set; }

}