using Microsoft.EntityFrameworkCore;
using TestTask.Data;
using TestTask.Models;
using TestTask.Services.Interfaces;

namespace TestTask.Services
{
    public class OrderService : IOrderService
    {
        private readonly ApplicationDbContext dbContext;

        public OrderService(ApplicationDbContext dbContext)
        {
                this.dbContext = dbContext;
        }

        public async Task<Order> GetOrder()
        {
            return await this.dbContext.Orders.FirstOrDefaultAsync( x => x.Price<50);
        }

        public async Task<List<Order>> GetOrders()
        {
            return await this.dbContext.Orders.ToListAsync();
        }
    }
}
