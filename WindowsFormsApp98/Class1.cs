using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp98
{
   public class cEmployee
    {
        public event delbig toobig;


        public string FirstName
        {
            get;
            set;
        }

        public string lastName
        {
            get;
            set;
        }

        public string Concatinate()
        {
            if ((FirstName + lastName).Length > 10)
                toobig.Invoke(this, new EventArgs());

            return FirstName + ' ' + lastName;
        }
        }
}
