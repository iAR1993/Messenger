using System.Collections.Generic;
using System.ServiceModel;
using MessengerServiceWebRole.Contracts;
using MessengerServiceWebRole.Contracts.Info;
using MessengerServiceWebRole.Contracts.Users;

namespace MessengerServiceWebRole
{
    [ServiceContract]
    public interface IMessengerService
    {
        #region Test

        [OperationContract]
        string GetData(int value);

        #endregion

        #region Users

        [OperationContract]
        ResultInfoContract SignIn(UserCredentialsContract credentials);

        [OperationContract]
        ResultInfoContract SignOut(UserContract user);

        [OperationContract]
        ResultInfoContract Register(UserRegisterInfoContract registerInfo);

        [OperationContract]
        ResultInfoContract AddContact(UserContract requestUser, UserContract responseUser);

        [OperationContract]
        IEnumerable<UserContract> GetUsers();

        #endregion
    }
}
