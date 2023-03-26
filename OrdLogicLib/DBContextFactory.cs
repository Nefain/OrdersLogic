using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using OrdLogicLib.Storage;

namespace OrdLogicLib
{
    public class DBContextFactory : IDesignTimeDbContextFactory<OrdersLogicDataContext>
    {
        public OrdersLogicDataContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<OrdersLogicDataContext>();
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=OrdersLogic;Trusted_Connection=True;TrustServerCertificate=True");
            return new OrdersLogicDataContext(optionsBuilder.Options);
        }
    }
}