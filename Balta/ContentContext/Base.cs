using Balta.NotificationContext;

namespace Balta.ContentContext
{
    public abstract class Base : Notifiable
    {
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}