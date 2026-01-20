using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceLineItems
{
    public partial class frmInvoiceLineItems : Form
    {
        public frmInvoiceLineItems()
        {
            InitializeComponent();
        }

        private List<LineItem> lineItems;
        private List<Invoice> invoiceItems;

        private void frmInvoiceLineItems_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mMABooksDataSet.InvoiceLineItems' table. You can move, or remove it, as needed.
            this.invoiceLineItemsTableAdapter.Fill(this.mMABooksDataSet.InvoiceLineItems);
            lineItems = LineItemDB.GetLineItems();
            invoiceItems = InvoiceDB.GetInvoices();

            // query to get all of the line items
            var query =
                from line in lineItems
                join invoice in invoiceItems 
                    on line.InvoiceID equals invoice.InvoiceID
                select new { line, invoice };

            // load the list view
            lvInvoiceLineItems.Items.Clear();

            foreach (var row in query)
            {
                LineItem item = row.line;
                Invoice inv = row.invoice;

                // Add all of the columns to the list view item
                ListViewItem lvi = new ListViewItem(item.InvoiceID.ToString());
                lvi.SubItems.Add(inv.InvoiceDate.ToString("MM/dd/yyyy"));
                lvi.SubItems.Add(inv.InvoiceTotal.ToString());

                lvi.SubItems.Add(item.ProductCode);
                lvi.SubItems.Add(item.UnitPrice.ToString());
                lvi.SubItems.Add(item.Quantity.ToString());
                lvi.SubItems.Add(item.ItemTotal.ToString());

                //Add the full item to the list view
                lvInvoiceLineItems.Items.Add(lvi);
            }


        }

        private void invoiceLineItemsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.invoiceLineItemsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mMABooksDataSet);

        }
    }
}
