using System.Runtime.Serialization;

namespace MessengerServiceWebRole.Contracts.Users
{
    [DataContract]
    public class UserCredentialsContract
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Password { get; set; }

        #region Constructors

        public UserCredentialsContract(string name, string password)
        {
            Name = name;
            Password = password;
        }

        #endregion
    }
}