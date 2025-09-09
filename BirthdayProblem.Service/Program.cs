namespace BirthdayProblem.Service;

class Program
{
    static void Main(string[] args)
    {
        if (string.IsNullOrWhiteSpace(args[0]))
            throw new Exception("Imput file not provided");
        else if (!args[0].ToLower().EndsWith(".json") && !args[0].ToLower().EndsWith(".csv"))
            throw new Exception("Imput filetype not supported");

        var today = DateTime.Today;// new DateTime(2025, 2, 28);
        var birthdayService = new BirthdayService(today);

        List<Person> persons = args[0].ToLower().EndsWith(".json") ? PersonJsonAdapter.GetPersonsFromJson(args[0]) : PersonCsvAdapter.GetPersonsFromCsv(args[0]);

        persons.ForEach(person =>
        {
            if (birthdayService.IsBirthdayToday(person.DateOfBirth))
            {
                Console.WriteLine($"Happy Birthday, {person.Name}!");
            }
        });

    }
}
