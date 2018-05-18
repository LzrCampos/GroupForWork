using System;

namespace DomainLayer.VOs{
    public class Responsibility{
        public Responsibility(string tag, string description)
        {
            Id = Guid.NewGuid();
            Tag = tag;
            Description = description;
        }

        public Guid Id { get; private set; }
        public string Tag { get; private set; }
        public string Description { get; private set; }
    }
}