namespace BirthdayProblem.Service;

public class BirthdayService
{
    private readonly DateTime _today;

    public BirthdayService(DateTime today)
    {
        _today = today;
    }

    public bool IsBirthdayToday(DateTime birthday)
    {
        bool isToday = birthday.Month == _today.Month && birthday.Day == _today.Day;
        if(!isToday && birthday.Month == 2 && birthday.Day == 29)
        {
            isToday = _today.Month == 2 && _today.Day == 28 && !DateTime.IsLeapYear(_today.Year);
        }
        return isToday;
    } 
}
