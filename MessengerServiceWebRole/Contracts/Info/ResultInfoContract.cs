using System.Runtime.Serialization;

namespace MessengerServiceWebRole.Contracts.Info
{
    [DataContract]
    public class ResultInfoContract
    {
        [DataMember]
        public ResultInfoTypes Type { get; set; }

        [DataMember]
        public string Message { get; set; }

        #region Constructors

        public ResultInfoContract(string message, ResultInfoTypes type)
        {
            Message = message;
            Type = type;
        }

        #endregion
    }
}