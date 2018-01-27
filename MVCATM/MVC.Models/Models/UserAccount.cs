using MVC.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace MVC.Models.Models
{
    public class UserAccount
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string MailId { get; set; }

        public Guid UniqueId { get; set; }

        public AccountType AccountType { get; set; }

    }
}
