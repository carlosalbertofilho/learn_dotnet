
using Balta.NotificationContext;

namespace Balta.ContentContext
{
    public class Career : Content
    {
        public Career(string title, string url)
            : base(title, url)
        {
        }
        public IList<CareerItem> Items { get; set; } = new List<CareerItem>();
        public int TotalCourses => Items.Count;
    }

    public class CareerItem : Base
    {
        public CareerItem(
            int order,
            string title,
            string description,
            Course course)
        {
            if (course is null) 
                AddNotification(new Notification("Course", "Curso inválido"));
            if (string.IsNullOrEmpty(title))
                AddNotification(new Notification("Title", "Título inválido"));
            if (string.IsNullOrEmpty(description))
                AddNotification(new Notification("Description", "Descrição inválida"));

            Order = order;
            Title = title;
            Description = description;
            Course = course;
        }

        public int Order { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Course Course { get; set; } = null!;
    }


}