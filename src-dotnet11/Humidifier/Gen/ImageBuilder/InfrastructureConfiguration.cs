namespace Humidifier.ImageBuilder
{
    using global::System.Collections.Generic;
    using InfrastructureConfigurationTypes;

    public class InfrastructureConfiguration : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveImageBuilderInfrastructureConfigurationTypesLoggingLogging, IHaveKeyPair, IHaveDescription, IHaveInstanceProfileName, IHaveStringDictionaryOfResourceTags, IHaveTerminateInstanceOnFailure_Boolean, IHaveSubnetId, IHaveStringListOfSecurityGroupIds, IHaveName, IHaveImageBuilderInfrastructureConfigurationTypesParentInstanceParentInstance, IHaveImageBuilderInfrastructureConfigurationTypesPlacementPlacement, IHaveImageBuilderInfrastructureConfigurationTypesInstanceMetadataOptionsInstanceMetadataOptions, IHaveStringListOfInstanceTypes, IHaveSnsTopicArn, IHaveStringDictionaryOfTags, IHaveTerminateInstanceOnCompletion_Boolean
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
            public static string Name =  "Name" ;
        }

        public override string AWSTypeName { get => AWS.ImageBuilder.InfrastructureConfiguration; }
        /// <summary>
        /// Logging
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-infrastructureconfiguration.html#cfn-imagebuilder-infrastructureconfiguration-logging
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Logging
        /// </summary>
        public Union<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.Logging, BaseFunction>? Logging { get; set; }
        /// <summary>
        /// KeyPair
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-infrastructureconfiguration.html#cfn-imagebuilder-infrastructureconfiguration-keypair
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KeyPair { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-infrastructureconfiguration.html#cfn-imagebuilder-infrastructureconfiguration-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// InstanceProfileName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-infrastructureconfiguration.html#cfn-imagebuilder-infrastructureconfiguration-instanceprofilename
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? InstanceProfileName { get; set; }
        /// <summary>
        /// ResourceTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-infrastructureconfiguration.html#cfn-imagebuilder-infrastructureconfiguration-resourcetags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? ResourceTags { get; set; }
        /// <summary>
        /// TerminateInstanceOnFailure
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-infrastructureconfiguration.html#cfn-imagebuilder-infrastructureconfiguration-terminateinstanceonfailure
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? TerminateInstanceOnFailure { get; set; }
        /// <summary>
        /// SubnetId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-infrastructureconfiguration.html#cfn-imagebuilder-infrastructureconfiguration-subnetid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SubnetId { get; set; }
        /// <summary>
        /// SecurityGroupIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-infrastructureconfiguration.html#cfn-imagebuilder-infrastructureconfiguration-securitygroupids
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// ParentInstance
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-infrastructureconfiguration.html#cfn-imagebuilder-infrastructureconfiguration-parentinstance
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ParentInstance
        /// </summary>
        public Union<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.ParentInstance, BaseFunction>? ParentInstance { get; set; }
        /// <summary>
        /// Placement
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-infrastructureconfiguration.html#cfn-imagebuilder-infrastructureconfiguration-placement
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Placement
        /// </summary>
        public Union<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.Placement, BaseFunction>? Placement { get; set; }
        /// <summary>
        /// InstanceMetadataOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-infrastructureconfiguration.html#cfn-imagebuilder-infrastructureconfiguration-instancemetadataoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: InstanceMetadataOptions
        /// </summary>
        public Union<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.InstanceMetadataOptions, BaseFunction>? InstanceMetadataOptions { get; set; }
        /// <summary>
        /// InstanceTypes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-infrastructureconfiguration.html#cfn-imagebuilder-infrastructureconfiguration-instancetypes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? InstanceTypes { get; set; }
        /// <summary>
        /// SnsTopicArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-infrastructureconfiguration.html#cfn-imagebuilder-infrastructureconfiguration-snstopicarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SnsTopicArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-infrastructureconfiguration.html#cfn-imagebuilder-infrastructureconfiguration-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// TerminateInstanceOnCompletion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-infrastructureconfiguration.html#cfn-imagebuilder-infrastructureconfiguration-terminateinstanceoncompletion
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? TerminateInstanceOnCompletion { get; set; }
    }

    namespace InfrastructureConfigurationTypes
    {
        public class AutoScalingGroup : Humidifier.Base.BaseSubResource, IHaveCapacityWaitTimeoutSeconds_Integer, IHaveName
        {
            /// <summary>
            /// CapacityWaitTimeoutSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-infrastructureconfiguration-autoscalinggroup.html#cfn-imagebuilder-infrastructureconfiguration-autoscalinggroup-capacitywaittimeoutseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? CapacityWaitTimeoutSeconds { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-infrastructureconfiguration-autoscalinggroup.html#cfn-imagebuilder-infrastructureconfiguration-autoscalinggroup-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class InstanceMetadataOptions : Humidifier.Base.BaseSubResource, IHaveHttpPutResponseHopLimit_Integer, IHaveHttpTokens
        {
            /// <summary>
            /// HttpPutResponseHopLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-infrastructureconfiguration-instancemetadataoptions.html#cfn-imagebuilder-infrastructureconfiguration-instancemetadataoptions-httpputresponsehoplimit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? HttpPutResponseHopLimit { get; set; }
            /// <summary>
            /// HttpTokens
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-infrastructureconfiguration-instancemetadataoptions.html#cfn-imagebuilder-infrastructureconfiguration-instancemetadataoptions-httptokens
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HttpTokens { get; set; }
        }

        public class Logging : Humidifier.Base.BaseSubResource, IHaveImageBuilderInfrastructureConfigurationTypesS3LogsS3Logs
        {
            /// <summary>
            /// S3Logs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-infrastructureconfiguration-logging.html#cfn-imagebuilder-infrastructureconfiguration-logging-s3logs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3Logs
            /// </summary>
            public Union<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.S3Logs, BaseFunction>? S3Logs { get; set; }
        }

        public class ParentInstance : Humidifier.Base.BaseSubResource, IHaveImageBuilderInfrastructureConfigurationTypesAutoScalingGroupAutoScalingGroup
        {
            /// <summary>
            /// AutoScalingGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-infrastructureconfiguration-parentinstance.html#cfn-imagebuilder-infrastructureconfiguration-parentinstance-autoscalinggroup
            /// Required: True
            /// UpdateType: Mutable
            /// Type: AutoScalingGroup
            /// </summary>
            public Union<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.AutoScalingGroup, BaseFunction>? AutoScalingGroup { get; set; }
        }

        public class Placement : Humidifier.Base.BaseSubResource, IHaveTenancy, IHaveAvailabilityZone, IHaveHostId, IHaveHostResourceGroupArn
        {
            /// <summary>
            /// Tenancy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-infrastructureconfiguration-placement.html#cfn-imagebuilder-infrastructureconfiguration-placement-tenancy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Tenancy { get; set; }
            /// <summary>
            /// AvailabilityZone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-infrastructureconfiguration-placement.html#cfn-imagebuilder-infrastructureconfiguration-placement-availabilityzone
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AvailabilityZone { get; set; }
            /// <summary>
            /// HostId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-infrastructureconfiguration-placement.html#cfn-imagebuilder-infrastructureconfiguration-placement-hostid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HostId { get; set; }
            /// <summary>
            /// HostResourceGroupArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-infrastructureconfiguration-placement.html#cfn-imagebuilder-infrastructureconfiguration-placement-hostresourcegrouparn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HostResourceGroupArn { get; set; }
        }

        public class S3Logs : Humidifier.Base.BaseSubResource, IHaveS3KeyPrefix, IHaveS3BucketName
        {
            /// <summary>
            /// S3KeyPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-infrastructureconfiguration-s3logs.html#cfn-imagebuilder-infrastructureconfiguration-s3logs-s3keyprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3KeyPrefix { get; set; }
            /// <summary>
            /// S3BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-infrastructureconfiguration-s3logs.html#cfn-imagebuilder-infrastructureconfiguration-s3logs-s3bucketname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3BucketName { get; set; }
        }
    }
}