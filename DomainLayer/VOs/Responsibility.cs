using System;
using FluentValidator;
using FluentValidator.Validation;

namespace DomainLayer.VOs
{
    public class Responsibility : Notifiable
    {
        public Responsibility(string tag, string description)
        {
            Id = Guid.NewGuid();
            Tag = tag;
            Description = description;

            AddNotifications(new ValidationContract()
                .Requires()
                .HasMinLen(Tag, 3, "Tag", "A tag deve conter mais de 3 caracteres")
                .HasMaxLen(Tag, 11, "Tag", "A tag deve conter menos de 11 caracteres")
                .HasMaxLen(Description, 300, "Description", "A Descrição não pode conter mais de 300 caracteres")
                );
        }

        public Guid Id { get; private set; }
        public string Tag { get; private set; }
        public string Description { get; private set; }
    }
}