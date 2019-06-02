namespace GherkinScenarioGenerator
{
    partial class mainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.scenarioPreviewPanel = new System.Windows.Forms.Panel();
            this.scenarioSetupPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.scenarioPreviewLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.featureLab = new System.Windows.Forms.Label();
            this.typeLab = new System.Windows.Forms.Label();
            this.previewLab = new System.Windows.Forms.Label();
            this.addStepLab = new System.Windows.Forms.Label();
            this.FeatureDescriptionLab = new System.Windows.Forms.TextBox();
            this.titleTB = new System.Windows.Forms.TextBox();
            this.stepsDGV = new System.Windows.Forms.DataGridView();
            this.ScenarioTypeCB = new System.Windows.Forms.ComboBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.stepTypeCB = new System.Windows.Forms.ComboBox();
            this.stepDescriptionLab = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.scenarioPreviewPanel.SuspendLayout();
            this.scenarioSetupPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 380F));
            this.tableLayoutPanel1.Controls.Add(this.scenarioPreviewPanel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.scenarioSetupPanel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(948, 534);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // scenarioPreviewPanel
            // 
            this.scenarioPreviewPanel.Controls.Add(this.tableLayoutPanel2);
            this.scenarioPreviewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scenarioPreviewPanel.Location = new System.Drawing.Point(571, 3);
            this.scenarioPreviewPanel.Name = "scenarioPreviewPanel";
            this.scenarioPreviewPanel.Size = new System.Drawing.Size(374, 528);
            this.scenarioPreviewPanel.TabIndex = 0;
            // 
            // scenarioSetupPanel
            // 
            this.scenarioSetupPanel.Controls.Add(this.tableLayoutPanel3);
            this.scenarioSetupPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scenarioSetupPanel.Location = new System.Drawing.Point(3, 3);
            this.scenarioSetupPanel.Name = "scenarioSetupPanel";
            this.scenarioSetupPanel.Size = new System.Drawing.Size(562, 528);
            this.scenarioSetupPanel.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.Controls.Add(this.scenarioPreviewLabel, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox1, 1, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(374, 528);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // scenarioPreviewLabel
            // 
            this.scenarioPreviewLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scenarioPreviewLabel.AutoSize = true;
            this.scenarioPreviewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.scenarioPreviewLabel.Location = new System.Drawing.Point(21, 26);
            this.scenarioPreviewLabel.Name = "scenarioPreviewLabel";
            this.scenarioPreviewLabel.Size = new System.Drawing.Size(330, 79);
            this.scenarioPreviewLabel.TabIndex = 0;
            this.scenarioPreviewLabel.Text = "Preview of Scenario";
            this.scenarioPreviewLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 7;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.050505F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.26263F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.050505F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.050505F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.26263F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.050505F));
            this.tableLayoutPanel3.Controls.Add(this.featureLab, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.typeLab, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.previewLab, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.addStepLab, 1, 9);
            this.tableLayoutPanel3.Controls.Add(this.FeatureDescriptionLab, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.titleTB, 5, 3);
            this.tableLayoutPanel3.Controls.Add(this.stepsDGV, 1, 7);
            this.tableLayoutPanel3.Controls.Add(this.ScenarioTypeCB, 3, 3);
            this.tableLayoutPanel3.Controls.Add(this.deleteBtn, 5, 13);
            this.tableLayoutPanel3.Controls.Add(this.updateBtn, 3, 13);
            this.tableLayoutPanel3.Controls.Add(this.addBtn, 1, 13);
            this.tableLayoutPanel3.Controls.Add(this.saveBtn, 1, 15);
            this.tableLayoutPanel3.Controls.Add(this.stepTypeCB, 1, 11);
            this.tableLayoutPanel3.Controls.Add(this.stepDescriptionLab, 3, 11);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 17;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(562, 528);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // featureLab
            // 
            this.featureLab.AutoSize = true;
            this.featureLab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.featureLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.featureLab.Location = new System.Drawing.Point(31, 26);
            this.featureLab.Name = "featureLab";
            this.featureLab.Size = new System.Drawing.Size(141, 52);
            this.featureLab.TabIndex = 0;
            this.featureLab.Text = "Feature";
            // 
            // typeLab
            // 
            this.typeLab.AutoSize = true;
            this.typeLab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typeLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.typeLab.Location = new System.Drawing.Point(31, 88);
            this.typeLab.Name = "typeLab";
            this.typeLab.Size = new System.Drawing.Size(141, 52);
            this.typeLab.TabIndex = 1;
            this.typeLab.Text = "Type";
            // 
            // previewLab
            // 
            this.previewLab.AutoSize = true;
            this.previewLab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.previewLab.Location = new System.Drawing.Point(31, 150);
            this.previewLab.Name = "previewLab";
            this.previewLab.Size = new System.Drawing.Size(141, 26);
            this.previewLab.TabIndex = 2;
            this.previewLab.Text = "Preview";
            // 
            // addStepLab
            // 
            this.addStepLab.AutoSize = true;
            this.addStepLab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addStepLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addStepLab.Location = new System.Drawing.Point(31, 312);
            this.addStepLab.Name = "addStepLab";
            this.addStepLab.Size = new System.Drawing.Size(141, 26);
            this.addStepLab.TabIndex = 3;
            this.addStepLab.Text = "Add Step";
            // 
            // FeatureDescriptionLab
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.FeatureDescriptionLab, 3);
            this.FeatureDescriptionLab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FeatureDescriptionLab.Location = new System.Drawing.Point(206, 29);
            this.FeatureDescriptionLab.Name = "FeatureDescriptionLab";
            this.FeatureDescriptionLab.Size = new System.Drawing.Size(322, 22);
            this.FeatureDescriptionLab.TabIndex = 9;
            this.FeatureDescriptionLab.Text = "feature description\r\n";
            this.FeatureDescriptionLab.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // titleTB
            // 
            this.titleTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleTB.Location = new System.Drawing.Point(387, 91);
            this.titleTB.Name = "titleTB";
            this.titleTB.Size = new System.Drawing.Size(141, 22);
            this.titleTB.TabIndex = 10;
            this.titleTB.Text = "title";
            this.titleTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // stepsDGV
            // 
            this.stepsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel3.SetColumnSpan(this.stepsDGV, 5);
            this.stepsDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stepsDGV.Location = new System.Drawing.Point(31, 189);
            this.stepsDGV.Name = "stepsDGV";
            this.stepsDGV.RowTemplate.Height = 24;
            this.stepsDGV.Size = new System.Drawing.Size(497, 110);
            this.stepsDGV.TabIndex = 11;
            // 
            // ScenarioTypeCB
            // 
            this.ScenarioTypeCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScenarioTypeCB.FormattingEnabled = true;
            this.ScenarioTypeCB.Location = new System.Drawing.Point(206, 91);
            this.ScenarioTypeCB.Name = "ScenarioTypeCB";
            this.ScenarioTypeCB.Size = new System.Drawing.Size(147, 24);
            this.ScenarioTypeCB.TabIndex = 12;
            // 
            // addBtn
            // 
            this.addBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addBtn.Location = new System.Drawing.Point(31, 403);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(141, 36);
            this.addBtn.TabIndex = 13;
            this.addBtn.Text = "Add Step";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // updateBtn
            // 
            this.updateBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.updateBtn.Location = new System.Drawing.Point(206, 403);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(147, 36);
            this.updateBtn.TabIndex = 14;
            this.updateBtn.Text = "Update Step";
            this.updateBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteBtn.Location = new System.Drawing.Point(387, 403);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(141, 36);
            this.deleteBtn.TabIndex = 15;
            this.deleteBtn.Text = "Delete Step";
            this.deleteBtn.UseVisualStyleBackColor = true;
            // 
            // saveBtn
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.saveBtn, 5);
            this.saveBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.saveBtn.Location = new System.Drawing.Point(31, 455);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(497, 36);
            this.saveBtn.TabIndex = 16;
            this.saveBtn.Text = "Save Scenario";
            this.saveBtn.UseVisualStyleBackColor = true;
            // 
            // stepTypeCB
            // 
            this.stepTypeCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stepTypeCB.FormattingEnabled = true;
            this.stepTypeCB.Location = new System.Drawing.Point(31, 351);
            this.stepTypeCB.Name = "stepTypeCB";
            this.stepTypeCB.Size = new System.Drawing.Size(141, 24);
            this.stepTypeCB.TabIndex = 17;
            // 
            // stepDescriptionLab
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.stepDescriptionLab, 3);
            this.stepDescriptionLab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stepDescriptionLab.Location = new System.Drawing.Point(206, 351);
            this.stepDescriptionLab.Name = "stepDescriptionLab";
            this.stepDescriptionLab.Size = new System.Drawing.Size(322, 22);
            this.stepDescriptionLab.TabIndex = 18;
            this.stepDescriptionLab.Text = "step description";
            this.stepDescriptionLab.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(21, 134);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(330, 363);
            this.textBox1.TabIndex = 1;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 534);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "mainForm";
            this.Text = "GHERKIN Generator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.scenarioPreviewPanel.ResumeLayout(false);
            this.scenarioSetupPanel.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepsDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel scenarioPreviewPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label scenarioPreviewLabel;
        private System.Windows.Forms.Panel scenarioSetupPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label featureLab;
        private System.Windows.Forms.Label typeLab;
        private System.Windows.Forms.Label previewLab;
        private System.Windows.Forms.Label addStepLab;
        private System.Windows.Forms.TextBox FeatureDescriptionLab;
        private System.Windows.Forms.TextBox titleTB;
        private System.Windows.Forms.DataGridView stepsDGV;
        private System.Windows.Forms.ComboBox ScenarioTypeCB;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.ComboBox stepTypeCB;
        private System.Windows.Forms.TextBox stepDescriptionLab;
        private System.Windows.Forms.TextBox textBox1;
    }
}

