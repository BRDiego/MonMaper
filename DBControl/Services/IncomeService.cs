using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using DBControl.Data;
using Microsoft.EntityFrameworkCore;

namespace DBControl.Services
{
    public class IncomeService
    {
        private readonly MonMaperContext _context;
        public IncomeService(MonMaperContext context)
        {
            _context = context;
        }
        public int Insert(Income obj)
        {
            try
            {
                _context.Incomes.Add(obj);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        public List<Income> ListAll()
        {
            try
            {
                List<Income> list = _context.Incomes.ToList();
                return list;
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        public List<Income> ListByMonth(int month)
        {
            try
            {
                List<Income> list = _context.Incomes.Where(x => x.Moment.Month == month).ToList();
                return list;
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        public Income FindById(int id)
        {
            try
            {
                var obj = _context.Incomes.Find(id);               
                return obj;
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        public int Update(Income obj)
        {
            try
            {
                _context.Incomes.Update(obj);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        public int Remove(Income obj)
        {
            try
            {
                _context.Remove(obj);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }
    }
}
