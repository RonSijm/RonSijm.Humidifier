namespace Humidifier.PCS
{
    using System.Collections.Generic;
    using ComputeNodeGroupTypes;

    public class ComputeNodeGroup : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveSubnetIds
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string ErrorInfo =  "ErrorInfo" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.PCS.ComputeNodeGroup; }

        /// <summary>
        /// ClusterId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pcs-computenodegroup.html#cfn-pcs-computenodegroup-clusterid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ClusterId { get; set; }
        /// <summary>
        /// SpotOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pcs-computenodegroup.html#cfn-pcs-computenodegroup-spotoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SpotOptions
        /// </summary>
        public Humidifier.PCS.ComputeNodeGroupTypes.SpotOptions SpotOptions { get; set; }
        /// <summary>
        /// SlurmConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pcs-computenodegroup.html#cfn-pcs-computenodegroup-slurmconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SlurmConfiguration
        /// </summary>
        public Humidifier.PCS.ComputeNodeGroupTypes.SlurmConfiguration SlurmConfiguration { get; set; }

        /// <summary>
        /// ScalingConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pcs-computenodegroup.html#cfn-pcs-computenodegroup-scalingconfiguration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: ScalingConfiguration
        /// </summary>
        [Required]
        public Humidifier.PCS.ComputeNodeGroupTypes.ScalingConfiguration ScalingConfiguration { get; set; }

        /// <summary>
        /// InstanceConfigs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pcs-computenodegroup.html#cfn-pcs-computenodegroup-instanceconfigs
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: InstanceConfig
        /// </summary>
        [Required]
        public List<Humidifier.PCS.ComputeNodeGroupTypes.InstanceConfig> InstanceConfigs { get; set; }
        /// <summary>
        /// PurchaseOption
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pcs-computenodegroup.html#cfn-pcs-computenodegroup-purchaseoption
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic PurchaseOption { get; set; }

        /// <summary>
        /// CustomLaunchTemplate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pcs-computenodegroup.html#cfn-pcs-computenodegroup-customlaunchtemplate
        /// Required: True
        /// UpdateType: Mutable
        /// Type: CustomLaunchTemplate
        /// </summary>
        [Required]
        public Humidifier.PCS.ComputeNodeGroupTypes.CustomLaunchTemplate CustomLaunchTemplate { get; set; }

        /// <summary>
        /// SubnetIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pcs-computenodegroup.html#cfn-pcs-computenodegroup-subnetids
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public dynamic SubnetIds { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pcs-computenodegroup.html#cfn-pcs-computenodegroup-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// AmiId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pcs-computenodegroup.html#cfn-pcs-computenodegroup-amiid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AmiId { get; set; }

        /// <summary>
        /// IamInstanceProfileArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pcs-computenodegroup.html#cfn-pcs-computenodegroup-iaminstanceprofilearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic IamInstanceProfileArn { get; set; }
    }

    namespace ComputeNodeGroupTypes
    {
        public class CustomLaunchTemplate : Humidifier.Base.BaseSubResource, IHaveId, IHaveVersion
        {
            /// <summary>
            /// Version
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-computenodegroup-customlaunchtemplate.html#cfn-pcs-computenodegroup-customlaunchtemplate-version
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Version { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-computenodegroup-customlaunchtemplate.html#cfn-pcs-computenodegroup-customlaunchtemplate-id
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Id { get; set; }
        }

        public class ErrorInfo : Humidifier.Base.BaseSubResource, IHaveMessage, IHaveCode
        {
            /// <summary>
            /// Message
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-computenodegroup-errorinfo.html#cfn-pcs-computenodegroup-errorinfo-message
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Message { get; set; }
            /// <summary>
            /// Code
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-computenodegroup-errorinfo.html#cfn-pcs-computenodegroup-errorinfo-code
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Code { get; set; }
        }

        public class InstanceConfig : Humidifier.Base.BaseSubResource, IHaveInstanceType
        {
            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-computenodegroup-instanceconfig.html#cfn-pcs-computenodegroup-instanceconfig-instancetype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InstanceType { get; set; }
        }

        public class ScalingConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MaxInstanceCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-computenodegroup-scalingconfiguration.html#cfn-pcs-computenodegroup-scalingconfiguration-maxinstancecount
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxInstanceCount { get; set; }
            /// <summary>
            /// MinInstanceCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-computenodegroup-scalingconfiguration.html#cfn-pcs-computenodegroup-scalingconfiguration-mininstancecount
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MinInstanceCount { get; set; }
        }

        public class SlurmConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SlurmCustomSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-computenodegroup-slurmconfiguration.html#cfn-pcs-computenodegroup-slurmconfiguration-slurmcustomsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SlurmCustomSetting
            /// </summary>
            public List<Humidifier.PCS.ComputeNodeGroupTypes.SlurmCustomSetting> SlurmCustomSettings { get; set; }
        }

        public class SlurmCustomSetting : Humidifier.Base.BaseSubResource, IHaveParameterName, IHaveParameterValue
        {
            /// <summary>
            /// ParameterValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-computenodegroup-slurmcustomsetting.html#cfn-pcs-computenodegroup-slurmcustomsetting-parametervalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParameterValue { get; set; }
            /// <summary>
            /// ParameterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-computenodegroup-slurmcustomsetting.html#cfn-pcs-computenodegroup-slurmcustomsetting-parametername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParameterName { get; set; }
        }

        public class SpotOptions : Humidifier.Base.BaseSubResource, IHaveAllocationStrategy
        {
            /// <summary>
            /// AllocationStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-computenodegroup-spotoptions.html#cfn-pcs-computenodegroup-spotoptions-allocationstrategy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AllocationStrategy { get; set; }
        }
    }
}