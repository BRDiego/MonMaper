using System.Collections.Generic;
using Model;

namespace DBControl.Services
{
    internal interface IPaymentCRUD
    {
        int Insert(Payment obj);
        List<Payment> ListAll();
        Payment FindById(int id);
        int Update(Payment obj);
        int Remove(Payment obj);
        List<Payment> ListByMonth(int month);
    }
}
