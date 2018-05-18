using System;
using DomainLayer.Entities;
using DomainLayer.VOs;
using Xunit;

namespace TestsDomain.Entities
{
    public class StudentTests
    {
        Student student = new Student(new Name("Lazaro", "Campos"), 21660411, "lazaro@email.com");

        [Fact]
        public void CheckName()
        {            
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
