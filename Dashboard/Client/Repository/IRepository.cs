using Dashboard.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dashboard.Client.Repository
{
    public interface IRepository
    {
        List<CustomerVM> GetCustomers();
        List<DebitTypeVM> GetDebitTypes();
        List<PayMethodVM> GetPayMethods();
        List<ProviderVM> GetProviders();
        List<WorkerVM> GetWorkers();


    }
}
