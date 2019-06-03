using GherkinScenarioGenerator.logic;
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
        List<GherkinStep> gherkinSteps = new List<GherkinStep>();
        int rowIndex;

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            scenarioTypeCB.SelectedIndex = 0;
            stepTypeCB.SelectedIndex = 0;
        }

        private void featureDescriptionTB_Leave(object sender, EventArgs e)
        {
            if (featureDescriptionTB.Text == "")
            {
                featureDescriptionTB.Text = "Feature Description";
                featureDescriptionTB.ForeColor = Color.Silver;
            }
        }

        private void featureDescriptionTB_Enter(object sender, EventArgs e)
        {
            if (featureDescriptionTB.Text == "Feature Description")
            {
                featureDescriptionTB.Text = "";
                featureDescriptionTB.ForeColor = Color.Black;
            }
        }

        private void titleTB_Leave(object sender, EventArgs e)
        {
            if (scenarioTitleTB.Text == "")
            {
                scenarioTitleTB.Text = "Scenario Title";
                scenarioTitleTB.ForeColor = Color.Silver;
            }
        }

        private void titleTB_Enter(object sender, EventArgs e)
        {
            if (scenarioTitleTB.Text == "Scenario Title")
            {
                scenarioTitleTB.Text = "";
                scenarioTitleTB.ForeColor = Color.Black;
            }
        }

        private void stepDescriptionTB_Leave(object sender, EventArgs e)
        {
            if (stepDescriptionTB.Text == "")
            {
                stepDescriptionTB.Text = "Step Description";
                stepDescriptionTB.ForeColor = Color.Silver;
            }
        }

        private void stepDescriptionTB_Enter(object sender, EventArgs e)
        {
            if (stepDescriptionTB.Text == "Step Description")
            {
                stepDescriptionTB.Text = "";
                stepDescriptionTB.ForeColor = Color.Black;
            }
        }

        private void display_scenario_preview(object sender, EventArgs e)
        {
            string featureText = featureLab.Text + ": " + featureDescriptionTB.Text;
            string scenarioType = scenarioTypeCB.Text + ":";
            string scenarioTitle = scenarioTitleTB.Text;
            string scenarioSteps = "";

            foreach (DataGridViewRow row in stepsDGV.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    scenarioSteps += cell.Value.ToString() + " ";

                }
                scenarioSteps += "\n";
            }

            scenarioPreviewTB.Text = "#Gherkin Generator Output" + Environment.NewLine + Environment.NewLine +
                featureText + Environment.NewLine +
                scenarioType +
                scenarioTitle + Environment.NewLine +
                scenarioSteps;
        }

        private void scenarioPreviewTB_TextChanged(object sender, EventArgs e)
        {
            this.CheckKeyword("Feature:", Color.Purple, 0);
            this.CheckKeyword("Scenario:", Color.Green, 0);
            this.CheckKeyword("Scenario Outline:", Color.Green, 0);
            this.CheckKeyword("Given", Color.DarkOrange, 0);
            this.CheckKeyword("When", Color.DarkOrange, 0);
            this.CheckKeyword("Then", Color.DarkOrange, 0);
        }

        private void CheckKeyword(string word, Color color, int startIndex)
        {
            if (this.scenarioPreviewTB.Text.Contains(word))
            {
                int index = -1;
                int selectStart = this.scenarioPreviewTB.SelectionStart;

                while ((index = this.scenarioPreviewTB.Text.IndexOf(word, (index + 1))) != -1)
                {
                    this.scenarioPreviewTB.Select(selectStart, 0);
                    this.scenarioPreviewTB.SelectionColor = Color.Black;
                    this.scenarioPreviewTB.Select((index + startIndex), word.Length);
                    this.scenarioPreviewTB.SelectionColor = color;
                }
            }
        }

        private void click_add_step_btn(object sender, EventArgs e)
        {
            var obj = new GherkinStep(stepTypeCB.Text, stepDescriptionTB.Text);
            gherkinSteps.Add(obj);

            var source = new BindingSource();
            source.DataSource = gherkinSteps;
            stepsDGV.DataSource = source;
            display_scenario_preview(sender, e);

            stepDescriptionTB.Text = "";
        }

        private void click_delete_btn(object sender, EventArgs e)
        {
            if (stepsDGV.SelectedCells.Count > 0)
            {
                int rowIndex = stepsDGV.CurrentCell.ColumnIndex;
                stepsDGV.Rows.RemoveAt(rowIndex);
            }
            display_scenario_preview(sender, e);
        }

        private void cell_clicked(object sender, DataGridViewCellEventArgs e)
        {
            if (stepsDGV.SelectedRows.Count == 1)
            {
                rowIndex = e.RowIndex;
                DataGridViewRow row = stepsDGV.Rows[rowIndex];

                stepTypeCB.Text = row.Cells[0].Value.ToString();
                stepDescriptionTB.Text = row.Cells[1].Value.ToString();
            }
        }

        private void click_update_btn(object sender, EventArgs e)
        {
            if (stepsDGV.SelectedRows.Count == 1)
            {
                DataGridViewRow newRow = stepsDGV.Rows[rowIndex];
                newRow.Cells[0].Value = stepTypeCB.Text;
                newRow.Cells[1].Value = stepDescriptionTB.Text;
            }
            display_scenario_preview(sender, e);
            stepDescriptionTB.Text = "";
        }
    }
}


