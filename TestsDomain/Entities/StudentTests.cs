using System;
using DomainLayer.Entities;
using DomainLayer.VOs;
using Xunit;

namespace TestsDomain.Entities
{
    public class StudentTests
    {
        [Fact]
        public void CheckName()
        {
            var name = new Name("Lazaro", "Campos");
            var student = new Student(name, 21660411, "lazaro@email.com");

            Assert.Equal(student.Name.FirstName, "Lazaro");
        }

        // Theory Test
        // [Theory]
        // [InlineData("Lazaro")]
        // [InlineData("Lazaro")]
        // [InlineData("Lazaro")]
        // public void MyFirstTheory(string value)
        // {
        //     Assert.Equal(student.Name.FirstName, value);
        // }
    }
}
