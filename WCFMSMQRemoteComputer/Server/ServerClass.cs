using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Server
{
    [ServiceContract]
    public interface IServer
    {
        [OperationContract(IsOneWay = true)]
        void Receive(string data);
    }

    public class QueueService : IServer
    {
        public static string computerInfo;
        public QueueService() { }

        public void Receive(string data)
        {
            computerInfo = data;
        }

        public string getComputerInfo()
        {
            return computerInfo;
        }
    }
}
