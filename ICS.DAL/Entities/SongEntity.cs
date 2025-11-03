namespace ICS.DAL.Entities;

public class SongEntity : IEntity
{
    public Guid Id { get; init; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public required int SizeInBytes { get; set; }
    public double Length { get; set; }
    public required AuthorEntity Author { get; set; }

}