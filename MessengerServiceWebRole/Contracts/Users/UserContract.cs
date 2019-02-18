using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using MessengerServiceWebRole.Database.Context.Entities;

namespace MessengerServiceWebRole.Contracts.Users
{
    [DataContract]
    public class UserContract
    {
        [DataMember]
        public int Id { get; set; }
    
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Password { get; set; }

        //public IEnumerable<UserContract> Contacts { get; set; }

        #region Constructors

        public UserContract(UserContext record)
        {
            Name = record.Name;
            Password = record.Password;
            //Contacts = new UserContract[]{};
        }

        #endregion

        //public void AddContact(UserContract contact)
        //{
        //    if (!Contacts.Contains(contact))
        //    {
        //        var contacts = Contacts.ToList();
        //        contacts.Add(contact);
        //        Contacts = contacts.ToArray();
        //    }
        //}
    }
}