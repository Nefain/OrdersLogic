using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToDB.Mapping;

namespace OrdersLogic.Models
{
    [Table(Name = "Orders")]
    public class OrderModel
    {
        [PrimaryKey]
        [Column(Name = "IdOrder")]
        public Guid IdOrder { get; set; }

        [Column(Name = "OrderDate")]
        public DateTime OrderDate { get; set; }

        [Column(Name = "Sum")]
        public decimal Sum { get; set; }

        [Column(Name = "Balance")]
        public decimal Balance { get; set; }
    }
}
