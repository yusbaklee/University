using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    internal class Department : Result,IRegistration
    {
        public string name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string matricID { get { throw new NotImplementedException(); } set => throw new NotImplementedException(); }
        public string address { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override string grade => throw new NotImplementedException();

       
    }


}
