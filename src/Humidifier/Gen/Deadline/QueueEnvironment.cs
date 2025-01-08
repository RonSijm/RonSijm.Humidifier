namespace Humidifier.Deadline
{
    using System.Collections.Generic;

    public class QueueEnvironment : Humidifier.Base.BaseResource, IHavePriority, IHaveTemplateType, IHaveFarmId, IHaveTemplate, IHaveQueueId
    {
        public class Attributes
        {
            public static string QueueEnvironmentId =  "QueueEnvironmentId" ;
            public static string Name =  "Name" ;
        }

        public override string AWSTypeName { get => AWS.Deadline.QueueEnvironment; }

        /// <summary>
        /// Priority
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-queueenvironment.html#cfn-deadline-queueenvironment-priority
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public dynamic Priority { get; set; }

        /// <summary>
        /// QueueId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-queueenvironment.html#cfn-deadline-queueenvironment-queueid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic QueueId { get; set; }

        /// <summary>
        /// TemplateType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-queueenvironment.html#cfn-deadline-queueenvironment-templatetype
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic TemplateType { get; set; }

        /// <summary>
        /// FarmId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-queueenvironment.html#cfn-deadline-queueenvironment-farmid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic FarmId { get; set; }

        /// <summary>
        /// Template
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-queueenvironment.html#cfn-deadline-queueenvironment-template
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Template { get; set; }
    }
}