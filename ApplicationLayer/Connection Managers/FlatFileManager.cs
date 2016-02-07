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

        private DomainLogicLayer.Controllers.FlatFileController ffc;

        private void SetUpDisplay()
        {
            lbData = new ListBox();
            lbData.Items.Clear();
        }

        public FlatFileManager()
        {
            InitializeComponent();
            SetUpDisplay();
        }

        public FlatFileManager(string deviceName)
        {
            InitializeComponent();
            SetUpDisplay();
            DeviceName = deviceName;

            ffc = new DomainLogicLayer.Controllers.FlatFileController(DeviceName);
            lDeviceId.Text = "#" + ffc.GetCommunicator().Id;
        }

        private void FlatFileManager_Load(object sender, EventArgs e)
        {
            tDeviceName.Text = DeviceName;

            cbValueType.Items.AddRange(ffc.GetValueTypes());
        }

        private void bGetPath_Click(object sender, EventArgs e)
        {
            ofdPathFinder.ShowDialog();
            ffc.GetCommunicator().SetFilePath(@ofdPathFinder.FileName);

            tFilePath.Text = ffc.GetCommunicator().FolderPath;
            tFileName.Text = ffc.GetCommunicator().FileName;
        }

        private void bStartTest_Click(object sender, EventArgs e)
        {
            ffc.GetCommunicator().StartFileWatcher();
            ffc.GetCommunicator().onValueRecieved += FlatFileManager_onValueRecieved;
        }

        private void FlatFileManager_onValueRecieved(object source, NewValueRecievedEventArgs e)
        {
            string value = e.GetEventInfo();
            

            LastKnownValue = ffc.GetCommunicator().LastKnownValue;
            lbData.Items.Add(DateTime.Now.ToString());//+ " [" + LastKnownValue + "]");
        }

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

      
        private void bQuestion_Click(object sender, EventArgs e)
        {
            //Shows the assistance message for all "?" buttons.
            System.Windows.Forms.MessageBox.Show("This is some assistance text. \n\nLorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Assistance");
        }
    }
}
