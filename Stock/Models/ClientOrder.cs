using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace Stock.Models
{
    public class ClientOrder
    {
        public int Id { get; set; }
        public string PhoneNum { get; set; }
        public string AllName { get; set; }
        public string NameOfOrder { get; set; }
        public bool StatusOfPay { get; set; }
        public string Sum { get; set; }
        public DateTime Creating { get; set; }
        public DateTime LastChanched { get; set; }
    }
}
