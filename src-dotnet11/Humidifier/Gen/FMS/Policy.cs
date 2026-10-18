namespace Humidifier.FMS
{
    using global::System.Collections.Generic;
    using PolicyTypes;

    public class Policy : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveResourceTagLogicalOperator, IHaveResourcesCleanUp_Boolean, IHaveListOfFMSPolicyTypesResourceTagResourceTags, IHaveExcludeResourceTags_Boolean, IHaveResourceType, IHaveStringListOfResourceSetIds, IHaveFMSPolicyTypesSecurityServicePolicyDataSecurityServicePolicyData, IHaveRemediationEnabled_Boolean, IHaveDeleteAllPolicyResources_Boolean, IHaveFMSPolicyTypesIEMapExcludeMap, IHaveFMSPolicyTypesIEMapIncludeMap, IHavePolicyDescription, IHavePolicyName, IHaveStringListOfResourceTypeList, IHaveListOfFMSPolicyTypesPolicyTagTags, IHaveDescription
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.FMS.Policy; }
        /// <summary>
        /// ResourceTagLogicalOperator
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fms-policy.html#cfn-fms-policy-resourcetaglogicaloperator
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ResourceTagLogicalOperator { get; set; }
        /// <summary>
        /// ResourcesCleanUp
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fms-policy.html#cfn-fms-policy-resourcescleanup
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? ResourcesCleanUp { get; set; }
        /// <summary>
        /// ResourceTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fms-policy.html#cfn-fms-policy-resourcetags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ResourceTag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.FMS.PolicyTypes.ResourceTag>, IReadOnlyList<Union<Humidifier.FMS.PolicyTypes.ResourceTag, BaseFunction>>, BaseFunction>? ResourceTags { get; set; }

        /// <summary>
        /// ExcludeResourceTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fms-policy.html#cfn-fms-policy-excluderesourcetags
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        [Required]
        public Union<bool, BaseFunction>? ExcludeResourceTags { get; set; }
        /// <summary>
        /// ResourceType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fms-policy.html#cfn-fms-policy-resourcetype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ResourceType { get; set; }
        /// <summary>
        /// ResourceSetIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fms-policy.html#cfn-fms-policy-resourcesetids
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ResourceSetIds { get; set; }

        /// <summary>
        /// SecurityServicePolicyData
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fms-policy.html#cfn-fms-policy-securityservicepolicydata
        /// Required: True
        /// UpdateType: Mutable
        /// Type: SecurityServicePolicyData
        /// </summary>
        [Required]
        public Union<Humidifier.FMS.PolicyTypes.SecurityServicePolicyData, BaseFunction>? SecurityServicePolicyData { get; set; }

        /// <summary>
        /// RemediationEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fms-policy.html#cfn-fms-policy-remediationenabled
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        [Required]
        public Union<bool, BaseFunction>? RemediationEnabled { get; set; }
        /// <summary>
        /// DeleteAllPolicyResources
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fms-policy.html#cfn-fms-policy-deleteallpolicyresources
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? DeleteAllPolicyResources { get; set; }
        /// <summary>
        /// ExcludeMap
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fms-policy.html#cfn-fms-policy-excludemap
        /// Required: False
        /// UpdateType: Mutable
        /// Type: IEMap
        /// </summary>
        public Union<Humidifier.FMS.PolicyTypes.IEMap, BaseFunction>? ExcludeMap { get; set; }
        /// <summary>
        /// IncludeMap
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fms-policy.html#cfn-fms-policy-includemap
        /// Required: False
        /// UpdateType: Mutable
        /// Type: IEMap
        /// </summary>
        public Union<Humidifier.FMS.PolicyTypes.IEMap, BaseFunction>? IncludeMap { get; set; }
        /// <summary>
        /// PolicyDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fms-policy.html#cfn-fms-policy-policydescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PolicyDescription { get; set; }

        [Ignore]
        public Union<string, BaseFunction>? Description { get => PolicyDescription; set => PolicyDescription = value; }
        public Union<string, BaseFunction>? PolicyName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// ResourceTypeList
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fms-policy.html#cfn-fms-policy-resourcetypelist
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ResourceTypeList { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fms-policy.html#cfn-fms-policy-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: PolicyTag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.FMS.PolicyTypes.PolicyTag>, IReadOnlyList<Union<Humidifier.FMS.PolicyTypes.PolicyTag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace PolicyTypes
    {
        public class IEMap : Humidifier.Base.BaseSubResource, IHaveStringListOfACCOUNT, IHaveStringListOfORGUNIT
        {
            /// <summary>
            /// ACCOUNT
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fms-policy-iemap.html#cfn-fms-policy-iemap-account
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ACCOUNT { get; set; }
            /// <summary>
            /// ORGUNIT
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fms-policy-iemap.html#cfn-fms-policy-iemap-orgunit
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ORGUNIT { get; set; }
        }

        public class IcmpTypeCode : Humidifier.Base.BaseSubResource, IHaveType_Integer, IHaveCode_Integer
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fms-policy-icmptypecode.html#cfn-fms-policy-icmptypecode-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Code
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fms-policy-icmptypecode.html#cfn-fms-policy-icmptypecode-code
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Code { get; set; }
        }

        public class NetworkAclCommonPolicy : Humidifier.Base.BaseSubResource, IHaveFMSPolicyTypesNetworkAclEntrySetNetworkAclEntrySet
        {
            /// <summary>
            /// NetworkAclEntrySet
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fms-policy-networkaclcommonpolicy.html#cfn-fms-policy-networkaclcommonpolicy-networkaclentryset
            /// Required: True
            /// UpdateType: Mutable
            /// Type: NetworkAclEntrySet
            /// </summary>
            public Union<Humidifier.FMS.PolicyTypes.NetworkAclEntrySet, BaseFunction>? NetworkAclEntrySet { get; set; }
        }

        public class NetworkAclEntry : Humidifier.Base.BaseSubResource, IHaveFMSPolicyTypesPortRangePortRange, IHaveFMSPolicyTypesIcmpTypeCodeIcmpTypeCode, IHaveRuleAction, IHaveCidrBlock, IHaveEgress_Boolean, IHaveIpv6CidrBlock, IHaveProtocol
        {
            /// <summary>
            /// PortRange
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fms-policy-networkaclentry.html#cfn-fms-policy-networkaclentry-portrange
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PortRange
            /// </summary>
            public Union<Humidifier.FMS.PolicyTypes.PortRange, BaseFunction>? PortRange { get; set; }
            /// <summary>
            /// IcmpTypeCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fms-policy-networkaclentry.html#cfn-fms-policy-networkaclentry-icmptypecode
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IcmpTypeCode
            /// </summary>
            public Union<Humidifier.FMS.PolicyTypes.IcmpTypeCode, BaseFunction>? IcmpTypeCode { get; set; }
            /// <summary>
            /// RuleAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fms-policy-networkaclentry.html#cfn-fms-policy-networkaclentry-ruleaction
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RuleAction { get; set; }
            /// <summary>
            /// CidrBlock
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fms-policy-networkaclentry.html#cfn-fms-policy-networkaclentry-cidrblock
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CidrBlock { get; set; }
            /// <summary>
            /// Egress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fms-policy-networkaclentry.html#cfn-fms-policy-networkaclentry-egress
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Egress { get; set; }
            /// <summary>
            /// Ipv6CidrBlock
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fms-policy-networkaclentry.html#cfn-fms-policy-networkaclentry-ipv6cidrblock
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Ipv6CidrBlock { get; set; }
            /// <summary>
            /// Protocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fms-policy-networkaclentry.html#cfn-fms-policy-networkaclentry-protocol
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Protocol { get; set; }
        }

        public class NetworkAclEntrySet : Humidifier.Base.BaseSubResource, IHaveListOfFMSPolicyTypesNetworkAclEntryLastEntries, IHaveForceRemediateForFirstEntries_Boolean, IHaveListOfFMSPolicyTypesNetworkAclEntryFirstEntries, IHaveForceRemediateForLastEntries_Boolean
        {
            /// <summary>
            /// LastEntries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fms-policy-networkaclentryset.html#cfn-fms-policy-networkaclentryset-lastentries
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: NetworkAclEntry
            /// </summary>
            public Union<IReadOnlyList<Humidifier.FMS.PolicyTypes.NetworkAclEntry>, IReadOnlyList<Union<Humidifier.FMS.PolicyTypes.NetworkAclEntry, BaseFunction>>, BaseFunction>? LastEntries { get; set; }
            /// <summary>
            /// ForceRemediateForFirstEntries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fms-policy-networkaclentryset.html#cfn-fms-policy-networkaclentryset-forceremediateforfirstentries
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ForceRemediateForFirstEntries { get; set; }
            /// <summary>
            /// FirstEntries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fms-policy-networkaclentryset.html#cfn-fms-policy-networkaclentryset-firstentries
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: NetworkAclEntry
            /// </summary>
            public Union<IReadOnlyList<Humidifier.FMS.PolicyTypes.NetworkAclEntry>, IReadOnlyList<Union<Humidifier.FMS.PolicyTypes.NetworkAclEntry, BaseFunction>>, BaseFunction>? FirstEntries { get; set; }
            /// <summary>
            /// ForceRemediateForLastEntries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fms-policy-networkaclentryset.html#cfn-fms-policy-networkaclentryset-forceremediateforlastentries
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ForceRemediateForLastEntries { get; set; }
        }

        public class NetworkFirewallPolicy : Humidifier.Base.BaseSubResource, IHaveFirewallDeploymentModel
        {
            /// <summary>
            /// FirewallDeploymentModel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fms-policy-networkfirewallpolicy.html#cfn-fms-policy-networkfirewallpolicy-firewalldeploymentmodel
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FirewallDeploymentModel { get; set; }
        }

        public class PolicyOption : Humidifier.Base.BaseSubResource, IHaveFMSPolicyTypesNetworkFirewallPolicyNetworkFirewallPolicy, IHaveFMSPolicyTypesNetworkAclCommonPolicyNetworkAclCommonPolicy, IHaveFMSPolicyTypesThirdPartyFirewallPolicyThirdPartyFirewallPolicy
        {
            /// <summary>
            /// NetworkFirewallPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fms-policy-policyoption.html#cfn-fms-policy-policyoption-networkfirewallpolicy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NetworkFirewallPolicy
            /// </summary>
            public Union<Humidifier.FMS.PolicyTypes.NetworkFirewallPolicy, BaseFunction>? NetworkFirewallPolicy { get; set; }
            /// <summary>
            /// NetworkAclCommonPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fms-policy-policyoption.html#cfn-fms-policy-policyoption-networkaclcommonpolicy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NetworkAclCommonPolicy
            /// </summary>
            public Union<Humidifier.FMS.PolicyTypes.NetworkAclCommonPolicy, BaseFunction>? NetworkAclCommonPolicy { get; set; }
            /// <summary>
            /// ThirdPartyFirewallPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fms-policy-policyoption.html#cfn-fms-policy-policyoption-thirdpartyfirewallpolicy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ThirdPartyFirewallPolicy
            /// </summary>
            public Union<Humidifier.FMS.PolicyTypes.ThirdPartyFirewallPolicy, BaseFunction>? ThirdPartyFirewallPolicy { get; set; }
        }

        public class PolicyTag : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fms-policy-policytag.html#cfn-fms-policy-policytag-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fms-policy-policytag.html#cfn-fms-policy-policytag-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class PortRange : Humidifier.Base.BaseSubResource, IHaveFrom_Integer, IHaveTo_Integer
        {
            /// <summary>
            /// From
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fms-policy-portrange.html#cfn-fms-policy-portrange-from
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? From { get; set; }
            /// <summary>
            /// To
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fms-policy-portrange.html#cfn-fms-policy-portrange-to
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? To { get; set; }
        }

        public class ResourceTag : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fms-policy-resourcetag.html#cfn-fms-policy-resourcetag-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fms-policy-resourcetag.html#cfn-fms-policy-resourcetag-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class SecurityServicePolicyData : Humidifier.Base.BaseSubResource, IHaveManagedServiceData, IHaveType, IHaveFMSPolicyTypesPolicyOptionPolicyOption
        {
            /// <summary>
            /// ManagedServiceData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fms-policy-securityservicepolicydata.html#cfn-fms-policy-securityservicepolicydata-managedservicedata
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ManagedServiceData { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fms-policy-securityservicepolicydata.html#cfn-fms-policy-securityservicepolicydata-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// PolicyOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fms-policy-securityservicepolicydata.html#cfn-fms-policy-securityservicepolicydata-policyoption
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PolicyOption
            /// </summary>
            public Union<Humidifier.FMS.PolicyTypes.PolicyOption, BaseFunction>? PolicyOption { get; set; }
        }

        public class ThirdPartyFirewallPolicy : Humidifier.Base.BaseSubResource, IHaveFirewallDeploymentModel
        {
            /// <summary>
            /// FirewallDeploymentModel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fms-policy-thirdpartyfirewallpolicy.html#cfn-fms-policy-thirdpartyfirewallpolicy-firewalldeploymentmodel
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FirewallDeploymentModel { get; set; }
        }
    }
}