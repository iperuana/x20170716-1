using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informatica_Peruana.SGC.DA_Sistema_SGC
{
    public abstract class DA_Base
    {
        // protected static string db = ConfigurationManager.AppSettings["CSSGC"].ToString();
        protected static Database db = DatabaseFactory.CreateDatabase("CSSGC");
    }
}
