using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zaa.Services;
using System.ServiceModel;
using Zza.Client.ZzaServices;
using System.ServiceModel.Channels;
using System.Collections.ObjectModel;

namespace Zza.Client
{
    class ZzaProxy : ClientBase<IZzaService>, IZzaService
    {
        public ZzaProxy() { }
        public ZzaProxy(string endpointName) : base(endpointName) { }
        public ZzaProxy(Binding binding, string address) : base(binding, new EndpointAddress(address)) { }
        public ObservableCollection<Entities.Product> GetProducts()
        {
            return Channel.GetProducts();
        }
    }
}
