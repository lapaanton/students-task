using System;
namespace students_task.Application.Exceptions
{
    [System.Serializable]
    public class NotFoundException : System.Exception
    {
        public NotFoundException() { }
        public NotFoundException(string name, string message) 
            : base(((Func<string>)(() => string.Format("{0}({1}) not found",name,message)))())
        {
            //TODO: !!!!!
        }
        public NotFoundException(string message, System.Exception inner) : base(message, inner) { }
        protected NotFoundException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}