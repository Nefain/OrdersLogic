using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdLogicLib.Models
{
    public class OrderModel
    {
        [Key]
        public Guid IdOrder { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Sum { get; set; }
        public decimal Balance { get; set; }
    }
}
