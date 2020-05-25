using FluentValidator;
using FluentValidator.Validation;
using System;

namespace NotificationPatternNetCoreSample.Entity
{
    public class Person : Notifiable
    {
        public Person(
            string name,
            string emailAddress)
        {
            Name = name;
            EmailAddress = emailAddress;

            AddNotifications(new ValidationContract()
                .HasMinLen(Name, 3, "Name", "Name property must have at least 3 chars")
                .HasMaxLen(Name, 10, "Name", "Name must not exceed 10 chars")
                .IsEmail(EmailAddress, EmailAddress, "Email is not valid")
                );
        }
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string EmailAddress { get; private set; }
    }
}
