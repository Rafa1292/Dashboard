using Dashboard.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dashboard.Client.Repository
{
    public class Repository : IRepository
    {
        public List<CustomerVM> GetCustomers()
        {
            List<CustomerVM> customers = new List<CustomerVM>();

            customers.Add(new CustomerVM() { Name = "Hector", Phone = 85002818, MaxAmount = 20000 });
            customers.Add(new CustomerVM() { Name = "Manuel", Phone = 85002818, MaxAmount = 30000 });
            customers.Add(new CustomerVM() { Name = "Enrique", Phone = 85002818, MaxAmount = 10000 });
            customers.Add(new CustomerVM() { Name = "Manolas", Phone = 85002818, MaxAmount = 5000 });

            return customers;
        }

        public List<DebitTypeVM> GetDebitTypes()
        {
            List<DebitTypeVM> debitTypes = new List<DebitTypeVM>();

            debitTypes.Add(new DebitTypeVM() { Description = "Insumo" });
            debitTypes.Add(new DebitTypeVM() { Description = "Salario" });
            debitTypes.Add(new DebitTypeVM() { Description = "Gasto Fijo" });

            return debitTypes;
        }

        public List<PayMethodVM> GetPayMethods()
        {
            List<PayMethodVM> payMethods = new List<PayMethodVM>();

            payMethods.Add(new PayMethodVM() { Description = "Efectivo" });
            payMethods.Add(new PayMethodVM() { Description = "Tarjeta" });
            payMethods.Add(new PayMethodVM() { Description = "Sinpe" });

            return payMethods;

        }

        public List<ProviderVM> GetProviders()
        {
            List<ProviderVM> providers = new List<ProviderVM>();

            providers.Add(new ProviderVM() { Name = "Cae", Phone = 85002818 });
            providers.Add(new ProviderVM() { Name = "La Raza", Phone = 85002818 });
            providers.Add(new ProviderVM() { Name = "Sigma", Phone = 85002818 });
            providers.Add(new ProviderVM() { Name = "Coca-Cola", Phone = 85002818 });

            return providers;

        }

        public List<WorkerVM> GetWorkers()
        {
            List<WorkerVM> workers = new List<WorkerVM>();

            workers.Add(new WorkerVM() { Name = "Beto", Phone = 85002818, Salary = 20000, StartOfWork = DateTime.Now.Date });
            workers.Add(new WorkerVM() { Name = "Millo", Phone = 85002818, Salary = 30000, StartOfWork = DateTime.Now.Date });
            workers.Add(new WorkerVM() { Name = "Karie", Phone = 85002818, Salary = 10000, StartOfWork = DateTime.Now.Date });
            workers.Add(new WorkerVM() { Name = "Yorleny", Phone = 85002818, Salary = 5000, StartOfWork = DateTime.Now.Date });

            return workers;

        }
    }
}
