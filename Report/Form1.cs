using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Report
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mushtaqdbDataSet.MT_Report' table. You can move, or remove it, as needed.
            this.MT_ReportTableAdapter.Fill(this.mushtaqdbDataSet.MT_Report);

            this.reportViewer1.RefreshReport();
        }
    }
}
