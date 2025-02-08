namespace Humidifier.Deadline
{
    using System.Collections.Generic;

    public class Limit : Humidifier.Base.BaseResource, IHaveDescription, IHaveDisplayName, IHaveFarmId, IHaveMaxCount
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
        public dynamic Description { get; set; }

        /// <summary>
        /// AmountRequirementName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-limit.html#cfn-deadline-limit-amountrequirementname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic AmountRequirementName { get; set; }

        /// <summary>
        /// DisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-limit.html#cfn-deadline-limit-displayname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DisplayName { get; set; }

        /// <summary>
        /// MaxCount
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-limit.html#cfn-deadline-limit-maxcount
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public dynamic MaxCount { get; set; }

        /// <summary>
        /// FarmId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-limit.html#cfn-deadline-limit-farmid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic FarmId { get; set; }
    }
}