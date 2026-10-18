namespace Humidifier.CloudFormation
{
    using global::System.Collections.Generic;
    using TypeActivationTypes;

    public class TypeActivation : Humidifier.Base.BaseResource, IHaveMajorVersion, IHaveExecutionRoleArn, IHaveTypeName, IHaveType, IHavePublicTypeArn, IHaveAutoUpdate_Boolean, IHaveCloudFormationTypeActivationTypesLoggingConfigLoggingConfig, IHavePublisherId, IHaveVersionBump, IHaveTypeNameAlias
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.CloudFormation.TypeActivation; }
        /// <summary>
        /// MajorVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-typeactivation.html#cfn-cloudformation-typeactivation-majorversion
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? MajorVersion { get; set; }
        /// <summary>
        /// ExecutionRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-typeactivation.html#cfn-cloudformation-typeactivation-executionrolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ExecutionRoleArn { get; set; }
        /// <summary>
        /// TypeName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-typeactivation.html#cfn-cloudformation-typeactivation-typename
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TypeName { get; set; }
        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-typeactivation.html#cfn-cloudformation-typeactivation-type
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Type { get; set; }
        /// <summary>
        /// PublicTypeArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-typeactivation.html#cfn-cloudformation-typeactivation-publictypearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PublicTypeArn { get; set; }
        /// <summary>
        /// AutoUpdate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-typeactivation.html#cfn-cloudformation-typeactivation-autoupdate
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? AutoUpdate { get; set; }
        /// <summary>
        /// LoggingConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-typeactivation.html#cfn-cloudformation-typeactivation-loggingconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: LoggingConfig
        /// </summary>
        public Union<Humidifier.CloudFormation.TypeActivationTypes.LoggingConfig, BaseFunction>? LoggingConfig { get; set; }
        /// <summary>
        /// PublisherId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-typeactivation.html#cfn-cloudformation-typeactivation-publisherid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PublisherId { get; set; }
        /// <summary>
        /// VersionBump
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-typeactivation.html#cfn-cloudformation-typeactivation-versionbump
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? VersionBump { get; set; }
        /// <summary>
        /// TypeNameAlias
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-typeactivation.html#cfn-cloudformation-typeactivation-typenamealias
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TypeNameAlias { get; set; }
    }

    namespace TypeActivationTypes
    {
        public class LoggingConfig : Humidifier.Base.BaseSubResource, IHaveLogGroupName, IHaveLogRoleArn
        {
            /// <summary>
            /// LogGroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-typeactivation-loggingconfig.html#cfn-cloudformation-typeactivation-loggingconfig-loggroupname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogGroupName { get; set; }
            /// <summary>
            /// LogRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-typeactivation-loggingconfig.html#cfn-cloudformation-typeactivation-loggingconfig-logrolearn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogRoleArn { get; set; }
        }
    }
}