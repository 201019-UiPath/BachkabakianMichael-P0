using System.Collections.Generic;
using System.Threading.Tasks;
using JCDB.Models;

namespace JCDB
{
    /// <summary>
    /// Data access interface for JerkyCentral users
    /// </summary>
    public interface IUserRepo
    {
        void AddUserAsync(User user);
        void UpdateUser(User user);
        void DeleteUser(User user);
        User GetUserById(int id);
        User GetUserByName(string name);
        User GetUserByManagerStatus(bool status);
        Task<List<User>> GetAllUsersAsync();
    }
}