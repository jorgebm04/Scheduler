namespace Scheduler.Windows
{
    public partial class GUIScheduler
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
            this.daysNumericUpDown = new System.Windows.Forms.NumericUpDown();
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
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.nextExecutionTextBox = new System.Windows.Forms.TextBox();
            this.nextExecutionLabel = new System.Windows.Forms.Label();
            this.inputGroup.SuspendLayout();
            this.configurationGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.daysNumericUpDown)).BeginInit();
            this.limitsGroupBox1.SuspendLayout();
            this.outputGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputGroup
            // 
            this.inputGroup.Controls.Add(this.calculateDateButton);
            this.inputGroup.Controls.Add(this.currentDateTextBox);
            this.inputGroup.Controls.Add(this.currentDateLabel);
            this.inputGroup.Location = new System.Drawing.Point(10, 20);
            this.inputGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputGroup.Name = "inputGroup";
            this.inputGroup.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputGroup.Size = new System.Drawing.Size(542, 49);
            this.inputGroup.TabIndex = 0;
            this.inputGroup.TabStop = false;
            this.inputGroup.Text = "Input";
            // 
            // calculateDateButton
            // 
            this.calculateDateButton.Location = new System.Drawing.Point(290, 14);
            this.calculateDateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calculateDateButton.Name = "calculateDateButton";
            this.calculateDateButton.Size = new System.Drawing.Size(247, 22);
            this.calculateDateButton.TabIndex = 2;
            this.calculateDateButton.Text = "Calculate next date";
            this.calculateDateButton.UseVisualStyleBackColor = true;
            this.calculateDateButton.Click += new System.EventHandler(this.CheckAndCalculate);
            // 
            // currentDateTextBox
            // 
            this.currentDateTextBox.Location = new System.Drawing.Point(156, 15);
            this.currentDateTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.currentDateTextBox.Name = "currentDateTextBox";
            this.currentDateTextBox.Size = new System.Drawing.Size(130, 23);
            this.currentDateTextBox.TabIndex = 1;
            this.currentDateTextBox.Text = "17/05/2022";
            // 
            // currentDateLabel
            // 
            this.currentDateLabel.AutoSize = true;
            this.currentDateLabel.Location = new System.Drawing.Point(5, 17);
            this.currentDateLabel.Name = "currentDateLabel";
            this.currentDateLabel.Size = new System.Drawing.Size(74, 15);
            this.currentDateLabel.TabIndex = 0;
            this.currentDateLabel.Text = "Current Date";
            // 
            // configurationGroup
            // 
            this.configurationGroup.Controls.Add(this.daysNumericUpDown);
            this.configurationGroup.Controls.Add(this.daysLabel);
            this.configurationGroup.Controls.Add(this.everyLabel);
            this.configurationGroup.Controls.Add(this.occursComboBox);
            this.configurationGroup.Controls.Add(this.ocursLabel);
            this.configurationGroup.Controls.Add(this.dateTimeTextBox);
            this.configurationGroup.Controls.Add(this.dateTimeLabel);
            this.configurationGroup.Controls.Add(this.enabledCheckBox);
            this.configurationGroup.Controls.Add(this.typeComboBox);
            this.configurationGroup.Controls.Add(this.typeLabel);
            this.configurationGroup.Location = new System.Drawing.Point(10, 74);
            this.configurationGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.configurationGroup.Name = "configurationGroup";
            this.configurationGroup.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.configurationGroup.Size = new System.Drawing.Size(542, 127);
            this.configurationGroup.TabIndex = 1;
            this.configurationGroup.TabStop = false;
            this.configurationGroup.Text = "Configuration";
            // 
            // daysNumericUpDown
            // 
            this.daysNumericUpDown.Location = new System.Drawing.Point(414, 97);
            this.daysNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.daysNumericUpDown.Name = "daysNumericUpDown";
            this.daysNumericUpDown.Size = new System.Drawing.Size(49, 23);
            this.daysNumericUpDown.TabIndex = 10;
            // 
            // daysLabel
            // 
            this.daysLabel.AutoSize = true;
            this.daysLabel.Location = new System.Drawing.Point(468, 100);
            this.daysLabel.Name = "daysLabel";
            this.daysLabel.Size = new System.Drawing.Size(39, 15);
            this.daysLabel.TabIndex = 9;
            this.daysLabel.Text = "day(s)";
            // 
            // everyLabel
            // 
            this.everyLabel.AutoSize = true;
            this.everyLabel.Location = new System.Drawing.Point(290, 100);
            this.everyLabel.Name = "everyLabel";
            this.everyLabel.Size = new System.Drawing.Size(35, 15);
            this.everyLabel.TabIndex = 7;
            this.everyLabel.Text = "Every";
            // 
            // occursComboBox
            // 
            this.occursComboBox.FormattingEnabled = true;
            this.occursComboBox.Items.AddRange(new object[] {
            "Daily"});
            this.occursComboBox.Location = new System.Drawing.Point(153, 98);
            this.occursComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.occursComboBox.Name = "occursComboBox";
            this.occursComboBox.Size = new System.Drawing.Size(133, 23);
            this.occursComboBox.TabIndex = 6;
            // 
            // ocursLabel
            // 
            this.ocursLabel.AutoSize = true;
            this.ocursLabel.Location = new System.Drawing.Point(5, 98);
            this.ocursLabel.Name = "ocursLabel";
            this.ocursLabel.Size = new System.Drawing.Size(44, 15);
            this.ocursLabel.TabIndex = 5;
            this.ocursLabel.Text = "Occurs";
            // 
            // dateTimeTextBox
            // 
            this.dateTimeTextBox.Location = new System.Drawing.Point(153, 54);
            this.dateTimeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimeTextBox.Name = "dateTimeTextBox";
            this.dateTimeTextBox.Size = new System.Drawing.Size(385, 23);
            this.dateTimeTextBox.TabIndex = 4;
            // 
            // dateTimeLabel
            // 
            this.dateTimeLabel.AutoSize = true;
            this.dateTimeLabel.Location = new System.Drawing.Point(5, 56);
            this.dateTimeLabel.Name = "dateTimeLabel";
            this.dateTimeLabel.Size = new System.Drawing.Size(57, 15);
            this.dateTimeLabel.TabIndex = 3;
            this.dateTimeLabel.Text = "DateTime";
            // 
            // enabledCheckBox
            // 
            this.enabledCheckBox.AutoSize = true;
            this.enabledCheckBox.Checked = true;
            this.enabledCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enabledCheckBox.Location = new System.Drawing.Point(290, 20);
            this.enabledCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enabledCheckBox.Name = "enabledCheckBox";
            this.enabledCheckBox.Size = new System.Drawing.Size(68, 19);
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
            this.typeComboBox.Location = new System.Drawing.Point(153, 17);
            this.typeComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(133, 23);
            this.typeComboBox.TabIndex = 1;
            this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged);
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(5, 17);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(31, 15);
            this.typeLabel.TabIndex = 0;
            this.typeLabel.Text = "Type";
            // 
            // limitsGroupBox1
            // 
            this.limitsGroupBox1.Controls.Add(this.endDateTextBox);
            this.limitsGroupBox1.Controls.Add(this.endDateLabel);
            this.limitsGroupBox1.Controls.Add(this.startDateTextBox);
            this.limitsGroupBox1.Controls.Add(this.startDateLabel);
            this.limitsGroupBox1.Location = new System.Drawing.Point(10, 205);
            this.limitsGroupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.limitsGroupBox1.Name = "limitsGroupBox1";
            this.limitsGroupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.limitsGroupBox1.Size = new System.Drawing.Size(542, 46);
            this.limitsGroupBox1.TabIndex = 2;
            this.limitsGroupBox1.TabStop = false;
            this.limitsGroupBox1.Text = "Limits";
            // 
            // endDateTextBox
            // 
            this.endDateTextBox.Location = new System.Drawing.Point(378, 17);
            this.endDateTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.endDateTextBox.Name = "endDateTextBox";
            this.endDateTextBox.Size = new System.Drawing.Size(160, 23);
            this.endDateTextBox.TabIndex = 3;
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(288, 20);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(53, 15);
            this.endDateLabel.TabIndex = 2;
            this.endDateLabel.Text = "End date";
            // 
            // startDateTextBox
            // 
            this.startDateTextBox.Location = new System.Drawing.Point(153, 17);
            this.startDateTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startDateTextBox.Name = "startDateTextBox";
            this.startDateTextBox.Size = new System.Drawing.Size(130, 23);
            this.startDateTextBox.TabIndex = 1;
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(5, 17);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(57, 15);
            this.startDateLabel.TabIndex = 0;
            this.startDateLabel.Text = "Start date";
            // 
            // outputGroupBox1
            // 
            this.outputGroupBox1.Controls.Add(this.descriptionTextBox);
            this.outputGroupBox1.Controls.Add(this.descriptionLabel);
            this.outputGroupBox1.Controls.Add(this.nextExecutionTextBox);
            this.outputGroupBox1.Controls.Add(this.nextExecutionLabel);
            this.outputGroupBox1.Location = new System.Drawing.Point(10, 255);
            this.outputGroupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.outputGroupBox1.Name = "outputGroupBox1";
            this.outputGroupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.outputGroupBox1.Size = new System.Drawing.Size(542, 129);
            this.outputGroupBox1.TabIndex = 3;
            this.outputGroupBox1.TabStop = false;
            this.outputGroupBox1.Text = "Output";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(5, 60);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(532, 45);
            this.descriptionTextBox.TabIndex = 3;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(5, 43);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(67, 15);
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.Text = "Description";
            // 
            // nextExecutionTextBox
            // 
            this.nextExecutionTextBox.Location = new System.Drawing.Point(153, 15);
            this.nextExecutionTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nextExecutionTextBox.Name = "nextExecutionTextBox";
            this.nextExecutionTextBox.ReadOnly = true;
            this.nextExecutionTextBox.Size = new System.Drawing.Size(385, 23);
            this.nextExecutionTextBox.TabIndex = 1;
            // 
            // nextExecutionLabel
            // 
            this.nextExecutionLabel.AutoSize = true;
            this.nextExecutionLabel.Location = new System.Drawing.Point(5, 17);
            this.nextExecutionLabel.Name = "nextExecutionLabel";
            this.nextExecutionLabel.Size = new System.Drawing.Size(114, 15);
            this.nextExecutionLabel.TabIndex = 0;
            this.nextExecutionLabel.Text = "Next execution time";
            // 
            // GUIScheduler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 400);
            this.Controls.Add(this.outputGroupBox1);
            this.Controls.Add(this.limitsGroupBox1);
            this.Controls.Add(this.configurationGroup);
            this.Controls.Add(this.inputGroup);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GUIScheduler";
            this.Text = "Scheduler";
            this.inputGroup.ResumeLayout(false);
            this.inputGroup.PerformLayout();
            this.configurationGroup.ResumeLayout(false);
            this.configurationGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.daysNumericUpDown)).EndInit();
            this.limitsGroupBox1.ResumeLayout(false);
            this.limitsGroupBox1.PerformLayout();
            this.outputGroupBox1.ResumeLayout(false);
            this.outputGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public GroupBox inputGroup;
        public Button calculateDateButton;
        public TextBox currentDateTextBox;
        public Label currentDateLabel;
        public GroupBox configurationGroup;
        public CheckBox enabledCheckBox;
        public ComboBox typeComboBox;
        public Label typeLabel;
        public Label ocursLabel;
        public TextBox dateTimeTextBox;
        public Label dateTimeLabel;
        public Label daysLabel;
        public Label everyLabel;
        public ComboBox occursComboBox;
        public NumericUpDown daysNumericUpDown;
        public GroupBox limitsGroupBox1;
        public TextBox endDateTextBox;
        public Label endDateLabel;
        public TextBox startDateTextBox;
        public Label startDateLabel;
        public GroupBox outputGroupBox1;
        public TextBox descriptionTextBox;
        public Label descriptionLabel;
        public TextBox nextExecutionTextBox;
        public Label nextExecutionLabel;
    }
}