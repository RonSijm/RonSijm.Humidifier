namespace Humidifier.CloudWatch
{
    using global::System.Collections.Generic;
    using DomainAccessGrantForOrganizationTypes;

    public class DomainAccessGrantForOrganization : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDomainId, IHavePermission, IHaveCloudWatchDomainAccessGrantForOrganizationTypesOrganizationAccessGrantPrincipalPrincipal, IHaveName
    {
        public class Attributes
        {
            public static string CreatedBy =  "CreatedBy" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string GrantId =  "GrantId" ;
            public static string GrantType =  "GrantType" ;
            public static string Arn =  "Arn" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.CloudWatch.DomainAccessGrantForOrganization; }

        /// <summary>
        /// DomainId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-domainaccessgrantfororganization.html#cfn-cloudwatch-domainaccessgrantfororganization-domainid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DomainId { get; set; }

        /// <summary>
        /// Permission
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-domainaccessgrantfororganization.html#cfn-cloudwatch-domainaccessgrantfororganization-permission
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Permission { get; set; }

        /// <summary>
        /// Principal
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-domainaccessgrantfororganization.html#cfn-cloudwatch-domainaccessgrantfororganization-principal
        /// Required: True
        /// UpdateType: Immutable
        /// Type: OrganizationAccessGrantPrincipal
        /// </summary>
        [Required]
        public Union<Humidifier.CloudWatch.DomainAccessGrantForOrganizationTypes.OrganizationAccessGrantPrincipal, BaseFunction>? Principal { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-domainaccessgrantfororganization.html#cfn-cloudwatch-domainaccessgrantfororganization-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace DomainAccessGrantForOrganizationTypes
    {
        public class OrganizationAccessGrantPrincipal : Humidifier.Base.BaseSubResource, IHavePrincipalId, IHaveListOfCloudWatchDomainAccessGrantForOrganizationTypesPrincipalAttributePrincipalAttributes, IHavePrincipalType
        {
            /// <summary>
            /// PrincipalId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-domainaccessgrantfororganization-organizationaccessgrantprincipal.html#cfn-cloudwatch-domainaccessgrantfororganization-organizationaccessgrantprincipal-principalid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PrincipalId { get; set; }
            /// <summary>
            /// PrincipalAttributes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-domainaccessgrantfororganization-organizationaccessgrantprincipal.html#cfn-cloudwatch-domainaccessgrantfororganization-organizationaccessgrantprincipal-principalattributes
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: PrincipalAttribute
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CloudWatch.DomainAccessGrantForOrganizationTypes.PrincipalAttribute>, IReadOnlyList<Union<Humidifier.CloudWatch.DomainAccessGrantForOrganizationTypes.PrincipalAttribute, BaseFunction>>, BaseFunction>? PrincipalAttributes { get; set; }
            /// <summary>
            /// PrincipalType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-domainaccessgrantfororganization-organizationaccessgrantprincipal.html#cfn-cloudwatch-domainaccessgrantfororganization-organizationaccessgrantprincipal-principaltype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PrincipalType { get; set; }
        }

        public class PrincipalAttribute : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-domainaccessgrantfororganization-principalattribute.html#cfn-cloudwatch-domainaccessgrantfororganization-principalattribute-value
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-domainaccessgrantfororganization-principalattribute.html#cfn-cloudwatch-domainaccessgrantfororganization-principalattribute-key
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}