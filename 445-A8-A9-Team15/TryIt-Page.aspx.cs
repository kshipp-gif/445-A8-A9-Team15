using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _445_A8_A9_Team15
{
    public partial class TryIt_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }
        protected void Button1_Click(object sender, EventArgs e) // Imperial to Metric button
        {
            if (TextBox1.Text == "")
            {
                ErrorMessage.Text = "Please enter a decimal value";
            }
            else
            {
                ErrorMessage.Text = "";
                AllServices.Service1Client measurementConversionService = new AllServices.Service1Client();

                double value = double.Parse(TextBox1.Text);
                string metricType = MetricDropDown.SelectedItem.Value;
                string imperialType = ImperialDropDown.SelectedItem.Value;
                string result = measurementConversionService.ImperialToMetric(imperialType, metricType, value).ToString();

                resultsLabel.Text = result;
            }
        }

        protected void Button2_Click(object sender, EventArgs e) // Metric to Imperial button
        {
            if (TextBox1.Text == "")
            {
                ErrorMessage.Text = "Please enter a decimal value";
            }
            else
            {
                ErrorMessage.Text = "";
                AllServices.Service1Client measurementConversionService = new AllServices.Service1Client();

                double value = double.Parse(TextBox1.Text);
                string metricType = MetricDropDown.SelectedItem.Value;
                string imperialType = ImperialDropDown.SelectedItem.Value;
                string result = measurementConversionService.MetricToImperial(metricType, imperialType, value).ToString();

                resultsLabel.Text = result;
            }
        }

        protected void Button3_Click(object sender, EventArgs e) // Invoke MergeSort button
        {
            if (InputTextBox.Text != "")
            {
                // valid text input
                AllServices.Service1Client mergeSortService = new AllServices.Service1Client();
                string numbers = InputTextBox.Text;
                string output = mergeSortService.SortService(numbers);
                Label2.Text = output;
            }
            else
            {
                Label2.Text = "Invalid Input";
            }
        }

        protected void CaptchaGuessBtn_Click(object sender, EventArgs e)
        {
            string captchaGuess = CaptchaGuessText.Text;
            string captchaActual = (string)HttpContext.Current.Session["CaptchaImageText"];

            if (captchaGuess == captchaActual)
            {
                Output.Text = "Captcha solved correctly.";
            }
            else
            {
                Output.Text = "Captcha solved incorrectly, please try again.";
            }
        }
    }
}