namespace OnBase_Barcodes
{
    partial class OnBase_Barcodes_Parent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OnBase_Barcodes_Parent));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ParentStatus = new System.Windows.Forms.StatusStrip();
            this.ConnStatusLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.DocListChkLst = new System.Windows.Forms.CheckedListBox();
            this.GenBarcodeBtn = new System.Windows.Forms.Button();
            this.PacketPDFPanel = new AxAcroPDFLib.AxAcroPDF();
            this.PDFStatus = new System.Windows.Forms.StatusStrip();
            this.axAcroPDF2 = new AxAcroPDFLib.AxAcroPDF();
            this.menuStrip.SuspendLayout();
            this.ParentStatus.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PacketPDFPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.newConnectionToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(35, 20);
            this.fileMenu.Text = "&File";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.connectToolStripMenuItem.Text = "&Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // newConnectionToolStripMenuItem
            // 
            this.newConnectionToolStripMenuItem.Name = "newConnectionToolStripMenuItem";
            this.newConnectionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newConnectionToolStripMenuItem.Text = "&New Connection";
            this.newConnectionToolStripMenuItem.Click += new System.EventHandler(this.newConnectionToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // ParentStatus
            // 
            this.ParentStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConnStatusLbl});
            this.ParentStatus.Location = new System.Drawing.Point(0, 431);
            this.ParentStatus.Name = "ParentStatus";
            this.ParentStatus.Size = new System.Drawing.Size(632, 22);
            this.ParentStatus.TabIndex = 2;
            this.ParentStatus.Text = "StatusStrip";
            // 
            // ConnStatusLbl
            // 
            this.ConnStatusLbl.Name = "ConnStatusLbl";
            this.ConnStatusLbl.Size = new System.Drawing.Size(184, 17);
            this.ConnStatusLbl.Text = "Connection Name: <No Connection>";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.DocListChkLst);
            this.splitContainer1.Panel1.Controls.Add(this.GenBarcodeBtn);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.PacketPDFPanel);
            this.splitContainer1.Panel2.Controls.Add(this.PDFStatus);
            this.splitContainer1.Size = new System.Drawing.Size(632, 407);
            this.splitContainer1.SplitterDistance = 286;
            this.splitContainer1.TabIndex = 4;
            // 
            // DocListChkLst
            // 
            this.DocListChkLst.CheckOnClick = true;
            this.DocListChkLst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DocListChkLst.FormattingEnabled = true;
            this.DocListChkLst.Location = new System.Drawing.Point(0, 0);
            this.DocListChkLst.Name = "DocListChkLst";
            this.DocListChkLst.Size = new System.Drawing.Size(286, 379);
            this.DocListChkLst.TabIndex = 0;
            // 
            // GenBarcodeBtn
            // 
            this.GenBarcodeBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GenBarcodeBtn.Location = new System.Drawing.Point(0, 385);
            this.GenBarcodeBtn.Name = "GenBarcodeBtn";
            this.GenBarcodeBtn.Size = new System.Drawing.Size(286, 22);
            this.GenBarcodeBtn.TabIndex = 1;
            this.GenBarcodeBtn.Text = "Generate Barcode Packet";
            this.GenBarcodeBtn.UseVisualStyleBackColor = true;
            this.GenBarcodeBtn.Click += new System.EventHandler(this.GenBarcodeBtn_Click);
            // 
            // PacketPDFPanel
            // 
            this.PacketPDFPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PacketPDFPanel.Enabled = true;
            this.PacketPDFPanel.Location = new System.Drawing.Point(0, 0);
            this.PacketPDFPanel.Name = "PacketPDFPanel";
            this.PacketPDFPanel.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("PacketPDFPanel.OcxState")));
            this.PacketPDFPanel.Size = new System.Drawing.Size(342, 385);
            this.PacketPDFPanel.TabIndex = 3;
            // 
            // PDFStatus
            // 
            this.PDFStatus.Location = new System.Drawing.Point(0, 385);
            this.PDFStatus.Name = "PDFStatus";
            this.PDFStatus.Size = new System.Drawing.Size(342, 22);
            this.PDFStatus.TabIndex = 2;
            this.PDFStatus.Text = "statusStrip1";
            // 
            // axAcroPDF2
            // 
            this.axAcroPDF2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axAcroPDF2.Enabled = true;
            this.axAcroPDF2.Location = new System.Drawing.Point(0, 25);
            this.axAcroPDF2.Name = "axAcroPDF2";
            this.axAcroPDF2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF2.OcxState")));
            this.axAcroPDF2.Size = new System.Drawing.Size(342, 357);
            this.axAcroPDF2.TabIndex = 1;
            // 
            // OnBase_Barcodes_Parent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.ParentStatus);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "OnBase_Barcodes_Parent";
            this.Text = "OnBase Barcodes";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ParentStatus.ResumeLayout(false);
            this.ParentStatus.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PacketPDFPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip ParentStatus;
        private System.Windows.Forms.ToolStripStatusLabel ConnStatusLbl;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newConnectionToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF2;
        private System.Windows.Forms.StatusStrip PDFStatus;
        private AxAcroPDFLib.AxAcroPDF PacketPDFPanel;
        private System.Windows.Forms.Button GenBarcodeBtn;
        private System.Windows.Forms.CheckedListBox DocListChkLst;
    }
}



