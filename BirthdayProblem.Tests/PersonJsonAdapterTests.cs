namespace BirthdayProblem.Tests
{
    using BirthdayProblem.Service;
    public class PersonJsonAdapterTests
    {
        [Fact]
        [Trait("Category", "Unit")]
        public void GetPersonsFromCsv_TestCsv_ReturnsPersonList()
        {
            // Arrange
            string fileName = "JsonTests.json";
            string name1Expected = "Kurt Cobain";
            var dateOfBirth1Expected = DateTime.Parse("1967-02-20");
            string name2Expected = "Rihanna";
            var dateOfBirth2Expected = DateTime.Parse("1988-02-20");

            // Act
            List<Person> result = PersonJsonAdapter.GetPersonsFromJson(fileName);

            // Assert
            Assert.True(result.Count == 6);
            Assert.Equal(name1Expected, result[0].Name);
            Assert.Equal(dateOfBirth1Expected, result[0].DateOfBirth);
            Assert.Equal(name2Expected, result[1].Name);
            Assert.Equal(dateOfBirth2Expected, result[1].DateOfBirth);
        }
    }
}
