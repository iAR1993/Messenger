using System.Runtime.Serialization;

namespace MessengerServiceWebRole.Contracts.Users
{
    [DataContract]
    public class UserRegisterInfoContract
    {
        //TODO: Add another user data here...

        [DataMember]
        public UserCredentialsContract Credentials { get; set; }

        #region Constructors

        public UserRegisterInfoContract(UserCredentialsContract credentials)
        {

        }

        #endregion
    }
}