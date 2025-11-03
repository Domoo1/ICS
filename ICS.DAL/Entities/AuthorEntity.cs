namespace ICS.DAL.Entities;

public class AuthorEntity : IEntity
{
    public Guid Id { get; init; }
    public required string Name { get; set; }
    public required string Surname { get; set; }
    public ICollection<SongCountEntity> Songs { get; set; } = new List<SongCountEntity>();
}