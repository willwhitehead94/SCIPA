using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SCIPA.Domain.Inbound;
using SCIPA.Domain.Logic;
using SCIPA.DomainLogic;
using SCIPA.Models;
using SCIPA.UI.Object_Manager;
using ValueType = SCIPA.Models.ValueType;

namespace SCIPA.UI
{
    public partial class LogTest : Form
    {

        public Device myDevice = null;

        SerialCommunicator myCommunicator = new SerialCommunicator()
        {
            ComPort = "COM3",
            StartChar = 2,
            EndChar =  4
        };

        private FileCommunicator secondCommunicator = new FileCommunicator()
        {
            FilePath = @"C:\scipa\values.dat"
        };

        public LogTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Domain.Generic.DebugOutput.Print("Button has been clicked!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var controller = new DeviceController();
            Device testDev = controller.GetAllDevices().Last();

            AddRule ar = new AddRule(testDev);
            ar.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var controller = new RuleController();
            var ruleObj = controller.TestMethod_GetLatestRule();

            AddAction aa = new AddAction(ruleObj);
            aa.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void LogTest_Load(object sender, EventArgs e)
        { 
            this.Text = SCIPA.Domain.Logic.Properties.Settings.Default.UserName;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var cont = new CommunicatorController();
            
            CommunicatorModifier cm = new CommunicatorModifier(cont.GetAllCommunicators().First());
            cm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var controller = new DeviceController();
            Device testDev = controller.GetAllDevices().Last();

            AddCommunicator ai = new AddCommunicator(testDev,true);
            ai.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var cd = new CreateDevice();
            cd.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var cont = new DeviceController();
            var firstDev = cont.RetrieveDevice(1);
            var window = new SetDeviceCommunicators(firstDev);
            window.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            DeviceCommunicators dc = new DeviceCommunicators();
            dc.Show();
        }
    }
}
