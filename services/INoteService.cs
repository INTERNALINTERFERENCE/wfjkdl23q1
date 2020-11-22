using mysql.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace services
{
    public interface INoteService
    {
        Users CreateUser(Users user);
        Users GetUser(int id);
        List<Users> GetUsers();
        void DeleteUser(int id);
        void EditUser(Users users);
    }
}
