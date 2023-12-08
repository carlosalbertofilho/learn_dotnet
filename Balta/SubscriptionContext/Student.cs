using Balta.SharedContext;

namespace Balta.SubscriptionContext
{
    public class Student : Base
    {
        public Student(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public string Name { get; private set; } = string.Empty;
        public string Email { get; private set; } = string.Empty;
        public User User { get; private set; } = null!;

        public IList<Subscription> Subscriptions { get; set; } = new List<Subscription>();
        public bool IsPremium => Subscriptions.Any(x => !x.IsInactive);

    }
}