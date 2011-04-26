namespace OnBase_Barcodes
{
    partial class Reorder
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
            this.lstDocTypes = new System.Windows.Forms.ListBox();
            this.btnItemUp = new System.Windows.Forms.Button();
            this.btnItemDown = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstDocTypes
            // 
            this.lstDocTypes.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstDocTypes.FormattingEnabled = true;
            this.lstDocTypes.Location = new System.Drawing.Point(0, 0);
            this.lstDocTypes.Name = "lstDocTypes";
            this.lstDocTypes.Size = new System.Drawing.Size(264, 225);
            this.lstDocTypes.TabIndex = 0;
            // 
            // btnItemUp
            // 
            this.btnItemUp.Location = new System.Drawing.Point(270, 51);
            this.btnItemUp.Name = "btnItemUp";
            this.btnItemUp.Size = new System.Drawing.Size(108, 25);
            this.btnItemUp.TabIndex = 1;
            this.btnItemUp.Text = "Move Item Up";
            this.btnItemUp.UseVisualStyleBackColor = true;
            this.btnItemUp.Click += new System.EventHandler(this.btnItemUp_Click);
            // 
            // btnItemDown
            // 
            this.btnItemDown.Location = new System.Drawing.Point(270, 111);
            this.btnItemDown.Name = "btnItemDown";
            this.btnItemDown.Size = new System.Drawing.Size(108, 23);
            this.btnItemDown.TabIndex = 2;
            this.btnItemDown.Text = "Move Item Down";
            this.btnItemDown.UseVisualStyleBackColor = true;
            this.btnItemDown.Click += new System.EventHandler(this.btnItemDown_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(270, 82);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(108, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove Item";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(270, 193);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(108, 23);
            this.btnContinue.TabIndex = 4;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // Reorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 228);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnItemDown);
            this.Controls.Add(this.btnItemUp);
            this.Controls.Add(this.lstDocTypes);
            this.Name = "Reorder";
            this.Text = "Reorder";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstDocTypes;
        private System.Windows.Forms.Button btnItemUp;
        private System.Windows.Forms.Button btnItemDown;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnContinue;
    }
}