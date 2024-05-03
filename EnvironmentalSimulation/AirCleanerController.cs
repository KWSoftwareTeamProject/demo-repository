﻿using System;
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
    public partial class AirCleanerController : Form
    {
        public AirCleanerController()
        {
            InitializeComponent();
        }

        private void AirCleaner_Shown(object sender, EventArgs e)
        {
            Graphics g = base.CreateGraphics();
            SolidBrush brush = new SolidBrush(Color.DarkGray);

            g.FillEllipse(brush, 10, 10, 280, 280);

            rdoLow.BackColor = Color.DarkGray;
            rdoMid.BackColor = Color.DarkGray;
            rdoHigh.BackColor = Color.DarkGray;            
        }

        private void PowerOff()
        {

        }

        private void PowerOn(RadioButton rdoBtn)
        {

        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            RadioButton checkedRdoBtn = Change();

            if (checkedRdoBtn == null) PowerOff();
            else PowerOn(checkedRdoBtn);


        }

        private RadioButton Change()
        {
            if (rdoLow.Checked)
            {
                rdoMid.Checked = true;
                return rdoMid;
            }
            else if (rdoMid.Checked)
            {
                rdoHigh.Checked = true;
                return rdoHigh;
            }
            else if (rdoHigh.Checked)
            {
                rdoHigh.Checked = false;
                return null;
            }
            else
            {
                rdoLow.Checked = true;
                return rdoLow;
            }
        }
    }
}
