using BusinessLogic.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace BusinessLogic.Models
{
    public class UsersAccount
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
