using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.SQL
{

    public class stringConnect
    {
        public string connStr = ConfigurationManager.ConnectionStrings["Database"].ConnectionString;
    }
}
