namespace Humidifier.CloudFormation
{
    using System.Collections.Generic;
    using HookVersionTypes;

    public class HookVersion : Humidifier.Base.BaseResource, IHaveExecutionRoleArn, IHaveTypeName, IHaveSchemaHandlerPackage
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
        public dynamic ExecutionRoleArn { get; set; }

        /// <summary>
        /// TypeName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-hookversion.html#cfn-cloudformation-hookversion-typename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic TypeName { get; set; }
        /// <summary>
        /// LoggingConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-hookversion.html#cfn-cloudformation-hookversion-loggingconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: LoggingConfig
        /// </summary>
        public Humidifier.CloudFormation.HookVersionTypes.LoggingConfig LoggingConfig { get; set; }

        /// <summary>
        /// SchemaHandlerPackage
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-hookversion.html#cfn-cloudformation-hookversion-schemahandlerpackage
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic SchemaHandlerPackage { get; set; }
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
            public dynamic LogGroupName { get; set; }
            /// <summary>
            /// LogRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-hookversion-loggingconfig.html#cfn-cloudformation-hookversion-loggingconfig-logrolearn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogRoleArn { get; set; }
        }
    }
}