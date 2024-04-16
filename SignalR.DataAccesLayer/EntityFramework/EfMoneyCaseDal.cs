using SignalR.DataAccesLayer.Abstract;
using SignalR.DataAccesLayer.Concrate;
using SignalR.DataAccesLayer.Repositories;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccesLayer.EntityFramework
{
    public class EfMoneyCaseDal : GenericRepository<MoneyCase>, IMoneyCaseDal
    {
        public EfMoneyCaseDal(SignalRContext context) : base(context)
        {
        }

        public decimal TotalMoneyCaseAmount()
        {
            using var context = new SignalRContext();
            return context.MoneyCases.Select(x => x.TotalAmount).FirstOrDefault();
        }
    }
}
