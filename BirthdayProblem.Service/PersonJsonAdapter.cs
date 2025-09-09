using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayProblem.Service
{
    public class PersonJsonAdapter
    {
        public static List<Person> GetPersonsFromJson(string filePath)
        {
            var jsonString = File.ReadAllText(filePath);
            return System.Text.Json.JsonSerializer.Deserialize<List<Person>>(jsonString) ?? new List<Person>();
        }
    }
}
