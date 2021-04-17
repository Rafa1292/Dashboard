using Dashboard.Shared.DTOs;
using Dashboard.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dashboard.Client.Repository
{
    public interface IRepository
    {
        List<CalendarDayDTO> FillDays();
        List<MonthDTO> FillMonths(int year);
        List<int> FillYears();
        List<CustomerVM> GetCustomers();
        List<DayVM> GetDays();
        List<DebitTypeVM> GetDebitTypes();
        List<PayMethodVM> GetPayMethods();
        List<ProviderVM> GetProviders();
        List<WorkerVM> GetWorkers();


    }
}
