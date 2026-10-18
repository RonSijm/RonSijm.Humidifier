namespace Humidifier.DRS
{
    using global::System.Collections.Generic;

    public class RecoveryPlanExecution : Humidifier.Base.BaseResource, IHaveTags, IHaveRecoveryPlanArn, IHaveMode
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string RecoveryPlanExecutionArn =  "RecoveryPlanExecutionArn" ;
            public static string CompletedAt =  "CompletedAt" ;
            public static string StartedAt =  "StartedAt" ;
        }

        public override string AWSTypeName { get => AWS.DRS.RecoveryPlanExecution; }

        /// <summary>
        /// RecoveryPlanArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-drs-recoveryplanexecution.html#cfn-drs-recoveryplanexecution-recoveryplanarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RecoveryPlanArn { get; set; }

        /// <summary>
        /// Mode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-drs-recoveryplanexecution.html#cfn-drs-recoveryplanexecution-mode
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Mode { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-drs-recoveryplanexecution.html#cfn-drs-recoveryplanexecution-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}