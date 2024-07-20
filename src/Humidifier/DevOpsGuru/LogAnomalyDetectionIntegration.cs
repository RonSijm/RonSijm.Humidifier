namespace Humidifier.DevOpsGuru
{
    using System.Collections.Generic;

    public class LogAnomalyDetectionIntegration : Humidifier.Resource
    {
        public class Attributes
        {
            public static string AccountId =  "AccountId" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::DevOpsGuru::LogAnomalyDetectionIntegration";
            }
        }
    }
}