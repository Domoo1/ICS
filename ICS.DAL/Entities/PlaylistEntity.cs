namespace ICS.DAL.Entities;

public class PlaylistEntity : IEntity
{
    public Guid Id { get; init; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public ICollection<SongCountEntity> Songs { get; set; } = new List<SongCountEntity>();
}