using JCDB;
using JCDB.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace JCLib
{
    public class UserServices
    {
        private IUserRepo repo;

        public UserServices(IUserRepo repo) 
        {
            this.repo = repo;
        }
        public void AddUser(User user)
        {
            repo.AddUserAsync(user);
        }
        public void UpdateUser(User user)
        {
            repo.UpdateUser(user);
        }
        public void DeleteUser(User user)
        {
            repo.DeleteUser(user);
        }
        public User GetUserById(int id)
        {
            User user = repo.GetUserById(id);
            return user;
        }
        public User GetUserByName(string name)
        {
            User user = repo.GetUserByName(name);
            return user;
        }
        public User GetUserByStatus(bool status)
        {
            User user = repo.GetUserByManagerStatus(status);
            return user;
        }
        public Task<List<User>> GetAllUsers()
        {
            Task<List<User>> users = repo.GetAllUsersAsync();
            return users;
        }
    }
}