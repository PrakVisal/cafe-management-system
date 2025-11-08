using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RMS_Project
{
    public partial class UC_Total : UserControl
    {
        public UC_Total()
        {
            InitializeComponent();
        }

        public string Title
        {
            get { return lblTitle.Text; }
            set { lblTitle.Text = value; }
        }

        public string Value
        {
            get { return lblValue.Text; }
            set { lblValue.Text = value; }
        }

        public Label TitleLabel
        {
            get { return lblTitle; }
        }
      
        public Label ValueLabel
        {
            get { return lblValue; }
        }

        public Label TimePeriodLabel
        {
            get { return lblAllTime; }
        }

    }
}
