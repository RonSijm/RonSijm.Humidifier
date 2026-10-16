namespace Humidifier.SES
{
    using global::System.Collections.Generic;
    using TenantTypes;

    public class Tenant : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.SES.Tenant; }
        /// <summary>
        /// SuppressionAttributes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-tenant.html#cfn-ses-tenant-suppressionattributes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: TenantSuppressionAttributes
        /// </summary>
        public Humidifier.SES.TenantTypes.TenantSuppressionAttributes SuppressionAttributes { get; set; }
        /// <summary>
        /// ResourceAssociations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-tenant.html#cfn-ses-tenant-resourceassociations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ResourceAssociation
        /// </summary>
        public List<Humidifier.SES.TenantTypes.ResourceAssociation> ResourceAssociations { get; set; }
        public dynamic TenantName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// ReputationEntity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-tenant.html#cfn-ses-tenant-reputationentity
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ReputationEntity
        /// </summary>
        public Humidifier.SES.TenantTypes.ReputationEntity ReputationEntity { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-tenant.html#cfn-ses-tenant-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace TenantTypes
    {
        public class ReputationEntity : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Policy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-tenant-reputationentity.html#cfn-ses-tenant-reputationentity-policy
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ReputationPolicy
            /// </summary>
            public Humidifier.SES.TenantTypes.ReputationPolicy Policy { get; set; }
        }

        public class ReputationPolicy : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ReputationEntityPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-tenant-reputationpolicy.html#cfn-ses-tenant-reputationpolicy-reputationentitypolicy
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ReputationEntityPolicy { get; set; }
        }

        public class ResourceAssociation : Humidifier.Base.BaseSubResource, IHaveResourceArn
        {
            /// <summary>
            /// ResourceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-tenant-resourceassociation.html#cfn-ses-tenant-resourceassociation-resourcearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ResourceArn { get; set; }
        }

        public class TenantSuppressionAttributes : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SuppressionScope
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-tenant-tenantsuppressionattributes.html#cfn-ses-tenant-tenantsuppressionattributes-suppressionscope
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SuppressionScope { get; set; }
            /// <summary>
            /// SuppressedReasons
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-tenant-tenantsuppressionattributes.html#cfn-ses-tenant-tenantsuppressionattributes-suppressedreasons
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SuppressedReasons { get; set; }
        }
    }
}