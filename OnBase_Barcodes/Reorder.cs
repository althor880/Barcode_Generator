using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OnBase_Barcodes
{
    public partial class Reorder : Form
    {
        private ArrayList _docTypeAr;

        public Reorder(ArrayList docTypeAr)
        {
            InitializeComponent();
            _docTypeAr = docTypeAr;
            LoadDocTypeList();
        }

        private void LoadDocTypeList()
        {
            for (Int32 x = 0; x < _docTypeAr.Count; x++)
            {
                lstDocTypes.Items.Add(_docTypeAr[x]);
            }
        }

        public ArrayList DocTypeAr
        {
            get { return _docTypeAr; }
            set { _docTypeAr = value; }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            _docTypeAr = new ArrayList();
            for (Int32 x = 0; x < lstDocTypes.Items.Count; x++ )
            {
                _docTypeAr.Add(lstDocTypes.Items[x]);
            }
            if (_docTypeAr.Count > 0)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("You have removed all items! Please reselect, and try again.");
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lstDocTypes.Items.RemoveAt(lstDocTypes.SelectedIndex);
        }

        private void btnItemUp_Click(object sender, EventArgs e)
        {
            Int32 i = lstDocTypes.SelectedIndex;
            if (i > 0)
            {
                CheckedListBoxItem docType = (CheckedListBoxItem)lstDocTypes.Items[i];
                lstDocTypes.Items.RemoveAt(i);
                lstDocTypes.Items.Insert(i - 1, docType);
                lstDocTypes.SelectedIndex = i - 1;
            }
            else
            {
                lstDocTypes.SelectedIndex = i;
            }
        }

        private void btnItemDown_Click(object sender, EventArgs e)
        {
            Int32 i = lstDocTypes.SelectedIndex;
            if (i < lstDocTypes.Items.Count - 1)
            {
                CheckedListBoxItem docType = (CheckedListBoxItem)lstDocTypes.Items[i];
                lstDocTypes.Items.RemoveAt(i);
                lstDocTypes.Items.Insert(i + 1, docType);
                lstDocTypes.SelectedIndex = i + 1;
            }
            else
            {
                lstDocTypes.SelectedIndex = i;
            }
        }
    }
}
