using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCIPA.UI.HMI
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void bSqlClear_Click(object sender, EventArgs e)
        {
            var controller = new SCIPA.Domain.Logic.SystemController();
            controller.ClearSql();
        }

        private void bMongoClear_Click(object sender, EventArgs e)
        {
            var controller = new SCIPA.Domain.Logic.SystemController();
            controller.ClearMongo();
        }

        private void bLogClear_Click(object sender, EventArgs e)
        {
            var controller = new SCIPA.Domain.Logic.SystemController();
            controller.ClearLog();
        }
    }
}
