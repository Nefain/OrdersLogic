using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using LinqToDB;
using LinqToDB.Data;
using Newtonsoft.Json;
using OrdersLogic.Models;

namespace OrdersLogic.Managers
{
    public class PaymentManager
    {
        DataConnection db;
        private string str;
        public PaymentManager()
        {
            str = JsonConvert.DeserializeObject<ConfigDTO>(File.ReadAllText("appsettings.json")).ConnectionStrings.DefaultConnection;
        }
        
        public IEnumerable<PaymentModel> Get()
        {
            db = new DataConnection(new DataOptions().UseSqlServer(str));
            return db.GetTable<PaymentModel>().ToList();
        }
        public PaymentModel GetId(PaymentModel _paymentModel)
        {
            db = new DataConnection(new DataOptions().UseSqlServer(str));
            return db.GetTable<PaymentModel>().FirstOrDefault(i => i.IdOrder == _paymentModel.IdOrder&&i.IdTranche== _paymentModel.IdTranche);
        }

        public void Post(PaymentModel _newPayment)
        {
            db = new DataConnection(new DataOptions().UseSqlServer(str));
            db.Insert(_newPayment, "Payments");
        }

        public void Delete(PaymentModel _paymentModel)
        {
            db = new DataConnection(new DataOptions().UseSqlServer(str));
            db.Delete(_paymentModel, "Payments");
        }
    }
}
