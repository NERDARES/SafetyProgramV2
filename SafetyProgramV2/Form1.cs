using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;
using System.IO;
using Microsoft.Office.Core;
using Microsoft.Win32;
using Excel = Microsoft.Office.Interop.Excel;

namespace SafetyProgramV2
{
    public partial class SafetyProgramForm : Form
    {
        #region Members

        /// <summary>
        /// Stores all the relevant information from the user input in the form.
        /// </summary>
        private string[] mTexts;
        
        /// <summary>
        /// The excel application.
        /// </summary>
        private Excel.Application mOXLApp = null;

        /// <summary>
        /// The excel workbook we are currently on.
        /// </summary>
        private Excel.Workbook mOXLWorkbook = null;

        /// <summary>
        /// The excel sheet in the workbook.
        /// </summary>
        private Excel.Worksheet mOXLWorksheet = null;

        #endregion

        /// <summary>
        /// Store's the corresponding cell order for the excel document.
        /// </summary>
        public enum Cells { NAME = 1, STUDENTNUM = 2, DATE = 3, DESCRIPTION = 4, RESOLUTION = 5 };

        public SafetyProgramForm()
        {
            InitializeComponent(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Try to get the excel application in the user's computer.
            Type officeType = Type.GetTypeFromProgID("Excel.Application");
            if (officeType == null)
            {
                MessageBox.Show("Microsoft Office Excel could not be found on this computer. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            
        }
        
        #region Buttons

        /// <summary>
        /// Submit's user's data inputted to an excel document.
        /// </summary>
        private void submitBtn_Click(object sender, EventArgs e)
        {
            mTexts = new string[] { nameTxtBox.Text, stdNumericUpDown.Value.ToString(), dateTimePicker.Text, descriptionRichTxtBox.Text, resolutionRichTxtBox.Text };

            foreach(string text in mTexts)
            {
                if (text == "")
                {
                    MessageBox.Show("Please fill all entries");
                    return;
                }
            }

            WriteToExcelDocument();
        }
        
        /// <summary>
        /// Create's an excel document.
        /// </summary>
        private void createBtn_Click(object sender, EventArgs e)
        {
            CreateExcelDocument();
        }

        #endregion

        #region Excel methods

        /// <summary>
        /// Creates the new excel document if it hasn't been created already.
        /// </summary>
        public void CreateExcelDocument()
        {
            #region Create Excel Neccesities

            mOXLApp = new Excel.Application { DisplayAlerts = false };
            mOXLWorkbook = mOXLApp.Workbooks.Add("");
            mOXLWorksheet = (Excel.Worksheet)mOXLWorkbook.ActiveSheet;

            #endregion

            #region Populate title cells

            mOXLWorksheet.Cells[1, Cells.NAME] = "Name";
            mOXLWorksheet.Cells[1, Cells.STUDENTNUM] = "Student Number";
            mOXLWorksheet.Cells[1, Cells.DATE] = "Date";
            mOXLWorksheet.Cells[1, Cells.DESCRIPTION] = "Description";
            mOXLWorksheet.Cells[1, Cells.RESOLUTION] = "Resolution";

            mOXLWorksheet.Columns.AutoFit();
            #endregion
            
            #region Create Save File Dialog
            
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Filter = "Excel files (*.xlsx)|*.xlsx",
                FilterIndex = 0,
                RestoreDirectory = true,
                CreatePrompt = true,
                Title = "Save excel file as..."
            };

            #endregion

            #region Save Excel

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                //oXLWorkBook.ChangeFileAccess(Excel.XlFileAccess.xlReadWrite);
                mOXLWorkbook.SaveAs(saveFileDialog.FileName);
                mOXLWorkbook.Close();
                mOXLApp.Quit();
                CloseExcelDocument();
            }

            #endregion
        }

        /// <summary>
        /// Writes to an existing excel document.
        /// </summary>
        public void WriteToExcelDocument()
        {
            mOXLApp = new Excel.Application { DisplayAlerts = false };

            #region Create an Open File Dialog

            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel files (*.xlsx)|*.xlsx",
                FilterIndex = 0,
                RestoreDirectory = true,
                Title = "Open an existing excel file"
            };

            #endregion

            #region Use the selected file to populate

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                mOXLWorkbook = mOXLApp.Workbooks.Open(openFileDialog.FileName, 0, false, 5, "", "", false, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "", true,
                     false, 0, true, false, false);

                mOXLWorksheet = (Excel.Worksheet)mOXLWorkbook.ActiveSheet;

                Excel.Range range = mOXLWorksheet.UsedRange;
                int rowCount = range.Rows.Count;

                #region Populate Cells

                mOXLWorksheet.Cells[rowCount + 1, Cells.NAME] = mTexts[0];
                mOXLWorksheet.Cells[rowCount + 1, Cells.STUDENTNUM] = mTexts[1];
                mOXLWorksheet.Cells[rowCount + 1, Cells.DATE] = mTexts[2];
                mOXLWorksheet.Cells[rowCount + 1, Cells.DESCRIPTION] = mTexts[3];
                mOXLWorksheet.Cells[rowCount + 1, Cells.RESOLUTION] = mTexts[4];

                #endregion

                mOXLWorksheet.Columns.AutoFit();
            }

            #endregion

            #region Save Excel

            mOXLWorkbook.SaveAs(openFileDialog.FileName);
            mOXLWorkbook.Close();
            mOXLApp.Quit();
            CloseExcelDocument();

            #endregion

            #region Clear Forms

            nameTxtBox.Text = "";
            stdNumericUpDown.Value = 0;
            dateTimePicker.ResetText();
            descriptionRichTxtBox.Text = "";
            resolutionRichTxtBox.Text = "";

            #endregion
        }

        /// <summary>
        /// Closes the application, workbook and worksheet.
        /// </summary>
        public void CloseExcelDocument()
        {
            mOXLWorksheet = null;
            mOXLWorkbook = null;
            mOXLApp = null;

            GC.WaitForPendingFinalizers();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }

        #endregion
    }
}
