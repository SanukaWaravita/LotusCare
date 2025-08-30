using LotusCare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotusCare.Services
{
    public interface IUserService
    {
        User Authenticate(string username, string password);
    }
}
