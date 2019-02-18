using System.Runtime.Serialization;

namespace MessengerServiceWebRole.Contracts.Info
{
    [DataContract]
    public enum ResultInfoTypes
    {
        [EnumMember]
        Success,

        [EnumMember]
        Error
    }
}