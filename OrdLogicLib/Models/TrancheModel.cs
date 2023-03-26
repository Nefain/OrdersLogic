using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdLogicLib.Models
{
    public class TrancheModel
    {
        [Key]
        public Guid IdTranche { get; set; }
        public DateTime TrancheDate { get; set; }
        public decimal Sum { get; set; }
        public decimal Residual { get; set; }
    }
}
