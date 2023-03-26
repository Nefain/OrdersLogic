using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdLogicLib.Models
{
    public class UserModel
    {
        [Key]
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public Guid UserOrdersIdGuid { get; set; }
        public virtual OrderModel OrderModel { get; set; }
    }
}
