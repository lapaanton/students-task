
namespace students_task.Domain.Exceptions
{
    [System.Serializable]
    public class EmailInvalidException : System.Exception
    {
        public EmailInvalidException() { }
        public EmailInvalidException(string message) : base(message) { }
        public EmailInvalidException(string message, System.Exception inner) : base(message, inner) { }
        protected EmailInvalidException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}