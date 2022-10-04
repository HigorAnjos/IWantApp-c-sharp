using Flunt.Notifications;

namespace IWantApp.Domain
{
    public class Entity : Notifiable<Notification>
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public string EditedBy { get; set; } = string.Empty;
        public DateTime EditedOn { get; set; } = DateTime.Now;
        public bool Active { get; set; } = true;
    }
}
