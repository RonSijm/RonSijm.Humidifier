namespace Humidifier.SES
{
    using global::System.Collections.Generic;
    using TenantTypes;

    public class Tenant : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveListOfSESTenantTypesResourceAssociationResourceAssociations, IHaveTenantName
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.SES.Tenant; }
        /// <summary>
        /// ResourceAssociations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-tenant.html#cfn-ses-tenant-resourceassociations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ResourceAssociation
        /// </summary>
        public Union<IReadOnlyList<Humidifier.SES.TenantTypes.ResourceAssociation>, IReadOnlyList<Union<Humidifier.SES.TenantTypes.ResourceAssociation, BaseFunction>>, BaseFunction>? ResourceAssociations { get; set; }
        public Union<string, BaseFunction>? TenantName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-tenant.html#cfn-ses-tenant-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace TenantTypes
    {
        public class ResourceAssociation : Humidifier.Base.BaseSubResource, IHaveResourceArn
        {
            /// <summary>
            /// ResourceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-tenant-resourceassociation.html#cfn-ses-tenant-resourceassociation-resourcearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceArn { get; set; }
        }
    }
}