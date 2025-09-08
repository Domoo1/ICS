namespace ICS.DAL.Entities;

public class SongCountEntity : IEntity
{
    public required Guid Id { get; init; }

    public required Guid SongId { get; set; }
    public required SongEntity Song { get; init; }

    public required Guid PlaylistId { get; set; }
    public required PlaylistEntity Playlist{ get; init; }

    public int Count { get; set; }
}