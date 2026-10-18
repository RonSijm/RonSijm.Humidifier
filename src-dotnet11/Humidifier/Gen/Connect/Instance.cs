namespace Humidifier.Connect
{
    using global::System.Collections.Generic;
    using InstanceTypes;

    public class Instance : Humidifier.Base.BaseResource, IHaveTags, IHaveDirectoryId, IHaveIdentityManagementType, IHaveInstanceAlias, IHaveConnectInstanceTypesAttributesAttributes_
    {
        public class Attributes
        {
            public static string CreatedTime =  "CreatedTime" ;
            public static string ServiceRole =  "ServiceRole" ;
            public static string InstanceStatus =  "InstanceStatus" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Connect.Instance; }
        /// <summary>
        /// DirectoryId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-instance.html#cfn-connect-instance-directoryid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DirectoryId { get; set; }

        /// <summary>
        /// IdentityManagementType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-instance.html#cfn-connect-instance-identitymanagementtype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? IdentityManagementType { get; set; }
        /// <summary>
        /// InstanceAlias
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-instance.html#cfn-connect-instance-instancealias
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? InstanceAlias { get; set; }

        /// <summary>
        /// Attributes_
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-instance.html#cfn-connect-instance-attributes
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Attributes
        /// </summary>
        [Required]
        public Union<Humidifier.Connect.InstanceTypes.Attributes, BaseFunction>? Attributes_ { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-instance.html#cfn-connect-instance-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace InstanceTypes
    {
        public class Attributes : Humidifier.Base.BaseSubResource, IHaveEnhancedContactMonitoring_Boolean, IHaveOutboundCalls_Boolean, IHaveEarlyMedia_Boolean, IHaveMessageStreaming_Boolean, IHaveMultiPartyConference_Boolean, IHaveContactLens_Boolean, IHaveAutoResolveBestVoices_Boolean, IHaveInboundCalls_Boolean, IHaveEnhancedChatMonitoring_Boolean, IHaveUseCustomTTSVoices_Boolean, IHaveContactflowLogs_Boolean, IHaveMultiPartyChatConference_Boolean, IHaveHighVolumeOutBound_Boolean
        {
            /// <summary>
            /// EnhancedContactMonitoring
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-instance-attributes.html#cfn-connect-instance-attributes-enhancedcontactmonitoring
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnhancedContactMonitoring { get; set; }
            /// <summary>
            /// OutboundCalls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-instance-attributes.html#cfn-connect-instance-attributes-outboundcalls
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? OutboundCalls { get; set; }
            /// <summary>
            /// EarlyMedia
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-instance-attributes.html#cfn-connect-instance-attributes-earlymedia
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EarlyMedia { get; set; }
            /// <summary>
            /// MessageStreaming
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-instance-attributes.html#cfn-connect-instance-attributes-messagestreaming
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? MessageStreaming { get; set; }
            /// <summary>
            /// MultiPartyConference
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-instance-attributes.html#cfn-connect-instance-attributes-multipartyconference
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? MultiPartyConference { get; set; }
            /// <summary>
            /// ContactLens
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-instance-attributes.html#cfn-connect-instance-attributes-contactlens
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ContactLens { get; set; }
            /// <summary>
            /// AutoResolveBestVoices
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-instance-attributes.html#cfn-connect-instance-attributes-autoresolvebestvoices
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AutoResolveBestVoices { get; set; }
            /// <summary>
            /// InboundCalls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-instance-attributes.html#cfn-connect-instance-attributes-inboundcalls
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? InboundCalls { get; set; }
            /// <summary>
            /// EnhancedChatMonitoring
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-instance-attributes.html#cfn-connect-instance-attributes-enhancedchatmonitoring
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnhancedChatMonitoring { get; set; }
            /// <summary>
            /// UseCustomTTSVoices
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-instance-attributes.html#cfn-connect-instance-attributes-usecustomttsvoices
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? UseCustomTTSVoices { get; set; }
            /// <summary>
            /// ContactflowLogs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-instance-attributes.html#cfn-connect-instance-attributes-contactflowlogs
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ContactflowLogs { get; set; }
            /// <summary>
            /// MultiPartyChatConference
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-instance-attributes.html#cfn-connect-instance-attributes-multipartychatconference
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? MultiPartyChatConference { get; set; }
            /// <summary>
            /// HighVolumeOutBound
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-instance-attributes.html#cfn-connect-instance-attributes-highvolumeoutbound
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? HighVolumeOutBound { get; set; }
        }
    }
}