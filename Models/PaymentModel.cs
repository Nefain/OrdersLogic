using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToDB.Mapping;

namespace OrdersLogic.Models
{
    [Table(Name = "Payments")]
    public class PaymentModel
    {
        [Column(Name = "IdOrder")]
        public Guid IdOrder { get; set; }

        [Column(Name = "IdTranche")]
        public Guid IdTranche { get; set; }

        [Column(Name = "TotalPayment")]
        public decimal TotalPayment { get; set; }
    }
}
