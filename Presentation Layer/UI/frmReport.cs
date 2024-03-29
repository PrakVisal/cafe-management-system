using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using ClosedXML.Excel;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using iText.Layout.Properties;
using System.Drawing.Printing;
using RMS_Project.Business_Layer;

namespace RMS_Project
{
    public partial class frmReport : Form
    {
        
        private ReportManager reportManager;
        public frmReport()
        {
            InitializeComponent();
            btnAccount.Text = SharedData.CurrentUsername;
            reportManager = new ReportManager();
        }
        

        private void frmReport_Load(object sender, EventArgs e)
        {
            LoadInvoiceList();
        }

        private void LoadInvoiceList()
        {
            DataTable dataTable = reportManager.GetInvoiceList();
            LoadDataToDataGridView(dataTable);
        }

        private void LoadStockInReport()
        {
            DataTable dataTable = reportManager.GetStockInReport();
            LoadDataToDataGridView(dataTable);
        }

        private void LoadStockOutReport()
        {
            DataTable dataTable = reportManager.GetStockOutReport();
            LoadDataToDataGridView(dataTable);
        }

        private void LoadStockCountReport()
        {
            DataTable dataTable = reportManager.GetStockCountReport();
            LoadDataToDataGridView(dataTable);
        }

        private void LoadStockAlertReport()
        {
            DataTable dataTable = reportManager.GetStockAlertReport();
            LoadDataToDataGridView(dataTable);
        }

        private void LoadDataToDataGridView(DataTable dataTable)
        {
            try
            {
                dgv.DataSource = dataTable;
                CustomizeDataGridViewAppearance();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }


        private void cboRole_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            switch (cboRole.SelectedItem.ToString())
            {
                case "Invoice List":
                    LoadInvoiceList();
                    CustomizeDataGridViewAppearance();
                    break;
                case "Stock IN Report":
                    LoadStockInReport();
                    CustomizeDataGridViewAppearance();
                    break;
                case "Stock OUT Report":
                    LoadStockOutReport();
                    CustomizeDataGridViewAppearance();
                    break;
                case "Stock Count Report":
                    LoadStockCountReport();
                    CustomizeDataGridViewAppearance();
                    break;
                case "Stock Alert Report":
                    LoadStockAlertReport();
                    break;
                default:
                    break;
            }
        }
        private void CustomizeDataGridViewAppearance()
        {
            // Set column header height
            dgv.ColumnHeadersHeight = 60;

            // Set default cell height
            dgv.RowTemplate.Height = 40;

            // Set font size and font family for column headers and cell values
            System.Drawing.Font headerFont = new System.Drawing.Font("Poppins", 14);
            dgv.ColumnHeadersDefaultCellStyle.Font = headerFont;
            dgv.DefaultCellStyle.Font = new System.Drawing.Font("Poppins", 12);
            dgv.AlternatingRowsDefaultCellStyle.Font = new System.Drawing.Font("Poppins", 12);

            // Set column header color and text color
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(75, 103, 89);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            // Refresh the DataGridView to apply the changes
            dgv.Refresh();
        }

        private int excelCounter = 1;
        private int pdfCounter = 1;

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Sheet1");

                    // Get the DataGridView headers
                    for (int i = 0; i < dgv.Columns.Count; i++)
                    {
                        worksheet.Cell(1, i + 1).Value = dgv.Columns[i].HeaderText;
                    }

                    // Get the DataGridView data
                    for (int i = 0; i < dgv.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgv.Columns.Count; j++)
                        {
                            worksheet.Cell(i + 2, j + 1).Value = dgv.Rows[i].Cells[j].Value.ToString();
                        }
                    }

                    // Save the Excel file with a unique name
                    string fileName = $"ReportData{excelCounter}.xlsx";
                    string filePath = Path.Combine(@"C:\Users\siv naysim\OneDrive\Documents\", fileName);
                    workbook.SaveAs(filePath);
                    MessageBox.Show($"Excel file '{fileName}' saved successfully.");

                    excelCounter++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting to Excel: " + ex.Message);
            }
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            try
            {
                // Creating DataTable to hold the data
                DataTable dataTable = new DataTable();

                // Adding columns to the DataTable
                foreach (DataGridViewColumn column in dgv.Columns)
                {
                    dataTable.Columns.Add(column.HeaderText);
                }

                // Adding rows to the DataTable
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    DataRow dataRow = dataTable.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        dataRow[cell.ColumnIndex] = cell.Value;
                    }
                    dataTable.Rows.Add(dataRow);
                }

                // Exporting DataTable to PDF with a unique name
                string fileName = $"ReportData{pdfCounter}.pdf";
                string filePath = Path.Combine(@"C:\Users\siv naysim\OneDrive\Documents\", fileName);
                using (FileStream stream = new FileStream(filePath, FileMode.Create))
                {
                    Document pdfDoc = new Document();
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    PdfPTable pdfTable = new PdfPTable(dataTable.Columns.Count);
                    foreach (DataColumn column in dataTable.Columns)
                    {
                        pdfTable.AddCell(new Phrase(column.ColumnName));
                    }

                    foreach (DataRow row in dataTable.Rows)
                    {
                        foreach (var cell in row.ItemArray)
                        {
                            pdfTable.AddCell(new Phrase(cell.ToString()));
                        }
                    }

                    pdfDoc.Add(pdfTable);
                    pdfDoc.Close();
                    stream.Close();

                    MessageBox.Show($"PDF file '{fileName}' saved successfully.", "Export to PDF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                pdfCounter++;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting to PDF: " + ex.Message, "Export to PDF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnPrint_Click(object sender, EventArgs e)
        {

            try
            {
                // Create a PrintDocument
                PrintDocument printDocument = new PrintDocument();
                printDocument.PrintPage += printDocument1_PrintPage;

                // Show print dialog
                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = printDocument;
                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument.Print();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error printing: " + ex.Message, "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                // Set up print page settings
                int marginLeft = e.MarginBounds.Left;
                int marginTop = e.MarginBounds.Top;
                int marginRight = e.MarginBounds.Right;
                int marginBottom = e.MarginBounds.Bottom;
                int cellPadding = 5;

                // Determine row height based on font size
                int rowHeight = (int)(dgv.Font.GetHeight() + cellPadding * 2);

                // Calculate column widths
                int[] columnWidths = new int[dgv.Columns.Count];
                int totalWidth = 0;
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    columnWidths[i] = dgv.Columns[i].Width;
                    totalWidth += columnWidths[i];
                }

                // Calculate total table width and scale column widths to fit page
                float scale = (float)(marginRight - marginLeft) / totalWidth;
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    columnWidths[i] = (int)(columnWidths[i] * scale);
                }

                // Draw table headers
                int x = marginLeft;
                int y = marginTop;
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    e.Graphics.DrawString(dgv.Columns[i].HeaderText, dgv.Font, Brushes.Black, new System.Drawing.Rectangle(x, y, columnWidths[i], rowHeight), StringFormat.GenericDefault);
                    x += columnWidths[i];
                }
                y += rowHeight;

                // Draw table rows
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    x = marginLeft;
                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        e.Graphics.DrawString(dgv.Rows[i].Cells[j].Value.ToString(), dgv.Font, Brushes.Black, new System.Drawing.Rectangle(x, y, columnWidths[j], rowHeight), StringFormat.GenericDefault);
                        x += columnWidths[j];
                    }
                    y += rowHeight;
                }

                e.HasMorePages = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error printing: " + ex.Message, "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAccount_Click_1(object sender, EventArgs e)
        {
            FormHelper.AccountButton_Click(sender, e);
        }
    }

    
    
}
