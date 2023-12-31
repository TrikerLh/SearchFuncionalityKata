using FluentAssertions;

namespace SearchFuncionalityKata.Tests {
    public class CityShould {
        [SetUp]
        public void Setup() {
        }

        [Test]
        public void Return_no_result_when_the_search_test_is_fewer_than_2()
        {
            var reslut = City.Search("A");

            reslut.Should().BeEquivalentTo(new List<string>());
        }

        [TestCase("Va")]
        [TestCase("va")]
        public void Return_cities_when_the_name_start_with_the_text(string textSearch) {
            var reslut = City.Search(textSearch);

            reslut.Should().BeEquivalentTo(new List<string>{"Valencia", "Vancouver"});
        }

        [Test]
        public void Return_cities_when_the_name_contains_the_text() {
            var reslut = City.Search("ape");

            reslut.Should().BeEquivalentTo(new List<string> { "Budapest" });
        }

        [Test]
        public void Return_all_cities_when_the_text_is_asterisk() {
            var reslut = City.Search("*");

            reslut.Should().BeEquivalentTo(new List<string> { "Paris", "Budapest", "Skopje", "Rotterdam", "Valencia", "Vancouver", "Amsterdam", "Vienna", "Sydney", "New York City", "London", "Bangkok", "Hong Kong", "Dubai", "Rome", "Istanbul" });
        }
    }
}