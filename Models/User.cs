using Pharm_Mini_Project.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharm_Mini_Project.Models
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();  
        public string FirstName { get; set; }
        public int LastName { get; set; }
        public UserRole Role { get; set; } = UserRole.User;
        public string Login { get; set; }
        public string Password { get; set; }    


    }
}
 