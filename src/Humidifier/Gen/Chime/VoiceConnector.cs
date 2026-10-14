namespace Humidifier.Chime
{
    using global::System.Collections.Generic;

    public class VoiceConnector : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveNetworkType, IHaveAwsRegion
    {
        public class Attributes
        {
            public static string UpdatedTimestamp =  "UpdatedTimestamp" ;
            public static string VoiceConnectorId =  "VoiceConnectorId" ;
            public static string CreatedTimestamp =  "CreatedTimestamp" ;
            public static string OutboundHostName =  "OutboundHostName" ;
            public static string VoiceConnectorArn =  "VoiceConnectorArn" ;
        }

        public override string AWSTypeName { get => AWS.Chime.VoiceConnector; }

        /// <summary>
        /// RequireEncryption
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-voiceconnector.html#cfn-chime-voiceconnector-requireencryption
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        [Required]
        public dynamic RequireEncryption { get; set; }
        /// <summary>
        /// AwsRegion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-voiceconnector.html#cfn-chime-voiceconnector-awsregion
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AwsRegion { get; set; }
        /// <summary>
        /// NetworkType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-voiceconnector.html#cfn-chime-voiceconnector-networktype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic NetworkType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-voiceconnector.html#cfn-chime-voiceconnector-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }
}