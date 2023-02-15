using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Application.Models
{
    public class EmailSettings
    {
        public string Apikey { get; set; }
        public string FromAddress { get; set; }
        public string FormName { get; set; }
    }
}
