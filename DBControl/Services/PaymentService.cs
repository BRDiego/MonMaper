using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using DBControl.Data;
using Microsoft.EntityFrameworkCore;

namespace DBControl.Services
{
    public class PaymentService : IPaymentCRUD
    {
        private readonly MonMaperContext _context;
        public PaymentService(MonMaperContext context)
        {
            _context = context;
        }
        public int Insert(Payment obj)
        {
            try
            {
                _context.Payments.Add(obj);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception )
            {
                throw;
            }
        }

        public List<Payment> ListAll()
        {
            try
            {
                List<Payment> list = _context.Payments.ToList();
                return list;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Payment> ListByMonth(int month)
        {
            try
            {
                List<Payment> list = _context.Payments.Where(x => x.Moment.Month == month).ToList();
                return list;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Payment FindById(int id)
        {
            try
            {
                var obj = _context.Payments.Find(id);
                return obj;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int Update(Payment obj)
        {
            try
            {
                _context.Payments.Update(obj);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int Remove(Payment obj)
        {
            try
            {
                _context.Remove(obj);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
