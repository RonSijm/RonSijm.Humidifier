namespace Humidifier.SecurityHub
{
    using System.Collections.Generic;
    using InsightTypes;

    public class Insight : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName
    {
        public class Attributes
        {
            public static string InsightArn =  "InsightArn" ;
        }

        public override string AWSTypeName { get => AWS.SecurityHub.Insight; }

        /// <summary>
        /// Filters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityhub-insight.html#cfn-securityhub-insight-filters
        /// Required: True
        /// UpdateType: Mutable
        /// Type: AwsSecurityFindingFilters
        /// </summary>
        [Required]
        public Humidifier.SecurityHub.InsightTypes.AwsSecurityFindingFilters Filters { get; set; }

        /// <summary>
        /// GroupByAttribute
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityhub-insight.html#cfn-securityhub-insight-groupbyattribute
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic GroupByAttribute { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace InsightTypes
    {
        public class AwsSecurityFindingFilters : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ResourceAwsEc2InstanceIamInstanceProfileArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-resourceawsec2instanceiaminstanceprofilearn
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> ResourceAwsEc2InstanceIamInstanceProfileArn { get; set; }
            /// <summary>
            /// SourceUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-sourceurl
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> SourceUrl { get; set; }
            /// <summary>
            /// ProcessName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-processname
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> ProcessName { get; set; }
            /// <summary>
            /// FindingProviderFieldsConfidence
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-findingproviderfieldsconfidence
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: NumberFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.NumberFilter> FindingProviderFieldsConfidence { get; set; }
            /// <summary>
            /// FirstObservedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-firstobservedat
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DateFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.DateFilter> FirstObservedAt { get; set; }
            /// <summary>
            /// CreatedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-createdat
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DateFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.DateFilter> CreatedAt { get; set; }
            /// <summary>
            /// MalwareState
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-malwarestate
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> MalwareState { get; set; }
            /// <summary>
            /// UserDefinedFields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-userdefinedfields
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MapFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.MapFilter> UserDefinedFields { get; set; }
            /// <summary>
            /// NetworkSourcePort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-networksourceport
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: NumberFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.NumberFilter> NetworkSourcePort { get; set; }
            /// <summary>
            /// ResourceAwsIamUserUserName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-resourceawsiamuserusername
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> ResourceAwsIamUserUserName { get; set; }
            /// <summary>
            /// NetworkSourceDomain
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-networksourcedomain
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> NetworkSourceDomain { get; set; }
            /// <summary>
            /// ResourcePartition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-resourcepartition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> ResourcePartition { get; set; }
            /// <summary>
            /// FindingProviderFieldsRelatedFindingsId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-findingproviderfieldsrelatedfindingsid
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> FindingProviderFieldsRelatedFindingsId { get; set; }
            /// <summary>
            /// NetworkDirection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-networkdirection
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> NetworkDirection { get; set; }
            /// <summary>
            /// Criticality
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-criticality
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: NumberFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.NumberFilter> Criticality { get; set; }
            /// <summary>
            /// ResourceApplicationArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-resourceapplicationarn
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> ResourceApplicationArn { get; set; }
            /// <summary>
            /// ComplianceSecurityControlParametersValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-compliancesecuritycontrolparametersvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> ComplianceSecurityControlParametersValue { get; set; }
            /// <summary>
            /// SeverityLabel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-severitylabel
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> SeverityLabel { get; set; }
            /// <summary>
            /// RelatedFindingsProductArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-relatedfindingsproductarn
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> RelatedFindingsProductArn { get; set; }
            /// <summary>
            /// ResourceAwsIamAccessKeyPrincipalName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-resourceawsiamaccesskeyprincipalname
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> ResourceAwsIamAccessKeyPrincipalName { get; set; }
            /// <summary>
            /// ThreatIntelIndicatorCategory
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-threatintelindicatorcategory
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> ThreatIntelIndicatorCategory { get; set; }
            /// <summary>
            /// ComplianceStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-compliancestatus
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> ComplianceStatus { get; set; }
            /// <summary>
            /// ThreatIntelIndicatorValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-threatintelindicatorvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> ThreatIntelIndicatorValue { get; set; }
            /// <summary>
            /// ResourceContainerImageName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-resourcecontainerimagename
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> ResourceContainerImageName { get; set; }
            /// <summary>
            /// MalwareType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-malwaretype
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> MalwareType { get; set; }
            /// <summary>
            /// ThreatIntelIndicatorSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-threatintelindicatorsource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> ThreatIntelIndicatorSource { get; set; }
            /// <summary>
            /// ResourceAwsIamAccessKeyCreatedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-resourceawsiamaccesskeycreatedat
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DateFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.DateFilter> ResourceAwsIamAccessKeyCreatedAt { get; set; }
            /// <summary>
            /// ResourceAwsEc2InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-resourceawsec2instancetype
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> ResourceAwsEc2InstanceType { get; set; }
            /// <summary>
            /// RecommendationText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-recommendationtext
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> RecommendationText { get; set; }
            /// <summary>
            /// AwsAccountName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-awsaccountname
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> AwsAccountName { get; set; }
            /// <summary>
            /// FindingProviderFieldsRelatedFindingsProductArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-findingproviderfieldsrelatedfindingsproductarn
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> FindingProviderFieldsRelatedFindingsProductArn { get; set; }
            /// <summary>
            /// AwsAccountId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-awsaccountid
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> AwsAccountId { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-id
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> Id { get; set; }
            /// <summary>
            /// ProcessParentPid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-processparentpid
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: NumberFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.NumberFilter> ProcessParentPid { get; set; }
            /// <summary>
            /// ResourceApplicationName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-resourceapplicationname
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> ResourceApplicationName { get; set; }
            /// <summary>
            /// ProductArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-productarn
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> ProductArn { get; set; }
            /// <summary>
            /// ResourceAwsEc2InstanceIpV6Addresses
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-resourceawsec2instanceipv6addresses
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: IpFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.IpFilter> ResourceAwsEc2InstanceIpV6Addresses { get; set; }
            /// <summary>
            /// MalwareName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-malwarename
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> MalwareName { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-description
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> Description { get; set; }
            /// <summary>
            /// ResourceContainerLaunchedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-resourcecontainerlaunchedat
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DateFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.DateFilter> ResourceContainerLaunchedAt { get; set; }
            /// <summary>
            /// ProcessPid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-processpid
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: NumberFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.NumberFilter> ProcessPid { get; set; }
            /// <summary>
            /// NoteText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-notetext
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> NoteText { get; set; }
            /// <summary>
            /// ResourceAwsEc2InstanceKeyName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-resourceawsec2instancekeyname
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> ResourceAwsEc2InstanceKeyName { get; set; }
            /// <summary>
            /// FindingProviderFieldsTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-findingproviderfieldstypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> FindingProviderFieldsTypes { get; set; }
            /// <summary>
            /// ComplianceSecurityControlId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-compliancesecuritycontrolid
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> ComplianceSecurityControlId { get; set; }
            /// <summary>
            /// NoteUpdatedBy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-noteupdatedby
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> NoteUpdatedBy { get; set; }
            /// <summary>
            /// VerificationState
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-verificationstate
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> VerificationState { get; set; }
            /// <summary>
            /// GeneratorId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-generatorid
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> GeneratorId { get; set; }
            /// <summary>
            /// ResourceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-resourcetype
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> ResourceType { get; set; }
            /// <summary>
            /// NetworkProtocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-networkprotocol
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> NetworkProtocol { get; set; }
            /// <summary>
            /// UpdatedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-updatedat
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DateFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.DateFilter> UpdatedAt { get; set; }
            /// <summary>
            /// ProcessPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-processpath
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> ProcessPath { get; set; }
            /// <summary>
            /// WorkflowStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-workflowstatus
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> WorkflowStatus { get; set; }
            /// <summary>
            /// ResourceContainerName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-resourcecontainername
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> ResourceContainerName { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-type
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> Type { get; set; }
            /// <summary>
            /// ResourceId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-resourceid
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> ResourceId { get; set; }
            /// <summary>
            /// NetworkDestinationDomain
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-networkdestinationdomain
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> NetworkDestinationDomain { get; set; }
            /// <summary>
            /// ProductName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-productname
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> ProductName { get; set; }
            /// <summary>
            /// ResourceTags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-resourcetags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MapFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.MapFilter> ResourceTags { get; set; }
            /// <summary>
            /// ResourceAwsEc2InstanceVpcId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-resourceawsec2instancevpcid
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> ResourceAwsEc2InstanceVpcId { get; set; }
            /// <summary>
            /// ResourceAwsS3BucketOwnerName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-resourceawss3bucketownername
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> ResourceAwsS3BucketOwnerName { get; set; }
            /// <summary>
            /// LastObservedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-lastobservedat
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DateFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.DateFilter> LastObservedAt { get; set; }
            /// <summary>
            /// ComplianceSecurityControlParametersName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-compliancesecuritycontrolparametersname
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> ComplianceSecurityControlParametersName { get; set; }
            /// <summary>
            /// NetworkSourceIpV4
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-networksourceipv4
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: IpFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.IpFilter> NetworkSourceIpV4 { get; set; }
            /// <summary>
            /// ProcessLaunchedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-processlaunchedat
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DateFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.DateFilter> ProcessLaunchedAt { get; set; }
            /// <summary>
            /// ResourceAwsEc2InstanceLaunchedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-resourceawsec2instancelaunchedat
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DateFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.DateFilter> ResourceAwsEc2InstanceLaunchedAt { get; set; }
            /// <summary>
            /// NoteUpdatedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-noteupdatedat
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DateFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.DateFilter> NoteUpdatedAt { get; set; }
            /// <summary>
            /// ThreatIntelIndicatorType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-threatintelindicatortype
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> ThreatIntelIndicatorType { get; set; }
            /// <summary>
            /// CompanyName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-companyname
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> CompanyName { get; set; }
            /// <summary>
            /// ResourceRegion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-resourceregion
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> ResourceRegion { get; set; }
            /// <summary>
            /// ResourceAwsIamAccessKeyStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-resourceawsiamaccesskeystatus
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> ResourceAwsIamAccessKeyStatus { get; set; }
            /// <summary>
            /// NetworkSourceIpV6
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-networksourceipv6
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: IpFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.IpFilter> NetworkSourceIpV6 { get; set; }
            /// <summary>
            /// Confidence
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-confidence
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: NumberFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.NumberFilter> Confidence { get; set; }
            /// <summary>
            /// ProductFields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-productfields
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MapFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.MapFilter> ProductFields { get; set; }
            /// <summary>
            /// ThreatIntelIndicatorLastObservedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-threatintelindicatorlastobservedat
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DateFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.DateFilter> ThreatIntelIndicatorLastObservedAt { get; set; }
            /// <summary>
            /// ResourceAwsEc2InstanceSubnetId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-resourceawsec2instancesubnetid
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> ResourceAwsEc2InstanceSubnetId { get; set; }
            /// <summary>
            /// ComplianceAssociatedStandardsId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-complianceassociatedstandardsid
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> ComplianceAssociatedStandardsId { get; set; }
            /// <summary>
            /// ResourceAwsEc2InstanceImageId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-resourceawsec2instanceimageid
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> ResourceAwsEc2InstanceImageId { get; set; }
            /// <summary>
            /// ResourceAwsEc2InstanceIpV4Addresses
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-resourceawsec2instanceipv4addresses
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: IpFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.IpFilter> ResourceAwsEc2InstanceIpV4Addresses { get; set; }
            /// <summary>
            /// RelatedFindingsId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-relatedfindingsid
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> RelatedFindingsId { get; set; }
            /// <summary>
            /// ProcessTerminatedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-processterminatedat
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DateFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.DateFilter> ProcessTerminatedAt { get; set; }
            /// <summary>
            /// ResourceContainerImageId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-resourcecontainerimageid
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> ResourceContainerImageId { get; set; }
            /// <summary>
            /// NetworkDestinationIpV4
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-networkdestinationipv4
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: IpFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.IpFilter> NetworkDestinationIpV4 { get; set; }
            /// <summary>
            /// Region
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-region
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> Region { get; set; }
            /// <summary>
            /// NetworkDestinationIpV6
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-networkdestinationipv6
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: IpFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.IpFilter> NetworkDestinationIpV6 { get; set; }
            /// <summary>
            /// VulnerabilitiesExploitAvailable
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-vulnerabilitiesexploitavailable
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> VulnerabilitiesExploitAvailable { get; set; }
            /// <summary>
            /// FindingProviderFieldsCriticality
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-findingproviderfieldscriticality
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: NumberFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.NumberFilter> FindingProviderFieldsCriticality { get; set; }
            /// <summary>
            /// NetworkDestinationPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-networkdestinationport
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: NumberFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.NumberFilter> NetworkDestinationPort { get; set; }
            /// <summary>
            /// ResourceDetailsOther
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-resourcedetailsother
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MapFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.MapFilter> ResourceDetailsOther { get; set; }
            /// <summary>
            /// FindingProviderFieldsSeverityLabel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-findingproviderfieldsseveritylabel
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> FindingProviderFieldsSeverityLabel { get; set; }
            /// <summary>
            /// ThreatIntelIndicatorSourceUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-threatintelindicatorsourceurl
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> ThreatIntelIndicatorSourceUrl { get; set; }
            /// <summary>
            /// FindingProviderFieldsSeverityOriginal
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-findingproviderfieldsseverityoriginal
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> FindingProviderFieldsSeverityOriginal { get; set; }
            /// <summary>
            /// MalwarePath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-malwarepath
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> MalwarePath { get; set; }
            /// <summary>
            /// Sample
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-sample
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: BooleanFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.BooleanFilter> Sample { get; set; }
            /// <summary>
            /// RecordState
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-recordstate
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> RecordState { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> Title { get; set; }
            /// <summary>
            /// WorkflowState
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-workflowstate
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> WorkflowState { get; set; }
            /// <summary>
            /// NetworkSourceMac
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-networksourcemac
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> NetworkSourceMac { get; set; }
            /// <summary>
            /// ResourceAwsS3BucketOwnerId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-resourceawss3bucketownerid
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> ResourceAwsS3BucketOwnerId { get; set; }
            /// <summary>
            /// VulnerabilitiesFixAvailable
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-awssecurityfindingfilters.html#cfn-securityhub-insight-awssecurityfindingfilters-vulnerabilitiesfixavailable
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.SecurityHub.InsightTypes.StringFilter> VulnerabilitiesFixAvailable { get; set; }
        }

        public class BooleanFilter : Humidifier.Base.BaseSubResource, IHaveValue
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-booleanfilter.html#cfn-securityhub-insight-booleanfilter-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Value { get; set; }
        }

        public class DateFilter : Humidifier.Base.BaseSubResource, IHaveEnd, IHaveStart
        {
            /// <summary>
            /// DateRange
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-datefilter.html#cfn-securityhub-insight-datefilter-daterange
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DateRange
            /// </summary>
            public Humidifier.SecurityHub.InsightTypes.DateRange DateRange { get; set; }
            /// <summary>
            /// Start
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-datefilter.html#cfn-securityhub-insight-datefilter-start
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Start { get; set; }
            /// <summary>
            /// End
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-datefilter.html#cfn-securityhub-insight-datefilter-end
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic End { get; set; }
        }

        public class DateRange : Humidifier.Base.BaseSubResource, IHaveValue, IHaveUnit
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-daterange.html#cfn-securityhub-insight-daterange-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Unit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-daterange.html#cfn-securityhub-insight-daterange-unit
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Unit { get; set; }
        }

        public class IpFilter : Humidifier.Base.BaseSubResource, IHaveCidr
        {
            /// <summary>
            /// Cidr
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-ipfilter.html#cfn-securityhub-insight-ipfilter-cidr
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Cidr { get; set; }
        }

        public class MapFilter : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey, IHaveComparison
        {
            /// <summary>
            /// Comparison
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-mapfilter.html#cfn-securityhub-insight-mapfilter-comparison
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Comparison { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-mapfilter.html#cfn-securityhub-insight-mapfilter-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-mapfilter.html#cfn-securityhub-insight-mapfilter-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }

        public class NumberFilter : Humidifier.Base.BaseSubResource, IHaveEq, IHaveGte, IHaveLte
        {
            /// <summary>
            /// Gte
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-numberfilter.html#cfn-securityhub-insight-numberfilter-gte
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Gte { get; set; }
            /// <summary>
            /// Eq
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-numberfilter.html#cfn-securityhub-insight-numberfilter-eq
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Eq { get; set; }
            /// <summary>
            /// Lte
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-numberfilter.html#cfn-securityhub-insight-numberfilter-lte
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Lte { get; set; }
        }

        public class StringFilter : Humidifier.Base.BaseSubResource, IHaveValue, IHaveComparison
        {
            /// <summary>
            /// Comparison
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-stringfilter.html#cfn-securityhub-insight-stringfilter-comparison
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Comparison { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-insight-stringfilter.html#cfn-securityhub-insight-stringfilter-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
        }
    }
}