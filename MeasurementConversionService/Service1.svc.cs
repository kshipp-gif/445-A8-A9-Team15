using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MeasurementConversionService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public double MetricToImperial(string metricType, string imperialType, double value)
        {
            // -1.0 result indicates the number is either too large or too small to reasonably display
            // -2.0 result indicates failure to meet any if condition

            double result = -2.0;

            // TO INCHES
            if (metricType == "mm" && imperialType == "in")
            {
                result = value / 25.4;
                return result;
            }
            else if (metricType == "cm" && imperialType == "in")
            {
                result = value / 2.54;
                return result;
            }
            else if (metricType == "m" && imperialType == "in")
            {
                result = value * 39.37;
                return result;
            }
            else if (metricType == "km" && imperialType == "in")
            {
                result = value * 39370;
                return result;
            }

            // TO FEET
            else if (metricType == "mm" && imperialType == "ft")
            {
                result = value / 304.8;
                return result;
            }
            else if (metricType == "cm" && imperialType == "ft")
            {
                result = value / 30.48;
                return result;
            }
            else if (metricType == "m" && imperialType == "ft")
            {
                result = value * 3.281;
                return result;
            }
            else if (metricType == "km" && imperialType == "ft")
            {
                result = value * 3281.0;
                return result;
            }

            // TO YARDS
            else if (metricType == "mm" && imperialType == "yd")
            {
                result = value / 914.4;
                return result;
            }
            else if (metricType == "cm" && imperialType == "yd")
            {
                result = value / 91.44;
                return result;
            }
            else if (metricType == "m" && imperialType == "yd")
            {
                result = value * 1.094;
                return result;
            }
            else if (metricType == "km" && imperialType == "yd")
            {
                result = value * 1094.0;
                return result;
            }

            // TO MILES
            else if (metricType == "mm" && imperialType == "mi")
            {
                result = -1.0;
                return result;
            }
            else if (metricType == "cm" && imperialType == "mi")
            {
                result = -1.0;
                return result;
            }
            else if (metricType == "m" && imperialType == "mi")
            {
                result = value / 1609;
                return result;
            }
            else if (metricType == "km" && imperialType == "mi")
            {
                result = value / 1.609;
                return result;
            }
            return result;
        }

        public double ImperialToMetric(string imperialType, string metricType, double value)
        {
            double result = -2.0;

            // TO MILLIMETER
            if (imperialType == "in" && metricType == "mm")
            {
                result = value * 25.4;
                return result;
            }
            else if (imperialType == "ft" && metricType == "mm")
            {
                result = value * 304.8;
                return result;
            }
            else if (imperialType == "yd" && metricType == "mm")
            {
                result = value * 914.4;
                return result;
            }
            else if (imperialType == "mi" && metricType == "mm")
            {
                result = -1.0;
                return result;
            }

            // TO CENTIMETER
            else if (imperialType == "in" && metricType == "cm")
            {
                result = value * 2.54;
                return result;
            }
            else if (imperialType == "ft" && metricType == "cm")
            {
                result = value * 30.48;
                return result;
            }
            else if (imperialType == "yd" && metricType == "cm")
            {
                result = value * 91.44;
                return result;
            }
            else if (imperialType == "mi" && metricType == "cm")
            {
                result = -1.0;
                return result;
            }

            // TO METER
            else if (imperialType == "in" && metricType == "m")
            {
                result = value / 39.37;
                return result;
            }
            else if (imperialType == "ft" && metricType == "m")
            {
                result = value / 3.281;
                return result;
            }
            else if (imperialType == "yd" && metricType == "m")
            {
                result = value / 1.094;
                return result;
            }
            else if (imperialType == "mi" && metricType == "m")
            {
                result = value / 1609.0;
                return result;
            }

            // TO KILOMETER
            else if (imperialType == "in" && metricType == "km")
            {
                result = -1.0;
                return result;
            }
            else if (imperialType == "ft" && metricType == "km")
            {
                result = value / 3281.0;
                return result;
            }
            else if (imperialType == "yd" && metricType == "km")
            {
                result = value / 1094.0;
                return result;
            }
            else if (imperialType == "mi" && metricType == "km")
            {
                result = value * 1.609;
                return result;
            }

            return result;
        }
    }
}
