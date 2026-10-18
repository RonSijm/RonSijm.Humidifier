namespace Humidifier.RAM
{
    using global::System.Collections.Generic;
    using ResourceShareTypes;

    public class ResourceShare : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveRAMResourceShareTypesResourceShareConfigurationResourceShareConfiguration, IHaveStringListOfPermissionArns, IHaveStringListOfPrincipals, IHaveAllowExternalPrincipals_Boolean, IHaveStringListOfSources, IHaveStringListOfResourceArns, IHaveName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string CreationTime =  "CreationTime" ;
            public static string LastUpdatedTime =  "LastUpdatedTime" ;
            public static string OwningAccountId =  "OwningAccountId" ;
            public static string FeatureSet =  "FeatureSet" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.RAM.ResourceShare; }
        /// <summary>
        /// ResourceShareConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ram-resourceshare.html#cfn-ram-resourceshare-resourceshareconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ResourceShareConfiguration
        /// </summary>
        public Union<Humidifier.RAM.ResourceShareTypes.ResourceShareConfiguration, BaseFunction>? ResourceShareConfiguration { get; set; }
        /// <summary>
        /// PermissionArns
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ram-resourceshare.html#cfn-ram-resourceshare-permissionarns
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? PermissionArns { get; set; }
        /// <summary>
        /// Principals
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ram-resourceshare.html#cfn-ram-resourceshare-principals
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Principals { get; set; }
        /// <summary>
        /// AllowExternalPrincipals
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ram-resourceshare.html#cfn-ram-resourceshare-allowexternalprincipals
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? AllowExternalPrincipals { get; set; }
        /// <summary>
        /// Sources
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ram-resourceshare.html#cfn-ram-resourceshare-sources
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Sources { get; set; }
        /// <summary>
        /// ResourceArns
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ram-resourceshare.html#cfn-ram-resourceshare-resourcearns
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ResourceArns { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ram-resourceshare.html#cfn-ram-resourceshare-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace ResourceShareTypes
    {
        public class ResourceShareConfiguration : Humidifier.Base.BaseSubResource, IHaveExclusiveAccountAccess_Boolean, IHaveRetainSharingOnAccountLeaveOrganization_Boolean
        {
            /// <summary>
            /// ExclusiveAccountAccess
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ram-resourceshare-resourceshareconfiguration.html#cfn-ram-resourceshare-resourceshareconfiguration-exclusiveaccountaccess
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ExclusiveAccountAccess { get; set; }
            /// <summary>
            /// RetainSharingOnAccountLeaveOrganization
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ram-resourceshare-resourceshareconfiguration.html#cfn-ram-resourceshare-resourceshareconfiguration-retainsharingonaccountleaveorganization
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? RetainSharingOnAccountLeaveOrganization { get; set; }
        }
    }
}