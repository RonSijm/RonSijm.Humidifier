namespace Humidifier.NovaAct
{
    using global::System.Collections.Generic;
    using WorkflowDefinitionTypes;

    public class WorkflowDefinition : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveDescription
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.NovaAct.WorkflowDefinition; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-novaact-workflowdefinition.html#cfn-novaact-workflowdefinition-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// ExportConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-novaact-workflowdefinition.html#cfn-novaact-workflowdefinition-exportconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: WorkflowExportConfig
        /// </summary>
        public Humidifier.NovaAct.WorkflowDefinitionTypes.WorkflowExportConfig ExportConfig { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace WorkflowDefinitionTypes
    {
        public class WorkflowExportConfig : Humidifier.Base.BaseSubResource, IHaveS3BucketName, IHaveS3KeyPrefix
        {
            /// <summary>
            /// S3KeyPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-novaact-workflowdefinition-workflowexportconfig.html#cfn-novaact-workflowdefinition-workflowexportconfig-s3keyprefix
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3KeyPrefix { get; set; }
            /// <summary>
            /// S3BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-novaact-workflowdefinition-workflowexportconfig.html#cfn-novaact-workflowdefinition-workflowexportconfig-s3bucketname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3BucketName { get; set; }
        }
    }
}