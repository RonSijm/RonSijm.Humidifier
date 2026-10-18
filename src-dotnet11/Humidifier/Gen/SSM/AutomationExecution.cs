namespace Humidifier.SSM
{
    using global::System.Collections.Generic;

    public class AutomationExecution : Humidifier.Base.BaseResource, IHaveTags, IHaveDocumentName
    {
        public class Attributes
        {
            public static string AutomationExecutionStatus =  "AutomationExecutionStatus" ;
            public static string ExecutionStartTime =  "ExecutionStartTime" ;
            public static string Mode =  "Mode" ;
            public static string DocumentVersion =  "DocumentVersion" ;
            public static string Arn =  "Arn" ;
            public static string AutomationExecutionId =  "AutomationExecutionId" ;
            public static string ExecutedBy =  "ExecutedBy" ;
        }

        public override string AWSTypeName { get => AWS.SSM.AutomationExecution; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-automationexecution.html#cfn-ssm-automationexecution-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }

        /// <summary>
        /// DocumentName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-automationexecution.html#cfn-ssm-automationexecution-documentname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DocumentName { get; set; }
    }
}