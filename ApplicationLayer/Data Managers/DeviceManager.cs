using Microsoft.Data.ConnectionUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationLayer.Connection_Managers;

namespace ApplicationLayer.DataManagers
{
    public partial class DeviceManager : Form
    {
        //Create generic controller object
        //Controllers.DeviceController controller = new Controllers.AlarmController();

        public DeviceManager()
        {
            InitializeComponent();
        }

        private void DeviceManager_Load(object sender, EventArgs e)
        {

        }

        private void rbInput_CheckedChanged(object sender, EventArgs e)
        {
            

           
        }

        private void rbOutput_CheckedChanged(object sender, EventArgs e)
        {
            gbCommands.Visible = rbOutput.Checked;
        }

        private void tDeviceName_Leave(object sender, EventArgs e)
        {
            CheckValidity(1, 10, tDeviceName, lNameCheck);
        }

        private void CheckValidity (int min, int max, object textbox, object label)
        {
            Label validityLabel = (Label)label;
            TextBox textBox = (TextBox)textbox;

            int length = textBox.Text.Length;

            if (length >= min && length <= max)
            {
                validityLabel.Text =("Okay!");
                validityLabel.ForeColor = Color.Green;
            }
            else
            {
                validityLabel.Text = ("Not okay!");
                validityLabel.ForeColor = Color.Red;
            }

            validityLabel.Visible = true;
        }

        private void gbConnection_Enter(object sender, EventArgs e)
        {

        }

        private void bNewConnection_Click(object sender, EventArgs e)
        {
            //Offer different set up depending on the connection type
            if (rbDatabase.Checked)
            {

            }
            else if (rbSerial.Checked)
            {

            }
            else if (rbFlat.Checked)
            {
                CreateFlatFileConnection();
            }
        }

        private string CreateFlatFileConnection()
        {
            string filePath, fileName, valueType;
            int startChar, endChar;
            bool openReadOnly;

            //Read the file every X seconds.
            int secondsBetweenReads;

            //Only read the file if the timestamp has updated.
            DateTime lastKnownUpdate;
            bool readUpdateOnly;

            double defaultValue;
            bool nullable;

            FlatFileManager manager = new FlatFileManager(tDeviceName.Text);

            manager.Show(this) ;
            return manager.DeviceName;
        }
    }
}
