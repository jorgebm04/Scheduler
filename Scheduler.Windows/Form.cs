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
                return;
            }
            settings.type = typeComboBox.SelectedIndex;
            settings.enable = enabledCheckBox.Checked;
            if(settings.type == (int)EnumTypes.Types.Once)
            {
                try
                {
                    settings.dateTime = DateTime.ParseExact(dateTimeTextBox.Text, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
                }
                catch (FormatException)
                {
                    nextExecutionTextBox.Text = "DateTime format not correct.";
                    return;
                }
            }
            
            settings.occurs = occursComboBox.SelectedIndex;
            settings.days = (double)daysNumericUpDown.Value;
            try
            {
                settings.startDate = DateTime.ParseExact(startDateTextBox.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch (FormatException)
            {
                nextExecutionTextBox.Text = "Start limit format not correct.";
                return;
            }
            if (settings.type == (int)EnumTypes.Types.Recurring)
            {
                try
                {
                    settings.endDate = DateTime.ParseExact(endDateTextBox.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                }
                catch (FormatException)
                {
                    nextExecutionTextBox.Text = "End limit format not correct.";
                    return;
                }
            }           
      
            //Check the info
            InfoValidator.CheckInfo(settings);
            nextExecutionTextBox.Text = settings.exit;
            
            //Calls the calculate method
            if(settings.exit.Length == 0)
            {       
                DateCalculator.CalculateDate(settings.currentDate, settings.dateTime,settings);
                nextExecutionTextBox.Text = settings.exit;
                descriptionTextBox.Text = settings.description;
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