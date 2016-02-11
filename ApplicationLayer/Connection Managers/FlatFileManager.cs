using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DomainLogicLayer.Events;

namespace ApplicationLayer.Connection_Managers
{
    public partial class FlatFileManager : Form
    {
        public string DeviceName { get; set; }
        public string FilePath { get; set; }
        public string FileName { get; set; }
        public string ValueType { get; set; }
        public int? StartChar { get; set; }
        public int? EndChar { get; set; }
        public bool ReadOnly { get; set; }
        public int CheckTime { get; set; }
        public DateTime? LastUpdateTime { get; set; }
        public bool ReadUpdatesOnly { get; set; }
        public string DefaultValue { get; set; }
        public bool Nullable { get; set; }

        private string LastKnownValue { get; set; }

        /// <summary>
        /// Global access to the FlatFile Controller within the DomainLogicLayer.
        /// </summary>
        private DomainLogicLayer.Controllers.FlatFileController ffc;

        /// <summary>
        /// Delegate to enable asynchronous calls for setting text properties
        /// within TextBox objects.
        /// </summary>
        /// <param name="text">The value to set.</param>
        delegate void SetTextCallback(TextBox sender, string text);

        /// <summary>
        /// Blank constructor.
        /// </summary>
        public FlatFileManager()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor taking the device's name as a parameter.
        /// </summary>
        /// <param name="deviceName"></param>
        public FlatFileManager(string deviceName)
        {
            InitializeComponent();
            DeviceName = deviceName;

            ffc = new DomainLogicLayer.Controllers.FlatFileController(DeviceName);
            lDeviceId.Text = "#" + ffc.Communicator().Id;
        }

        /// <summary>
        /// The executing statements that are run on the first instance of the FlatFileManager opening.
        /// </summary>
        /// <param name="sender">Calling object.</param>
        /// <param name="e">The calling arguments.</param>
        private void FlatFileManager_Load(object sender, EventArgs e)
        {
            tDeviceName.Text = DeviceName;

            cbValueType.Items.AddRange(ffc.GetValueTypes());
        }

        /// <summary>
        /// Opens a new file selector dialog and stores the selected path and file into the communicator object.
        /// </summary>
        /// <param name="sender">The button object.</param>
        /// <param name="e">Button click event.</param>
        private void bGetPath_Click(object sender, EventArgs e)
        {
            ofdPathFinder.ShowDialog();
            ffc.Communicator().SetFilePath(@ofdPathFinder.FileName);

            tFilePath.Text = ffc.Communicator().FolderPath;
            tFileName.Text = ffc.Communicator().FileName;
        }

        /// <summary>
        /// Button click event code for starting the file monitoring process.
        /// </summary>
        /// <param name="sender">The button object.</param>
        /// <param name="e">Button click event.</param>
        private void bStartTest_Click(object sender, EventArgs e)
        {
            if (ffc.Communicator().CheckFileExists())
            {
                ffc.Communicator().StartChar = Convert.ToInt32(tStartChar.Text);
                ffc.Communicator().EndChar = Convert.ToInt32(tEndChar.Text);
                ffc.Communicator().ValueType = cbValueType.Text;
                ffc.Communicator().CheckTime = Convert.ToInt32(tCheckEvery.Text);
                ffc.Communicator().DefaultValue = tDefaultValue.Text;

                ffc.Communicator().StartFileWatcher();
                ffc.Communicator().onValueRecieved += OnValueRecieved_Event;
                
                cbFileAccessible.Checked = true;
                cbInRange.Checked = true;
                ShowWarning();
                bStartTest.Text = "Reading File!";
                
            }
            else
            {
                cbFileAccessible.Checked = false;
                ShowWarning("Could not access file!");
            }
        }

        /// <summary>
        /// Updates and shows the warning text unless the message is blank, in which case
        /// the warning is hidden.
        /// </summary>
        /// <param name="text"></param>
        public void ShowWarning(string text ="")
        {
            lWarning.Text = text;

            if (lWarning.Text.Length == 0)
            {
                lWarning.Visible = false;
            }
            else
            {
                lWarning.Visible = true;
            }
        }


        /// <summary>
        /// The code executed each time the flat file encounters an update; called by the Communicator objects OnValueRecieved event.
        /// </summary>
        /// <param name="source">The Communicator's OnValueRecieved.</param>
        /// <param name="e">The recieved evernt arguments.</param>
        private void OnValueRecieved_Event(object source, NewValueRecievedEventArgs e)
        {
            //Updates the 'last known value' textbox with the time stamp of the event.
            ThreadSafeTextSetting_TextBox(tLastUpdate, e.GetEventTime().ToString());

            //Adds the data recieved from the event the assigned textbox.
            string valueToStore =  e.GetEventInfo();
            ThreadSafeTextSetting_TextBox(tLastValue, valueToStore);
            
        }

        /// <summary>
        /// Thread-safe way to update text in a TextBox automatically via the usage of the linked delegate.
        /// </summary>
        /// <param name="sender">TextBox object to update.</param>
        /// <param name="text">Text to update in object.</param>
        private void ThreadSafeTextSetting_TextBox(TextBox sender, string text)
        {
            TextBox txt = (TextBox)sender;

            if (txt.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(ThreadSafeTextSetting_TextBox);
                this.Invoke(d, new object[] { txt,text });
            }
            else
            {
                txt.Text = text;
            }
        }

        /// <summary>
        /// Key Press event ensures that TextBox objects only accept numerical digits below
        /// the maximum integer value.
        /// </summary>
        /// <param name="sender">TextBox objects.</param>
        /// <param name="e">The occuring event.</param>
        private void OnlyAllowDigits_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox sentObj = (TextBox)sender;

            //Because of the following rule, we know that all values will conform to the integer standard
            int currentValue = 0;
            if (sentObj.Text != "")
            {
                try
                { Convert.ToInt32(sentObj.Text); }
                catch (Exception exc)
                {
                    currentValue = int.MaxValue;
                }
            }

            if (!char.IsDigit(e.KeyChar) || currentValue >= int.MaxValue)
            {
                e.Handled = true;                    
            }
            else
            {
                e.Handled = false;
            }
        }

      
        /// <summary>
        /// Button Click event produces a popup window giving textual assistance for the GUI.
        /// </summary>
        /// <param name="sender">Button objects.</param>
        /// <param name="e">The click event arguments.</param>
        private void bQuestion_Click(object sender, EventArgs e)
        {
            //Shows the assistance message for all "?" buttons.
            System.Windows.Forms.MessageBox.Show("This is some assistance text. \n\nLorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Assistance");
        }

        private void tLastValue_TextChanged(object sender, EventArgs e)
        {
            int isInt = int.MinValue;

            try
            {
                isInt = Convert.ToInt32(tLastValue.Text);
                cbValueTypeOkay.Checked = true;
            }
            catch
            {
                cbValueTypeOkay.Checked = false;
            }
        }

        private void cbReadOnly_CheckedChanged(object sender, EventArgs e)
        {
            ffc.Communicator().ReadOnly = cbReadOnly.Checked;
        }

        private void cbReadUpdateOnly_CheckedChanged(object sender, EventArgs e)
        {
            ffc.Communicator().ReadUpdatesOnly = cbReadUpdateOnly.Checked;
        }

        private void cbNullable_CheckedChanged(object sender, EventArgs e)
        {
            ffc.Communicator().Nullable = cbNullable.Checked;
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            ffc.SaveNewDevice();
        }

        private void cbValidity_CheckedChanged(object sender, EventArgs e)
        {
            if (cbInRange.Checked && cbFileAccessible.Checked && cbValueTypeOkay.Checked)
            {
                bSave.Enabled = true;
            }
            else
            {
                bSave.Enabled = false;
            }
        }
    }
}
