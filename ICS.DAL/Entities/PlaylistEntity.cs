namespace ICS.DAL.Entities;

public class PlaylistEntity : IEntity
{
    public Guid Id { get; init; }
    public string Name { get; set; }
    public string Description { get; set; }
    public ICollection<SongCountEntity> Songs { get; set; } = new List<SongCountEntity>();
}