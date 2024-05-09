using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnvironmentalSimulation
{
    public partial class EnvironmentalChange : Form
    {
        public EventHandler settingDatahandler;

        public EnvironmentalChange()
        {
            InitializeComponent();
        }

        private void setbtn_Click(object sender, EventArgs e)
        {
            settingDatahandler(this, new EventArgs());
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string getseasonData()
        {
            return seasonCb.Text;
        }

        public string gettimeData()
        {
            return timeCb.Text;
        }

        private void EnvironmentalChange_Load(object sender, EventArgs e)
        {
            seasonCb.Text = "봄";
            timeCb.Text = "0";
        }
    }
}
