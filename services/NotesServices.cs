using mysql.Data;
using mysql.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace services
{
    public class NotesServices : INoteService
    {
        private MysqlDbContext _context;

        public NotesServices(MysqlDbContext context)
        {
            _context = context;
        }

        public Users CreateUser(Users user)
        {
            _context.Add(user);
            _context.SaveChanges();

            return user;
        }

        public void DeleteUser(int id)
        {
            var user = _context.Users.First(n => n.Id == id);
            _context.Users.Remove(user);
            _context.SaveChanges();
        }

        public void EditUser(Users users)
        {
            throw new NotImplementedException();
        }

        public Users GetUser(int id)
        {
            return _context.Users.First(n => n.Id == id);
        }

        public List<Users> GetUsers()
        {
            return _context.Users.ToList();
        }
    }
}
