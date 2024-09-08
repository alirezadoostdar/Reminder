
namespace Reminder.Models;


[Collection("catalogstockreminder")]
public class CatalogStockReminder
{
    public int Id { get; set; }
    public required string Message { get; set; }
    public Guid UserId { get; set; }
    public required string Slug { get; set; }
    public required NotifyChannel NotifyChannel { get; set; }
}
