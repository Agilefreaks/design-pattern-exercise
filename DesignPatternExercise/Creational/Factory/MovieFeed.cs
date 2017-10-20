using System.Collections.Generic;
using System.Text;

namespace DesignPatternExercise.Creational.Factory
{
    public class MovieFeed
    {
        public string GenerateFeed(IEnumerable<Movie> movies, FeedType feedType)
        {
            StringBuilder result = new StringBuilder();

            if (feedType == FeedType.Csv)
            {
                result.AppendLine("Title, Description");
            }
            else
            {
                result.AppendLine(@"<?xml version=""1.0"" encoding=""UTF-8"" ?>");
                result.AppendLine("<Movies>");
            }

            foreach (var movie in movies)
            {
                if (feedType == FeedType.Csv)
                {
                    result.AppendLine($"{movie.Title},{movie.Description}");
                }
                else
                {
                    result.AppendLine($@"<Movie Title=""{movie.Title}"" Description=""{movie.Description}""/>");
                }
            }

            if (feedType == FeedType.Xml)
            {
                result.AppendLine("</Movies>");
            }

            return result.ToString();
        }
    }
}
