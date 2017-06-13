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
    public partial class frmStateMaintain : Form
    {
        public frmStateMaintain()
        {
            InitializeComponent();
        }

        State SelectedState;

        private void StateMaintain_Load(object sender, EventArgs e)
        {
            this.LoadComboBoxes();

        }

        private void LoadComboBoxes()
        {
            try
            {
                var states = from state in DataContext.payables.States
                              orderby state.StateName
                              select new { state.StateCode, state.StateName };
                comboState.DataSource = states;
                comboState.DisplayMember = "StateName";
                comboState.ValueMember = "StateCode";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void StateCode_Click(object sender, EventArgs e)
        {

        }

        private void btnLoadState_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent(comboState) )
                
            {
                try
                {
                    SelectedState = 
                        (from state in DataContext.payables.States
                         where state.StateCode == Convert.ToString(comboState.SelectedValue)
                         select state).Single();
                    this.DisplayState();
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("No vendor found with this ID. " +
                        "Please try again.", "Vendor Not Found");
                    this.ClearControls();
                    comboState.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }
         
        private void DisplayState()
        {
            txtFirstZIP.Text = SelectedState.FirstZipCode.ToString();
            txtLastZIP.Text = SelectedState.LastZipCode.ToString(); 



        }

        private void ClearControls()
        {
            comboState.SelectedValue = -1;
            txtFirstZIP.Text = "";
            txtLastZIP.Text = SelectedState.LastZipCode.ToString();
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmStateModify addModifyStateForm = new frmStateModify();
            addModifyStateForm.addState = true;
            DialogResult result = addModifyStateForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                SelectedState = addModifyStateForm.state;
                comboState.SelectedValue = SelectedState.StateCode.ToString();
                this.DisplayState();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmStateModify addModifyStateForm = new frmStateModify();
            addModifyStateForm.addState = false;
            addModifyStateForm.state = SelectedState;
            DialogResult result = addModifyStateForm.ShowDialog();
            
            if (result == DialogResult.OK || result == DialogResult.Retry)
            {
                SelectedState = addModifyStateForm.state;
                this.DisplayState();
            }
            else if (result == DialogResult.Abort)
            {
                comboState.SelectedValue = -1;
                this.ClearControls();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result =
              MessageBox.Show("Delete " + SelectedState.StateName + "?",
              "Confirm Delete", MessageBoxButtons.YesNo,
              MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    DataContext.payables.States.DeleteOnSubmit(SelectedState);
                    DataContext.payables.SubmitChanges();
                    comboState.SelectedValue = -1;
                    this.ClearControls();
                }
                catch (ChangeConflictException)
                {
                    DataContext.GetCurrentValues();
                    MessageBox.Show("Another user has updated that state.",
                        "Database Error");
                    this.DisplayState();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }
        }

        }
    

