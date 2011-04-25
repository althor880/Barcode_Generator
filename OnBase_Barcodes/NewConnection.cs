using System;
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
    public partial class NewConnection : Form
    {
        
        private String _ConnName;
        private String _DSName;

        public NewConnection()
        {
            InitializeComponent();
        }

        public String ConnName
        {
            get { return _ConnName; }
            set { _ConnName = value; }
        }

        public String DSName
        {
            get { return _DSName; }
            set { _DSName = value; }
        }

        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.txtConnName.Text.Length > 0 && this.txtDBSource.Text.Length > 0)
            {
                System.Text.RegularExpressions.Regex newConnRegEx = new Regex("(\\w+)");
                System.Text.RegularExpressions.Match connNameMatch = newConnRegEx.Match(this.txtConnName.Text);
                System.Text.RegularExpressions.Match dsNameMatch = newConnRegEx.Match(this.txtDBSource.Text);
                if (connNameMatch.Length == txtConnName.Text.Length && dsNameMatch.Length == txtDBSource.Text.Length)
                {
                    _ConnName = this.txtConnName.Text;
                    _DSName = this.txtDBSource.Text;
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("No special characters may be used!");
                }
            }
            else
            {
                MessageBox.Show("Each entry must be filled!");
            }
        }
    }
}
