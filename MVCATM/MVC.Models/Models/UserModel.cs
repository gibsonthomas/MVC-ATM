using MVC.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace MVC.Models.Models
{
    public class UserModel
    {
        [Required(ErrorMessage ="Please enter a username.")]
        public string Username { get; set; }

        [Required(ErrorMessage ="Please enter the password.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.EmailAddress)]
        public string MailId { get; set; }

        public Guid UniqueId { get; set; }

        public AccountType AccountType { get; set; }

        public int Id { get; set; }

    }
}
