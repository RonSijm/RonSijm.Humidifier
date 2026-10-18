namespace Humidifier.PCS
{
    using global::System.Collections.Generic;
    using QueueTypes;

    public class Queue : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveClusterId, IHaveListOfPCSQueueTypesComputeNodeGroupConfigurationComputeNodeGroupConfigurations, IHavePCSQueueTypesSlurmConfigurationSlurmConfiguration, IHaveStringDictionaryOfTags, IHaveName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string ErrorInfo =  "ErrorInfo" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.PCS.Queue; }

        /// <summary>
        /// ClusterId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pcs-queue.html#cfn-pcs-queue-clusterid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ClusterId { get; set; }
        /// <summary>
        /// ComputeNodeGroupConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pcs-queue.html#cfn-pcs-queue-computenodegroupconfigurations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ComputeNodeGroupConfiguration
        /// </summary>
        public Union<IReadOnlyList<Humidifier.PCS.QueueTypes.ComputeNodeGroupConfiguration>, IReadOnlyList<Union<Humidifier.PCS.QueueTypes.ComputeNodeGroupConfiguration, BaseFunction>>, BaseFunction>? ComputeNodeGroupConfigurations { get; set; }
        /// <summary>
        /// SlurmConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pcs-queue.html#cfn-pcs-queue-slurmconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SlurmConfiguration
        /// </summary>
        public Union<Humidifier.PCS.QueueTypes.SlurmConfiguration, BaseFunction>? SlurmConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pcs-queue.html#cfn-pcs-queue-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace QueueTypes
    {
        public class ComputeNodeGroupConfiguration : Humidifier.Base.BaseSubResource, IHaveComputeNodeGroupId
        {
            /// <summary>
            /// ComputeNodeGroupId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-queue-computenodegroupconfiguration.html#cfn-pcs-queue-computenodegroupconfiguration-computenodegroupid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ComputeNodeGroupId { get; set; }
        }

        public class ErrorInfo : Humidifier.Base.BaseSubResource, IHaveMessage, IHaveCode
        {
            /// <summary>
            /// Message
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-queue-errorinfo.html#cfn-pcs-queue-errorinfo-message
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Message { get; set; }
            /// <summary>
            /// Code
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-queue-errorinfo.html#cfn-pcs-queue-errorinfo-code
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Code { get; set; }
        }

        public class SlurmConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfPCSQueueTypesSlurmCustomSettingSlurmCustomSettings
        {
            /// <summary>
            /// SlurmCustomSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-queue-slurmconfiguration.html#cfn-pcs-queue-slurmconfiguration-slurmcustomsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SlurmCustomSetting
            /// </summary>
            public Union<IReadOnlyList<Humidifier.PCS.QueueTypes.SlurmCustomSetting>, IReadOnlyList<Union<Humidifier.PCS.QueueTypes.SlurmCustomSetting, BaseFunction>>, BaseFunction>? SlurmCustomSettings { get; set; }
        }

        public class SlurmCustomSetting : Humidifier.Base.BaseSubResource, IHaveParameterValue, IHaveParameterName
        {
            /// <summary>
            /// ParameterValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-queue-slurmcustomsetting.html#cfn-pcs-queue-slurmcustomsetting-parametervalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ParameterValue { get; set; }
            /// <summary>
            /// ParameterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-queue-slurmcustomsetting.html#cfn-pcs-queue-slurmcustomsetting-parametername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ParameterName { get; set; }
        }
    }
}