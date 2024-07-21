namespace Humidifier.CustomerProfiles
{
    using System.Collections.Generic;
    using DomainTypes;

    public class Domain : Humidifier.Resource, IHaveTags
    {
        public class Attributes
        {
            public static string LastUpdatedAt =  "LastUpdatedAt" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Stats =  "Stats" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::CustomerProfiles::Domain";
            }
        }

        /// <summary>
        /// Matching
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-domain.html#cfn-customerprofiles-domain-matching
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Matching
        /// </summary>
        public Matching Matching { get; set; }
        /// <summary>
        /// DefaultExpirationDays
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-domain.html#cfn-customerprofiles-domain-defaultexpirationdays
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic DefaultExpirationDays { get; set; }
        /// <summary>
        /// DomainName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-domain.html#cfn-customerprofiles-domain-domainname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DomainName { get; set; }
        /// <summary>
        /// DeadLetterQueueUrl
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-domain.html#cfn-customerprofiles-domain-deadletterqueueurl
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DeadLetterQueueUrl { get; set; }
        /// <summary>
        /// DefaultEncryptionKey
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-domain.html#cfn-customerprofiles-domain-defaultencryptionkey
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DefaultEncryptionKey { get; set; }
        /// <summary>
        /// RuleBasedMatching
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-domain.html#cfn-customerprofiles-domain-rulebasedmatching
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RuleBasedMatching
        /// </summary>
        public RuleBasedMatching RuleBasedMatching { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-domain.html#cfn-customerprofiles-domain-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace DomainTypes
    {
        public class AttributeTypesSelector
        {
            /// <summary>
            /// Address
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-attributetypesselector.html#cfn-customerprofiles-domain-attributetypesselector-address
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Address { get; set; }
            /// <summary>
            /// AttributeMatchingModel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-attributetypesselector.html#cfn-customerprofiles-domain-attributetypesselector-attributematchingmodel
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AttributeMatchingModel { get; set; }
            /// <summary>
            /// PhoneNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-attributetypesselector.html#cfn-customerprofiles-domain-attributetypesselector-phonenumber
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic PhoneNumber { get; set; }
            /// <summary>
            /// EmailAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-attributetypesselector.html#cfn-customerprofiles-domain-attributetypesselector-emailaddress
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic EmailAddress { get; set; }
        }

        public class AutoMerging
        {
            /// <summary>
            /// Consolidation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-automerging.html#cfn-customerprofiles-domain-automerging-consolidation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Consolidation
            /// </summary>
            public Consolidation Consolidation { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-automerging.html#cfn-customerprofiles-domain-automerging-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
            /// <summary>
            /// ConflictResolution
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-automerging.html#cfn-customerprofiles-domain-automerging-conflictresolution
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConflictResolution
            /// </summary>
            public ConflictResolution ConflictResolution { get; set; }
            /// <summary>
            /// MinAllowedConfidenceScoreForMerging
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-automerging.html#cfn-customerprofiles-domain-automerging-minallowedconfidencescoreformerging
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MinAllowedConfidenceScoreForMerging { get; set; }
        }

        public class ConflictResolution
        {
            /// <summary>
            /// ConflictResolvingModel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-conflictresolution.html#cfn-customerprofiles-domain-conflictresolution-conflictresolvingmodel
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ConflictResolvingModel { get; set; }
            /// <summary>
            /// SourceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-conflictresolution.html#cfn-customerprofiles-domain-conflictresolution-sourcename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceName { get; set; }
        }

        public class Consolidation
        {
            /// <summary>
            /// MatchingAttributesList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-consolidation.html#cfn-customerprofiles-domain-consolidation-matchingattributeslist
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic MatchingAttributesList { get; set; }
        }

        public class DomainStats
        {
            /// <summary>
            /// MeteringProfileCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-domainstats.html#cfn-customerprofiles-domain-domainstats-meteringprofilecount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MeteringProfileCount { get; set; }
            /// <summary>
            /// ProfileCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-domainstats.html#cfn-customerprofiles-domain-domainstats-profilecount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic ProfileCount { get; set; }
            /// <summary>
            /// ObjectCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-domainstats.html#cfn-customerprofiles-domain-domainstats-objectcount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic ObjectCount { get; set; }
            /// <summary>
            /// TotalSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-domainstats.html#cfn-customerprofiles-domain-domainstats-totalsize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic TotalSize { get; set; }
        }

        public class ExportingConfig
        {
            /// <summary>
            /// S3Exporting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-exportingconfig.html#cfn-customerprofiles-domain-exportingconfig-s3exporting
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3ExportingConfig
            /// </summary>
            public S3ExportingConfig S3Exporting { get; set; }
        }

        public class JobSchedule
        {
            /// <summary>
            /// DayOfTheWeek
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-jobschedule.html#cfn-customerprofiles-domain-jobschedule-dayoftheweek
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DayOfTheWeek { get; set; }
            /// <summary>
            /// Time
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-jobschedule.html#cfn-customerprofiles-domain-jobschedule-time
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Time { get; set; }
        }

        public class Matching
        {
            /// <summary>
            /// AutoMerging
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-matching.html#cfn-customerprofiles-domain-matching-automerging
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AutoMerging
            /// </summary>
            public AutoMerging AutoMerging { get; set; }
            /// <summary>
            /// JobSchedule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-matching.html#cfn-customerprofiles-domain-matching-jobschedule
            /// Required: False
            /// UpdateType: Mutable
            /// Type: JobSchedule
            /// </summary>
            public JobSchedule JobSchedule { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-matching.html#cfn-customerprofiles-domain-matching-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
            /// <summary>
            /// ExportingConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-matching.html#cfn-customerprofiles-domain-matching-exportingconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ExportingConfig
            /// </summary>
            public ExportingConfig ExportingConfig { get; set; }
        }

        public class MatchingRule
        {
            /// <summary>
            /// Rule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-matchingrule.html#cfn-customerprofiles-domain-matchingrule-rule
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Rule { get; set; }
        }

        public class RuleBasedMatching
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-rulebasedmatching.html#cfn-customerprofiles-domain-rulebasedmatching-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// MaxAllowedRuleLevelForMerging
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-rulebasedmatching.html#cfn-customerprofiles-domain-rulebasedmatching-maxallowedrulelevelformerging
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxAllowedRuleLevelForMerging { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-rulebasedmatching.html#cfn-customerprofiles-domain-rulebasedmatching-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
            /// <summary>
            /// MatchingRules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-rulebasedmatching.html#cfn-customerprofiles-domain-rulebasedmatching-matchingrules
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MatchingRule
            /// </summary>
            public List<MatchingRule> MatchingRules { get; set; }
            /// <summary>
            /// AttributeTypesSelector
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-rulebasedmatching.html#cfn-customerprofiles-domain-rulebasedmatching-attributetypesselector
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AttributeTypesSelector
            /// </summary>
            public AttributeTypesSelector AttributeTypesSelector { get; set; }
            /// <summary>
            /// ConflictResolution
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-rulebasedmatching.html#cfn-customerprofiles-domain-rulebasedmatching-conflictresolution
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConflictResolution
            /// </summary>
            public ConflictResolution ConflictResolution { get; set; }
            /// <summary>
            /// ExportingConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-rulebasedmatching.html#cfn-customerprofiles-domain-rulebasedmatching-exportingconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ExportingConfig
            /// </summary>
            public ExportingConfig ExportingConfig { get; set; }
            /// <summary>
            /// MaxAllowedRuleLevelForMatching
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-rulebasedmatching.html#cfn-customerprofiles-domain-rulebasedmatching-maxallowedrulelevelformatching
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxAllowedRuleLevelForMatching { get; set; }
        }

        public class S3ExportingConfig
        {
            /// <summary>
            /// S3BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-s3exportingconfig.html#cfn-customerprofiles-domain-s3exportingconfig-s3bucketname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3BucketName { get; set; }
            /// <summary>
            /// S3KeyName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-s3exportingconfig.html#cfn-customerprofiles-domain-s3exportingconfig-s3keyname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3KeyName { get; set; }
        }
    }
}