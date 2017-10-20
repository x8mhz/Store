using Microsoft.VisualStudio.TestTools.UnitTesting;
using Store.Domain.Entities;
using System;

namespace Store.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var p = new User("fabricio@hotmail.com", "123", "123");

            Console.WriteLine("Email: " + p.Email + " Senha: " + p.Password + "Confirmar: " + p.ConfirmPassword);

            var obj = p;


        }
    }
}
