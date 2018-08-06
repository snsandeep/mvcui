using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface Idalinter
    {
         int disply();
         int insert();
    }

    public class Class1 : Idalinter
    {
        public int disply()
        {
            //logic to return data to blogic
            return 100;
        }

        public int insert()
        {

            return 1;
        }
    }

    class DalManeger
    {
        public static Idalinter GetInstance()
        {
            Idalinter ob = new Class1();
            return ob;

        }
    }


}
