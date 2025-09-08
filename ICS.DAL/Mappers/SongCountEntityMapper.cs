using ICS.DAL.Entities;

namespace ICS.DAL.Mappers;

public class SongCountEntityMapper : IEntityMapper<SongCountEntity>
{
	public void MapToExistingEntity(SongCountEntity existingEntity, SongCountEntity newEntity)
	{
		existingEntity.PlaylistId = newEntity.PlaylistId;
		existingEntity.SongId = newEntity.SongId;
		existingEntity.Count= newEntity.Count;
	}
}