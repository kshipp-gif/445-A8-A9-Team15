using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MeasurementConversionService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        //[WebGet(UriTemplate = "MetricToImperial?metricType={metricType}&imperialType={imperialType}&value={value}")]
        double MetricToImperial(string metricType, string imperialType, double value);

        [OperationContract]
        //[WebGet(UriTemplate = "ImperialToMetric?type={imperialType}&metricType={metricType}&value={value}")]
        double ImperialToMetric(string imperialType, string metricType, double value);

        // TODO: Add your service operations here
    }
}
