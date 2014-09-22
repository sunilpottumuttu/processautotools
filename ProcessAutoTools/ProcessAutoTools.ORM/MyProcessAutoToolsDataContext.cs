using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ProcessAutoTools.ORM
{
    public class MyProcessAutoToolsDataContext:ProcessAutoToolsDataContext
    {
        public MyProcessAutoToolsDataContext():base(ConfigurationManager.ConnectionStrings["ProcessAutoToolsConnString"].ToString())
        {

        }
    }
}
