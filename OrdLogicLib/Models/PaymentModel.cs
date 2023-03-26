using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdLogicLib.Models
{
    public class PaymentModel
    {
        public Guid IdOrder { get; set; }
        public Guid IdTranche { get; set; }
        public decimal TotalPayment { get; set; }
        public virtual OrderModel OrderModel { get; set; }
        public virtual TrancheModel TrancheModel { get; set; }
    }
}
