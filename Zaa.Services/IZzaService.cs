using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Zza.Entities;

namespace Zaa.Services
{
    [ServiceContract]
    public interface IZzaService
    {
        [OperationContract]
        List<Product> GetProduct();
        [OperationContract]
        List<Customer> GetCustomers();
        [OperationContract]
        void SubmitOrder(Order order);
    }
}
