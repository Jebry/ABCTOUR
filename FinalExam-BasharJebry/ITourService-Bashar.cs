using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FinalExam_BasharJebry
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITourService_Bashar" in both code and config file together.
    [ServiceContract]
    public interface ITourAuthenticateUserService_Bashar
    {
        [OperationContract]
        string AuthenticateUser(UserInfo user);
        
    }
    [ServiceContract]
    public interface ITourDBOperationsService_Bashar
    {

        [OperationContract]
        string InsertABus(InsertABus bus);
        [OperationContract]
        string UpdateABus(UpdateABus bus);
        [OperationContract]
        RetrieveBusInfo RetrieveBusInfo();
        [OperationContract]
        string DeleteABus(DeleteABus bus);
        [OperationContract]
        FoundRecord FindABus(FindABus bus);

    }

    [DataContract]
    public class FoundRecord
    {
        [DataMember]
        public int BusId { get; set; }
        [DataMember]
        public string Make { get; set; }
        [DataMember]
        public string Model { get; set; }
        [DataMember]
        public int NoOfSeats { get; set; }
    }

    [DataContract]
    public class FindABus
    {
        [DataMember]
        public int BusId { get; set; }
    }

    [DataContract]
    public class RetrieveBusInfo
    {
        [DataMember]
        public List<BusInfo> dataset { get; set; }     
    }

    [DataContract]
    public class DeleteABus
    {
        [DataMember]
        public int BusId { get; set; }
    }

    [DataContract]
    public class UpdateABus
    {
        [DataMember]
        public int BusId { get; set; }
        [DataMember]
        public string Make { get; set; }
        [DataMember]
        public string Model { get; set; }
        [DataMember]
        public int NoOfSeats { get; set; }
    }

    [DataContract]
    public class InsertABus
    {
        [DataMember]
        public int BusId { get; set; }
        [DataMember]
        public string Make { get; set; }
        [DataMember]
        public string Model { get; set; }
        [DataMember]
        public int NoOfSeats { get; set; }
    }

    [DataContract]
    public class UserInfo
    {
        [DataMember]
        public string UserName { get; set; }
        [DataMember]
        public string Password { get; set; }
    }
}
