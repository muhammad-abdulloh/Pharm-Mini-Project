using Pharm_Mini_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharm_Mini_Project.IRepositories
{
    public interface IUserRepositories
    {
        User Create(User user);
    }
}
