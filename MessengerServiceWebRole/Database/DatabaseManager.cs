using System;
using System.Collections.Generic;
using System.Diagnostics;
using MessengerServiceWebRole.Database.Context;
using MessengerServiceWebRole.Database.Context.Entities;

namespace MessengerServiceWebRole.Database
{
    public class DatabaseManager : IDatabaseManager
    {
        private DatabaseModel DB { get; }

        #region Constructors

        public DatabaseManager()
        {
            try
            {
                DB = new DatabaseModel();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }
        }

        #endregion

        public IEnumerable<UserContext> GetUsers()
        {
            return DB.Users;
        }

        public bool AddUser(string userName, string password)
        {
            try
            {
                DB.Users.Add(new UserContext
                {
                    Name = userName,
                    Password = password
                });

                DB.SaveChanges();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return false;
            }

            return true;
        }
    }
}