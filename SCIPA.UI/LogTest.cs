using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SCIPA.Domain.Inbound;
using SCIPA.Models;

namespace SCIPA.UI
{
    public partial class LogTest : Form
    {
        SerialCommunicator myCommunicator = new SerialCommunicator()
        {
            comPort = "COM3"
        };

        private FileCommunicator secondCommunicator = new FileCommunicator()
        {
            FilePath = @"C:\scipa\values.dat"
        };

        private SerialDataHandler myHandler;

        private SerialDataReader myReader;

        private FlatFileHandler secondHandler;
        private FlatFileReader secondReader;

        public LogTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Domain.Logic.DebugOutput.Print("Button has been clicked!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Models.FileCommunicator ffc = new Models.FileCommunicator()
            {
                FilePath = @"C:\scipa\values.dat",
                StartChar = 0,
                EndChar = 0,
                ValueEType = Models.eType.String
            };

            Domain.Inbound.FlatFileHandler ffh = new Domain.Inbound.FlatFileHandler(ffc);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

            //myHandler = new SerialDataHandler(myCommunicator);

           // myReader = new SerialDataReader(myHandler);

            button3.Enabled = false;
            //string x = myReader.GetString();

            secondHandler = new FlatFileHandler(secondCommunicator);
            secondReader = new FlatFileReader(secondHandler);

        }

        private void button4_Click(object sender, EventArgs e)
        {
        //    label1.Text = myReader.GetString();
        //    label2.Text = myReader.GetBoolean().ToString();
        //    label3.Text = myReader.GetFloat().ToString();
        //    label4.Text = myReader.GetInteger().ToString();
            label1.Text = secondHandler.InboundDataQueue.Count.ToString();
            //label2.Text = secondReader.GetString();
        }

        private void LogTest_Load(object sender, EventArgs e)
        {
            this.Text = SCIPA.Domain.Logic.Properties.Settings.Default.UserName;
        }
    }
}
