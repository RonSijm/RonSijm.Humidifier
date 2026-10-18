namespace Humidifier.Shield
{
    using global::System.Collections.Generic;

    public class ProtectionGroup : Humidifier.Base.BaseResource, IHaveTags, IHaveAggregation, IHavePattern, IHaveProtectionGroupId, IHaveResourceType, IHaveStringListOfMembers
    {
        public class Attributes
        {
            public static string ProtectionGroupArn =  "ProtectionGroupArn" ;
        }

        public override string AWSTypeName { get => AWS.Shield.ProtectionGroup; }

        /// <summary>
        /// Aggregation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-shield-protectiongroup.html#cfn-shield-protectiongroup-aggregation
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Aggregation { get; set; }

        /// <summary>
        /// Pattern
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-shield-protectiongroup.html#cfn-shield-protectiongroup-pattern
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Pattern { get; set; }

        /// <summary>
        /// ProtectionGroupId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-shield-protectiongroup.html#cfn-shield-protectiongroup-protectiongroupid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ProtectionGroupId { get; set; }
        /// <summary>
        /// ResourceType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-shield-protectiongroup.html#cfn-shield-protectiongroup-resourcetype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ResourceType { get; set; }
        /// <summary>
        /// Members
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-shield-protectiongroup.html#cfn-shield-protectiongroup-members
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Members { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-shield-protectiongroup.html#cfn-shield-protectiongroup-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}