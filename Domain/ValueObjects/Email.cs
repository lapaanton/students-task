using students_task.Domain.Infrastructure;
using System.Collections.Generic;
using students_task.Domain.Exceptions;

namespace students_task.Domain.ValueObjects
{
    public class Email : ValueObject
    {
        private string name;
        private string domain;

        public string Name 
        { 
            get => name; 
            set {
                    if (ValidateUserName(value)){
                        name = value;
                    } else {
                        throw new EmailInvalidException();
                    }
                } 
        }
        public string Domain { get => domain; set => domain = value; }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return name;
            yield return domain;
        }
        private static bool ValidateUserName(string username)
        {
            //TODO: username and domain validation validation
            return true;
        }
        private static bool ValidateDomain(string domain)
        {
            //TODO: username and domain validation validation
            return true;
        }
        public static Email FromString(string emailString)
        {
            var userEmail = new Email();
            var index = emailString.IndexOf('@');
            if (index < 0)
            {
                throw new EmailInvalidException();
            }
            
            userEmail.name = emailString.Substring(0, index);
            userEmail.domain = emailString.Substring(index + 1);
            if (!ValidateUserName(userEmail.name) || !ValidateDomain(userEmail.domain))
            {
                throw new EmailInvalidException();
            }
            
            return userEmail;
        }
        public static implicit operator string(Email email)
        {
            return email.ToString();
        }
        public static explicit operator Email(string emailString){
            return FromString(emailString);
        }
    }
}