namespace Day14
{
    internal class Program
    {   public class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
        }
        static void Main5654(string[] args)
        {
            var directory = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
            var filePath = directory + "\\csvfile\\books.csv";
            List<Person> list = new List<Person>{
                new Person { Id = 1,Name="Athira", Age = 1},
                new Person { Id = 2,Name="Syam",Age = 2}
                };
            ;
            //Console.WriteLine("Hello, World!");
        }
    }
}