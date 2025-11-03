using ICS.DAL.Entities;
using ICS.DAL.Mappers;

namespace CookBook.DAL.Mappers;

public class PlaylistEntityMapper : IEntityMapper<PlaylistEntity>
{
    public void MapToExistingEntity(PlaylistEntity existingEntity, PlaylistEntity newEntity)
    {
        existingEntity.Name = newEntity.Name;
        existingEntity.Description = newEntity.Description;
        existingEntity.Duration = newEntity.Duration;
    }
}
