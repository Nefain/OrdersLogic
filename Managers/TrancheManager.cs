using LinqToDB;
using LinqToDB.Data;
using Newtonsoft.Json;
using OrdersLogic.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersLogic.Managers
{
    public class TrancheManager
    {
        DataConnection db;
        private string str;
        public TrancheManager()
        {
            str = JsonConvert.DeserializeObject<ConfigDTO>(File.ReadAllText("appsettings.json")).ConnectionStrings.DefaultConnection;
        }
        public IEnumerable<TrancheModel> Get()
        {
            db = new DataConnection(new DataOptions().UseSqlServer(str));
            return db.GetTable<TrancheModel>().ToList();
        }
        public TrancheModel GetId(TrancheModel _trancheModel)
        {
            db = new DataConnection(new DataOptions().UseSqlServer(str));
            return db.GetTable<TrancheModel>().FirstOrDefault(i => i.IdTranche == _trancheModel.IdTranche);
        }

        public void Post(TrancheModel _newTranche)
        {
            db = new DataConnection(new DataOptions().UseSqlServer(str));
            _newTranche.IdTranche = Guid.NewGuid();
            db.Insert(_newTranche, "Tranches");

        }

        public void Delete(TrancheModel _trancheModel)
        {
            db = new DataConnection(new DataOptions().UseSqlServer(str));
            db.Delete(_trancheModel, "Tranches");
        }
    }
}
