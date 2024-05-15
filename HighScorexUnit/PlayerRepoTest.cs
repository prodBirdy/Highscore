using Xunit;
using BL;
using BL.Repos;
using Models;

namespace HighScorexUnit
{
    public class HighscoreRepoTest
    {
        private readonly IUow _uow;

        public HighscoreRepoTest()
        {
            _uow = new Uow(DALType.Json); // Use the appropriate DALType
        }

        [Fact]
        public void AddHighscore_Test()
        {
            // Arrange
            var highscore = new Highscore(); // Create a new Highscore object with required properties

            // Act
            _uow.Highscores.Add(highscore);
            _uow.Commit();

            // Assert
            // Assert that the highscore has been added successfully
        }

        [Fact]
        public void GetHighscore_Test()
        {
            // Act
            var highscore = _uow.Highscores.GetHighscores();

            // Assert
            // Assert that the returned highscore is not null and has the expected properties
        }

        [Fact]
        public void UpdateHighscore_Test()
        {
            // Arrange
            var highscore = new Highscore(); // Create a new Highscore object with required properties

            // Act
            _uow.Highscores.Update(highscore);
            _uow.Commit();

            // Assert
            // Assert that the highscore has been updated successfully
        }

        [Fact]
        public void DeleteHighscore_Test()
        {
            // Arrange
            Highscore hs = new Highscore();

            // Act
            _uow.Highscores.Delete(hs);
            _uow.Commit();

            // Assert
            // Assert that the highscore has been deleted successfully
        }
    }
}