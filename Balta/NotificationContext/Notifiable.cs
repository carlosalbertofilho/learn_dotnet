namespace Balta.NotificationContext
{
    public abstract class Notifiable
    {
        public List<Notification> Notifications { get; set; } = [];

        public void AddNotification(Notification notification)
        {
            Notifications.Add(notification);
        }

        public void AddRange(IList<Notification> notifications)
        {
            Notifications.AddRange(notifications);
        }

        public bool IsInvalid => Notifications.Any();
    }
}