using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OracleClient;

namespace OBConnector
{
    public class OBConnection
    {
        private System.String _ConnectionName;
        private System.String _ConnectionString;
        
        public OBConnection(System.String inputConnectionName, System.String inputConnectionString)
        {
            _ConnectionString = inputConnectionString;
            _ConnectionName = inputConnectionName;
        }

        public System.String ConnectionString
        {
            get { return _ConnectionString; }
            set { _ConnectionString = value; }
        }

        public System.String ConnectionName
        {
            get { return _ConnectionName; }
            set { _ConnectionName = value; }
        }

        public System.Data.DataSet Query(System.String sql, System.Type[] dtAr)
        {
            using (OracleConnection OBConn = new OracleConnection())
            {

                DataSet ds = new DataSet();

                ds.Tables.Add(new DataTable());

                OBConn.ConnectionString = _ConnectionString;
                OBConn.Open();

                OracleCommand OBCommand = OBConn.CreateCommand();
                OBCommand.CommandText = sql;

                OracleDataAdapter OBDa = new OracleDataAdapter(OBCommand);

                OBDa.Fill(ds.Tables[0]);

                return ds;
            }
        }
        
    }

    public class OBConnectionCollection : System.Collections.CollectionBase
    {
        public OBConnectionCollection()
        {

        }

        public OBConnection this[int index]
        {
            get { return (OBConnection)this.List[index]; }
            set { this.List[index] = value; }
        }

        public int IndexOf(OBConnection item)
        {
            return base.List.IndexOf(item);
        }

        public int Add(OBConnection item)
        {
            return this.List.Add(item);
        }

        public int Add(System.String inputName, System.String inputConnection)
        {
            OBConnection inputOBCon = new OBConnection(inputName, inputConnection);
            return this.Add(inputOBCon);
        }

        public void Remove(OBConnection item)
        {
            this.InnerList.Remove(item);
        }

        public void CopyTo(Array array, int index)
        {
            this.List.CopyTo(array, index);
        }

        public void AddRange(OBConnectionCollection collection)
        {
            for (int i = 0; i < collection.Count; i++)
            {
                this.List.Add(collection[i]);
            }
        }

        public void AddRange(OBConnection[] collection)
        {
            this.AddRange(collection);
        }

        public bool Contains(OBConnection item)
        {
            return this.List.Contains(item);
        }

        public void Insert(int index, OBConnection item)
        {
            this.List.Insert(index, item);
        }
    }

}
