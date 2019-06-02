using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GherkinScenarioGenerator
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        public void featureDescriptionTB_Leave(object sender, EventArgs e)
        {
            if (featureDescriptionTB.Text == "")
            {
                featureDescriptionTB.Text = "Feature Description";
                featureDescriptionTB.ForeColor = Color.Silver;
            }
        }

        public void featureDescriptionTB_Enter(object sender, EventArgs e)
        {
            if (featureDescriptionTB.Text == "Feature Description")
            {
                featureDescriptionTB.Text = "";
                featureDescriptionTB.ForeColor = Color.Black;
            }
        }

        public void titleTB_Leave(object sender, EventArgs e)
        {
            if (titleTB.Text == "")
            {
                titleTB.Text = "Scenario Title";
                titleTB.ForeColor = Color.Silver;
            }
        }

        public void titleTB_Enter(object sender, EventArgs e)
        {
            if (titleTB.Text == "Scenario Title")
            {
                titleTB.Text = "";
                titleTB.ForeColor = Color.Black;
            }
        }

        public void stepDescriptionTB_Leave(object sender, EventArgs e)
        {
            if (stepDescriptionTB.Text == "")
            {
                stepDescriptionTB.Text = "Step Description";
                stepDescriptionTB.ForeColor = Color.Silver;
            }
        }

        public void stepDescriptionTB_Enter(object sender, EventArgs e)
        {
            if (stepDescriptionTB.Text == "Step Description")
            {
                stepDescriptionTB.Text = "";
                stepDescriptionTB.ForeColor = Color.Black;
            }
        }        
    }
}
