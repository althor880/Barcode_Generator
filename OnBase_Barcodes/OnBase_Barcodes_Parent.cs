using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using OBConnector;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace OnBase_Barcodes
{
    public partial class OnBase_Barcodes_Parent : Form
    {
        private int childFormNumber = 0;
        private OBConnection connector;
        
        public OnBase_Barcodes_Parent()
        {
            InitializeComponent();
            CheckCreateTemp();
        }

        private void CheckCreateTemp()
        {
            if (!(Directory.Exists(Properties.Settings.Default.TempDirectory.ToString())))
            {
                Directory.CreateDirectory(Properties.Settings.Default.TempDirectory.ToString());
            }
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParentStatus.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Connect connForm = Connect.GetChildInstance();
            if (connForm.ShowDialog(this) == DialogResult.OK)
            {
                this.DocListChkLst.Items.Clear();
                this.connector = new OBConnection(connForm.ConnName, connForm.ConnString);
                this.ConnStatusLbl.Text = "Connection Name: " + connForm.ConnName;

                String queryString = "select itemtypenum, trim(itemtypename) from hsi.doctype where itemtypenum in (select itemtypenum from hsi.scanqueuexit) and itemtypegroupnum > 100 order by itemtypename";
                Type[] typeAr = { Type.GetType("System.Int32"), Type.GetType("System.String") };
                System.Data.DataSet DocumentTypes = this.connector.Query(queryString, typeAr);
                System.Data.DataTable DocTypeTable = DocumentTypes.Tables[0];

                for (Int32 x = 0; x < DocTypeTable.Rows.Count; x++)
                {
                    CheckedListBoxItem clbItem = new CheckedListBoxItem((System.String)DocTypeTable.Rows[x][1], System.Decimal.ToInt32((System.Decimal)DocTypeTable.Rows[x][0]));
                    DocListChkLst.Items.Add(clbItem);
                }
            }
        }

        private void GenBarcodeBtn_Click(object sender, EventArgs e)
        {
            if (DocListChkLst.CheckedItems.Count > 0)
            {
                ArrayList docTypeAr = new ArrayList();
                for (Int32 x = 0; x < DocListChkLst.CheckedItems.Count; x++)
                {
                    docTypeAr.Add((CheckedListBoxItem)DocListChkLst.CheckedItems[x]);
                }
                WriteTempPDF(docTypeAr);
                PacketPDFPanel.src = Properties.Settings.Default.TempDirectory + @"\Temp.pdf";
                
            }
            else
            {
                MessageBox.Show("Please check one or more document types");
            }
        }

        private static Bitmap CreateBarcode(String data)
        {
            data = data.ToUpper();
            String dataString = data;

            if (data.Length > 0)
            {
                if (data[0] != '*')
                {
                    data = "*" + data;
                }

                if (data[data.Length - 1] != '*')
                {
                    data = data + "*";
                }
            }

            Bitmap barCode = new Bitmap(1, 1);

            System.Drawing.Font threeOfNine = new System.Drawing.Font("Free 3 of 9", 240, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            System.Drawing.Font timesNR = new System.Drawing.Font("Times New Roman", 80, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

            Graphics graphics = Graphics.FromImage(barCode);

            SizeF dataSize = new SizeF();

            SizeF dataSize_bar = graphics.MeasureString(data, threeOfNine);
            SizeF dataSize_text = graphics.MeasureString(dataString, timesNR);

            if (dataSize_bar.Width > dataSize_text.Width)
            {
                dataSize.Width = dataSize_bar.Width;
            }
            else
            {
                dataSize.Width = dataSize_text.Width;
            }

            dataSize.Height = (dataSize_bar.Height + dataSize_text.Height);

            barCode = new Bitmap(barCode, dataSize.ToSize());

            graphics = Graphics.FromImage(barCode);

            graphics.Clear(Color.White);

            graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixel;

            graphics.DrawString(data, threeOfNine, new SolidBrush(Color.Black), ((dataSize.Width / 2f) - (dataSize_bar.Width / 2f)), 0);
            graphics.DrawString(dataString, timesNR, new SolidBrush(Color.Black), ((dataSize.Width / 2f) - (dataSize_text.Width / 2f)), dataSize_bar.Height);

            graphics.Flush();

            threeOfNine.Dispose();

            graphics.Dispose();

            return barCode;
        }

        private static void WriteTempPDF(ArrayList docTypeArray)
        {
            Document doc = new Document(PageSize.LETTER);
            try
            {
                PdfWriter.GetInstance(doc, new FileStream(Properties.Settings.Default.TempDirectory + @"\Temp.pdf", FileMode.Create));
                doc.Open();

                Bitmap OBSelfConfigBarcode = CreateBarcode("OBSELFCONFIG");
                iTextSharp.text.Image OBSFBBitmap = iTextSharp.text.Image.GetInstance(OBSelfConfigBarcode, System.Drawing.Imaging.ImageFormat.Bmp);
                OBSFBBitmap.ScalePercent(8f);
                OBSFBBitmap.SetAbsolutePosition(30f, doc.PageSize.Height - OBSFBBitmap.ScaledHeight - 30f);

                for (Int32 x = 0; x < docTypeArray.Count; x++)
                {

                    doc.Add(OBSFBBitmap);
                    
                    Bitmap barCode = CreateBarcode(((CheckedListBoxItem)docTypeArray[x]).ItemValue.ToString());
                    iTextSharp.text.Image bitmap = iTextSharp.text.Image.GetInstance(barCode, System.Drawing.Imaging.ImageFormat.Bmp);
                    bitmap.ScalePercent(8f);
                    bitmap.SetAbsolutePosition(doc.PageSize.Width - bitmap.ScaledWidth - 30f, doc.PageSize.Height - bitmap.ScaledHeight - 30f);
                    doc.Add(bitmap);

                    if (x != (docTypeArray.Count - 1))
                    {
                        doc.NewPage();
                    }
                }

            }
            catch (DocumentException dex)
            {
                Console.Write(dex.Message);
            }
            catch (IOException ioex)
            {
                Console.Write(ioex.Message);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            finally
            {
                doc.Close();
            }
        }

    }

    public class CheckedListBoxItem
    {
        private String _DisplayName;
        private Int32 _ItemValue;

        public CheckedListBoxItem(String DisplayName, Int32 ItemValue)
        {
            this._DisplayName = DisplayName;
            this._ItemValue = ItemValue;
        }

        public CheckedListBoxItem(String DisplayName, String ItemValue)
        {
            this._DisplayName = DisplayName;
            Int32.TryParse(ItemValue, out this._ItemValue);
        }

        public String DisplayName
        {
            get { return this._DisplayName; }
        }

        public Int32 ItemValue
        {
            get { return this._ItemValue; }
        }

        public override string ToString()
        {
            return this._DisplayName;
        }

    }
}
