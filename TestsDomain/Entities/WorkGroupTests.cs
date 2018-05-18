using System;
using DomainLayer.Entities;
using DomainLayer.VOs;
using Xunit;

namespace TestsDomain.Entities
{
    public class WorkGroupTests
    {
        [Fact]
        public void VerifyIfAddStudentInGroup()
        {
            var student1 = new Student(new Name("Lazaro", "Campos"), 21660411, "lazaro@email.com");
            var student2 = new Student(new Name("Test", "Testou"), 66608121, "test@email.com");
            var workGroup = new StudentsGroup("groupA", 1);

            workGroup.AddStudent(student1);
            var res = workGroup.AddStudent(student2);

            Assert.True(res == "Grupo já atingiu o limite de estudantes!");
        }
    }
}