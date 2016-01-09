using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controllers = DomainLogicLayer.Controllers;
using Models = DomainLogicLayer.ViewModels;
using Service = DomainLogicLayer.Service;

namespace ApplicationLayer.DataManagers
{
    public partial class AlarmManager: Form
    {
        //Create generic controller object
        Controllers.AlarmController controller = new Controllers.AlarmController();

        public AlarmManager()
        {
            InitializeComponent();
        }

        private void bAll_Click(object sender, EventArgs e)
        {
            lbExisting.Items.Clear();

            foreach (string obj in controller.ConvertToModel<Models.AlarmVM>(controller.GetModels()).Select(obj => obj.Id.ToString()).ToList())
            {
                lbExisting.Items.Add("ID " + obj);
            }
            
            lbExisting.Refresh();
        }

        private void lbExisting_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DomainLogicLayer.Service.DebugPrint("Investigating new object", lbExisting.SelectedItem.ToString());

                int selectedId = Convert.ToInt32(lbExisting.SelectedItem.ToString().Substring(2));

                UpdateDataLabels((Models.AlarmVM)controller.GetFromId(selectedId));
            }
            catch (NullReferenceException nre)
            {
                Service.DebugPrint("There has been a null reference exception within lbExisting.",nre.Message);
            }
            catch (Exception ge)
            {
                Service.DebugPrint("There has been a general exception within lbExisting.", ge.Message);
            }
        }

        private void UpdateDataLabels(Models.AlarmVM selectedModel)
        {
            lIdData.Text = selectedModel.Id.ToString();
            lDeviceData.Text = selectedModel.DeviceId.ToString();
            lAlarmTypeData.Text = selectedModel.AlarmTypeId.ToString();
            lLatestData.Text = selectedModel.Value;
            lEnabledData.Text = selectedModel.IsEnabled.ToString();

            UpdateDeviceLabel(selectedModel.DeviceId);
            UpdateAlarmTypeLabel(selectedModel.AlarmTypeId);
        }

        private void UpdateDeviceLabel(int deviceId)
        {
            string deviceName = "Unknown Device";

            //Controllers.DeviceController devCont = new Controllers.DeviceController();
            //deviceName = devCont.GetModel(deviceId).GetName();

            lDeviceData.Text = string.Format("{0} ({1})",deviceId,deviceName);
        }

        private void UpdateAlarmTypeLabel(int alarmTypeId)
        {
            lAlarmTypeData.Text =string.Format("{0} ({1})", alarmTypeId, "Unknown Type");
        }

        private void bTopHundred_Click(object sender, EventArgs e)
        {
            lbExisting.Items.Clear();

            foreach (string obj in controller.ConvertToModel<Models.AlarmVM>(controller.GetModels(100)).Select(obj => obj.Id.ToString()).ToList())
            {
                lbExisting.Items.Add("ID " + obj);
            }

            lbExisting.Refresh();
        }

        private void bOffline_Click(object sender, EventArgs e)
        {
            lbExisting.Items.Clear();
            
            foreach (Models.AlarmVM obj in controller.DownloadAll<Models.AlarmVM>())
            {
                lbExisting.Items.Add("ID " + obj.Id);
            }

            lbExisting.Refresh();
        }
    }
}
