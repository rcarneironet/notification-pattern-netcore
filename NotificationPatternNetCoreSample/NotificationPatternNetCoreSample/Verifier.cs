using FluentValidator;
using NotificationPatternNetCoreSample.Entity;
using NotificationPatternNetCoreSample.Result;
using System;

namespace NotificationPatternNetCoreSample
{
    public class Verifier : Notifiable
    {
        public NotificationResultDto Execute()
        {
            var person = new Person("Ray", "contato@academiadotnet.com.br");
            return Verify(person);
        }

        private NotificationResultDto Verify(Person person)
        {

            //Validates entity
            AddNotifications(person.Notifications);

            if (Invalid)
            {
                return new NotificationResultDto(
                    false,
                    "Please validate following fields:",
                    Notifications);
            }

            return new NotificationResultDto(
                true,
                "Validation success",
                null);
        }
    }
}
