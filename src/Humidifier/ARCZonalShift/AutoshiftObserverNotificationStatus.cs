namespace Humidifier.ARCZonalShift
{
    using System.Collections.Generic;

    public class AutoshiftObserverNotificationStatus : Humidifier.Resource
    {
        public class Attributes
        {
            public static string AccountId =  "AccountId" ;
            public static string Region =  "Region" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::ARCZonalShift::AutoshiftObserverNotificationStatus";
            }
        }

        /// <summary>
        /// Status
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-arczonalshift-autoshiftobservernotificationstatus.html#cfn-arczonalshift-autoshiftobservernotificationstatus-status
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Status { get; set; }
    }
}