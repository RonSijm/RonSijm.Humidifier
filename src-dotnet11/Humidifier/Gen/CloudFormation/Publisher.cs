namespace Humidifier.CloudFormation
{
    using global::System.Collections.Generic;

    public class Publisher : Humidifier.Base.BaseResource, IHaveAcceptTermsAndConditions_Boolean, IHaveConnectionArn
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
        public Union<bool, BaseFunction>? AcceptTermsAndConditions { get; set; }
        /// <summary>
        /// ConnectionArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-publisher.html#cfn-cloudformation-publisher-connectionarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ConnectionArn { get; set; }
    }
}