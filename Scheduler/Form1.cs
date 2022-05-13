

namespace Scheduler
{
    public partial class GUIScheduler : Form
    {
        public GUIScheduler()
        {
            InitializeComponent();
        }

       private void CheckInfo(object sender, EventArgs e)
        {
            //Checks the Current Date
            try
            {
                CurrentDayChecker currentDayChecker = new CurrentDayChecker();
                currentDayChecker.checkCurrentDate(currentDateTextBox.Text);
            }
            catch (System.FormatException)
            {
                nextExecutionTextBox.Text = "Current date format not valid.";
                return;
            }
            catch (System.Exception)
            {
                nextExecutionTextBox.Text = "Current date not valid.";
                return;
            }

            //Checks the Enabled Button
            try
            {
                EnabledChecker enabledChecker = new EnabledChecker();
                Boolean enabled = enabledChecker.checkEnabled(enabledCheckBox);
            } catch (System.Exception)
            {
                nextExecutionTextBox.Text = "No schedule enabled";
                return;
            }

            //Checks the Type
            try
            {
                TypeChecker typeChecker = new TypeChecker();
                String type = typeChecker.checkScheduleType(typeComboBox);
            } catch (System.Exception)
            {
                nextExecutionTextBox.Text = "Select a type of schedule.";
                return;
            }

            //Checks the DateTime
            try
            {
                DateTimeChecker dateTimeChecker = new DateTimeChecker();
                DateTime checkedDate = dateTimeChecker.checkDateTime(dateTimeTextBox.Text);

            }catch (System.FormatException)
            {
                nextExecutionTextBox.Text = "DateTime format not valid.";
                return;
            }
            catch (System.Exception)
            {
                nextExecutionTextBox.Text = "DateTime not valid.";
                return;
            }

            //Checks the Limits
            try
            {
                LimitsChecker limitsChecker = new LimitsChecker();
                limitsChecker.checkLimits(startDateTextBox.Text, endDateTextBox.Text, dateTimeTextBox.Text,typeComboBox.GetItemText(typeComboBox.SelectedItem));
            }
            catch (System.Exception)
            {
                nextExecutionTextBox.Text = "DateTime not in the limits.";
                return;
            }
            
            //Calls the calculate method
            calculateDate(typeComboBox.SelectedText, dateTimeTextBox.Text);
        }

        private void calculateDate(String type, String DateTime)
        {
            //Calculates the time
            try
            {
                DateCalculator date = new DateCalculator();
                DateTime calculatedDate = date.calculateDate(type, DateTime);
                nextExecutionTextBox.Text = calculatedDate.ToString("dd'/'MM'/'yyyy");
            }
            catch (System.FormatException)
            {
                nextExecutionTextBox.Text = "Error al calcular fecha.";
            }
        }
            

        private void occursComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
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