namespace Humidifier.CloudWatch
{
    using global::System.Collections.Generic;
    using AccessGrantTypes;

    public class AccessGrant : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDomainId, IHaveSpaceId, IHavePermission, IHaveListOfCloudWatchAccessGrantTypesScopedActionsScopedActions, IHaveCloudWatchAccessGrantTypesAccessGrantPrincipalPrincipal, IHaveName
    {
        public class Attributes
        {
            public static string AccountId =  "AccountId" ;
            public static string CreatedBy =  "CreatedBy" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string GrantType =  "GrantType" ;
            public static string GrantId =  "GrantId" ;
            public static string Arn =  "Arn" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.CloudWatch.AccessGrant; }

        /// <summary>
        /// DomainId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-accessgrant.html#cfn-cloudwatch-accessgrant-domainid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DomainId { get; set; }

        /// <summary>
        /// SpaceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-accessgrant.html#cfn-cloudwatch-accessgrant-spaceid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? SpaceId { get; set; }

        /// <summary>
        /// Permission
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-accessgrant.html#cfn-cloudwatch-accessgrant-permission
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Permission { get; set; }
        /// <summary>
        /// ScopedActions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-accessgrant.html#cfn-cloudwatch-accessgrant-scopedactions
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: ScopedActions
        /// </summary>
        public Union<IReadOnlyList<Humidifier.CloudWatch.AccessGrantTypes.ScopedActions>, IReadOnlyList<Union<Humidifier.CloudWatch.AccessGrantTypes.ScopedActions, BaseFunction>>, BaseFunction>? ScopedActions { get; set; }

        /// <summary>
        /// Principal
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-accessgrant.html#cfn-cloudwatch-accessgrant-principal
        /// Required: True
        /// UpdateType: Immutable
        /// Type: AccessGrantPrincipal
        /// </summary>
        [Required]
        public Union<Humidifier.CloudWatch.AccessGrantTypes.AccessGrantPrincipal, BaseFunction>? Principal { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-accessgrant.html#cfn-cloudwatch-accessgrant-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace AccessGrantTypes
    {
        public class AccessGrantPrincipal : Humidifier.Base.BaseSubResource, IHavePrincipalId, IHaveListOfCloudWatchAccessGrantTypesAccessGrantPrincipalAttributePrincipalAttributes, IHavePrincipalType
        {
            /// <summary>
            /// PrincipalId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-accessgrant-accessgrantprincipal.html#cfn-cloudwatch-accessgrant-accessgrantprincipal-principalid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PrincipalId { get; set; }
            /// <summary>
            /// PrincipalAttributes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-accessgrant-accessgrantprincipal.html#cfn-cloudwatch-accessgrant-accessgrantprincipal-principalattributes
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: AccessGrantPrincipalAttribute
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CloudWatch.AccessGrantTypes.AccessGrantPrincipalAttribute>, IReadOnlyList<Union<Humidifier.CloudWatch.AccessGrantTypes.AccessGrantPrincipalAttribute, BaseFunction>>, BaseFunction>? PrincipalAttributes { get; set; }
            /// <summary>
            /// PrincipalType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-accessgrant-accessgrantprincipal.html#cfn-cloudwatch-accessgrant-accessgrantprincipal-principaltype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PrincipalType { get; set; }
        }

        public class AccessGrantPrincipalAttribute : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-accessgrant-accessgrantprincipalattribute.html#cfn-cloudwatch-accessgrant-accessgrantprincipalattribute-value
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-accessgrant-accessgrantprincipalattribute.html#cfn-cloudwatch-accessgrant-accessgrantprincipalattribute-key
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class ResourceScope : Humidifier.Base.BaseSubResource, IHaveResourceType, IHaveRowScopeGroups_Json, IHaveStringListOfResourceArns, IHaveStringDictionaryOfTags, IHaveStringListOfSignalTypes
        {
            /// <summary>
            /// ResourceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-accessgrant-resourcescope.html#cfn-cloudwatch-accessgrant-resourcescope-resourcetype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceType { get; set; }
            /// <summary>
            /// RowScopeGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-accessgrant-resourcescope.html#cfn-cloudwatch-accessgrant-resourcescope-rowscopegroups
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? RowScopeGroups { get; set; }
            /// <summary>
            /// ResourceArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-accessgrant-resourcescope.html#cfn-cloudwatch-accessgrant-resourcescope-resourcearns
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ResourceArns { get; set; }
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-accessgrant-resourcescope.html#cfn-cloudwatch-accessgrant-resourcescope-tags
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
            /// <summary>
            /// SignalTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-accessgrant-resourcescope.html#cfn-cloudwatch-accessgrant-resourcescope-signaltypes
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SignalTypes { get; set; }
        }

        public class ScopedActions : Humidifier.Base.BaseSubResource, IHaveStringListOfActions, IHaveListOfCloudWatchAccessGrantTypesResourceScopeResources, IHaveContextConditions_Json
        {
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-accessgrant-scopedactions.html#cfn-cloudwatch-accessgrant-scopedactions-actions
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Actions { get; set; }
            /// <summary>
            /// Resources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-accessgrant-scopedactions.html#cfn-cloudwatch-accessgrant-scopedactions-resources
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: ResourceScope
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CloudWatch.AccessGrantTypes.ResourceScope>, IReadOnlyList<Union<Humidifier.CloudWatch.AccessGrantTypes.ResourceScope, BaseFunction>>, BaseFunction>? Resources { get; set; }
            /// <summary>
            /// ContextConditions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-accessgrant-scopedactions.html#cfn-cloudwatch-accessgrant-scopedactions-contextconditions
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? ContextConditions { get; set; }
        }
    }
}