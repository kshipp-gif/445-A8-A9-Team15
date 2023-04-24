using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Http;
using System.Xml.Linq;
using Newtonsoft.Json;
using System.IO;
using System.Xml;

namespace _445_A8_A9_Team15
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox2.Text == "")
            {
                ErrorMessage.Text = "Please enter a decimal value";
            }
            else
            {
                ErrorMessage.Text = "";
                MeasurementService.Service1Client measurementConversionService = new MeasurementService.Service1Client();

                double value = double.Parse(TextBox2.Text);
                string metricType = MetricDropDown.SelectedItem.Value;
                string imperialType = ImperialDropDown.SelectedItem.Value;
                string result = measurementConversionService.ImperialToMetric(imperialType, metricType, value).ToString();

                resultsLabel.Text = result;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string zipcode;
            try
            {
                zipcode = Convert.ToString(TextBox1.Text);
            }
            catch (System.FormatException)
            {
                zipcode = "85295"; //if input is empty, this is the default value
            }

            WeatherService.Service1Client service = new WeatherService.Service1Client();
            string[] output = service.WeatherFor(zipcode);
            //day 1
            Label5.Text = "Date: " + output[4].Substring(0, output[4].Length - 8);
            Label6.Text = " Low: " + output[0] + "     High: " + output[1];
            Label7.Text = "Weather: " + output[2] + "(" + output[3] + ")";

            int temp = Int32.Parse(output[4].Substring(11, 2));
            int x = 0;
            if (temp == 00)
            {
                x = 40;


            }
            else if (temp == 03)
            {
                x = 35;

            }
            else if (temp == 06)
            {
                x = 30;

            }
            else if (temp == 09)
            {
                x = 25;
            }
            else if (temp == 12)
            {
                x = 20;
            }
            else if (temp == 15)
            {
                x = 15;
            }
            else if (temp == 18)
            {
                x = 10;
            }
            else if (temp == 21)
            {
                x = 5;
            }
            else
            {
                x = 0;
            }


            //day 2
            Label9.Text = "Date: " + output[4 + x].Substring(0, output[4 + x].Length - 8);
            Label10.Text = " Low: " + output[0 + x] + "     High: " + output[1 + x];
            Label11.Text = "Weather: " + output[2 + x] + " (" + output[3 + x] + ")";

            //day 3
            Label13.Text = "Date: " + output[4 + x + 40].Substring(0, output[4 + x + 40].Length - 8);
            Label14.Text = " Low: " + output[0 + x + 40] + "     High: " + output[1 + x + 40];
            Label15.Text = "Weather: " + output[2 + x + 40] + " (" + output[3 + x + 40] + ")";

            //day 4
            Label17.Text = "Date: " + output[4 + x + 80].Substring(0, output[4 + x + 80].Length - 8);
            Label18.Text = " Low: " + output[0 + x + 80] + "     High: " + output[1 + x + 80];
            Label19.Text = "Weather: " + output[2 + x + 80] + " (" + output[3 + x + 80] + ")";

            //day 5
            Label21.Text = "Date: " + output[4 + x + 120].Substring(0, output[4 + x + 120].Length - 8);
            Label22.Text = " Low: " + output[0 + x + 120] + "     High: " + output[1 + x + 120];
            Label23.Text = "Weather: " + output[2 + x + 120] + " (" + output[3 + x + 120] + ")";

            //seperates days
            Label8.Text = "---------------------------------";
            Label12.Text = "---------------------------------";
            Label16.Text = "---------------------------------";
            Label20.Text = "---------------------------------";

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (TextBox2.Text == "")
            {
                ErrorMessage.Text = "Please enter a decimal value";
            }
            else
            {
                ErrorMessage.Text = "";
                MeasurementService.Service1Client measurementConversionService = new MeasurementService.Service1Client();

                double value = double.Parse(TextBox2.Text);
                string metricType = MetricDropDown.SelectedItem.Value;
                string imperialType = ImperialDropDown.SelectedItem.Value;
                string result = measurementConversionService.MetricToImperial(imperialType, metricType, value).ToString();

                resultsLabel.Text = result;
            }
        }

        protected void envokeNaturalHazardService_Click(object sender, EventArgs e)
        {
            string tryitLink = "http://webstrar164.fulton.asu.edu/page0/Service1.svc/";
            string inputForNH = TextBox4.Text;
            HttpClient webClient = new HttpClient();
            string url = tryitLink + "NaturalHazardInfo?zipcode=" + inputForNH;

            HttpResponseMessage randomNameGeneratorResults = webClient.GetAsync(url).Result;
            HttpContent content = randomNameGeneratorResults.Content;
            string contents = content.ReadAsStringAsync().Result;

            XDocument temp = XDocument.Parse(contents);

            string result = temp.ToString();

            Label32.Text = result;

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string zipcode = TextBox3.Text;
            NaturalHazardService.Service1Client client = new NaturalHazardService.Service1Client();
            string results = client.getLocationFromZip(Int32.Parse(zipcode));
            Label27.Text = results;
        }

        protected void homePageButton_Click(object sender, EventArgs e)
        {

        }

        protected void Logout_Click(object sender, EventArgs e)
        {

        }
    }
}