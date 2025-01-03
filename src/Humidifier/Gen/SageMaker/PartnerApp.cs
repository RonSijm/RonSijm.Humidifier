namespace Humidifier.SageMaker
{
    using System.Collections.Generic;
    using PartnerAppTypes;

    public class PartnerApp : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveType, IHaveExecutionRoleArn, IHaveAuthType, IHaveTier
    {
        public class Attributes
        {
            public static string BaseUrl =  "BaseUrl" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.SageMaker.PartnerApp; }

        /// <summary>
        /// ExecutionRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-partnerapp.html#cfn-sagemaker-partnerapp-executionrolearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ExecutionRoleArn { get; set; }

        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-partnerapp.html#cfn-sagemaker-partnerapp-type
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Type { get; set; }
        /// <summary>
        /// EnableIamSessionBasedIdentity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-partnerapp.html#cfn-sagemaker-partnerapp-enableiamsessionbasedidentity
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic EnableIamSessionBasedIdentity { get; set; }

        /// <summary>
        /// Tier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-partnerapp.html#cfn-sagemaker-partnerapp-tier
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Tier { get; set; }
        /// <summary>
        /// ApplicationConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-partnerapp.html#cfn-sagemaker-partnerapp-applicationconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: PartnerAppConfig
        /// </summary>
        public Humidifier.SageMaker.PartnerAppTypes.PartnerAppConfig ApplicationConfig { get; set; }

        /// <summary>
        /// AuthType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-partnerapp.html#cfn-sagemaker-partnerapp-authtype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic AuthType { get; set; }
        /// <summary>
        /// MaintenanceConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-partnerapp.html#cfn-sagemaker-partnerapp-maintenanceconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: PartnerAppMaintenanceConfig
        /// </summary>
        public Humidifier.SageMaker.PartnerAppTypes.PartnerAppMaintenanceConfig MaintenanceConfig { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-partnerapp.html#cfn-sagemaker-partnerapp-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace PartnerAppTypes
    {
        public class PartnerAppConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AdminUsers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-partnerapp-partnerappconfig.html#cfn-sagemaker-partnerapp-partnerappconfig-adminusers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AdminUsers { get; set; }
            /// <summary>
            /// Arguments
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-partnerapp-partnerappconfig.html#cfn-sagemaker-partnerapp-partnerappconfig-arguments
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> Arguments { get; set; }
        }

        public class PartnerAppMaintenanceConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MaintenanceWindowStart
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-partnerapp-partnerappmaintenanceconfig.html#cfn-sagemaker-partnerapp-partnerappmaintenanceconfig-maintenancewindowstart
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MaintenanceWindowStart { get; set; }
        }
    }
}