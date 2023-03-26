using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToDB.Mapping;

namespace OrdersLogic.Models
{
    [Table(Name = "Users")]
    public class UserModel
    {
        [PrimaryKey]
        [Column(Name = "UserId")]
        public Guid UserId { get; set; }

        [Column(Name = "Name")]
        public string Name { get; set; }

        [Column(Name = "Password")]
        public string Password { get; set; }
        [Column(Name = "UserOrdersIdGuid")]
        public Guid UserOrdersIdGuid { get; set; }
    }
}
