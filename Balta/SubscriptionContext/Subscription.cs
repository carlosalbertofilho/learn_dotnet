using Balta.SharedContext;

namespace Balta.SubscriptionContext
{
    public class Subscription : Base
    {
        public Plan Plan { get; set; } = new Plan();
        public DateTime? EndDate { get; set; } = null;
        public bool IsInactive => EndDate <= DateTime.Now;
    }
}