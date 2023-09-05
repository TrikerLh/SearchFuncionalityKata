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
    }
}