﻿using System;
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
using ValueType = SCIPA.Models.ValueType;

namespace SCIPA.UI
{
    public partial class LogTest : Form
    {

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
            Domain.Generic.DebugOutput.Print("Button has been clicked!");
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
                connectionString = @"Data Source=DESKTOP-81SM1A6;Initial Catalog=SCIPA;Integrated Security=True",
                query = "SELECT TOP 1 Id FROM dbo.Alarm ORDER BY Id DESC"
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
            //myDevice = new Device()
            //{
            //    Id = 1,
            //    Name = "Arduino Uno Trend App",
            //    Location = "Desk 1",
            //    Custodian = "W. Whitehead",
            //    InboundReader = new SerialDataReader(new SerialDataHandler(new SerialCommunicator()
            //    {
            //        Id = 1,
            //        comPort = "COM3",
            //        StartChar = 0,
            //        EndChar = 0,
            //        baudRate = 9600,
            //        dataBits = 8,
            //        isDTR = false,
            //        isRTS = false
            //    }))
            //};

            Domain.Logic.DeviceController.AllDevices.Add(new Device()
            {
                Id = 1,
                Name = "Arduino Uno Trend App",
                Location = "Desk 1",
                Custodian = "W. Whitehead",
                InboundReader = new SerialDataReader(new SerialDataHandler(new SerialCommunicator()
                {
                    Id = 1,
                    comPort = "COM3",
                    StartChar = 0,
                    EndChar = 0,
                    baudRate = 9600,
                    dataBits = 8,
                    isDTR = false,
                    isRTS = false
                }))
            });

            //Domain.Logic.DeviceController.AllCommunicators.Add(new Device()
            //{
            //    Id = 2,
            //    Name = "Arduino Uno Trend App 2",
            //    Location = "Desk 1",
            //    Custodian = "W. Whitehead",
            //    InboundReader = new DatabaseReader(new DatabaseHandler(new DatabaseCommunicator()
            //    {
            //        Id = ,
            //        EndChar = ,
            //        StartChar = ,
            //        LastReadTime = ,
            //        ValueValueType = ,
            //        DatabaseType = ,
            //        connectionString = ,
            //        query = ,
            //        databaseTypeId = 
            //    }));
            //    InboundReader = new SerialDataReader(new SerialDataHandler(new SerialCommunicator()
            //    {
            //        Id = 1,
            //        comPort = "COM3",
            //        StartChar = 0,
            //        EndChar = 0,
            //        baudRate = 9600,
            //        dataBits = 8,
            //        isDTR = false,
            //        isRTS = false
            //    }))
            //});

            //DebugOutput.Print(myDevice.Custodian+"'s " + myDevice.Name + " now starting...");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Domain.Logic.DeviceController temp = new DeviceController();
            //temp.GetAllDevices();

            DomainLogic.SharedResources sr = new SharedResources();
            System.Windows.Forms.MessageBox.Show(sr.GetValueCount().ToString());

            //if (myDevice != null)
            //{
            //    DataReader myReader = (DataReader)myDevice.InboundReader;

            //    if (myDevice.InboundValues == null)
            //    {
            //        myDevice.InboundValues = new List<Value>();
            //    }

            //    List<Value> newValues = new List<Value>();
            //    while (myReader.AvailableValues() > 0)
            //    {
            //        myDevice.InboundValues.Add(myReader.GetNextValue());
            //    }

            //    System.Windows.Forms.MessageBox.Show(myDevice.InboundValues.Count.ToString());
            //}
        }

        private void LogTest_Load(object sender, EventArgs e)
        { 
            this.Text = SCIPA.Domain.Logic.Properties.Settings.Default.UserName;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CreateDevice cd = new CreateDevice();
            cd.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Device testDev = new Device()
            {
                Id = 1,
                Name = "Arduino Uno Trend App",
                Location = "Desk 1",
                Custodian = "W. Whitehead",
                Enabled = true
            };

            AddInbound ai = new AddInbound(testDev);
            ai.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var cd = new CreateDevice();
            cd.ShowDialog();
        }
    }
}
