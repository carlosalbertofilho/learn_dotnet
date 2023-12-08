
using Balta.ContentContext.Enums;
using Balta.SharedContext;

namespace Balta.ContentContext
{
    public class Course : Content
    {
        public Course(string title, string url)
            : base(title, url)
        {
        }
        public string Tag { get; set; } = string.Empty;
        public IList<Module> Modules { get; set; } = new List<Module>();
    }

    public class Module : Base
    {
        public int Order { get; set; }
        public string Title { get; set; } = string.Empty;
        public IList<Lecture> Lectures { get; set; } = new List<Lecture>();
    }

    public class Lecture : Base
    {
        public int Order { get; set; }
        public string Title { get; set; } = string.Empty;
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }
    }
}