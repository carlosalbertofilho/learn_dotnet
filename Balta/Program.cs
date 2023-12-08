using Balta.ContentContext;

namespace Balta
{
    class Program
    {
        static void Main(string[] args)
        {

            var course =
                new Course("Fundamentos OOP", "fundamentos-oop");
            var courseOOP =
                new Course("OOP em C#", "oop-csharp");
            var courseAspnet =
                new Course("Fundamentos ASP.NET", "fundamentos-aspnet");

            var careers =
                new Career("Especialista .NET", "especialista-dotnet");

            careers.Items.Add(
                new CareerItem(
                    1,
                    "Comece por aqui",
                    "Fundamentos OOP - I", course));
            careers.Items.Add(
                new CareerItem(
                    2,
                    "Aprenda OOP",
                    "Fundamentos OOP - II", courseOOP));
            careers.Items.Add(
                new CareerItem(
                    3,
                    "Aprenda .NET",
                    "Fundamentos OOP - III", courseAspnet));


            Console.WriteLine(careers.Title);
            foreach (
                var career in careers.Items.OrderBy(x => x.Order))
            {
                Console.WriteLine($"{career.Order} - {career.Title} - {career.Course.Title}");
            }
        }
    }
}