using System.Runtime.Serialization;

namespace ToDoApp.Core.Exceptions
{
    [Serializable]
    internal class CustomException : Exception
    {
        

        public CustomException(string? message) : base(message)
        {
        }

      
    }
}