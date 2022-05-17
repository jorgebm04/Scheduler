using System.Globalization;
using Scheduler;

namespace Scheduler.Windows
{
    public partial class GUIScheduler : Form
    {
        public GUIScheduler()
        {
            InitializeComponent();
        }

        private void CheckAndCalculate(object sender, EventArgs e)
        {
            nextExecutionTextBox.Text = "";
            descriptionTextBox.Text = "";

            //Fill the Settings
            Settings settings = new Settings();
            try
            {
                settings.currentDate = DateTime.ParseExact(currentDateTextBox.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            } catch (FormatException)
            {
                nextExecutionTextBox.Text = "Current date format not correct.";
            }
            settings.type = typeComboBox.SelectedIndex;
            settings.enable = enabledCheckBox.Checked;
            try
            {
                settings.dateTime = DateTime.ParseExact(dateTimeTextBox.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch (FormatException)
            {
                nextExecutionTextBox.Text = "DateTime format not correct.";
            }
            settings.occurs = occursComboBox.SelectedIndex;
            settings.days = (double)daysNumericUpDown.Value;
            try
            {
                settings.startDate = DateTime.ParseExact(startDateLabel.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch (FormatException)
            {
                nextExecutionTextBox.Text = "Start limit format not correct.";
            }
            try
            {
                settings.endDate = DateTime.ParseExact(endDateLabel.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch (FormatException)
            {
                nextExecutionTextBox.Text = "End limit format not correct.";
            }

            //Check the info
            InfoValidator.CheckInfo(settings);
            nextExecutionTextBox.Text = settings.exit;
            //Calls the calculate method
            if(settings.exit.Length == 0)
            {       
                DateCalculator.calculateDate(settings.currentDate, settings.dateTime,settings);
            } else
            {
                return;
            }
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typeComboBox.SelectedIndex == 0)
            { 
                endDateTextBox.ReadOnly = true;
            }
            if (typeComboBox.SelectedIndex == 1)
            {
                endDateTextBox.ReadOnly = false;
            }
        }

        
    }
}