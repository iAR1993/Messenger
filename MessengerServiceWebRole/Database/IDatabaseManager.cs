using System.Collections.Generic;
using MessengerServiceWebRole.Contracts.Users;
using MessengerServiceWebRole.Database.Context.Entities;

namespace MessengerServiceWebRole.Database
{
    public interface IDatabaseManager
    {
        IEnumerable<UserContext> GetUsers();
        bool AddUser(string userName, string password);
    }
}