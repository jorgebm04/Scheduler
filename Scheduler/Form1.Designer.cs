namespace Scheduler
{
    partial class GUIScheduler
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputGroup = new System.Windows.Forms.GroupBox();
            this.calculateDateButton = new System.Windows.Forms.Button();
            this.currentDateTextBox = new System.Windows.Forms.TextBox();
            this.currentDateLabel = new System.Windows.Forms.Label();
            this.configurationGroup = new System.Windows.Forms.GroupBox();
            this.daysNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.daysLabel = new System.Windows.Forms.Label();
            this.everyLabel = new System.Windows.Forms.Label();
            this.occursComboBox = new System.Windows.Forms.ComboBox();
            this.ocursLabel = new System.Windows.Forms.Label();
            this.dateTimeTextBox = new System.Windows.Forms.TextBox();
            this.dateTimeLabel = new System.Windows.Forms.Label();
            this.enabledCheckBox = new System.Windows.Forms.CheckBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.limitsGroupBox1 = new System.Windows.Forms.GroupBox();
            this.endDateTextBox = new System.Windows.Forms.TextBox();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.startDateTextBox = new System.Windows.Forms.TextBox();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.outputGroupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.nextExecutionTextBox = new System.Windows.Forms.TextBox();
            this.nextExecutionLabel = new System.Windows.Forms.Label();
            this.inputGroup.SuspendLayout();
            this.configurationGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.daysNumericUpDown1)).BeginInit();
            this.limitsGroupBox1.SuspendLayout();
            this.outputGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputGroup
            // 
            this.inputGroup.Controls.Add(this.calculateDateButton);
            this.inputGroup.Controls.Add(this.currentDateTextBox);
            this.inputGroup.Controls.Add(this.currentDateLabel);
            this.inputGroup.Location = new System.Drawing.Point(12, 27);
            this.inputGroup.Name = "inputGroup";
            this.inputGroup.Size = new System.Drawing.Size(620, 65);
            this.inputGroup.TabIndex = 0;
            this.inputGroup.TabStop = false;
            this.inputGroup.Text = "Input";
            // 
            // calculateDateButton
            // 
            this.calculateDateButton.Location = new System.Drawing.Point(332, 19);
            this.calculateDateButton.Name = "calculateDateButton";
            this.calculateDateButton.Size = new System.Drawing.Size(282, 29);
            this.calculateDateButton.TabIndex = 2;
            this.calculateDateButton.Text = "Calculate next date";
            this.calculateDateButton.UseVisualStyleBackColor = true;
            this.calculateDateButton.Click += new System.EventHandler(this.CheckInfo);
            // 
            // currentDateTextBox
            // 
            this.currentDateTextBox.Location = new System.Drawing.Point(178, 20);
            this.currentDateTextBox.Name = "currentDateTextBox";
            this.currentDateTextBox.Size = new System.Drawing.Size(148, 27);
            this.currentDateTextBox.TabIndex = 1;
            this.currentDateTextBox.Text = "13/05/2022";
            // 
            // currentDateLabel
            // 
            this.currentDateLabel.AutoSize = true;
            this.currentDateLabel.Location = new System.Drawing.Point(6, 23);
            this.currentDateLabel.Name = "currentDateLabel";
            this.currentDateLabel.Size = new System.Drawing.Size(93, 20);
            this.currentDateLabel.TabIndex = 0;
            this.currentDateLabel.Text = "Current Date";
            // 
            // configurationGroup
            // 
            this.configurationGroup.Controls.Add(this.daysNumericUpDown1);
            this.configurationGroup.Controls.Add(this.daysLabel);
            this.configurationGroup.Controls.Add(this.everyLabel);
            this.configurationGroup.Controls.Add(this.occursComboBox);
            this.configurationGroup.Controls.Add(this.ocursLabel);
            this.configurationGroup.Controls.Add(this.dateTimeTextBox);
            this.configurationGroup.Controls.Add(this.dateTimeLabel);
            this.configurationGroup.Controls.Add(this.enabledCheckBox);
            this.configurationGroup.Controls.Add(this.typeComboBox);
            this.configurationGroup.Controls.Add(this.typeLabel);
            this.configurationGroup.Location = new System.Drawing.Point(12, 98);
            this.configurationGroup.Name = "configurationGroup";
            this.configurationGroup.Size = new System.Drawing.Size(620, 169);
            this.configurationGroup.TabIndex = 1;
            this.configurationGroup.TabStop = false;
            this.configurationGroup.Text = "Configuration";
            // 
            // daysNumericUpDown1
            // 
            this.daysNumericUpDown1.Location = new System.Drawing.Point(473, 129);
            this.daysNumericUpDown1.Name = "daysNumericUpDown1";
            this.daysNumericUpDown1.Size = new System.Drawing.Size(56, 27);
            this.daysNumericUpDown1.TabIndex = 10;
            // 
            // daysLabel
            // 
            this.daysLabel.AutoSize = true;
            this.daysLabel.Location = new System.Drawing.Point(535, 134);
            this.daysLabel.Name = "daysLabel";
            this.daysLabel.Size = new System.Drawing.Size(49, 20);
            this.daysLabel.TabIndex = 9;
            this.daysLabel.Text = "day(s)";
            // 
            // everyLabel
            // 
            this.everyLabel.AutoSize = true;
            this.everyLabel.Location = new System.Drawing.Point(332, 134);
            this.everyLabel.Name = "everyLabel";
            this.everyLabel.Size = new System.Drawing.Size(44, 20);
            this.everyLabel.TabIndex = 7;
            this.everyLabel.Text = "Every";
            // 
            // occursComboBox
            // 
            this.occursComboBox.FormattingEnabled = true;
            this.occursComboBox.Items.AddRange(new object[] {
            "Daily"});
            this.occursComboBox.Location = new System.Drawing.Point(175, 131);
            this.occursComboBox.Name = "occursComboBox";
            this.occursComboBox.Size = new System.Drawing.Size(151, 28);
            this.occursComboBox.TabIndex = 6;
            this.occursComboBox.SelectedIndexChanged += new System.EventHandler(this.occursComboBox_SelectedIndexChanged);
            // 
            // ocursLabel
            // 
            this.ocursLabel.AutoSize = true;
            this.ocursLabel.Location = new System.Drawing.Point(6, 131);
            this.ocursLabel.Name = "ocursLabel";
            this.ocursLabel.Size = new System.Drawing.Size(53, 20);
            this.ocursLabel.TabIndex = 5;
            this.ocursLabel.Text = "Occurs";
            // 
            // dateTimeTextBox
            // 
            this.dateTimeTextBox.Location = new System.Drawing.Point(175, 72);
            this.dateTimeTextBox.Name = "dateTimeTextBox";
            this.dateTimeTextBox.Size = new System.Drawing.Size(439, 27);
            this.dateTimeTextBox.TabIndex = 4;
            // 
            // dateTimeLabel
            // 
            this.dateTimeLabel.AutoSize = true;
            this.dateTimeLabel.Location = new System.Drawing.Point(6, 75);
            this.dateTimeLabel.Name = "dateTimeLabel";
            this.dateTimeLabel.Size = new System.Drawing.Size(74, 20);
            this.dateTimeLabel.TabIndex = 3;
            this.dateTimeLabel.Text = "DateTime";
            // 
            // enabledCheckBox
            // 
            this.enabledCheckBox.AutoSize = true;
            this.enabledCheckBox.Checked = true;
            this.enabledCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enabledCheckBox.Location = new System.Drawing.Point(332, 27);
            this.enabledCheckBox.Name = "enabledCheckBox";
            this.enabledCheckBox.Size = new System.Drawing.Size(85, 24);
            this.enabledCheckBox.TabIndex = 2;
            this.enabledCheckBox.Text = "Enabled";
            this.enabledCheckBox.UseVisualStyleBackColor = true;
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Once",
            "Recurring"});
            this.typeComboBox.Location = new System.Drawing.Point(175, 23);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(151, 28);
            this.typeComboBox.TabIndex = 1;
            this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged);
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(6, 23);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(40, 20);
            this.typeLabel.TabIndex = 0;
            this.typeLabel.Text = "Type";
            // 
            // limitsGroupBox1
            // 
            this.limitsGroupBox1.Controls.Add(this.endDateTextBox);
            this.limitsGroupBox1.Controls.Add(this.endDateLabel);
            this.limitsGroupBox1.Controls.Add(this.startDateTextBox);
            this.limitsGroupBox1.Controls.Add(this.startDateLabel);
            this.limitsGroupBox1.Location = new System.Drawing.Point(12, 273);
            this.limitsGroupBox1.Name = "limitsGroupBox1";
            this.limitsGroupBox1.Size = new System.Drawing.Size(620, 61);
            this.limitsGroupBox1.TabIndex = 2;
            this.limitsGroupBox1.TabStop = false;
            this.limitsGroupBox1.Text = "Limits";
            // 
            // endDateTextBox
            // 
            this.endDateTextBox.Location = new System.Drawing.Point(432, 23);
            this.endDateTextBox.Name = "endDateTextBox";
            this.endDateTextBox.Size = new System.Drawing.Size(182, 27);
            this.endDateTextBox.TabIndex = 3;
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(329, 26);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(68, 20);
            this.endDateLabel.TabIndex = 2;
            this.endDateLabel.Text = "End date";
            // 
            // startDateTextBox
            // 
            this.startDateTextBox.Location = new System.Drawing.Point(175, 23);
            this.startDateTextBox.Name = "startDateTextBox";
            this.startDateTextBox.Size = new System.Drawing.Size(148, 27);
            this.startDateTextBox.TabIndex = 1;
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(6, 23);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(74, 20);
            this.startDateLabel.TabIndex = 0;
            this.startDateLabel.Text = "Start date";
            // 
            // outputGroupBox1
            // 
            this.outputGroupBox1.Controls.Add(this.textBox1);
            this.outputGroupBox1.Controls.Add(this.descriptionLabel);
            this.outputGroupBox1.Controls.Add(this.nextExecutionTextBox);
            this.outputGroupBox1.Controls.Add(this.nextExecutionLabel);
            this.outputGroupBox1.Location = new System.Drawing.Point(12, 340);
            this.outputGroupBox1.Name = "outputGroupBox1";
            this.outputGroupBox1.Size = new System.Drawing.Size(620, 172);
            this.outputGroupBox1.TabIndex = 3;
            this.outputGroupBox1.TabStop = false;
            this.outputGroupBox1.Text = "Output";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 80);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(608, 59);
            this.textBox1.TabIndex = 3;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(6, 57);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(85, 20);
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.Text = "Description";
            // 
            // nextExecutionTextBox
            // 
            this.nextExecutionTextBox.Location = new System.Drawing.Point(175, 20);
            this.nextExecutionTextBox.Name = "nextExecutionTextBox";
            this.nextExecutionTextBox.ReadOnly = true;
            this.nextExecutionTextBox.Size = new System.Drawing.Size(439, 27);
            this.nextExecutionTextBox.TabIndex = 1;
            // 
            // nextExecutionLabel
            // 
            this.nextExecutionLabel.AutoSize = true;
            this.nextExecutionLabel.Location = new System.Drawing.Point(6, 23);
            this.nextExecutionLabel.Name = "nextExecutionLabel";
            this.nextExecutionLabel.Size = new System.Drawing.Size(142, 20);
            this.nextExecutionLabel.TabIndex = 0;
            this.nextExecutionLabel.Text = "Next execution time";
            // 
            // GUIScheduler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 533);
            this.Controls.Add(this.outputGroupBox1);
            this.Controls.Add(this.limitsGroupBox1);
            this.Controls.Add(this.configurationGroup);
            this.Controls.Add(this.inputGroup);
            this.Name = "GUIScheduler";
            this.Text = "Scheduler";
            this.inputGroup.ResumeLayout(false);
            this.inputGroup.PerformLayout();
            this.configurationGroup.ResumeLayout(false);
            this.configurationGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.daysNumericUpDown1)).EndInit();
            this.limitsGroupBox1.ResumeLayout(false);
            this.limitsGroupBox1.PerformLayout();
            this.outputGroupBox1.ResumeLayout(false);
            this.outputGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox inputGroup;
        private Button calculateDateButton;
        private TextBox currentDateTextBox;
        private Label currentDateLabel;
        private GroupBox configurationGroup;
        private CheckBox enabledCheckBox;
        private ComboBox typeComboBox;
        private Label typeLabel;
        private Label ocursLabel;
        private TextBox dateTimeTextBox;
        private Label dateTimeLabel;
        private Label daysLabel;
        private Label everyLabel;
        private ComboBox occursComboBox;
        private NumericUpDown daysNumericUpDown1;
        private GroupBox limitsGroupBox1;
        private TextBox endDateTextBox;
        private Label endDateLabel;
        private TextBox startDateTextBox;
        private Label startDateLabel;
        private GroupBox outputGroupBox1;
        private TextBox textBox1;
        private Label descriptionLabel;
        private TextBox nextExecutionTextBox;
        private Label nextExecutionLabel;
    }
}