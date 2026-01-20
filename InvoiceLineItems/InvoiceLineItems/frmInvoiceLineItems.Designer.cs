namespace InvoiceLineItems
{
    partial class frmInvoiceLineItems
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lvInvoiceLineItems = new System.Windows.Forms.ListView();
            this.InvoiceID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InvoiceDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InvoiceTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UnitPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ItemTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mMABooksDataSet = new InvoiceLineItems.MMABooksDataSet();
            this.invoiceLineItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceLineItemsTableAdapter = new InvoiceLineItems.MMABooksDataSetTableAdapters.InvoiceLineItemsTableAdapter();
            this.tableAdapterManager = new InvoiceLineItems.MMABooksDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.mMABooksDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceLineItemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lvInvoiceLineItems
            // 
            this.lvInvoiceLineItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.InvoiceID,
            this.InvoiceDate,
            this.InvoiceTotal,
            this.ProductCode,
            this.UnitPrice,
            this.Quantity,
            this.ItemTotal});
            this.lvInvoiceLineItems.HideSelection = false;
            this.lvInvoiceLineItems.Location = new System.Drawing.Point(12, 12);
            this.lvInvoiceLineItems.Name = "lvInvoiceLineItems";
            this.lvInvoiceLineItems.Size = new System.Drawing.Size(611, 417);
            this.lvInvoiceLineItems.TabIndex = 0;
            this.lvInvoiceLineItems.UseCompatibleStateImageBehavior = false;
            this.lvInvoiceLineItems.View = System.Windows.Forms.View.Details;
            // 
            // InvoiceID
            // 
            this.InvoiceID.Text = "InvoiceID";
            this.InvoiceID.Width = 74;
            // 
            // InvoiceDate
            // 
            this.InvoiceDate.Text = "InvoiceDate";
            this.InvoiceDate.Width = 85;
            // 
            // InvoiceTotal
            // 
            this.InvoiceTotal.Text = "InvoiceTotal";
            this.InvoiceTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.InvoiceTotal.Width = 81;
            // 
            // ProductCode
            // 
            this.ProductCode.Text = "ProductCode";
            this.ProductCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProductCode.Width = 91;
            // 
            // UnitPrice
            // 
            this.UnitPrice.Text = "UnitPrice";
            this.UnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.UnitPrice.Width = 86;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Quantity";
            this.Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Quantity.Width = 76;
            // 
            // ItemTotal
            // 
            this.ItemTotal.Text = "ItemTotal";
            this.ItemTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ItemTotal.Width = 87;
            // 
            // mMABooksDataSet
            // 
            this.mMABooksDataSet.DataSetName = "MMABooksDataSet";
            this.mMABooksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invoiceLineItemsBindingSource
            // 
            this.invoiceLineItemsBindingSource.DataMember = "InvoiceLineItems";
            this.invoiceLineItemsBindingSource.DataSource = this.mMABooksDataSet;
            // 
            // invoiceLineItemsTableAdapter
            // 
            this.invoiceLineItemsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.InvoiceLineItemsTableAdapter = this.invoiceLineItemsTableAdapter;
            this.tableAdapterManager.InvoicesTableAdapter = null;
            this.tableAdapterManager.OrderOptionsTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.StatesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = InvoiceLineItems.MMABooksDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmInvoiceLineItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 449);
            this.Controls.Add(this.lvInvoiceLineItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmInvoiceLineItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice Line Items by Invoice Date";
            this.Load += new System.EventHandler(this.frmInvoiceLineItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mMABooksDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceLineItemsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvInvoiceLineItems;
        private System.Windows.Forms.ColumnHeader InvoiceID;
        private System.Windows.Forms.ColumnHeader ProductCode;
        private System.Windows.Forms.ColumnHeader UnitPrice;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader ItemTotal;
        private MMABooksDataSet mMABooksDataSet;
        private System.Windows.Forms.BindingSource invoiceLineItemsBindingSource;
        private MMABooksDataSetTableAdapters.InvoiceLineItemsTableAdapter invoiceLineItemsTableAdapter;
        private MMABooksDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ColumnHeader InvoiceDate;
        private System.Windows.Forms.ColumnHeader InvoiceTotal;
    }
}

