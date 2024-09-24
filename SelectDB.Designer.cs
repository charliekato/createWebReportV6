namespace CreateWebReport
{
    partial class SelectDB
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
            this.lblServerName = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.cboxServerName = new System.Windows.Forms.ComboBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.Location = new System.Drawing.Point(120, 68);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(91, 24);
            this.lblServerName.TabIndex = 0;
            this.lblServerName.Text = "Sever名";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(541, 130);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(68, 50);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cboxServerName
            // 
            this.cboxServerName.FormattingEnabled = true;
            this.cboxServerName.Location = new System.Drawing.Point(231, 60);
            this.cboxServerName.Name = "cboxServerName";
            this.cboxServerName.Size = new System.Drawing.Size(377, 32);
            this.cboxServerName.TabIndex = 3;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(225, 216);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 24);
            this.lblMessage.TabIndex = 4;
            // 
            // SelectDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.cboxServerName);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblServerName);
            this.Name = "SelectDB";
            this.Text = "SelectDB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblServerName;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox cboxServerName;
        private System.Windows.Forms.Label lblMessage;
    }
}