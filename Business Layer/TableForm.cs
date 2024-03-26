using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Data.Common;

namespace RMS_Project
{
    public class TableForm: Form
    {
        private DataTable dataTable;
        private DataGridView dataGridView;

        public TableForm(DataTable table)
        {
            InitializeComponents();
            dataTable = table;
            LoadTable();
        }
        private void InitializeComponents()
        {
            dataGridView = new DataGridView();
            dataGridView.Dock = DockStyle.Fill;
            this.Controls.Add(dataGridView);
            this.Load += TableForm_Load;
        }

        private void LoadTable()
        {
            dataGridView.DataSource = dataTable;
        }


        private void TableForm_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = dataTable;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Auto size columns to fill the width
            dataGridView.AllowUserToAddRows = false; // Hide the last empty row
            dataGridView.RowHeadersVisible = false; // Hide row headers
            dataGridView.AllowUserToResizeRows = false; // Disable resizing rows
            dataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True; // Wrap text in cells
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells; // Auto size rows to fit cell content
            dataGridView.ScrollBars = ScrollBars.Vertical;

            // Calculate the size for the DataGridView to be 50% of the screen width and 100% of the screen height
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;
            int formWidth = screenWidth / 2;
            int formHeight = screenHeight / 2;

            // Set the size of the form
            this.Size = new System.Drawing.Size(formWidth, formHeight);

            // Set the font size and font family for the DataGridView
            dataGridView.DefaultCellStyle.Font = new Font("Poppins", 12);
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Poppins", 12);

            // Center the DataGridView within the form
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AllowUserToAddRows = false;

            // Set the DataSource for the DataGridView
            dataGridView.DataSource = dataTable;

            // Increase the height of the column headers
            dataGridView.ColumnHeadersHeight = 50;

            // Calculate the center position for the DataGridView
            int x = (this.ClientSize.Width - dataGridView.Width) / 2;
            int y = (this.ClientSize.Height - dataGridView.Height) / 2;

            // Set the location of the DataGridView
            dataGridView.Location = new Point(x, y);

            // Create a DataGridViewCellStyle object for the column headers
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.BackColor = Color.FromArgb(172, 181, 160); // Set the desired color
            columnHeaderStyle.Font = new Font("Poppins", 12, FontStyle.Bold); // Set the font and size
            dataGridView.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

        }
    }
}
