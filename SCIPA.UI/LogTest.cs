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
using SCIPA.Domain.Logic;
using SCIPA.Models;
using ValueType = SCIPA.Models.ValueType;
using SCIPA.Models.Resources;

namespace SCIPA.UI
{
    public partial class LogTest : Form
    {
        private object basicobj = null;

        public Device myDevice = null;

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
                ValueValueType = Models.ValueType.String
            };

            Domain.Inbound.FlatFileHandler ffh = new Domain.Inbound.FlatFileHandler(ffc);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DatabaseCommunicator dbComm = new DatabaseCommunicator()
            {
                DatabaseType = DatabaseType.SQL,
                ValueValueType = ValueType.String,
                connectionString = @"Data Source=DIANDLAD-LAPTOP\SQLENTERPRISE;Initial Catalog=SCIPA;Integrated Security=True",
                query = "SELECT TOP 1 id FROM dbo.Alarm ORDER BY id DESC"
            };

            var dbRead = new DatabaseReader(new DatabaseHandler(dbComm));
            //basicobj = dbRead;
            
            FileCommunicator ffComm = new FileCommunicator()
            {
                FilePath = @"C:\scipa\values.dat",
                ValueValueType = ValueType.String,
                StartChar = 0,
                EndChar = 0
            };
            var fileRead = new FlatFileReader(new FlatFileHandler(ffComm));

            SerialCommunicator sdComm = new SerialCommunicator()
            {
                comPort = "COM3",
                ValueValueType = ValueType.String,
                StartChar = 0,
                EndChar = 0
            };
            var serialRead = new SerialDataReader(new SerialDataHandler(sdComm));

        }

        private void button4_Click(object sender, EventArgs e)
        {
            myDevice = new Device()
            {
                Id = 1,
                Name = "Arduino Uno Trend App",
                Location = "Desk 1",
                Custodian = "W. Whitehead",
                InboundReader = new SerialDataReader(new SerialDataHandler(new SerialCommunicator()
                {
                    id = 1,
                    comPort = "COM3",
                    StartChar = 0,
                    EndChar = 0,
                    baudRate = 9600,
                    dataBits = 8,
                    isDTR = false,
                    isRTS = false
                }))
            };

            DebugOutput.Print(myDevice.Custodian+"'s " + myDevice.Name + " now starting...");
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (myDevice != null)
            {
                DataReader myReader = (DataReader)myDevice.InboundReader;

                if (myDevice.InboundValues == null)
                {
                    myDevice.InboundValues = new List<Value>();
                }

                List<Value> newValues = new List<Value>();
                while (myReader.AvailableValues() > 0)
                {
                    myDevice.InboundValues.Add(myReader.GetNextValue());
                }

                System.Windows.Forms.MessageBox.Show(myDevice.InboundValues.Count.ToString());
            }
        }

        private void LogTest_Load(object sender, EventArgs e)
        {
            this.Text = SCIPA.Domain.Logic.Properties.Settings.Default.UserName;
        }

        
    }
}
