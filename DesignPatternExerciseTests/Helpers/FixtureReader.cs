using System;
using System.IO;

namespace DesignPatternExerciseTests.Helpers
{
    public class FixtureReader
    {
        public static string ReadText(string fileName)
        {
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Fixtures", fileName);

            return File.ReadAllText(filePath);
        }
    }
}
