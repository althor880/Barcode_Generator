namespace OnBase_Barcodes
{
    partial class NewConnection
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
            this.txtConnName = new System.Windows.Forms.TextBox();
            this.txtDBSource = new System.Windows.Forms.TextBox();
            this.lblConnName = new System.Windows.Forms.Label();
            this.lblDBSource = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtConnName
            // 
            this.txtConnName.Location = new System.Drawing.Point(150, 18);
            this.txtConnName.Name = "txtConnName";
            this.txtConnName.Size = new System.Drawing.Size(100, 20);
            this.txtConnName.TabIndex = 0;
            // 
            // txtDBSource
            // 
            this.txtDBSource.Location = new System.Drawing.Point(150, 57);
            this.txtDBSource.Name = "txtDBSource";
            this.txtDBSource.Size = new System.Drawing.Size(100, 20);
            this.txtDBSource.TabIndex = 1;
            // 
            // lblConnName
            // 
            this.lblConnName.AutoSize = true;
            this.lblConnName.Location = new System.Drawing.Point(49, 21);
            this.lblConnName.Name = "lblConnName";
            this.lblConnName.Size = new System.Drawing.Size(95, 13);
            this.lblConnName.TabIndex = 2;
            this.lblConnName.Text = "Connection Name:";
            // 
            // lblDBSource
            // 
            this.lblDBSource.AutoSize = true;
            this.lblDBSource.Location = new System.Drawing.Point(43, 60);
            this.lblDBSource.Name = "lblDBSource";
            this.lblDBSource.Size = new System.Drawing.Size(101, 13);
            this.lblDBSource.TabIndex = 3;
            this.lblDBSource.Text = "Data Source Name:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(59, 99);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(158, 98);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // NewConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 141);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblDBSource);
            this.Controls.Add(this.lblConnName);
            this.Controls.Add(this.txtDBSource);
            this.Controls.Add(this.txtConnName);
            this.Name = "NewConnection";
            this.Text = "New Connection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConnName;
        private System.Windows.Forms.TextBox txtDBSource;
        private System.Windows.Forms.Label lblConnName;
        private System.Windows.Forms.Label lblDBSource;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}