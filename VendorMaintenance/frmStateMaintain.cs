using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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



        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        }
    }

