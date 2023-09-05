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
    }
}