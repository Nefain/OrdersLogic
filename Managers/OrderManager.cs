using OrdersLogic.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToDB;
using LinqToDB.Data;
using Newtonsoft.Json;

namespace OrdersLogic.Managers
{
    public class OrderManager
    {
        DataConnection db;
        private string str;
        public OrderManager()
        {
            str = JsonConvert.DeserializeObject<ConfigDTO>(File.ReadAllText("appsettings.json")).ConnectionStrings.DefaultConnection;
        }
        public IEnumerable<OrderModel> Get()
        {
            db = new DataConnection(new DataOptions().UseSqlServer(str));
            return db.GetTable<OrderModel>().ToList();
        }
        public OrderModel GetId(OrderModel _orderModel)
        {
            db = new DataConnection(new DataOptions().UseSqlServer(str));
            return db.GetTable<OrderModel>().FirstOrDefault(i => i.IdOrder == _orderModel.IdOrder);
        }

        public void Post(OrderModel newOrder)
        {
            db = new DataConnection(new DataOptions().UseSqlServer(str));
            newOrder.IdOrder = Guid.NewGuid();
            db.Insert(newOrder, "Orders");

        }

        public void Delete(OrderModel _orderModel)
        {
            db = new DataConnection(new DataOptions().UseSqlServer(str));
            db.Delete(_orderModel, "Orders");
        }
    }
}
