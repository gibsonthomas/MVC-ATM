using MVC.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Models.Models
{
    public class AccountModel
    {
        public string AccountNumber { get; set; }

        public AccountType AccountType { get; set; }

        public int Id { get; set; }


    }
}
