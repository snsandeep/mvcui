using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace businesslogic
{

    public interface IMyinter
    {
        int DisplayCustomer();
        int  insertCustomers();

    }
    public class Class1 : IMyinter
    {
        public int DisplayCustomer()
        {
            throw new NotImplementedException();
        }

        public int insertCustomers()
        {
            throw new NotImplementedException();
        }
    }
}
