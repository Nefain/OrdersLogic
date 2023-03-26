using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersLogic
{
    public class ConfigDTO
    {
        public ConfigDTO() { }
        public ConnectionStrings ConnectionStrings { get; set; }
    }
    public class ConnectionStrings
    {
        public string DefaultConnection { get; set; }
        public ConnectionStrings()
        {
            
        }
    }
}
