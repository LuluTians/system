using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASS2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void purchaseReportBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.purchaseReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.adventureWorks2012DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'adventureWorks2012DataSet.PurchaseReport' table. You can move, or remove it, as needed.
            this.purchaseReportTableAdapter.Fill(this.adventureWorks2012DataSet.PurchaseReport);

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            int year = System.Convert.ToInt32(yearText.Text);
            int month = System.Convert.ToInt32(monthText.Text);
            this.queriesTableAdapter1.spCreateReport(year, month);
            this.purchaseReportTableAdapter.Fill(this.adventureWorks2012DataSet.PurchaseReport);
        }
    }
}
