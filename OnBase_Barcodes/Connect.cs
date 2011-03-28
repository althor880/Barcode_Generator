using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace OnBase_Barcodes
{
    public partial class Connect : Form
    {
        private static Connect m_Connect;
        private String _ConnName;
        private String _ConnString;

        public Connect()
        {
            InitializeComponent();
            LoadConnections();

        }

        public String ConnString
        {
            get { return _ConnString; }
        }

        public String ConnName
        {
            get { return _ConnName; }
        }

        public static Connect GetChildInstance()
        {
            if (m_Connect == null)
            {
                m_Connect = new Connect();
            }
            return m_Connect;
        }

        public void LoadConnections()
        {
            String ConnectionString;
            for (Int16 x = 0; x < Properties.Settings.Default.ConnectionStrings.Count; x++)
            {
                ConnectionString = Properties.Settings.Default.ConnectionStrings[x];
                System.Text.RegularExpressions.Regex connRegEx = new Regex("\\[(\\w+)\\](.+)");
                System.Text.RegularExpressions.Match connMatch = connRegEx.Match(ConnectionString);
                String ConnName = connMatch.Groups[1].ToString();
                String ConnString = connMatch.Groups[2].ToString();
                ComboBoxItem cboItem = new ComboBoxItem(ConnName, ConnString);
                ConnectionsCbo.Items.Add(cboItem);
            }
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            if (ConnectionsCbo.SelectedItem != null)
            {
                this._ConnName = ((ComboBoxItem)ConnectionsCbo.SelectedItem).DisplayName;
                this._ConnString = ((ComboBoxItem)ConnectionsCbo.SelectedItem).ItemValue;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("SelectedItem = null!!");
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

    }

    public class ComboBoxItem
    {
        private String _DisplayName;
        private String _ItemValue;

        public ComboBoxItem(String DisplayName, String ItemValue)
        {
            this._DisplayName = DisplayName;
            this._ItemValue = ItemValue;
        }

        public String DisplayName
        {
            get { return this._DisplayName; }
            set { this._DisplayName = value; }
        }

        public String ItemValue
        {
            get { return this._ItemValue; }
            set { this._ItemValue = value; }
        }

        public override string ToString()
        {
            return this._DisplayName;
        }

    }
}
