using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IfcExport
{
    public partial class FrmExporter : Form
    {
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
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "IFC Files|*.ifc";
            saveFileDialog.Title = "Select an IFC File";

            string currentDir = Directory.GetCurrentDirectory();

            // Show the Dialog.  
            // If the user clicked OK in the dialog and  
            // a .CUR file was selected, open it.  
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Directory.SetCurrentDirectory(currentDir);
                // Assign the cursor in the Stream to the Form's Cursor property.  
                string outputFilePath = saveFileDialog.FileName;

                IfcConvert.Convert(txtIFC.Text, outputFilePath, message =>
                {

                });
            }
            else
            {
                Directory.SetCurrentDirectory(currentDir);
            }
        }
    }
}
