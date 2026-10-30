namespace Humidifier.AppFabric
{
    using global::System.Collections.Generic;

    public class Ingestion : Humidifier.Base.BaseResource, IHaveTags, IHaveTenantId
    {
        public class Attributes
        {
            public static string State =  "State" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Arn =  "Arn" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.AppFabric.Ingestion; }

        /// <summary>
        /// App
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appfabric-ingestion.html#cfn-appfabric-ingestion-app
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic App { get; set; }

        /// <summary>
        /// AppBundleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appfabric-ingestion.html#cfn-appfabric-ingestion-appbundlearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic AppBundleArn { get; set; }

        /// <summary>
        /// TenantId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appfabric-ingestion.html#cfn-appfabric-ingestion-tenantid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic TenantId { get; set; }

        /// <summary>
        /// IngestionType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appfabric-ingestion.html#cfn-appfabric-ingestion-ingestiontype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic IngestionType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appfabric-ingestion.html#cfn-appfabric-ingestion-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }
}