namespace Humidifier.SageMaker
{
    using global::System.Collections.Generic;
    using PartnerAppTypes;

    public class PartnerApp : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveAppVersion, IHaveExecutionRoleArn, IHaveType, IHaveKmsKeyId, IHaveEnableIamSessionBasedIdentity_Boolean, IHaveTier, IHaveEnableAutoMinorVersionUpgrade_Boolean, IHaveSageMakerPartnerAppTypesPartnerAppConfigApplicationConfig, IHaveAuthType, IHaveSageMakerPartnerAppTypesPartnerAppMaintenanceConfigMaintenanceConfig, IHaveName
    {
        public class Attributes
        {
            public static string CurrentVersionEolDate =  "CurrentVersionEolDate" ;
            public static string BaseUrl =  "BaseUrl" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.SageMaker.PartnerApp; }
        /// <summary>
        /// AppVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-partnerapp.html#cfn-sagemaker-partnerapp-appversion
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AppVersion { get; set; }

        /// <summary>
        /// ExecutionRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-partnerapp.html#cfn-sagemaker-partnerapp-executionrolearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ExecutionRoleArn { get; set; }

        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-partnerapp.html#cfn-sagemaker-partnerapp-type
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Type { get; set; }
        /// <summary>
        /// KmsKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-partnerapp.html#cfn-sagemaker-partnerapp-kmskeyid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsKeyId { get; set; }
        /// <summary>
        /// EnableIamSessionBasedIdentity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-partnerapp.html#cfn-sagemaker-partnerapp-enableiamsessionbasedidentity
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? EnableIamSessionBasedIdentity { get; set; }

        /// <summary>
        /// Tier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-partnerapp.html#cfn-sagemaker-partnerapp-tier
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Tier { get; set; }
        /// <summary>
        /// EnableAutoMinorVersionUpgrade
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-partnerapp.html#cfn-sagemaker-partnerapp-enableautominorversionupgrade
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? EnableAutoMinorVersionUpgrade { get; set; }
        /// <summary>
        /// ApplicationConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-partnerapp.html#cfn-sagemaker-partnerapp-applicationconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: PartnerAppConfig
        /// </summary>
        public Union<Humidifier.SageMaker.PartnerAppTypes.PartnerAppConfig, BaseFunction>? ApplicationConfig { get; set; }

        /// <summary>
        /// AuthType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-partnerapp.html#cfn-sagemaker-partnerapp-authtype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AuthType { get; set; }
        /// <summary>
        /// MaintenanceConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-partnerapp.html#cfn-sagemaker-partnerapp-maintenanceconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: PartnerAppMaintenanceConfig
        /// </summary>
        public Union<Humidifier.SageMaker.PartnerAppTypes.PartnerAppMaintenanceConfig, BaseFunction>? MaintenanceConfig { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-partnerapp.html#cfn-sagemaker-partnerapp-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace PartnerAppTypes
    {
        public class PartnerAppConfig : Humidifier.Base.BaseSubResource, IHaveStringListOfAdminUsers, IHaveStringDictionaryOfArguments
        {
            /// <summary>
            /// AdminUsers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-partnerapp-partnerappconfig.html#cfn-sagemaker-partnerapp-partnerappconfig-adminusers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AdminUsers { get; set; }
            /// <summary>
            /// Arguments
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-partnerapp-partnerappconfig.html#cfn-sagemaker-partnerapp-partnerappconfig-arguments
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Arguments { get; set; }
        }

        public class PartnerAppMaintenanceConfig : Humidifier.Base.BaseSubResource, IHaveMaintenanceWindowStart
        {
            /// <summary>
            /// MaintenanceWindowStart
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-partnerapp-partnerappmaintenanceconfig.html#cfn-sagemaker-partnerapp-partnerappmaintenanceconfig-maintenancewindowstart
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MaintenanceWindowStart { get; set; }
        }
    }
}