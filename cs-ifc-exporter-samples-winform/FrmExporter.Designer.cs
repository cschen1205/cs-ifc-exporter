namespace IfcExport
{
    partial class FrmExporter
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIFC = new System.Windows.Forms.TextBox();
            this.btnBrowseIFC = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source BIM File (IFC Format):";
            // 
            // txtIFC
            // 
            this.txtIFC.Location = new System.Drawing.Point(172, 15);
            this.txtIFC.Name = "txtIFC";
            this.txtIFC.Size = new System.Drawing.Size(392, 20);
            this.txtIFC.TabIndex = 1;
            // 
            // btnBrowseIFC
            // 
            this.btnBrowseIFC.Location = new System.Drawing.Point(582, 13);
            this.btnBrowseIFC.Name = "btnBrowseIFC";
            this.btnBrowseIFC.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseIFC.TabIndex = 2;
            this.btnBrowseIFC.Text = "Browse";
            this.btnBrowseIFC.UseVisualStyleBackColor = true;
            this.btnBrowseIFC.Click += new System.EventHandler(this.btnBrowseIFC_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(24, 61);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(153, 23);
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(198, 61);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessage.Size = new System.Drawing.Size(459, 131);
            this.txtMessage.TabIndex = 4;
            // 
            // FrmExporter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 204);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnBrowseIFC);
            this.Controls.Add(this.txtIFC);
            this.Controls.Add(this.label1);
            this.Name = "FrmExporter";
            this.Text = "IFC Converter";
            this.Load += new System.EventHandler(this.FrmExporter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIFC;
        private System.Windows.Forms.Button btnBrowseIFC;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox txtMessage;
    }
}

