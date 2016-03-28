using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCIPA.UI.Object_Manager
{
    public partial class AddAction : Form
    {
        private Models.Rule _rule = null;

        public AddAction(Models.Rule rule)
        {
            InitializeComponent();
            _rule = rule;
        }

        private void AddAction_Load(object sender, EventArgs e)
        {
            this.Text = _rule.ToString();
        }
    }
}
