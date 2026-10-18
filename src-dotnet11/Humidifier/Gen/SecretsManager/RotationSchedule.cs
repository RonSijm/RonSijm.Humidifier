namespace Humidifier.SecretsManager
{
    using global::System.Collections.Generic;
    using RotationScheduleTypes;

    public class RotationSchedule : Humidifier.Base.BaseResource, IHaveSecretsManagerRotationScheduleTypesHostedRotationLambdaHostedRotationLambda, IHaveSecretId, IHaveListOfSecretsManagerRotationScheduleTypesExternalSecretRotationMetadataItemExternalSecretRotationMetadata, IHaveExternalSecretRotationRoleArn, IHaveRotateImmediatelyOnUpdate_Boolean, IHaveRotationLambdaARN, IHaveSecretsManagerRotationScheduleTypesRotationRulesRotationRules
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.SecretsManager.RotationSchedule; }
        /// <summary>
        /// HostedRotationLambda
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-secretsmanager-rotationschedule.html#cfn-secretsmanager-rotationschedule-hostedrotationlambda
        /// Required: False
        /// UpdateType: Mutable
        /// Type: HostedRotationLambda
        /// </summary>
        public Union<Humidifier.SecretsManager.RotationScheduleTypes.HostedRotationLambda, BaseFunction>? HostedRotationLambda { get; set; }

        /// <summary>
        /// SecretId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-secretsmanager-rotationschedule.html#cfn-secretsmanager-rotationschedule-secretid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? SecretId { get; set; }
        /// <summary>
        /// ExternalSecretRotationMetadata
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-secretsmanager-rotationschedule.html#cfn-secretsmanager-rotationschedule-externalsecretrotationmetadata
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ExternalSecretRotationMetadataItem
        /// </summary>
        public Union<IReadOnlyList<Humidifier.SecretsManager.RotationScheduleTypes.ExternalSecretRotationMetadataItem>, IReadOnlyList<Union<Humidifier.SecretsManager.RotationScheduleTypes.ExternalSecretRotationMetadataItem, BaseFunction>>, BaseFunction>? ExternalSecretRotationMetadata { get; set; }
        /// <summary>
        /// ExternalSecretRotationRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-secretsmanager-rotationschedule.html#cfn-secretsmanager-rotationschedule-externalsecretrotationrolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ExternalSecretRotationRoleArn { get; set; }
        /// <summary>
        /// RotateImmediatelyOnUpdate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-secretsmanager-rotationschedule.html#cfn-secretsmanager-rotationschedule-rotateimmediatelyonupdate
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? RotateImmediatelyOnUpdate { get; set; }
        /// <summary>
        /// RotationLambdaARN
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-secretsmanager-rotationschedule.html#cfn-secretsmanager-rotationschedule-rotationlambdaarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RotationLambdaARN { get; set; }
        /// <summary>
        /// RotationRules
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-secretsmanager-rotationschedule.html#cfn-secretsmanager-rotationschedule-rotationrules
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RotationRules
        /// </summary>
        public Union<Humidifier.SecretsManager.RotationScheduleTypes.RotationRules, BaseFunction>? RotationRules { get; set; }
    }

    namespace RotationScheduleTypes
    {
        public class ExternalSecretRotationMetadataItem : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-secretsmanager-rotationschedule-externalsecretrotationmetadataitem.html#cfn-secretsmanager-rotationschedule-externalsecretrotationmetadataitem-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-secretsmanager-rotationschedule-externalsecretrotationmetadataitem.html#cfn-secretsmanager-rotationschedule-externalsecretrotationmetadataitem-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class HostedRotationLambda : Humidifier.Base.BaseSubResource, IHaveRuntime, IHaveKmsKeyArn, IHaveMasterSecretArn, IHaveRotationLambdaName, IHaveRotationType, IHaveExcludeCharacters, IHaveVpcSecurityGroupIds, IHaveMasterSecretKmsKeyArn, IHaveSuperuserSecretArn, IHaveSuperuserSecretKmsKeyArn, IHaveVpcSubnetIds
        {
            /// <summary>
            /// Runtime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-secretsmanager-rotationschedule-hostedrotationlambda.html#cfn-secretsmanager-rotationschedule-hostedrotationlambda-runtime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Runtime { get; set; }
            /// <summary>
            /// KmsKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-secretsmanager-rotationschedule-hostedrotationlambda.html#cfn-secretsmanager-rotationschedule-hostedrotationlambda-kmskeyarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyArn { get; set; }
            /// <summary>
            /// MasterSecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-secretsmanager-rotationschedule-hostedrotationlambda.html#cfn-secretsmanager-rotationschedule-hostedrotationlambda-mastersecretarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MasterSecretArn { get; set; }
            /// <summary>
            /// RotationLambdaName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-secretsmanager-rotationschedule-hostedrotationlambda.html#cfn-secretsmanager-rotationschedule-hostedrotationlambda-rotationlambdaname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RotationLambdaName { get; set; }
            /// <summary>
            /// RotationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-secretsmanager-rotationschedule-hostedrotationlambda.html#cfn-secretsmanager-rotationschedule-hostedrotationlambda-rotationtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RotationType { get; set; }
            /// <summary>
            /// ExcludeCharacters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-secretsmanager-rotationschedule-hostedrotationlambda.html#cfn-secretsmanager-rotationschedule-hostedrotationlambda-excludecharacters
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExcludeCharacters { get; set; }
            /// <summary>
            /// VpcSecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-secretsmanager-rotationschedule-hostedrotationlambda.html#cfn-secretsmanager-rotationschedule-hostedrotationlambda-vpcsecuritygroupids
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VpcSecurityGroupIds { get; set; }
            /// <summary>
            /// MasterSecretKmsKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-secretsmanager-rotationschedule-hostedrotationlambda.html#cfn-secretsmanager-rotationschedule-hostedrotationlambda-mastersecretkmskeyarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MasterSecretKmsKeyArn { get; set; }
            /// <summary>
            /// SuperuserSecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-secretsmanager-rotationschedule-hostedrotationlambda.html#cfn-secretsmanager-rotationschedule-hostedrotationlambda-superusersecretarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SuperuserSecretArn { get; set; }
            /// <summary>
            /// SuperuserSecretKmsKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-secretsmanager-rotationschedule-hostedrotationlambda.html#cfn-secretsmanager-rotationschedule-hostedrotationlambda-superusersecretkmskeyarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SuperuserSecretKmsKeyArn { get; set; }
            /// <summary>
            /// VpcSubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-secretsmanager-rotationschedule-hostedrotationlambda.html#cfn-secretsmanager-rotationschedule-hostedrotationlambda-vpcsubnetids
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VpcSubnetIds { get; set; }
        }

        public class RotationRules : Humidifier.Base.BaseSubResource, IHaveScheduleExpression, IHaveDuration, IHaveAutomaticallyAfterDays_Integer
        {
            /// <summary>
            /// ScheduleExpression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-secretsmanager-rotationschedule-rotationrules.html#cfn-secretsmanager-rotationschedule-rotationrules-scheduleexpression
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ScheduleExpression { get; set; }
            /// <summary>
            /// Duration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-secretsmanager-rotationschedule-rotationrules.html#cfn-secretsmanager-rotationschedule-rotationrules-duration
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Duration { get; set; }
            /// <summary>
            /// AutomaticallyAfterDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-secretsmanager-rotationschedule-rotationrules.html#cfn-secretsmanager-rotationschedule-rotationrules-automaticallyafterdays
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? AutomaticallyAfterDays { get; set; }
        }
    }
}