namespace BirthdayProblem.Service;

class Program
{
    static void Main(string[] args)
    {
        if (string.IsNullOrWhiteSpace(args[0]))
            throw new Exception("Imput file not provided");
        string extention = Path.GetExtension(args[0]).ToLower(); 
        

        List<Person> persons = extention switch
        {
            ".json" => PersonJsonAdapter.GetPersonsFromJson(args[0]),
            ".csv" => PersonCsvAdapter.GetPersonsFromCsv(args[0]),
            _ => throw new Exception("Imput filetype not supported")
        };

        var today = DateTime.Today; // new DateTime(2025, 2, 28);
        var birthdayService = new BirthdayService(today);
        persons.ForEach(person =>
        {
            if (birthdayService.IsBirthdayToday(person.DateOfBirth))
            {
                Console.WriteLine($"Happy Birthday, {person.Name}!");
            }
        });

    }
}
