using Dashboard.Shared.DTOs;
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
            providers.Add(new ProviderVM() { Name = "ICE", Phone = 85002818, FixedExpense = true });

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

        public List<DayVM> GetDays()
        {
            List<DayVM> days = new List<DayVM>();

            days.Add(new DayVM() { Name = "Lunes", DayId = 1, Open = true, Goal = 83000, DaysAfter = 6, DaysBefore = 0 });
            days.Add(new DayVM() { Name = "Martes", DayId = 2, Open = false, Goal = 0, DaysAfter = 5, DaysBefore = 1 });
            days.Add(new DayVM() { Name = "Miercoles", DayId = 3, Open = true, Goal = 83000, DaysAfter = 4, DaysBefore = 2 });
            days.Add(new DayVM() { Name = "Jueves", DayId = 4, Open = true, Goal = 83000, DaysAfter = 3, DaysBefore = 3 });
            days.Add(new DayVM() { Name = "Viernes", DayId = 5, Open = true, Goal = 132000, DaysAfter = 2, DaysBefore = 4 });
            days.Add(new DayVM() { Name = "Sabado", DayId = 6, Open = true, Goal = 250000, DaysAfter = 1, DaysBefore = 5 });
            days.Add(new DayVM() { Name = "Domingo", DayId = 7, Open = true, Goal = 165000, DaysAfter = 0, DaysBefore = 6 });


            return days;
        }

        public List<CalendarDayDTO> FillDays()
        {
            List<CalendarDayDTO> days = new List<CalendarDayDTO>();

            days.Add(new CalendarDayDTO()
            {
                Name = "Lunes",
                DaysBefore = 0,
                DaysAfter = 6
            });
            days.Add(new CalendarDayDTO()
            {
                Name = "Martes",
                DaysBefore = 1,
                DaysAfter = 5
            });
            days.Add(new CalendarDayDTO()
            {
                Name = "Miercoles",
                DaysBefore = 2,
                DaysAfter = 4
            });
            days.Add(new CalendarDayDTO()
            {
                Name = "Jueves",
                DaysBefore = 3,
                DaysAfter = 3
            });
            days.Add(new CalendarDayDTO()
            {
                Name = "Viernes",
                DaysBefore = 4,
                DaysAfter = 2
            });
            days.Add(new CalendarDayDTO()
            {
                Name = "Sabado",
                DaysBefore = 5,
                DaysAfter = 1
            });
            days.Add(new CalendarDayDTO()
            {
                Name = "Domingo",
                DaysBefore = 6,
                DaysAfter = 0
            });

            return days;
        }

        public List<MonthDTO> FillMonths(int year)
        {
            List<MonthDTO> months = new List<MonthDTO>();

            months.Add(new MonthDTO() { MonthLength = DateTime.DaysInMonth(year, 1), Id = 1, Name = "Enero" });
            months.Add(new MonthDTO() { MonthLength = DateTime.DaysInMonth(year, 2), Id = 2, Name = "Febrero" });
            months.Add(new MonthDTO() { MonthLength = DateTime.DaysInMonth(year, 3), Id = 3, Name = "Marzo" });
            months.Add(new MonthDTO() { MonthLength = DateTime.DaysInMonth(year, 4), Id = 4, Name = "Abril" });
            months.Add(new MonthDTO() { MonthLength = DateTime.DaysInMonth(year, 5), Id = 5, Name = "Mayo" });
            months.Add(new MonthDTO() { MonthLength = DateTime.DaysInMonth(year, 6), Id = 6, Name = "Junio" });
            months.Add(new MonthDTO() { MonthLength = DateTime.DaysInMonth(year, 7), Id = 7, Name = "Julio" });
            months.Add(new MonthDTO() { MonthLength = DateTime.DaysInMonth(year, 8), Id = 8, Name = "Agosto" });
            months.Add(new MonthDTO() { MonthLength = DateTime.DaysInMonth(year, 9), Id = 9, Name = "Septiembre" });
            months.Add(new MonthDTO() { MonthLength = DateTime.DaysInMonth(year, 10), Id = 10, Name = "Octubre" });
            months.Add(new MonthDTO() { MonthLength = DateTime.DaysInMonth(year, 11), Id = 11, Name = "Noviembre" });
            months.Add(new MonthDTO() { MonthLength = DateTime.DaysInMonth(year, 12), Id = 12, Name = "Diciembre" });

            return months;
        }

        public List<int> FillYears()
        {
            List<int> years = new List<int>();

            for (int i = 2021; i <= 2050; i++)
            {
                years.Add(i);
            }

            return years;
        }
    }
}
