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
        Users GetUsers(int id);
        List<Users> GetUsers();
        void DeleteUser();
        void EditUser(Users users);
    }
}
