using System.Text.Json.Serialization;

namespace BirthdayProblem.Service;

public class Person
{
    [JsonPropertyName("fullName")]
    public required string Name { get; set; }
    [JsonPropertyName("dateOfBirth")]
    public required DateTime DateOfBirth { get; set; }
}
