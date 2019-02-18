using System;
using System.Collections.Generic;
using System.Linq;
using MessengerServiceWebRole.Contracts.Info;
using MessengerServiceWebRole.Contracts.Users;
using MessengerServiceWebRole.Database;

namespace MessengerServiceWebRole
{
    public class MessengerService : IMessengerService
    {
        #region Managers

        private IDatabaseManager DatabaseManager { get; }

        #endregion

        public MessengerService()
        {
            DatabaseManager = new DatabaseManager();
        }

        #region Test

        public string GetData(int value)
        {
            return $"You entered: {value}";
        }
        
        #endregion

        #region Users

        public ResultInfoContract SignIn(UserCredentialsContract credentials)
        {
            throw new NotImplementedException();
        }

        public ResultInfoContract SignOut(UserContract user)
        {
            throw new NotImplementedException();
        }

        public ResultInfoContract Register(UserRegisterInfoContract registerInfo)
        {
            try
            {
                DatabaseManager.AddUser(
                    registerInfo.Credentials.Name,
                    registerInfo.Credentials.Password);
            }
            catch (Exception)
            {
                return new ResultInfoContract("Failed to register user!", ResultInfoTypes.Error);
            }

            return new ResultInfoContract("User successfully register!", ResultInfoTypes.Success);
        }

        public ResultInfoContract AddContact(UserContract requestUser, UserContract responseUser)
        {
            try
            {
                //requestUser.AddContact(responseUser);
            }
            catch (Exception)
            {
                return new ResultInfoContract("Failed to add user!", ResultInfoTypes.Error);
            }

            return new ResultInfoContract("User successfully added!", ResultInfoTypes.Success);
        }

        public IEnumerable<UserContract> GetUsers()
        {
            return DatabaseManager
                .GetUsers()
                .Select(record => new UserContract(record));
        }

        #endregion
    }
}
