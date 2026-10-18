namespace Humidifier.Deadline
{
    using global::System.Collections.Generic;

    public class Limit : Humidifier.Base.BaseResource, IHaveDescription, IHaveAmountRequirementName, IHaveDisplayName, IHaveMaxCount_Integer, IHaveFarmId
    {
        public class Attributes
        {
            public static string LimitId =  "LimitId" ;
            public static string CurrentCount =  "CurrentCount" ;
        }

        public override string AWSTypeName { get => AWS.Deadline.Limit; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-limit.html#cfn-deadline-limit-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// AmountRequirementName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-limit.html#cfn-deadline-limit-amountrequirementname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AmountRequirementName { get; set; }

        /// <summary>
        /// DisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-limit.html#cfn-deadline-limit-displayname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DisplayName { get; set; }

        /// <summary>
        /// MaxCount
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-limit.html#cfn-deadline-limit-maxcount
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public Union<int, BaseFunction>? MaxCount { get; set; }

        /// <summary>
        /// FarmId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-limit.html#cfn-deadline-limit-farmid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? FarmId { get; set; }
    }
}