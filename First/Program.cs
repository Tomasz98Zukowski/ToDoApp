namespace First
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1,2,3,4,5};
            List<string> list2 = new List<string>() { "dzien", "dobry","Kladia" };
            foreach (int i in list) { Console.WriteLine(i); }
            foreach(string i in list2) { Console.WriteLine(i); }
            Console.WriteLine(list.Max());
            list.Sort();
            list2.Sort();
        }
    }
}
