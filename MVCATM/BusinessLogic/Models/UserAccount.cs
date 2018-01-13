using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Models
{
    public class UsersAccount
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public Guid UniqueId { get; set; }

    }
}
