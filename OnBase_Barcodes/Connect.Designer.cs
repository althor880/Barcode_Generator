namespace OnBase_Barcodes
{
    partial class Connect
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
            this.ConnectionsCbo = new System.Windows.Forms.ComboBox();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.ChooseConnectionLbl = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.onBaseBarcodesParentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.onBaseBarcodesParentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ConnectionsCbo
            // 
            this.ConnectionsCbo.FormattingEnabled = true;
            this.ConnectionsCbo.Location = new System.Drawing.Point(128, 16);
            this.ConnectionsCbo.Name = "ConnectionsCbo";
            this.ConnectionsCbo.Size = new System.Drawing.Size(257, 21);
            this.ConnectionsCbo.TabIndex = 0;
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Location = new System.Drawing.Point(391, 14);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(75, 23);
            this.ConnectBtn.TabIndex = 1;
            this.ConnectBtn.Text = "&Connect";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // ChooseConnectionLbl
            // 
            this.ChooseConnectionLbl.AutoSize = true;
            this.ChooseConnectionLbl.Location = new System.Drawing.Point(17, 19);
            this.ChooseConnectionLbl.Name = "ChooseConnectionLbl";
            this.ChooseConnectionLbl.Size = new System.Drawing.Size(105, 13);
            this.ChooseConnectionLbl.TabIndex = 2;
            this.ChooseConnectionLbl.Text = "Select a connection:";
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(472, 14);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 3;
            this.CancelBtn.Text = "C&ancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // onBaseBarcodesParentBindingSource
            // 
            this.onBaseBarcodesParentBindingSource.DataSource = typeof(OnBase_Barcodes.OnBase_Barcodes_Parent);
            // 
            // Connect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 50);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.ChooseConnectionLbl);
            this.Controls.Add(this.ConnectBtn);
            this.Controls.Add(this.ConnectionsCbo);
            this.Name = "Connect";
            this.Text = "Connect";
            ((System.ComponentModel.ISupportInitialize)(this.onBaseBarcodesParentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ConnectionsCbo;
        private System.Windows.Forms.BindingSource onBaseBarcodesParentBindingSource;
        private System.Windows.Forms.Button ConnectBtn;
        private System.Windows.Forms.Label ChooseConnectionLbl;
        private System.Windows.Forms.Button CancelBtn;
    }
}