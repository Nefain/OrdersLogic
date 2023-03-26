using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToDB.Mapping;

namespace OrdersLogic.Models
{
    [Table(Name = "Tranches")]
    public  class TrancheModel
    {
        [PrimaryKey]
        [Column(Name = "IdTranche")]
        public Guid IdTranche { get; set; }

        [Column(Name = "TrancheDate")]
        public DateTime TrancheDate { get; set; }

        [Column(Name = "Sum")]
        public decimal Sum { get; set; }

        [Column(Name = "Residual")]
        public decimal Residual { get; set; }
    }
}
