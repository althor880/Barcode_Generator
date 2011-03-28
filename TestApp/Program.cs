using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OBConnector;
using System.Data.OracleClient;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            OBConnection OBConn = new OBConnection("Triumph", "Data Source=10.209.41.166:1521/TRIUMP;User ID=viewer;Password=cprt_hsi;Unicode=True");
            System.Data.DataSet results = OBConn.Query("Select username From hsi.useraccount");

            System.Data.DataTable resultTable = results.Tables[0];

            for (System.Int32 x = 0; x < resultTable.Rows.Count; x++ )
            {
                for (System.Int32 y = 0; y < resultTable.Columns.Count; y++)
                {
                    Console.WriteLine(resultTable.Rows[x][y]);
                }
            }

            Console.ReadLine();
            
        }
    }
}
