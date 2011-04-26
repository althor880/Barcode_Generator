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

        }

        public ArrayList DocTypeAr
        {
            get { return _docTypeAr; }
            set { _docTypeAr = value; }
        }
    }
}
