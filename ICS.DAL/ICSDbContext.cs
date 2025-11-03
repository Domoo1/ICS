using ICS.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace ICS.DAL
{
    public class ICSDbContext : DbContext
    {
        public DbSet<SongEntity> Songs => Set<SongEntity>();
        public DbSet<SongCountEntity> SongCounts => Set<SongCountEntity>();
        public DbSet<PlaylistEntity> Playlists => Set<PlaylistEntity>();
        public DbSet<AuthorEntity> Author => Set<AuthorEntity>();
        public ICSDbContext() { 
        
        }
    }
}
