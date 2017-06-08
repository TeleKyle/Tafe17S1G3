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
    public partial class frmAddModifyInvoiceSeq : Form
    {
        public frmAddModifyInvoiceSeq()
        {
            InitializeComponent();
        }

        public bool addInvoiceLineItem;
        public InvoiceLineItem invoiceLineItem;
        public Invoice invoice;

        private void frmAddModifyInvoiceLineItem_Load(object sender, EventArgs e)
        {
            this.LoadComboBox();
            //txtInvoiceSequence.Text = invoice.FindNumberOfInvoiceLineItems().ToString();
            txtInvoiceNumber.Text = invoice.InvoiceNumber.ToString();

            if (addInvoiceLineItem)
            {
                this.Text = "Add Invoice Line Item";
                cboAccountNum.SelectedIndex = -1;
                txtInvoiceSequence.Text = 
                    (frmInvoice.FindNumberOfInvoiceLineItems(invoice) + 1).ToString();
            }
            else
            {
                this.Text = "Modify Invoice Line Item";
                txtInvoiceSequence.Text = invoiceLineItem.InvoiceSequence.ToString();
                cboAccountNum.Text = invoiceLineItem.AccountNo.ToString();
                txtAmount.Text = invoiceLineItem.Amount.ToString();
                txtDescription.Text = invoiceLineItem.Description.ToString();
            }
        }

        private void LoadComboBox()
        {
            try
            {
                var account = from GLAccount in DataContext.payables.GLAccounts
                           orderby GLAccount.Description
                           select GLAccount;
                cboAccountNum.DataSource = account;
                cboAccountNum.DisplayMember = "AccountNo";
                cboAccountNum.ValueMember = "AccountNo";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                if (addInvoiceLineItem)
                {
                    invoiceLineItem = new InvoiceLineItem();
                    this.PutInvoiceLineItemData(invoiceLineItem);
                    DataContext.payables.InvoiceLineItems.InsertOnSubmit(invoiceLineItem);
                    try
                    {
                        DataContext.payables.SubmitChanges();
                        this.DialogResult = DialogResult.OK;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
                else
                {
                    this.PutInvoiceLineItemData(invoiceLineItem);
                    try
                    {
                        DataContext.payables.SubmitChanges();
                        this.DialogResult = DialogResult.OK;
                    }
                    catch (ChangeConflictException)
                    {
                        DataContext.GetCurrentValues();
                        if (DataContext.vendorDeleted)
                        {
                            MessageBox.Show("Another user has deleted " +
                                "that Invoice Line Item.", "Database Error");
                            this.DialogResult = DialogResult.Abort;
                        }
                        else
                        {
                            MessageBox.Show("Another user has updated " +
                                "that Invoice Line Item.", "Database Error");
                            this.DialogResult = DialogResult.Retry;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
            }
        }

        private bool IsValidData()
        {
            if (Validator.IsPresent(txtInvoiceSequence) &&
                    Validator.IsPresent(cboAccountNum) &&
                    Validator.IsPresent(txtAmount) &&
                    Validator.IsPresent(txtDescription)) 
            {
                return true;
            }
            return false;
        }

        private void PutInvoiceLineItemData(InvoiceLineItem invoiceLineItem) 
        { 
            invoiceLineItem.InvoiceID = invoice.InvoiceID;
            invoiceLineItem.AccountNo = System.Convert.ToInt32(cboAccountNum.Text);
            invoiceLineItem.Amount = System.Convert.ToDecimal(txtAmount.Text);
            invoiceLineItem.Description = txtDescription.Text;


        }



    }
}
