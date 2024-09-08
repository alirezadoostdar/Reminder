namespace Reminder;

public class ReminderOptions
{
    public required BrokerOptions BrokerOptions { get; set; }
    public required MongoOptions MongoDbSettings { get; set; }
}

public sealed class BrokerOptions
{
    public const string SectionName = "BrokerOptions";

    public required string Host { get; set; }
    public required string Username { get; set; }
    public required string Password { get; set; }
}

public sealed class MongoOptions
{
    public required string Host { get; set; }
    public required string DbName { get; set; }
}
