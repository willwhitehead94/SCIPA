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
        private object basicobj = null;

        SerialCommunicator myCommunicator = new SerialCommunicator()
        {
            comPort = "COM3",
            StartChar = 2,
            EndChar =  4
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
                EndChar = 4,
                ValueEType = Models.eType.String
            };

            Domain.Inbound.FlatFileHandler ffh = new Domain.Inbound.FlatFileHandler(ffc);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DatabaseCommunicator dbComm = new DatabaseCommunicator()
            {
                DatabaseType = DatabaseTechnologyType.SQL,
                ValueEType = eType.String,
                connectionString = @"Data Source=DIANDLAD-LAPTOP\SQLENTERPRISE;Initial Catalog=SCIPA;Integrated Security=True",
                query = "SELECT TOP 1 id FROM dbo.Alarm ORDER BY id DESC"
            };

            var dbRead = new DatabaseReader(new DatabaseHandler(dbComm));
            //basicobj = dbRead;
            
            FileCommunicator ffComm = new FileCommunicator()
            {
                FilePath = @"C:\scipa\values.dat",
                ValueEType = eType.String,
                StartChar = 0,
                EndChar = 0
            };
            var fileRead = new FlatFileReader(new FlatFileHandler(ffComm));

            SerialCommunicator sdComm = new SerialCommunicator()
            {
                comPort = "COM3",
                ValueEType = eType.String,
                StartChar = 0,
                EndChar = 0
            };
            var serialRead = new SerialDataReader(new SerialDataHandler(sdComm));

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DatabaseReader x = (DatabaseReader)basicobj;
            if (x.AvailableValues()>0)
                label1.Text = x.GetString();
            //    label2.Text = myReader.GetBoolean().ToString();
            //    label3.Text = myReader.GetFloat().ToString();
            //    label4.Text = myReader.GetInteger().ToString();
            //label1.Text = secondHandler.InboundDataQueue.Count.ToString();
            //label2.Text = secondReader.GetString();
        }

        private void LogTest_Load(object sender, EventArgs e)
        {
            this.Text = SCIPA.Domain.Logic.Properties.Settings.Default.UserName;
        }
    }
}
