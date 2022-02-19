using System;
using System.Collections.Generic;
using Model;
using DBControl.Services;
namespace DesktopController
{
    public class PaymentsDeskController
    {
        private readonly PaymentService _paymentService;

        public PaymentsDeskController()
        {
            _paymentService = new PaymentService(new DBControl.Data.MonMaperContext());
        }
        public int AddPayment(Payment obj)
        {
            return _paymentService.Insert(obj);
        }

        public Payment LoadPayment(int id)
        {
            return _paymentService.FindById(id);
        }

        public int UpdatePayment(Payment obj)
        {
            return _paymentService.Update(obj);
        }

        public int DeletePayment(Payment obj)
        {
            return _paymentService.Update(obj);
        }

        public List<Payment> ListPayments()
        {
            return _paymentService.ListAll();
        }

        public List<Payment> ListPayments(int month)
        {
            return _paymentService.ListByMonth(month);
        }
    }
}
