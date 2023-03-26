using LinqToDB.Data;
using LinqToDB;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using OrdersLogic.Models;
using LinqToDB.Extensions;

namespace OrdersLogic.Managers
{
    public class UserManager
    {
        DataConnection db;
        private string str;
        public UserManager()
        {
            str = JsonConvert.DeserializeObject<ConfigDTO>(File.ReadAllText("appsettings.json")).ConnectionStrings.DefaultConnection;
        }
        public IEnumerable<UserModel> Get()
        {
            db = new DataConnection(new DataOptions().UseSqlServer(str));
            return db.GetTable<UserModel>().ToList();
        }
        public UserModel GetId(UserModel _userModel)
        {
            db = new DataConnection(new DataOptions().UseSqlServer(str));
            return db.GetTable<UserModel>().FirstOrDefault(i => i.UserId == _userModel.UserId);
        }
        public void Update(UserModel _userModel)
        {
            db = new DataConnection(new DataOptions().UseSqlServer(str));
            db.Update(_userModel, "Users");
        }
    }
}
