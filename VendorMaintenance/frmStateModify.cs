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
    public partial class frmStateModify : Form
    {
        public frmStateModify()
        {
            InitializeComponent();
        }

        public bool addState;
        public State state;

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void frmStateModify_Load(object sender, EventArgs e)
        {
            if (addState)
            {
                this.Text = "Add State";
            }
            else
            {
                this.Text = "Modify Stater";
                this.DisplayStateData();
            }
        }

        private void DisplayStateData()
        {
            txtStateCode.Text = state.StateCode;
            txtStateName.Text = state.StateName;
            txtPost.Text = Convert.ToString(state.FirstZipCode);
            txtPostLast.Text = Convert.ToString(state.LastZipCode);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                if (addState)
                {
                    state = new State();
                    this.PutStateData(state);
                    DataContext.payables.States.InsertOnSubmit(state);
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
                    this.PutStateData(state);
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
                                "that vendor.", "Database Error");
                            this.DialogResult = DialogResult.Abort;
                        }
                        else
                        {
                            MessageBox.Show("Another user has updated " +
                                "that vendor.", "Database Error");
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

        private void PutStateData(State state )
        {
            state.StateName = txtStateName.Text;
            state.FirstZipCode = Convert.ToInt32(txtPost.Text);
            state.LastZipCode = Convert.ToInt32(txtPostLast.Text);
            state.StateCode = txtStateCode.Text;
        }

        private bool IsValidData()
        {
            if (Validator.IsPresent(txtStateName) &&
                Validator.IsPresent(txtPostLast) &&
                Validator.IsPresent(txtStateName))
                return true;

            else
                return false;

        }
    }
}
