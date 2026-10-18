namespace Humidifier.CloudFormation
{
    using global::System.Collections.Generic;
    using HookVersionTypes;

    public class HookVersion : Humidifier.Base.BaseResource, IHaveExecutionRoleArn, IHaveTypeName, IHaveCloudFormationHookVersionTypesLoggingConfigLoggingConfig, IHaveSchemaHandlerPackage
    {
        public class Attributes
        {
            public static string VersionId =  "VersionId" ;
            public static string IsDefaultVersion =  "IsDefaultVersion" ;
            public static string Visibility =  "Visibility" ;
            public static string Arn =  "Arn" ;
            public static string TypeArn =  "TypeArn" ;
        }

        public override string AWSTypeName { get => AWS.CloudFormation.HookVersion; }
        /// <summary>
        /// ExecutionRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-hookversion.html#cfn-cloudformation-hookversion-executionrolearn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ExecutionRoleArn { get; set; }

        /// <summary>
        /// TypeName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-hookversion.html#cfn-cloudformation-hookversion-typename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? TypeName { get; set; }
        /// <summary>
        /// LoggingConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-hookversion.html#cfn-cloudformation-hookversion-loggingconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: LoggingConfig
        /// </summary>
        public Union<Humidifier.CloudFormation.HookVersionTypes.LoggingConfig, BaseFunction>? LoggingConfig { get; set; }

        /// <summary>
        /// SchemaHandlerPackage
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-hookversion.html#cfn-cloudformation-hookversion-schemahandlerpackage
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? SchemaHandlerPackage { get; set; }
    }

    namespace HookVersionTypes
    {
        public class LoggingConfig : Humidifier.Base.BaseSubResource, IHaveLogGroupName, IHaveLogRoleArn
        {
            /// <summary>
            /// LogGroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-hookversion-loggingconfig.html#cfn-cloudformation-hookversion-loggingconfig-loggroupname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogGroupName { get; set; }
            /// <summary>
            /// LogRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-hookversion-loggingconfig.html#cfn-cloudformation-hookversion-loggingconfig-logrolearn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogRoleArn { get; set; }
        }
    }
}