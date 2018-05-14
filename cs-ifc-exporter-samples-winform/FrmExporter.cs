using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IfcExport
{
    public partial class FrmExporter : Form
    {
        delegate void StringArgReturningVoidDelegate(string text);

        public FrmExporter()
        {
            InitializeComponent();
        }

        private void btnBrowseIFC_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "IFC Files|*.ifc";
            openFileDialog1.Title = "Select an IFC File";

            string currentDir = Directory.GetCurrentDirectory();

            // Show the Dialog.  
            // If the user clicked OK in the dialog and  
            // a .CUR file was selected, open it.  
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Directory.SetCurrentDirectory(currentDir);
                // Assign the cursor in the Stream to the Form's Cursor property.  
                txtIFC.Text = openFileDialog1.FileName;
            } else
            {
                Directory.SetCurrentDirectory(currentDir);
            }
        }

        private void btnConvertToObj_Click(object sender, EventArgs e)
        {
            Convert2Obj();
        }

        private void Convert2Obj()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "OBJ Files|*.obj";
            saveFileDialog.Title = "Export As";

            string currentDir = Directory.GetCurrentDirectory();

            txtMessage.Text = "";
           

            // Show the Dialog.  
            // If the user clicked OK in the dialog and  
            // a .CUR file was selected, open it.  
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Directory.SetCurrentDirectory(currentDir);
                // Assign the cursor in the Stream to the Form's Cursor property.  
                string outputFilePath = saveFileDialog.FileName;

                if (File.Exists(outputFilePath))
                {
                    File.Delete(outputFilePath);
                }

                Thread thread = new Thread(() =>
                {
                    IfcConvert.Convert(txtIFC.Text, outputFilePath, message =>
                    {
                        AppendText(message);
                    });
                });

                thread.Start();
                
            }
            else
            {
                Directory.SetCurrentDirectory(currentDir);
            }
        }

        private void FrmExporter_Load(object sender, EventArgs e)
        {
            txtIFC.Text = Path.Combine(IOUtils.AssemblyDirectory, "..", "..", "sample.ifc");
        }

        private void AppendText(string message)
        {
            // InvokeRequired required compares the thread ID of the  
            // calling thread to the thread ID of the creating thread.  
            // If these threads are different, it returns true.  
            if (this.txtMessage.InvokeRequired)
            {
                StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(AppendText);
                this.Invoke(d, new object[] { message });
            }
            else
            {
                txtMessage.Text += message + "\r\n";
            }
        }
    }
}
