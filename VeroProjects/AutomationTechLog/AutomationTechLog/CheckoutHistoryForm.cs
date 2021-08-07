using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Runtime.InteropServices;

namespace AutomationTechLog
{
    public partial class CheckoutHistoryForm : Form
    {
        public sqlLiteMethods DBConn = new sqlLiteMethods();

        private const int HT_CAPTION = 0x2;

        private const int HT_CLIENT = 0x1;

        // Allows moving window by holding down left mouse button
        private const int WM_NCHITTEST = 0x84;
        DataTable historyTable = new DataTable();
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST) m.Result = (IntPtr)(HT_CAPTION);
        }

        public CheckoutHistoryForm()
        {
            InitializeComponent();
            historyTable = DBConn.getTable("TECHLOG_CHECKOUT");
            historyDataGridView.DataSource = historyTable;
            historyDataGridView.RowHeadersWidth = 4;
            historyDataGridView.Columns["tlc_ref"].Visible = false;

            historyDataGridView.Columns["tlt_name"].HeaderText = "Tech Name";
            historyDataGridView.Columns["tlt_auname"].HeaderText = "Tech ID";
            historyDataGridView.Columns["tlinv_partnumber"].HeaderText = "Part #";
            historyDataGridView.Columns["tlinv_desc"].HeaderText = "Part Description";
            historyDataGridView.Columns["tlc_qty"].HeaderText = "Qty";
            historyDataGridView.Columns["tlc_date"].HeaderText = "Date";
            historyDataGridView.Columns["tlc_qty"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            historyDataGridView.Columns["tlc_qty"].Width = 60;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
