using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using OBConnector;

namespace Barcode_Generator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MDIParent1());
        }
    }

    public class BGConfig
    {
        private OBConnector.OBConnectionCollection _OBConnections;

        public BGConfig()
        {

        }

        public BGConfig(System.String PathToXML)
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(BGConfig));
            TextReader textReader = new StreamReader(@PathToXML);
            BGConfig deserialized = ((BGConfig)deserializer.Deserialize(textReader));
            _OBConnections = deserialized.OBConnections;
            textReader.Close();
        }

        public OBConnector.OBConnectionCollection OBConnections
        {
            get { return _OBConnections; }
            set { _OBConnections = value; }
        }

        public void SerializeToXML(System.String XMLLocation)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(BGConfig));
            TextWriter textWriter = new StreamWriter(@XMLLocation);
            serializer.Serialize(textWriter, this);
            textWriter.Close();
        }
    }


}
