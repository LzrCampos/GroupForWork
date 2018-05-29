using System;
using System.Collections.Generic;
using DomainLayer.VOs;
using SharedLayer.Entities;

namespace DomainLayer.Entities
{
    public class Student : entity
    {
        public Student(Name name, int studentNumber, string email)
        {
            Name = name;
            StudentNumber = studentNumber;
            Email = email;
        }

        public Name Name { get; private set; }
        public int StudentNumber { get; private set; }
        public string Email { get; private set; }
        public List<Responsibility> Responsibilitys { get; private set; }

        public void AddResponsibility(Responsibility responsibility){
            Responsibilitys.Add(responsibility);
        }

        public override string ToString() => Name.ToString();

    }
}
