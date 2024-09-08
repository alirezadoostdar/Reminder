using Reminder.Infrastructure;

namespace Reminder.Extensions.CatalogRemindMessageSubscribe;

public class CatalogRemindMessageConsumer(ReminderDbContext dbContext) : IConsumer<CatalogRemindMessage>
{
    private readonly ReminderDbContext _dbContext;
    public async Task Consume(ConsumeContext<CatalogRemindMessage> context)
    {
        _dbContext.CatalogStockReminders.Add(new Models.CatalogStockReminder
        {
            Message = context.Message.Message,
            NotifyChannel = context.Message.Channel,
            Slug = context.Message.Slug,
            UserId = context.Message.UserId,
        });
        await _dbContext.SaveChangesAsync(context.CancellationToken);
    }
}
