using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;

namespace VendorMaintenance
{
    public partial class frmInvoice : Form
    {
        public frmInvoice()
        {
            InitializeComponent();
        }


        public InvoiceLineItem invoiceLineItem;

        public Invoice selectedInvoice;
        public InvoiceLineItem selectedInvoiceLineItem;
        

        /*-----------------------------------------------------------------------
         *      GetInvoice Click
         * ----------------------------------------------------------------------
         * */
        private void btnGetInvoice_Click(object sender, EventArgs e)
        {
            DisplayInvoice();
        }


        /*-----------------------------------------------------------------------
         *      DisplayInvoice
         * ----------------------------------------------------------------------
         * */
        private void DisplayInvoice()
        {

            if (Validator.IsPresent(txtInvoiceID) &&
                Validator.IsInt32(txtInvoiceID))
            {
                try
                {
                    selectedInvoice =
                        (from invoice in DataContext.payables.Invoices
                         where invoice.InvoiceID == Convert.ToInt32(txtInvoiceID.Text)
                         select invoice).Single();
                    

                    //clear listbox
                    listInvoiceSequence.Items.Clear();

                    //add data into textboxes
                    txtVendorID.Text = selectedInvoice.VendorID.ToString();
                    txtInvoiceNum.Text = selectedInvoice.InvoiceNumber;
                    txtInvoiceDate.Text = selectedInvoice.InvoiceDate.ToString();
                    txtInvoiceTotal.Text = selectedInvoice.InvoiceTotal.ToString();
                    txtPaymentTotal.Text = selectedInvoice.PaymentTotal.ToString("C");
                    txtCreditTotal.Text = selectedInvoice.CreditTotal.ToString("C");
                    txtTermsID.Text = selectedInvoice.TermsID.ToString();
                    txtDueDate.Text = selectedInvoice.DueDate.ToString();
                    txtPaymentDate.Text = selectedInvoice.PaymentDate.ToString();
                    int numberInvoiceLineItems = FindNumberOfInvoiceLineItems(selectedInvoice);
                    for (int i = 1; i <= numberInvoiceLineItems; i++)
                    {
                        listInvoiceSequence.Items.Add(i.ToString());

                    }
            

                    listInvoiceSequence.SelectedIndex = 0;

                    btnAddInvSeq.Enabled = true;
                    btnModifyInvSeq.Enabled = true;
                    btnDeleteInvoiceItem.Enabled = true;
                    btnModify.Enabled = true;
                    btnDelete.Enabled = true;
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("No invoice found with this ID. " +
                        "Please try again.", "Invoice Not Found");
                    this.ClearControls();
                    txtVendorID.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }

            
        }

        /*-----------------------------------------------------------------------
         *      Find number of invoice line items
         * ----------------------------------------------------------------------
         * */
        public static int FindNumberOfInvoiceLineItems(Invoice selectedInvoice)
        {
            int numberInvoiceLineItems = (
                    from invoice in DataContext.payables.InvoiceLineItems
                    where invoice.InvoiceID == selectedInvoice.InvoiceID
                    select invoice).Count();
            return numberInvoiceLineItems;
        }

        /*-----------------------------------------------------------------------
         *      Clear controls
         * ----------------------------------------------------------------------
         * */
        private void ClearControls()
        {
            //clear textboxes
            txtVendorID.Text = "";
            txtInvoiceNum.Text = "";
            txtInvoiceDate.Text = "";
            txtInvoiceTotal.Text = "";
            txtPaymentTotal.Text = "";
            txtCreditTotal.Text = "";
            txtTermsID.Text = "";
            txtDueDate.Text = "";
            txtPaymentDate.Text = "";
            txtAccountNum.Text = "";
            txtAmount.Text = "";
            txtDescription.Text = "";

            //disable buttons
            btnAddInvSeq.Enabled = false;
            btnModifyInvSeq.Enabled = false;
            btnDeleteInvoiceItem.Enabled = false;
            btnModify.Enabled = false;
            btnDelete.Enabled = false;
        }

        /*-----------------------------------------------------------------------
         *      list invoice sequence on selection change
         * ----------------------------------------------------------------------
         * */
        private void listInvoiceSequence_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                selectedInvoiceLineItem =
                    (from invoice in DataContext.payables.InvoiceLineItems
                        where invoice.InvoiceID == selectedInvoice.InvoiceID
                        && invoice.InvoiceSequence == listInvoiceSequence.SelectedIndex + 1
                        select invoice).Single();
                this.DisplayInvoiceLineItemDetails();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("No Item found with this ID. " +
                    "Please try again.", "Invoice Line Item Not Found");
                txtVendorID.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        /*-----------------------------------------------------------------------
         *      Display Invoice line item details
         * ----------------------------------------------------------------------
         * */
        private void DisplayInvoiceLineItemDetails()
        {
            txtAccountNum.Text = selectedInvoiceLineItem.AccountNo.ToString();
            txtAmount.Text = selectedInvoiceLineItem.Amount.ToString();
            txtDescription.Text = selectedInvoiceLineItem.Description.ToString();
        }

        /*-----------------------------------------------------------------------
         *      exit click
         * ----------------------------------------------------------------------
         * */
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*-----------------------------------------------------------------------
         *      add click
         * ----------------------------------------------------------------------
         * */
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddModifyInvoice addModifyInvoiceForm = new frmAddModifyInvoice();
            addModifyInvoiceForm.addInvoice = true;
            
            DialogResult result = addModifyInvoiceForm.ShowDialog();
            if(result == DialogResult.OK || result == DialogResult.Retry)
            {
                selectedInvoice = addModifyInvoiceForm.invoice;
                txtInvoiceID.Text = selectedInvoice.InvoiceID.ToString();
                this.DisplayInvoice();
            }
        }

        /*-----------------------------------------------------------------------
         *      add invoice sequence click
         * ----------------------------------------------------------------------
         * */
        private void btnAddInvoiceSeq_Click(object sender, EventArgs e)
        {
            frmAddModifyInvoiceSeq addModifyInvoiceSeqForm = new frmAddModifyInvoiceSeq();
            addModifyInvoiceSeqForm.addInvoiceLineItem = true;
            addModifyInvoiceSeqForm.invoice = selectedInvoice;
            DialogResult result = addModifyInvoiceSeqForm.ShowDialog();
            if (result == DialogResult.OK || result == DialogResult.Retry)
            {
                selectedInvoice = addModifyInvoiceSeqForm.invoice;
                txtInvoiceID.Text = selectedInvoice.InvoiceID.ToString();
                this.DisplayInvoice();
            }
        }

        /*-----------------------------------------------------------------------
         *      delete inv click
         * ----------------------------------------------------------------------
         * */
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result =
                MessageBox.Show("Delete this invoice?",
                "Confirm Delete", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    DataContext.payables.Invoices.DeleteOnSubmit(selectedInvoice);
                    DataContext.payables.SubmitChanges();
                    txtInvoiceID.Text = "";
                    this.ClearControls();
                }
                catch (ChangeConflictException)
                {
                    DataContext.GetCurrentValues();
                    MessageBox.Show("Another user has updated that invoice.",
                        "Database Error");
                    this.DisplayInvoice();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }

        /*-----------------------------------------------------------------------
         *      modify click
         * ----------------------------------------------------------------------
         * */
        private void btnModify_Click(object sender, EventArgs e)
        {
            frmAddModifyInvoice addModifyInvoiceForm = new frmAddModifyInvoice();
            addModifyInvoiceForm.addInvoice = false;
            addModifyInvoiceForm.invoice = selectedInvoice;
            DialogResult result = addModifyInvoiceForm.ShowDialog();
            if (result == DialogResult.OK || result == DialogResult.Retry)
            {
                selectedInvoice = addModifyInvoiceForm.invoice;
                this.DisplayInvoice();
            }
            else if(result == DialogResult.Abort){
                txtVendorID.Text = "";
                this.ClearControls();
            }
        }

        /*-----------------------------------------------------------------------
         *      modify list item click
         * ----------------------------------------------------------------------
         * */
        private void btnModifyListItem_Click(object sender, EventArgs e)
        {
            frmAddModifyInvoiceSeq addModifyInvoiceSeqForm = new frmAddModifyInvoiceSeq();
            addModifyInvoiceSeqForm.addInvoiceLineItem = false;
            addModifyInvoiceSeqForm.invoice = selectedInvoice;
            addModifyInvoiceSeqForm.invoiceLineItem = selectedInvoiceLineItem;
            DialogResult result = addModifyInvoiceSeqForm.ShowDialog();
            if (result == DialogResult.OK || result == DialogResult.Retry)
            {
                txtInvoiceID.Text = selectedInvoice.InvoiceID.ToString();
                this.DisplayInvoice();
            }
            
        }

        /*-----------------------------------------------------------------------
         *      delete list item click
         * ----------------------------------------------------------------------
         * */
        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            DialogResult result =
                MessageBox.Show("Delete this invoice list item?",
                "Confirm Delete", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    DataContext.payables.InvoiceLineItems.DeleteOnSubmit(selectedInvoiceLineItem);
                    DataContext.payables.SubmitChanges();
                    DisplayInvoice();
                }
                catch (ChangeConflictException)
                {
                    DataContext.GetCurrentValues();
                    MessageBox.Show("Another user has updated that invoice.",
                        "Database Error");
                    this.DisplayInvoice();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }
    }
}
