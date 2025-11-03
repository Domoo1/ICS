using ICS.DAL.Entities;

namespace ICS.DAL.Mappers;

public class AuthorEntityMapper : IEntityMapper<AuthorEntity>
{
    public void MapToExistingEntity(AuthorEntity existingEntity, AuthorEntity newEntity)
    {
        existingEntity.Name = newEntity.Name;
        existingEntity.Surname = newEntity.Surname;
    }
}