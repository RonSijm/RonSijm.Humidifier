namespace Humidifier.Chime
{
    using global::System.Collections.Generic;

    public class VoiceConnector : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveRequireEncryption_Boolean, IHaveAwsRegion, IHaveNetworkType, IHaveName
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
        public Union<bool, BaseFunction>? RequireEncryption { get; set; }
        /// <summary>
        /// AwsRegion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-voiceconnector.html#cfn-chime-voiceconnector-awsregion
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AwsRegion { get; set; }
        /// <summary>
        /// NetworkType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-voiceconnector.html#cfn-chime-voiceconnector-networktype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? NetworkType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-voiceconnector.html#cfn-chime-voiceconnector-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }
}