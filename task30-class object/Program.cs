namespace task30_class_object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var osoba = new Person() { Name="Tomasz",SurrName = "Żukowski", Age =25};
            var prostokąt = new Square() { height=10, width=10 };

            Country country1 = Country.Create("Polska", "PL");
            Console.WriteLine(country1.ShowName());
            country1.ChangeData("Niemcy", "DE");
            Console.WriteLine(country1.ShowName());
        }
    }
}
