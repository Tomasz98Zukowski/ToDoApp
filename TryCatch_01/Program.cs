namespace TryCatch_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ThrowException(0);
            }
            catch (InvalidOperationException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
        static void ThrowException(int id)
        {
            if (id == 0) { throw new ArgumentNullException("id"); }
        }

        
    }
}
