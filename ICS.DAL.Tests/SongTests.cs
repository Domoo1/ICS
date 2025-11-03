using ICS.DAL.Entities;
using Microsoft.Extensions.Options;

namespace ICS.DAL.Tests
{
    public class SongTests
    {
        private readonly ICSDbContext _dbContextSUT;
        public SongTests()
        {
            _dbContextSUT = new ICSDbContext();
        }
        [Fact]
        public void NewSong_Add_Added()
        {
            // Arrange
            var song = new SongEntity
            {
                Id = Guid.NewGuid(),
                Name = "Test",
                Description = "TestDescription",
                SizeInBytes = 100,
                Length = 100,
                Author = new AuthorEntity
                {
                    Name = "TestName",
                    Surname = "TestSurname",
                },
            };

            // Act
            _dbContextSUT.Songs.Add(song);
            _dbContextSUT.SaveChanges();

            // Use a new context to verify the insert
            using (var context = new ICSDbContext())
            {
                var songInDb = context.Songs.FirstOrDefault();
                Assert.NotNull(songInDb);
                Assert.Equal("Test", songInDb.Name);
            }
        }
    }
}