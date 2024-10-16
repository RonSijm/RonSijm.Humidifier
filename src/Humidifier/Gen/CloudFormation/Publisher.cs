namespace Humidifier.CloudFormation
{
    using System.Collections.Generic;

    public class Publisher : Humidifier.Base.BaseResource, IHaveConnectionArn
    {
        public class Attributes
        {
            public static string PublisherId =  "PublisherId" ;
            public static string IdentityProvider =  "IdentityProvider" ;
            public static string PublisherProfile =  "PublisherProfile" ;
            public static string PublisherStatus =  "PublisherStatus" ;
        }

        public override string AWSTypeName { get => AWS.CloudFormation.Publisher; }

        /// <summary>
        /// AcceptTermsAndConditions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-publisher.html#cfn-cloudformation-publisher-accepttermsandconditions
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        [Required]
        public dynamic AcceptTermsAndConditions { get; set; }
        /// <summary>
        /// ConnectionArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-publisher.html#cfn-cloudformation-publisher-connectionarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ConnectionArn { get; set; }
    }
}