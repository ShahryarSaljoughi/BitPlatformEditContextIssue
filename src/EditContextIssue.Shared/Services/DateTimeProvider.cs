namespace EditContextIssue.Shared.Services;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTimeOffset GetCurrentDateTime()
    {
        return DateTimeOffset.UtcNow;
    }
}
