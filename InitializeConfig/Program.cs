using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Barcode_Generator;
using OBConnector;

namespace InitializeConfig
{
    class Program
    {
        static void Main(string[] args)
        {
            Barcode_Generator.BGConfig config = new BGConfig();
            OBConnector.OBConnection newConn = new OBConnector.OBConnection("test", "test");
            OBConnector.OBConnectionCollection newCollection = new OBConnector.OBConnectionCollection();
            newCollection.Add("Triumph", "Data Source=10.209.41.166:1521/TRIUMP;User ID=viewer;Password=cprt_hsi;Unicode=True");
            newCollection.Add("Meadows", "Data Source=10.209.41.166:1521/MEADOW;User ID=viewer;Password=cprt_hsi;Unicode=True");
            config.OBConnections = newCollection;
            config.SerializeToXML("C:\\Documents and Settings\\afreeberg\\My Documents\\Visual Studio 2008\\Projects\\Barcode_Generator\\InitializeConfig\\bin\\Debug\\config.xml");
        }
    }
}
