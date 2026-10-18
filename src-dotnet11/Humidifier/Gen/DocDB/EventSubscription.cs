namespace Humidifier.DocDB
{
    using global::System.Collections.Generic;

    public class EventSubscription : Humidifier.Base.BaseResource, IHaveSourceType, IHaveEnabled_Boolean, IHaveStringListOfEventCategories, IHaveSnsTopicArn, IHaveSubscriptionName, IHaveStringListOfSourceIds
    {
        public override string AWSTypeName { get => AWS.DocDB.EventSubscription; }
        /// <summary>
        /// SourceType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-docdb-eventsubscription.html#cfn-docdb-eventsubscription-sourcetype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SourceType { get; set; }
        /// <summary>
        /// Enabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-docdb-eventsubscription.html#cfn-docdb-eventsubscription-enabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? Enabled { get; set; }
        /// <summary>
        /// EventCategories
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-docdb-eventsubscription.html#cfn-docdb-eventsubscription-eventcategories
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? EventCategories { get; set; }

        /// <summary>
        /// SnsTopicArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-docdb-eventsubscription.html#cfn-docdb-eventsubscription-snstopicarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? SnsTopicArn { get; set; }
        /// <summary>
        /// SubscriptionName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-docdb-eventsubscription.html#cfn-docdb-eventsubscription-subscriptionname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SubscriptionName { get; set; }
        /// <summary>
        /// SourceIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-docdb-eventsubscription.html#cfn-docdb-eventsubscription-sourceids
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SourceIds { get; set; }
    }
}