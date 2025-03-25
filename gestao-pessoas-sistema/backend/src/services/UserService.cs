using System.Collections.Generic;
using System.Linq;

namespace gestao_pessoas_sistema.backend.src.services
{
    public class UserService
    {
        private List<User> users = new List<User>();

        public void AddUser(User user)
        {
            users.Add(user);
        }

        public List<User> GetAllUsers()
        {
            return users.ToList();
        }

        public void RemoveUser(int userId)
        {
            var user = users.FirstOrDefault(u => u.Id == userId);
            if (user != null)
            {
                users.Remove(user);
            }
        }
    }
}