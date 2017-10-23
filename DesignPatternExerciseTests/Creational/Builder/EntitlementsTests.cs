using DesignPatternExercise.Creational.Builder;
using NUnit.Framework;
using System.Collections.Generic;

namespace DesignPatternExerciseTests.Creational.Builder
{
    [TestFixture]
    public class UrlTests
    {
        private UrlFormatter _subject;

        [SetUp]
        public void SetUp()
        {
            _subject = new UrlFormatter();
        }

        [Test]
        public void Format_WithBaseUrlAndEmptyQuery_FormatsUrlWithoutQueryString()
        {
            var baseUrl = "https://example.com";
            var query = new Dictionary<string, string>();

            var result = _subject.Format(baseUrl, query);

            Assert.AreEqual("https://example.com", result);
        }

        [Test]
        public void Format_WithBaseUrlAndQuery_FormatsUrlWithQueryString()
        {
            var baseUrl = "https://example.com";
            var query = new Dictionary<string, string> { { "term", "some term" }, { "page", "1" } };

            var result = _subject.Format(baseUrl, query);

            Assert.AreEqual("https://example.com?term=some%20term&page=1", result);
        }

        [Test]
        public void Format_WithBaseUrlAndHash_FormatsUrlWithHash()
        {
            var baseUrl = "https://example.com";
            var query = new Dictionary<string, string> { { "term", "42" } };
            var hash = "foo";

            var result = _subject.Format(baseUrl, hash);

            Assert.AreEqual("https://example.com#foo", result);
        }

        [Test]
        public void Format_WithBaseUrlQueryAndHash_FormatsUrlWithQueryAndHash()
        {
            var baseUrl = "https://example.com/x/y";
            var query = new Dictionary<string, string> { { "term", "test term" } };
            var hash = "foo";

            var result = _subject.Format(baseUrl, query, hash);

            Assert.AreEqual("https://example.com/x/y?term=test%20term#foo", result);
        }

        [Test]
        public void Format_WithBaseUrlQueryAndWithEmptyHash_FormatsUrlWithQueryAndWithoutHash()
        {
            var baseUrl = "https://example.com/x/y";
            var query = new Dictionary<string, string> { { "term", "test term" } };
            var hash = "";

            var result = _subject.Format(baseUrl, query, hash);

            Assert.AreEqual("https://example.com/x/y?term=test%20term", result);
        }

        [Test]
        public void Format_WithBaseUrlQueryAndHash_FormatsUrlWithHashAndWithoutQuery()
        {
            var baseUrl = "https://example.com/x/y";
            var query = new Dictionary<string, string>();
            var hash = "foo";

            var result = _subject.Format(baseUrl, query, hash);

            Assert.AreEqual("https://example.com/x/y#foo", result);
        }
    }
}
