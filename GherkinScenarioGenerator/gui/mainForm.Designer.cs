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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.scenarioPreviewPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.scenarioPreviewLabel = new System.Windows.Forms.Label();
            this.scenarioPreviewTB = new System.Windows.Forms.RichTextBox();
            this.scenarioSetupPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.featureLab = new System.Windows.Forms.Label();
            this.typeLab = new System.Windows.Forms.Label();
            this.previewLab = new System.Windows.Forms.Label();
            this.addStepLab = new System.Windows.Forms.Label();
            this.featureDescriptionTB = new System.Windows.Forms.RichTextBox();
            this.scenarioTitleTB = new System.Windows.Forms.RichTextBox();
            this.scenarioTypeCB = new System.Windows.Forms.ComboBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.stepTypeCB = new System.Windows.Forms.ComboBox();
            this.stepDescriptionTB = new System.Windows.Forms.RichTextBox();
            this.stepsDGV = new System.Windows.Forms.DataGridView();
            this.mainFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.scenarioPreviewPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.scenarioSetupPanel.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormBindingSource)).BeginInit();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1317, 618);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // scenarioPreviewPanel
            // 
            this.scenarioPreviewPanel.Controls.Add(this.tableLayoutPanel2);
            this.scenarioPreviewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scenarioPreviewPanel.Location = new System.Drawing.Point(940, 3);
            this.scenarioPreviewPanel.Name = "scenarioPreviewPanel";
            this.scenarioPreviewPanel.Size = new System.Drawing.Size(374, 612);
            this.scenarioPreviewPanel.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.Controls.Add(this.scenarioPreviewLabel, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.scenarioPreviewTB, 1, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(374, 612);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // scenarioPreviewLabel
            // 
            this.scenarioPreviewLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scenarioPreviewLabel.AutoSize = true;
            this.scenarioPreviewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.scenarioPreviewLabel.Location = new System.Drawing.Point(21, 30);
            this.scenarioPreviewLabel.Name = "scenarioPreviewLabel";
            this.scenarioPreviewLabel.Size = new System.Drawing.Size(330, 91);
            this.scenarioPreviewLabel.TabIndex = 0;
            this.scenarioPreviewLabel.Text = "Preview of Scenario";
            this.scenarioPreviewLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scenarioPreviewTB
            // 
            this.scenarioPreviewTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scenarioPreviewTB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.scenarioPreviewTB.Location = new System.Drawing.Point(21, 154);
            this.scenarioPreviewTB.Name = "scenarioPreviewTB";
            this.scenarioPreviewTB.Size = new System.Drawing.Size(330, 422);
            this.scenarioPreviewTB.TabIndex = 1;
            this.scenarioPreviewTB.Text = "";
            this.scenarioPreviewTB.TextChanged += new System.EventHandler(this.scenarioPreviewTB_TextChanged);
            // 
            // scenarioSetupPanel
            // 
            this.scenarioSetupPanel.Controls.Add(this.tableLayoutPanel3);
            this.scenarioSetupPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scenarioSetupPanel.Location = new System.Drawing.Point(3, 3);
            this.scenarioSetupPanel.Name = "scenarioSetupPanel";
            this.scenarioSetupPanel.Size = new System.Drawing.Size(931, 612);
            this.scenarioSetupPanel.TabIndex = 1;
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
            this.tableLayoutPanel3.Controls.Add(this.featureDescriptionTB, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.scenarioTitleTB, 5, 3);
            this.tableLayoutPanel3.Controls.Add(this.scenarioTypeCB, 3, 3);
            this.tableLayoutPanel3.Controls.Add(this.deleteBtn, 5, 13);
            this.tableLayoutPanel3.Controls.Add(this.updateBtn, 3, 13);
            this.tableLayoutPanel3.Controls.Add(this.addBtn, 1, 13);
            this.tableLayoutPanel3.Controls.Add(this.saveBtn, 1, 15);
            this.tableLayoutPanel3.Controls.Add(this.stepTypeCB, 1, 11);
            this.tableLayoutPanel3.Controls.Add(this.stepDescriptionTB, 3, 11);
            this.tableLayoutPanel3.Controls.Add(this.stepsDGV, 1, 7);
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
            this.tableLayoutPanel3.Size = new System.Drawing.Size(931, 612);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // featureLab
            // 
            this.featureLab.AutoSize = true;
            this.featureLab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.featureLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.featureLab.Location = new System.Drawing.Point(50, 30);
            this.featureLab.Name = "featureLab";
            this.featureLab.Size = new System.Drawing.Size(238, 61);
            this.featureLab.TabIndex = 0;
            this.featureLab.Text = "Feature";
            // 
            // typeLab
            // 
            this.typeLab.AutoSize = true;
            this.typeLab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typeLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.typeLab.Location = new System.Drawing.Point(50, 103);
            this.typeLab.Name = "typeLab";
            this.typeLab.Size = new System.Drawing.Size(238, 61);
            this.typeLab.TabIndex = 1;
            this.typeLab.Text = "Type";
            // 
            // previewLab
            // 
            this.previewLab.AutoSize = true;
            this.previewLab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.previewLab.Location = new System.Drawing.Point(50, 176);
            this.previewLab.Name = "previewLab";
            this.previewLab.Size = new System.Drawing.Size(238, 30);
            this.previewLab.TabIndex = 2;
            this.previewLab.Text = "Preview";
            // 
            // addStepLab
            // 
            this.addStepLab.AutoSize = true;
            this.addStepLab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addStepLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addStepLab.Location = new System.Drawing.Point(50, 364);
            this.addStepLab.Name = "addStepLab";
            this.addStepLab.Size = new System.Drawing.Size(238, 30);
            this.addStepLab.TabIndex = 3;
            this.addStepLab.Text = "Add Step";
            // 
            // featureDescriptionTB
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.featureDescriptionTB, 3);
            this.featureDescriptionTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.featureDescriptionTB.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.featureDescriptionTB.Location = new System.Drawing.Point(341, 33);
            this.featureDescriptionTB.Name = "featureDescriptionTB";
            this.featureDescriptionTB.Size = new System.Drawing.Size(538, 55);
            this.featureDescriptionTB.TabIndex = 9;
            this.featureDescriptionTB.TabStop = false;
            this.featureDescriptionTB.Text = "Feature Description";
            this.featureDescriptionTB.TextChanged += new System.EventHandler(this.display_scenario_preview);
            this.featureDescriptionTB.Enter += new System.EventHandler(this.featureDescriptionTB_Enter);
            this.featureDescriptionTB.Leave += new System.EventHandler(this.featureDescriptionTB_Leave);
            // 
            // scenarioTitleTB
            // 
            this.scenarioTitleTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scenarioTitleTB.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.scenarioTitleTB.Location = new System.Drawing.Point(641, 106);
            this.scenarioTitleTB.Name = "scenarioTitleTB";
            this.scenarioTitleTB.Size = new System.Drawing.Size(238, 55);
            this.scenarioTitleTB.TabIndex = 10;
            this.scenarioTitleTB.Text = "Scenario Title";
            this.scenarioTitleTB.TextChanged += new System.EventHandler(this.display_scenario_preview);
            this.scenarioTitleTB.Enter += new System.EventHandler(this.titleTB_Enter);
            this.scenarioTitleTB.Leave += new System.EventHandler(this.titleTB_Leave);
            // 
            // scenarioTypeCB
            // 
            this.scenarioTypeCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scenarioTypeCB.FormattingEnabled = true;
            this.scenarioTypeCB.Items.AddRange(new object[] {
            "Scenario",
            "Scenario Outline"});
            this.scenarioTypeCB.Location = new System.Drawing.Point(341, 106);
            this.scenarioTypeCB.Name = "scenarioTypeCB";
            this.scenarioTypeCB.Size = new System.Drawing.Size(247, 24);
            this.scenarioTypeCB.TabIndex = 12;
            this.scenarioTypeCB.TextChanged += new System.EventHandler(this.display_scenario_preview);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteBtn.Location = new System.Drawing.Point(641, 469);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(238, 42);
            this.deleteBtn.TabIndex = 15;
            this.deleteBtn.Text = "Delete Step";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.click_delete_btn);
            // 
            // updateBtn
            // 
            this.updateBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.updateBtn.Location = new System.Drawing.Point(341, 469);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(247, 42);
            this.updateBtn.TabIndex = 14;
            this.updateBtn.Text = "Update Step";
            this.updateBtn.UseVisualStyleBackColor = true;
            // 
            // addBtn
            // 
            this.addBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addBtn.Location = new System.Drawing.Point(50, 469);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(238, 42);
            this.addBtn.TabIndex = 13;
            this.addBtn.Text = "Add Step";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.click_add_step_btn);
            // 
            // saveBtn
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.saveBtn, 5);
            this.saveBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.saveBtn.Location = new System.Drawing.Point(50, 529);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(829, 42);
            this.saveBtn.TabIndex = 16;
            this.saveBtn.Text = "Save Scenario";
            this.saveBtn.UseVisualStyleBackColor = true;
            // 
            // stepTypeCB
            // 
            this.stepTypeCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stepTypeCB.FormattingEnabled = true;
            this.stepTypeCB.Items.AddRange(new object[] {
            "Given",
            "When",
            "Then"});
            this.stepTypeCB.Location = new System.Drawing.Point(50, 409);
            this.stepTypeCB.Name = "stepTypeCB";
            this.stepTypeCB.Size = new System.Drawing.Size(238, 24);
            this.stepTypeCB.TabIndex = 17;
            this.stepTypeCB.TextChanged += new System.EventHandler(this.display_scenario_preview);
            // 
            // stepDescriptionTB
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.stepDescriptionTB, 3);
            this.stepDescriptionTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stepDescriptionTB.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.stepDescriptionTB.Location = new System.Drawing.Point(341, 409);
            this.stepDescriptionTB.Name = "stepDescriptionTB";
            this.stepDescriptionTB.Size = new System.Drawing.Size(538, 42);
            this.stepDescriptionTB.TabIndex = 18;
            this.stepDescriptionTB.Text = "Step Description";
            this.stepDescriptionTB.TextChanged += new System.EventHandler(this.display_scenario_preview);
            this.stepDescriptionTB.Enter += new System.EventHandler(this.stepDescriptionTB_Enter);
            this.stepDescriptionTB.Leave += new System.EventHandler(this.stepDescriptionTB_Leave);
            // 
            // stepsDGV
            // 
            this.stepsDGV.AllowUserToAddRows = false;
            this.stepsDGV.AllowUserToDeleteRows = false;
            this.stepsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stepsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel3.SetColumnSpan(this.stepsDGV, 5);
            this.stepsDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stepsDGV.Location = new System.Drawing.Point(50, 221);
            this.stepsDGV.Name = "stepsDGV";
            this.stepsDGV.ReadOnly = true;
            this.stepsDGV.RowTemplate.Height = 24;
            this.stepsDGV.Size = new System.Drawing.Size(829, 128);
            this.stepsDGV.TabIndex = 19;
            // 
            // mainFormBindingSource
            // 
            this.mainFormBindingSource.DataSource = typeof(GherkinScenarioGenerator.mainForm);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 618);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "mainForm";
            this.Text = "GHERKIN Generator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.scenarioPreviewPanel.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.scenarioSetupPanel.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormBindingSource)).EndInit();
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
        private System.Windows.Forms.RichTextBox featureDescriptionTB;
        private System.Windows.Forms.RichTextBox scenarioTitleTB;
        private System.Windows.Forms.ComboBox scenarioTypeCB;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.ComboBox stepTypeCB;
        private System.Windows.Forms.RichTextBox stepDescriptionTB;
        private System.Windows.Forms.RichTextBox scenarioPreviewTB;
        private System.Windows.Forms.BindingSource mainFormBindingSource;
        private System.Windows.Forms.DataGridView stepsDGV;
    }
}

