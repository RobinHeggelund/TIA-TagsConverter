using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using System.Media;

namespace TagsConverter
{
    public partial class Form1 : Form
    {
        // UI Colors
        Color Black = Color.FromArgb(0,0, 0);
        Color mediumGray = Color.FromArgb(80, 80, 80);
        Color darkGray = Color.FromArgb(40, 40, 40);
        Color lightGray = Color.FromArgb(224, 224, 224);



        // Custom Boarder (Move window)
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        // Data
        public DataTable dt;
        public DataTableCollection tableCollection;


        // Methods
        private static DataTableCollection ImportExcelFile()
        {
            string filePath;
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx|Excel 97-2003 Workbook|*.xls" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;

                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true },
                            });
                            return result.Tables;
                        }
                    }
                }
                else { return null; }
            }
        }
        private void BindDatasetToView()
        {
            dt = tableCollection[comboBoxTables.SelectedItem.ToString()];
            dataGridViewExcel.DataSource = dt;

            comboBoxName.Items.Clear();
            comboBoxPath.Items.Clear();
            comboBoxDataType.Items.Clear();
            comboBoxLogicalAddress.Items.Clear();
            comboBoxComment.Items.Clear();

            foreach (DataColumn column in dt.Columns)
            {
                comboBoxName.Items.Add(column.ColumnName);
                comboBoxPath.Items.Add(column.ColumnName);
                comboBoxDataType.Items.Add(column.ColumnName);
                comboBoxLogicalAddress.Items.Add(column.ColumnName);
                comboBoxComment.Items.Add(column.ColumnName);
            }

            comboBoxDataType.Items.Add("Set all: Bool");
            comboBoxDataType.Items.Add("Set all: Byte");
        }

        public void ExportToExcelAndDisplay(
                                            DataTable dt,
                                            ComboBox comboBoxName,
                                            ComboBox comboBoxPath,
                                            ComboBox comboBoxDataType,
                                            ComboBox comboBoxLogicalAddress,
                                            ComboBox comboBoxComment,
                                            DataGridView dataGridView1
                                            )
        {
            // Create a new Excel package

            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            using (var package = new ExcelPackage())
            {
                // Add a new worksheet to the Excel package
                var worksheet = package.Workbook.Worksheets.Add("Sheet1");

                // Define new column headers
                string[] columnHeadersDefined = { "Name", "Path", "Data Type", "Logical Address", "Comment" };

                // Define column headers from the ComboBoxes
                string[] columnHeaders = {
                                            comboBoxName.SelectedItem?.ToString(),
                                            comboBoxPath.SelectedItem?.ToString(),
                                            comboBoxDataType.SelectedItem?.ToString(),
                                            comboBoxLogicalAddress.SelectedItem?.ToString(),
                                            comboBoxComment.SelectedItem?.ToString()
                                          };


                // Write column headers to the Excel sheet
                for (int i = 0; i < columnHeaders.Length; i++)
                {
                    worksheet.Cells[1, i + 1].Value = columnHeadersDefined[i];
                }

                // Iterate through the rows of the DataTable and populate the Excel sheet
                int row = 2; // Start from row 2 after the header row
                foreach (DataRow dataRow in dt.Rows)
                {
                    // Write data from corresponding columns in the DataTable to Excel
                    worksheet.Cells[row, 1].Value = dataRow[columnHeaders[0]];
                    worksheet.Cells[row, 2].Value = dataRow[columnHeaders[1]];
                    worksheet.Cells[row, 5].Value = dataRow[columnHeaders[4]];

                    // Handle % for IO 


                    string temp = dataRow[columnHeaders[3]].ToString();

                    if (temp.StartsWith("%"))
                    {
                        worksheet.Cells[row, 4].Value = dataRow[columnHeaders[3]];
                    }

                    else
                    {
                        worksheet.Cells[row, 4].Value = "%" + temp;
                    }


                    // Handle set bool and set bytes
                    if (columnHeaders[2] == "Set all: Bool")
                    {
                        worksheet.Cells[row, 3].Value = "Bool";
                    }

                    else if (columnHeaders[2] == "Set all: Byte")
                    {
                        worksheet.Cells[row, 3].Value = "Byte";
                    }

                    else
                    {
                        worksheet.Cells[row, 3].Value = dataRow[columnHeaders[2]];
                    }

                    row++;
                }

                // Save the Excel package to a file
                using (var saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
                    saveFileDialog.FileName = "ExportedData.xlsx";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        FileInfo fileInfo = new FileInfo(saveFileDialog.FileName);
                        package.SaveAs(fileInfo);
                        MessageBox.Show("Excel file exported successfully.");

                        string excelFilePath = fileInfo.FullName;



                    }
                }




            }
        }



        public Form1()
        {

            InitializeComponent();

            // Handle drag and drop
            panelImportScreen.DragDrop += new DragEventHandler(panelImportScreen_DragDrop);
            panelImportScreen.DragEnter += new DragEventHandler(panelImportScreen_DragEnter);
        }

        // Functional Events

        private void pictureBoxImport_Click(object sender, EventArgs e)
        {
            // Import data from excel file

            tableCollection = ImportExcelFile();


            if (tableCollection != null)
            {
                // Hide import elements

                panelImportScreen.Visible = false;


                // Check tables

                int tableCounter = 0;
                comboBoxTables.Items.Clear();



                foreach (DataTable table in tableCollection)
                {
                    comboBoxTables.Items.Add(table.TableName);
                    tableCounter += 1;

                }

                // Select first item in combobox

                comboBoxTables.SelectedIndex = 0;

                // If there are multiple tables, display table selection

                if (tableCounter > 1)
                {
                    panelTableSelection.Visible = true;

                }

                else

                // Open the file immediatly

                {
                    panelTableSelection.Visible = false;
                    BindDatasetToView();


                }
            }

        }
        private void buttonConvert_Click(object sender, EventArgs e)
        {
            dataGridViewExcel.DataSource = dt;

            if (comboBoxName.Text.Length > 0 && comboBoxPath.Text.Length > 0 && comboBoxDataType.Text.Length > 0 && comboBoxLogicalAddress.Text.Length > 0 && comboBoxComment.Text.Length > 0)
            {

                ExportToExcelAndDisplay(dt, comboBoxName, comboBoxPath, comboBoxDataType, comboBoxLogicalAddress, comboBoxComment, dataGridViewExcel);

            }
            else
            {
                System.Media.SystemSounds.Beep.Play();
            }


        }
        private void panelImportScreen_DragDrop(object sender, DragEventArgs e)
        {
            // Check if the dropped data contains file(s)
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                // Get the list of dropped file paths
                string[] filePaths = (string[])e.Data.GetData(DataFormats.FileDrop);

                // Loop through the dropped files (you can handle multiple files if needed)
                foreach (string filePath in filePaths)
                {
                    // Check if the dropped file is an Excel file
                    if (System.IO.Path.GetExtension(filePath).Equals(".xlsx", StringComparison.OrdinalIgnoreCase) ||
                        System.IO.Path.GetExtension(filePath).Equals(".xls", StringComparison.OrdinalIgnoreCase))
                    {
                        // Process the Excel file here, for example, open and read it

                        using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
                        {
                            using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                            {
                                DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                                {
                                    ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true },
                                });

                                // Import data from excel file
                                tableCollection = result.Tables;


                                if (tableCollection != null)
                                {
                                    // Hide import elements
                                    panelImportScreen.Visible = false;


                                    // Check tables
                                    int tableCounter = 0;
                                    comboBoxTables.Items.Clear();



                                    foreach (DataTable table in tableCollection)
                                    {
                                        comboBoxTables.Items.Add(table.TableName);
                                        tableCounter += 1;

                                    }

                                    // Select first item in combobox
                                    comboBoxTables.SelectedIndex = 0;

                                    // If there are multiple tables, display table selection
                                    if (tableCounter > 1)
                                    {
                                        panelTableSelection.Visible = true;

                                    }

                                    else
                                    // Open the file immediatly

                                    {
                                        panelTableSelection.Visible = false;
                                        BindDatasetToView();


                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please drop an Excel file.");
                    }
                }
            }
        }

        private void panelImportScreen_DragEnter(object sender, DragEventArgs e)
        {
            // Allow the operation to proceed if the data being dragged is a file(s)
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            BindDatasetToView();

            panelTableSelection.Visible = false;

        }
        private void buttonImportAgain_Click(object sender, EventArgs e)
        {
            InvokeOnClick(pictureBoxImport, null);
            panelTableSelection.Visible = true;
        }

        // UI Cosmetic Events
        private void panelBoarder_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }

            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void panelBoarderFullscreen_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }

            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void panelBoarderExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panelBoarderMinimize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
            }

            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            InvokeOnClick(panelBoarderMinimize, null);
        }

        private void pictureBoxFullscreen_Click(object sender, EventArgs e)
        {
            InvokeOnClick(panelBoarderFullscreen, null);
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panelBoarderMinimize_MouseEnter(object sender, EventArgs e)
        {
            panelBoarderMinimize.BackColor = darkGray;
        }

        private void pictureBoxMinimize_MouseEnter(object sender, EventArgs e)
        {
            panelBoarderMinimize.BackColor = darkGray;
        }

        private void panelBoarderFullscreen_MouseEnter(object sender, EventArgs e)
        {
            panelBoarderFullscreen.BackColor = darkGray;
        }

        private void pictureBoxFullscreen_MouseEnter(object sender, EventArgs e)
        {
            panelBoarderFullscreen.BackColor = darkGray;
        }

        private void panelBoarderExit_MouseEnter(object sender, EventArgs e)
        {
            panelBoarderExit.BackColor = darkGray;
        }

        private void pictureBoxExit_MouseEnter(object sender, EventArgs e)
        {
            panelBoarderExit.BackColor = darkGray;
        }

        private void panelBoarderMinimize_MouseLeave(object sender, EventArgs e)
        {
            panelBoarderMinimize.BackColor = Black;
        }

        private void pictureBoxMinimize_MouseLeave(object sender, EventArgs e)
        {
            panelBoarderMinimize.BackColor = Black;
        }

        private void panelBoarderFullscreen_MouseLeave(object sender, EventArgs e)
        {
            panelBoarderFullscreen.BackColor = Black;
        }

        private void pictureBoxFullscreen_MouseLeave(object sender, EventArgs e)
        {
            panelBoarderFullscreen.BackColor = Black;
        }

        private void panelBoarderExit_MouseLeave(object sender, EventArgs e)
        {
            panelBoarderExit.BackColor = Black;
        }

        private void pictureBoxExit_MouseLeave(object sender, EventArgs e)
        {
            panelBoarderExit.BackColor = Black;
        }

        private void panelBoarder_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void panelInputData_Click(object sender, EventArgs e)
        {
            dataGridViewExcel.Visible = true;
            
        }

        private void labelInputData_Click(object sender, EventArgs e)
        {
            dataGridViewExcel.Visible = true;
            
        }

        private void panelOutputData_Click(object sender, EventArgs e)
        {
            dataGridViewExcel.Visible = false;
            
        }

        private void labelOutputData_Click(object sender, EventArgs e)
        {
            dataGridViewExcel.Visible = false;
            
        }

        private void panelInputData_MouseEnter(object sender, EventArgs e)
        {
            panelInputData.BackColor = mediumGray;
        }

        private void labelInputData_MouseEnter(object sender, EventArgs e)
        {
            panelInputData.BackColor = mediumGray;
        }

        private void panelOutputData_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void labelOutputData_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void panelInputData_MouseLeave(object sender, EventArgs e)
        {
            panelInputData.BackColor = lightGray;
        }

        private void labelInputData_MouseLeave(object sender, EventArgs e)
        {
            panelInputData.BackColor = lightGray;
        }

        private void panelOutputData_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void labelOutputData_MouseLeave(object sender, EventArgs e)
        {
            
        }

      


    }
    
}
