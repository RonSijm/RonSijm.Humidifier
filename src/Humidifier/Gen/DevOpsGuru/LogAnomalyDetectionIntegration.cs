namespace Humidifier.DevOpsGuru
{
    using global::System.Collections.Generic;

    public class LogAnomalyDetectionIntegration : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string AccountId =  "AccountId" ;
        }

        public override string AWSTypeName { get => AWS.DevOpsGuru.LogAnomalyDetectionIntegration; }
    }
}