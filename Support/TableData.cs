using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Support
{
    public class TableData
    {
        public TableData() { 
        }

        public static Dictionary<string,string> convertTableToDic(Table table)
        {

            Dictionary<string, string> list = new Dictionary<string, string>();

            if (table.Header != null){
                list.Add(table.Header.ToList().ElementAt(0), table.Header.ToList().ElementAt(1));
            }
            foreach(var row in table.Rows)
            {
                list.Add(row[0], row[1]);
            }
            return list;


        }
    }
}
