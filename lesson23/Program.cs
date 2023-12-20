using System.Text;

namespace lesson23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Priority priority = Priority.low;
            Console.WriteLine(priority);
            string appendCharacter = "text";

            int[] samples = new int[2] { 100000, 1000000 };
            foreach (int sample in samples)
            {
                var currentTime = DateTime.UtcNow;
                testAppendString(sample, new StringBuilder(), appendCharacter);
                var endTime = DateTime.UtcNow;
                
                Console.WriteLine($"Time:{endTime.Subtract(currentTime)}");
            }

            static void testAppendString(int n, StringBuilder str, string appendCharacter)
            {
                for (int i = 0; i <= n; i++)
                {
                    str.Append(appendCharacter);
                }
            }

            


        }
    }
}
