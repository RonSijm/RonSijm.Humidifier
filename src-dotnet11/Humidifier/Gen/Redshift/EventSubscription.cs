namespace Humidifier.Redshift
{
    using global::System.Collections.Generic;

    public class EventSubscription : Humidifier.Base.BaseResource, IHaveTags, IHaveSourceType, IHaveStringListOfEventCategories, IHaveEnabled_Boolean, IHaveSeverity, IHaveSubscriptionName, IHaveStringListOfSourceIds, IHaveSnsTopicArn
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string CustSubscriptionId =  "CustSubscriptionId" ;
            public static string EventCategoriesList =  "EventCategoriesList" ;
            public static string SourceIdsList =  "SourceIdsList" ;
            public static string SubscriptionCreationTime =  "SubscriptionCreationTime" ;
            public static string CustomerAwsId =  "CustomerAwsId" ;
        }

        public override string AWSTypeName { get => AWS.Redshift.EventSubscription; }
        /// <summary>
        /// SourceType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-eventsubscription.html#cfn-redshift-eventsubscription-sourcetype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SourceType { get; set; }
        /// <summary>
        /// EventCategories
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-eventsubscription.html#cfn-redshift-eventsubscription-eventcategories
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? EventCategories { get; set; }
        /// <summary>
        /// Enabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-eventsubscription.html#cfn-redshift-eventsubscription-enabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? Enabled { get; set; }
        /// <summary>
        /// Severity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-eventsubscription.html#cfn-redshift-eventsubscription-severity
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Severity { get; set; }

        /// <summary>
        /// SubscriptionName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-eventsubscription.html#cfn-redshift-eventsubscription-subscriptionname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? SubscriptionName { get; set; }
        /// <summary>
        /// SourceIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-eventsubscription.html#cfn-redshift-eventsubscription-sourceids
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SourceIds { get; set; }
        /// <summary>
        /// SnsTopicArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-eventsubscription.html#cfn-redshift-eventsubscription-snstopicarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SnsTopicArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-eventsubscription.html#cfn-redshift-eventsubscription-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}