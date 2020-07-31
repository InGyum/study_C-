using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondCaliburnApp
{
    public class Commons
    {
        public static string strConnString =
            "Data Source=localhost;Port=3306;Database=employees;uid=root;password=mysql_p@ssw0rd";

        public static string SELECTPEOPLEQUERY =
            "SELECT id, FirstName, LastName " +
            "  FROM peopletbl " +
            " ORDER BY id ";
    }
}
