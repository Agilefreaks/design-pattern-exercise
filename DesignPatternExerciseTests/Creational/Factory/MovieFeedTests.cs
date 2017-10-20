using DesignPatternExercise.Creational.Factory;
using DesignPatternExerciseTests.Helpers;
using NUnit.Framework;
using System.Collections.Generic;

namespace DesignPatternExerciseTests.Creational.Factory
{
    [TestFixture]
    public class MovieFeedTests
    {
        private MovieFeed _subject;

        [SetUp]
        public void SetUp()
        {
            _subject = new MovieFeed();
        }

        [Test]
        public void GenerateFeed_FeedTypeIsXml_ReturnsXmlFormattedString()
        {
            var movies = GetSampleMovies();

            var result = _subject.GenerateFeed(movies, FeedType.Xml);
            
            Assert.AreEqual(FixtureReader.ReadText("MovieFeed.xml"), result);
        }

        [Test]
        public void GenerateFeed_FeedTypeIsCsv_ReturnsCsvFormattedString()
        {
            var movies = GetSampleMovies();

            var result = _subject.GenerateFeed(movies, FeedType.Csv);
            
            Assert.AreEqual(FixtureReader.ReadText("MovieFeed.csv"), result);
        }

        private IEnumerable<Movie> GetSampleMovies()
        {
            return new List<Movie>
            {
                new Movie { Title = "Rocky", Description = "The Rocky Movie" },
                new Movie { Title = "The Martian", Description = "Martian, the movie" }
            };
        }
    }
}
