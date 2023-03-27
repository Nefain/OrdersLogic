using Microsoft.EntityFrameworkCore;
using OrdLogicLib.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdLogicLib
{
    public class Initializer
    {
        public Initializer()
        {
            var optionBuilder = new DbContextOptionsBuilder<OrdersLogicDataContext>();
            var options = optionBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=OrdersLogic;Trusted_Connection=True;TrustServerCertificate=True").Options;
        }
    }
}
