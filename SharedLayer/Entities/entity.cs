using System;

namespace SharedLayer.Entities
{
    public class entity
    {
        public entity()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}
