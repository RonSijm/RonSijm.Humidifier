namespace Humidifier.Chime
{
    using global::System.Collections.Generic;
    using SipMediaApplicationTypes;

    public class SipMediaApplication : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveAwsRegion
    {
        public class Attributes
        {
            public static string UpdatedTimestamp =  "UpdatedTimestamp" ;
            public static string SipMediaApplicationId =  "SipMediaApplicationId" ;
            public static string CreatedTimestamp =  "CreatedTimestamp" ;
            public static string SipMediaApplicationArn =  "SipMediaApplicationArn" ;
        }

        public override string AWSTypeName { get => AWS.Chime.SipMediaApplication; }

        /// <summary>
        /// Endpoints
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-sipmediaapplication.html#cfn-chime-sipmediaapplication-endpoints
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: SipMediaApplicationEndpoint
        /// </summary>
        [Required]
        public List<Humidifier.Chime.SipMediaApplicationTypes.SipMediaApplicationEndpoint> Endpoints { get; set; }

        /// <summary>
        /// AwsRegion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-sipmediaapplication.html#cfn-chime-sipmediaapplication-awsregion
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic AwsRegion { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-sipmediaapplication.html#cfn-chime-sipmediaapplication-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace SipMediaApplicationTypes
    {
        public class SipMediaApplicationEndpoint : Humidifier.Base.BaseSubResource, IHaveLambdaArn
        {
            /// <summary>
            /// LambdaArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-sipmediaapplication-sipmediaapplicationendpoint.html#cfn-chime-sipmediaapplication-sipmediaapplicationendpoint-lambdaarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LambdaArn { get; set; }
        }
    }
}