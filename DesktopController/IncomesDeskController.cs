using System;
using System.Collections.Generic;
using Model;
using DBControl.Services;
namespace DesktopController
{
    public class IncomesDeskController
    {
        private readonly IncomeService _incomeService;

        public IncomesDeskController()
        {
            IncomeService incService = new IncomeService(new DBControl.Data.MonMaperContext());
            _incomeService = incService;
        }
        public int AddIncome(Income obj)
        {
            return _incomeService.Insert(obj);
        }

        public Income LoadIncome(int id)
        {
            return _incomeService.FindById(id);
        }

        public int UpdateIncome(Income obj)
        {
            return _incomeService.Update(obj);
        }

        public int DeleteIncome(Income obj)
        {
            return _incomeService.Update(obj);
        }

        public List<Income> ListIncomes()
        {
            return _incomeService.ListAll();
        }

        public List<Income> ListIncomes(int month)
        {
            return _incomeService.ListByMonth(month);
        }
    }
}
