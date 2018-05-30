using FluentValidator;
using FluentValidator.Validation;

namespace DomainLayer.VOs
{
    public class Email : Notifiable
    {
        public Email(string email)
        {
            Address = email;

            AddNotifications(new ValidationContract()
                .Requires()
                .IsEmail(Address, "Email", "O E-mail é inválido")
            );

        }

        public string Address { get; private set; }
    }
}