namespace Humidifier.CloudFormation
{
    using System.Collections.Generic;
    using ResourceVersionTypes;

    public class ResourceVersion : Humidifier.Base.BaseResource, IHaveExecutionRoleArn, IHaveTypeName
    {
        public class Attributes
        {
            public static string VersionId =  "VersionId" ;
            public static string ProvisioningType =  "ProvisioningType" ;
            public static string IsDefaultVersion =  "IsDefaultVersion" ;
            public static string Visibility =  "Visibility" ;
            public static string Arn =  "Arn" ;
            public static string TypeArn =  "TypeArn" ;
        }

        public override string AWSTypeName { get => AWS.CloudFormation.ResourceVersion; }
        /// <summary>
        /// ExecutionRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-resourceversion.html#cfn-cloudformation-resourceversion-executionrolearn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ExecutionRoleArn { get; set; }

        /// <summary>
        /// TypeName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-resourceversion.html#cfn-cloudformation-resourceversion-typename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic TypeName { get; set; }
        /// <summary>
        /// LoggingConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-resourceversion.html#cfn-cloudformation-resourceversion-loggingconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: LoggingConfig
        /// </summary>
        public Humidifier.CloudFormation.ResourceVersionTypes.LoggingConfig LoggingConfig { get; set; }

        /// <summary>
        /// SchemaHandlerPackage
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-resourceversion.html#cfn-cloudformation-resourceversion-schemahandlerpackage
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic SchemaHandlerPackage { get; set; }
    }

    namespace ResourceVersionTypes
    {
        public class LoggingConfig : Humidifier.Base.BaseSubResource, IHaveLogGroupName, IHaveLogRoleArn
        {
            /// <summary>
            /// LogGroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-resourceversion-loggingconfig.html#cfn-cloudformation-resourceversion-loggingconfig-loggroupname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogGroupName { get; set; }
            /// <summary>
            /// LogRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-resourceversion-loggingconfig.html#cfn-cloudformation-resourceversion-loggingconfig-logrolearn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogRoleArn { get; set; }
        }
    }
}