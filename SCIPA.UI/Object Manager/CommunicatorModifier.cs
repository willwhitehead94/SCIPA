using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SCIPA.Domain.Logic;
using SCIPA.Models;

namespace SCIPA.UI.Object_Manager
{
    public partial class CommunicatorModifier : Form
    {
        /// <summary>
        /// The communicator object that is being modified by the user.
        /// </summary>
        private Communicator _communicator = null;

        public CommunicatorModifier(Communicator communicator)
        {
            InitializeComponent();

            //Fill the combobox options with the enum values as given in the models.
            cbCommType.DataSource = Enum.GetValues(typeof (Models.ValueType));
            cbValueType.DataSource = Enum.GetValues(typeof (Models.ValueType));
            cbCommType.DataSource = Enum.GetValues(typeof (Models.ValueType));

            _communicator = communicator;
        }

        private void CommunicatorModifier_Load(object sender, EventArgs e)
        {
            /*
            * Hide all Specialised settings panels
            */ 
            pFile.Visible = false;
            pSerial.Visible = false;
            pDatabase.Visible = false;

            /*
            * Preparing all of the standard (abstract) Communicator fields
            */ 
            tId.Text = _communicator.Id.ToString();
            tStart.Text = _communicator.StartChar.ToString();
            tEnd.Text = _communicator.EndChar.ToString();
            tLastReadTime.Text = _communicator.LastReadTime.ToString();
            cbCommType.SelectedItem = _communicator.Type;
            cbValueType.SelectedItem = _communicator.ValueType;
            rbInbound.Checked = _communicator.Inbound;
            rbOutbound.Checked = _communicator.Inbound;

            /*
            * Preparing FileCommunicator fields
            */ 
            if (_communicator is FileCommunicator)
            {
                var temp = (FileCommunicator) _communicator;
                tFilePath.Text = temp.FilePath;

                //Make the specialised panel visible.
                pFile.Visible = true;
            }

            else if (_communicator is SerialCommunicator)
            {
                var temp = (SerialCommunicator) _communicator;
                cbComPort.SelectedItem = temp.ComPort;
                tBaudRate.Text = temp.BaudRate.ToString();
                tDataBits.Text = temp.DataBits.ToString();
                cbDtr.Checked = temp.IsDTR;
                cbRts.Checked = temp.IsRTS;

                //Make the specialised panel visible.
                pSerial.Visible = true;
            }

            else if (_communicator is DatabaseCommunicator)
            {
                var temp = (DatabaseCommunicator) _communicator;
                tConnectionString.Text = temp.ConnectionString;
                tQuery.Text = temp.Query;
                cbDatabaseType.SelectedItem = temp.DbType;

                //Make the specialised panel visible.
                pDatabase.Visible = true;
            }
            
        }

        private void bResetDate_Click(object sender, EventArgs e)
        {
            tLastReadTime.Text=new DateTime(1980,01,01).ToString();
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            var messagebox =
                System.Windows.Forms.MessageBox.Show("Are you sure you wish to delete Communicator ID " + _communicator.Id +
                                                "?","Delete Communicator",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);

            if (messagebox == DialogResult.Yes)
            {
                var controller = new CommunicatorController();
                // TODO delete the comms in the controller......

                System.Windows.Forms.MessageBox.Show("Deleted the Communicator successfully.");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Phew - nothing was deleted...");
            }
        }

        private void bReset_Click(object sender, EventArgs e)
        {
            var messagebox =
                System.Windows.Forms.MessageBox.Show("Resetting this information will remove any changes you may have made. Are you sure?", "Reset Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (messagebox == DialogResult.Yes)
            {
                CommunicatorModifier_Load(sender, e);
                this.Refresh();
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            var messagebox =
                System.Windows.Forms.MessageBox.Show("Are you sure you want to save your changes?", "Save Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (messagebox == DialogResult.Yes)
            {
                var controller = new CommunicatorController();

                UpdateCommunicatorObject();

                controller.SaveCommunicator(_communicator);
            }

            
        }

        private void UpdateCommunicatorObject()
        {
            /*
            * Preparing all of the standard (abstract) Communicator fields
            */
            //Id does not update
            _communicator.StartChar = Convert.ToInt32(tStart.Text);
            _communicator.EndChar = Convert.ToInt32(tEnd.Text);
            _communicator.LastReadTime = Convert.ToDateTime(tLastReadTime.Text);
            //CommType does not update
            _communicator.ValueType = (Models.ValueType)cbValueType.SelectedItem;
            _communicator.Inbound = rbInbound.Checked;

            /*
            * Preparing FileCommunicator fields
            */
            if (_communicator is FileCommunicator)
            {
                var temp = (FileCommunicator)_communicator;
                temp.FilePath = tFilePath.Text;

                //Store this in the global variable.
                _communicator = temp;
            }

            else if (_communicator is SerialCommunicator)
            {
                var temp = (SerialCommunicator)_communicator;
                temp.ComPort = cbComPort.SelectedText;
                temp.BaudRate = Convert.ToInt32(tBaudRate.Text);
                temp.DataBits = Convert.ToByte(tDataBits.Text);
                temp.IsDTR = cbDtr.Checked;
                temp.IsRTS = cbRts.Checked;

                //Store this in the global variable.
                _communicator = temp;
            }

            else if (_communicator is DatabaseCommunicator)
            {
                var temp = (DatabaseCommunicator)_communicator;
                temp.ConnectionString = tConnectionString.Text;
                temp.Query = tQuery.Text;
                temp.DbType = (Models.DatabaseType)cbDatabaseType.SelectedItem;

                //Store this in the global variable.
                _communicator = temp;
            }
        }
    }
}
