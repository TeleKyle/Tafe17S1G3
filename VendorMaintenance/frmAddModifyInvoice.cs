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
    public partial class frmAddModifyInvoice : Form
    {
        public frmAddModifyInvoice()
        {
            InitializeComponent();
        }

        public Invoice invoice;
        public bool addInvoice;
        //public Term term;
        //public Vendor vendors;
        //public String selectedVendorName;
        //public String selectedTermDesc;

        private void frmAddModifyInvoice_Load(object sender, EventArgs e)
        {
            this.LoadComboBoxes();
            if (addInvoice)
            {
                this.Text = "Add Invoice";
                cboTerm.SelectedIndex = -1;
                cboVendor.SelectedIndex = -1;
                
            }
            else
            {
                this.Text = "Modify Invoice";
                this.DisplayInvoiceData();
            }
        }

        private void LoadComboBoxes()
        {
            try
            {
                var term = from Terms in DataContext.payables.Terms
                             orderby Terms.Description
                             select new { Terms.TermsID, Terms.Description };
                cboTerm.DataSource = term;
                cboTerm.DisplayMember = "Description";
                cboTerm.ValueMember = "TermsID";

                var vendors = from Vendors in DataContext.payables.Vendors
                               orderby Vendors.Name
                               select Vendors;
                cboVendor.DataSource = vendors;
                cboVendor.DisplayMember = "Name";
                cboVendor.ValueMember = "VendorID";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void DisplayInvoiceData()
        {
            cboVendor.Text = invoice.Vendor.Name.ToString();
            cboTerm.Text = invoice.Term.Description.ToString();
            txtInvoiceNum.Text = invoice.InvoiceNumber;
            dtiInvoiceDate.Text = invoice.InvoiceDate.ToString();
            txtInvoiceTotal.Text = invoice.InvoiceTotal.ToString();
            txtPaymentTotal.Text = invoice.PaymentTotal.ToString();
            txtCreditTotal.Text = invoice.CreditTotal.ToString();
            dtiDueDate.Text = invoice.DueDate.ToString();
            dtiPaymentDate.Text = invoice.PaymentDate.ToString();
            
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if(IsValidData())
            {
                if (addInvoice)
                {
                    invoice = new Invoice();
                    this.PutInvoiceData(invoice);
                    DataContext.payables.Invoices.InsertOnSubmit(invoice);
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
                    this.PutInvoiceData(invoice);
                    try
                    {
                        DataContext.payables.SubmitChanges();
                        this.DialogResult = DialogResult.OK;
                    }
                    catch(ChangeConflictException)
                    {
                        DataContext.GetCurrentValues();
                        if(DataContext.invoiceDeleted){
                            MessageBox.Show("Another user has deleted " +
                                "that invoice.", "Database Error");
                            this.DialogResult = DialogResult.Abort;
                        }
                        else
                        {
                            MessageBox.Show("Another user has updated " +
                                "that invoice.", "Database Error");
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
            if (Validator.IsPresent(cboVendor) &&
                    Validator.IsPresent(cboTerm) &&
                //Validator.IsPresent(txtInvoiceNum) &&
                    Validator.IsPresent(dtiInvoiceDate) &&
                    Validator.IsPresent(txtInvoiceTotal) &&
                    Validator.IsPresent(txtPaymentTotal) &&
                    Validator.IsPresent(txtCreditTotal) &&
                    Validator.IsPresent(dtiDueDate) &&
                    Validator.IsPresent(dtiPaymentDate))
            {
                return true;
            }
            return false;
        }

        private void PutInvoiceData(Invoice invoice)
        {
            

            invoice.InvoiceNumber = txtInvoiceNum.Text;
            try
            {
                invoice.PaymentTotal = System.Convert.ToDecimal(txtPaymentTotal.Text);
                invoice.InvoiceTotal = System.Convert.ToDecimal(txtInvoiceTotal.Text);
            }
            catch
            {
                MessageBox.Show("Dollar amounts must be a decimal figure (##.##)");
                return;
            }
            invoice.PaymentDate = dtiPaymentDate.Value;
            invoice.DueDate = dtiDueDate.Value;
            invoice.InvoiceDate = dtiInvoiceDate.Value;
            invoice.VendorID = (int)cboVendor.SelectedValue;
            invoice.TermsID = (int)cboTerm.SelectedValue;
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
