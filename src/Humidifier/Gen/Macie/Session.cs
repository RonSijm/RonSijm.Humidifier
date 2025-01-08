namespace Humidifier.Macie
{
    using System.Collections.Generic;

    public class Session : Humidifier.Base.BaseResource, IHaveStatus, IHaveFindingPublishingFrequency
    {
        public class Attributes
        {
            public static string ServiceRole =  "ServiceRole" ;
            public static string AwsAccountId =  "AwsAccountId" ;
        }

        public override string AWSTypeName { get => AWS.Macie.Session; }
        /// <summary>
        /// Status
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-macie-session.html#cfn-macie-session-status
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Status { get; set; }
        /// <summary>
        /// FindingPublishingFrequency
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-macie-session.html#cfn-macie-session-findingpublishingfrequency
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic FindingPublishingFrequency { get; set; }
    }
}