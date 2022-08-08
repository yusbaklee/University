using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
     interface IRegistration
    {
        public string name { get; set; }
        public string matricID { get; set; }
        public string address { get; set; }
    }
}
