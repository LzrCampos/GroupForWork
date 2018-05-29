using System;
using FluentValidator;

namespace SharedLayer.Entities
{
    public class entity : Notifiable
    {
        public entity()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}
