using Bulky.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccess.Repository.IRepository
{
    public interface IOrderHeaderRepository : Repository<OrderHeader>
    {
        void Update(OrderHeader orderHeader);
        void UpdateStatus(int id,string  OrderStatus,string? paymentStatus = null);
        void UpdateStripePaymentId(int id,string sessionId,string PaymentIntentId);
        
    }
}
