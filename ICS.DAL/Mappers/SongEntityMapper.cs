using ICS.DAL.Entities;

namespace ICS.DAL.Mappers;

public class SongEntityMapper : IEntityMapper<SongEntity>
{
    public void MapToExistingEntity(SongEntity existingEntity, SongEntity newEntity)
    {
        existingEntity.Name = newEntity.Name;
        existingEntity.Description = newEntity.Description;
    }
}