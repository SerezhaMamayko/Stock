using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Models
{
    public class BookerOrder
    {
        public int Id { get; set; }
        public string PhoneNum { get; set; }
        public string AllName { get; set; }
        public string OrderName { get; set; }
        public bool PayStatus { get; set; }
        public string Sum { get; set; }
        public string NDS { get; set; }
        public string Total { get; set; }
        public DateTime Creating { get; set; }
    }
}
