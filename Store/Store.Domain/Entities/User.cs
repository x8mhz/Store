using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using FluentValidation.Attributes;
using Store.Domain.Validation;

namespace Store.Domain.Entities
{
    [Validator(typeof(UserValidator))]
    public class User
    {
        #region Ctor And Props

        public User(string email, string password)
        {
            Id = Guid.NewGuid();
            Email = email;
            Password = password;
            ActiveCode = new Random().Next(100, 10000);
            Active = false;
        }

        public Guid Id { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public string ConfirmPassword { get; private set; }
        public DateTime RegisterDate { get; private set; }
        public bool Active { get; private set; }
        public int ActiveCode { get; private set; }

        #endregion

        //Relações com o banco de dados
        #region Relationship

        public virtual ICollection<Order> Orders { get; set; }

        #endregion  

        #region Methods

        public void SendCode()
        {
            var mail = new MailMessage();
            mail.From = new MailAddress("fabricio.ramoss@hotmail.com");
            mail.Subject = "Ativação do cadastro na Store";
            mail.IsBodyHtml = true;
            mail.Body = "Código de ativação: " + ActiveCode;
            mail.To.Add(Email);
            var smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.Credentials = new NetworkCredential("teste", "teste");
            smtp.Send(mail);
        }

        public void Register(string code)
        {
            if (code != ActiveCode.ToString()) return;

            RegisterDate = DateTime.Now;
            Active = true;
        }

        #endregion

    }
}
