namespace Humidifier.CustomerProfiles
{
    using global::System.Collections.Generic;
    using DomainTypes;

    public class Domain : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveCustomerProfilesDomainTypesMatchingMatching, IHaveDefaultExpirationDays_Integer, IHaveDomainName, IHaveDeadLetterQueueUrl, IHaveCustomerProfilesDomainTypesDataStoreDataStore, IHaveDefaultEncryptionKey, IHaveCustomerProfilesDomainTypesRuleBasedMatchingRuleBasedMatching
    {
        public class Attributes
        {
            public static string LastUpdatedAt =  "LastUpdatedAt" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Stats =  "Stats" ;
        }

        public override string AWSTypeName { get => AWS.CustomerProfiles.Domain; }
        /// <summary>
        /// Matching
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-domain.html#cfn-customerprofiles-domain-matching
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Matching
        /// </summary>
        public Union<Humidifier.CustomerProfiles.DomainTypes.Matching, BaseFunction>? Matching { get; set; }

        /// <summary>
        /// DefaultExpirationDays
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-domain.html#cfn-customerprofiles-domain-defaultexpirationdays
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public Union<int, BaseFunction>? DefaultExpirationDays { get; set; }
        public Union<string, BaseFunction>? DomainName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// DeadLetterQueueUrl
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-domain.html#cfn-customerprofiles-domain-deadletterqueueurl
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DeadLetterQueueUrl { get; set; }
        /// <summary>
        /// DataStore
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-domain.html#cfn-customerprofiles-domain-datastore
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DataStore
        /// </summary>
        public Union<Humidifier.CustomerProfiles.DomainTypes.DataStore, BaseFunction>? DataStore { get; set; }
        /// <summary>
        /// DefaultEncryptionKey
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-domain.html#cfn-customerprofiles-domain-defaultencryptionkey
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DefaultEncryptionKey { get; set; }
        /// <summary>
        /// RuleBasedMatching
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-domain.html#cfn-customerprofiles-domain-rulebasedmatching
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RuleBasedMatching
        /// </summary>
        public Union<Humidifier.CustomerProfiles.DomainTypes.RuleBasedMatching, BaseFunction>? RuleBasedMatching { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-domain.html#cfn-customerprofiles-domain-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace DomainTypes
    {
        public class AttributeTypesSelector : Humidifier.Base.BaseSubResource, IHaveStringListOfAddress, IHaveAttributeMatchingModel, IHaveStringListOfPhoneNumber, IHaveStringListOfEmailAddress
        {
            /// <summary>
            /// Address
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-attributetypesselector.html#cfn-customerprofiles-domain-attributetypesselector-address
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Address { get; set; }
            /// <summary>
            /// AttributeMatchingModel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-attributetypesselector.html#cfn-customerprofiles-domain-attributetypesselector-attributematchingmodel
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AttributeMatchingModel { get; set; }
            /// <summary>
            /// PhoneNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-attributetypesselector.html#cfn-customerprofiles-domain-attributetypesselector-phonenumber
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? PhoneNumber { get; set; }
            /// <summary>
            /// EmailAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-attributetypesselector.html#cfn-customerprofiles-domain-attributetypesselector-emailaddress
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? EmailAddress { get; set; }
        }

        public class AutoMerging : Humidifier.Base.BaseSubResource, IHaveCustomerProfilesDomainTypesConsolidationConsolidation, IHaveEnabled_Boolean, IHaveCustomerProfilesDomainTypesConflictResolutionConflictResolution, IHaveMinAllowedConfidenceScoreForMerging_Double
        {
            /// <summary>
            /// Consolidation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-automerging.html#cfn-customerprofiles-domain-automerging-consolidation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Consolidation
            /// </summary>
            public Union<Humidifier.CustomerProfiles.DomainTypes.Consolidation, BaseFunction>? Consolidation { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-automerging.html#cfn-customerprofiles-domain-automerging-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
            /// <summary>
            /// ConflictResolution
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-automerging.html#cfn-customerprofiles-domain-automerging-conflictresolution
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConflictResolution
            /// </summary>
            public Union<Humidifier.CustomerProfiles.DomainTypes.ConflictResolution, BaseFunction>? ConflictResolution { get; set; }
            /// <summary>
            /// MinAllowedConfidenceScoreForMerging
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-automerging.html#cfn-customerprofiles-domain-automerging-minallowedconfidencescoreformerging
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? MinAllowedConfidenceScoreForMerging { get; set; }
        }

        public class ConflictResolution : Humidifier.Base.BaseSubResource, IHaveConflictResolvingModel, IHaveSourceName
        {
            /// <summary>
            /// ConflictResolvingModel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-conflictresolution.html#cfn-customerprofiles-domain-conflictresolution-conflictresolvingmodel
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConflictResolvingModel { get; set; }
            /// <summary>
            /// SourceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-conflictresolution.html#cfn-customerprofiles-domain-conflictresolution-sourcename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceName { get; set; }
        }

        public class Consolidation : Humidifier.Base.BaseSubResource, IHaveMatchingAttributesList_Json
        {
            /// <summary>
            /// MatchingAttributesList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-consolidation.html#cfn-customerprofiles-domain-consolidation-matchingattributeslist
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? MatchingAttributesList { get; set; }
        }

        public class DataStore : Humidifier.Base.BaseSubResource, IHaveCustomerProfilesDomainTypesReadinessReadiness, IHaveEnabled_Boolean
        {
            /// <summary>
            /// Readiness
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-datastore.html#cfn-customerprofiles-domain-datastore-readiness
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Readiness
            /// </summary>
            public Union<Humidifier.CustomerProfiles.DomainTypes.Readiness, BaseFunction>? Readiness { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-datastore.html#cfn-customerprofiles-domain-datastore-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class DomainStats : Humidifier.Base.BaseSubResource, IHaveMeteringProfileCount_Double, IHaveProfileCount_Double, IHaveObjectCount_Double, IHaveTotalSize_Double
        {
            /// <summary>
            /// MeteringProfileCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-domainstats.html#cfn-customerprofiles-domain-domainstats-meteringprofilecount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? MeteringProfileCount { get; set; }
            /// <summary>
            /// ProfileCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-domainstats.html#cfn-customerprofiles-domain-domainstats-profilecount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? ProfileCount { get; set; }
            /// <summary>
            /// ObjectCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-domainstats.html#cfn-customerprofiles-domain-domainstats-objectcount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? ObjectCount { get; set; }
            /// <summary>
            /// TotalSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-domainstats.html#cfn-customerprofiles-domain-domainstats-totalsize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? TotalSize { get; set; }
        }

        public class ExportingConfig : Humidifier.Base.BaseSubResource, IHaveCustomerProfilesDomainTypesS3ExportingConfigS3Exporting
        {
            /// <summary>
            /// S3Exporting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-exportingconfig.html#cfn-customerprofiles-domain-exportingconfig-s3exporting
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3ExportingConfig
            /// </summary>
            public Union<Humidifier.CustomerProfiles.DomainTypes.S3ExportingConfig, BaseFunction>? S3Exporting { get; set; }
        }

        public class JobSchedule : Humidifier.Base.BaseSubResource, IHaveDayOfTheWeek, IHaveTime
        {
            /// <summary>
            /// DayOfTheWeek
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-jobschedule.html#cfn-customerprofiles-domain-jobschedule-dayoftheweek
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DayOfTheWeek { get; set; }
            /// <summary>
            /// Time
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-jobschedule.html#cfn-customerprofiles-domain-jobschedule-time
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Time { get; set; }
        }

        public class Matching : Humidifier.Base.BaseSubResource, IHaveCustomerProfilesDomainTypesAutoMergingAutoMerging, IHaveCustomerProfilesDomainTypesJobScheduleJobSchedule, IHaveEnabled_Boolean, IHaveCustomerProfilesDomainTypesExportingConfigExportingConfig
        {
            /// <summary>
            /// AutoMerging
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-matching.html#cfn-customerprofiles-domain-matching-automerging
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AutoMerging
            /// </summary>
            public Union<Humidifier.CustomerProfiles.DomainTypes.AutoMerging, BaseFunction>? AutoMerging { get; set; }
            /// <summary>
            /// JobSchedule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-matching.html#cfn-customerprofiles-domain-matching-jobschedule
            /// Required: False
            /// UpdateType: Mutable
            /// Type: JobSchedule
            /// </summary>
            public Union<Humidifier.CustomerProfiles.DomainTypes.JobSchedule, BaseFunction>? JobSchedule { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-matching.html#cfn-customerprofiles-domain-matching-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
            /// <summary>
            /// ExportingConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-matching.html#cfn-customerprofiles-domain-matching-exportingconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ExportingConfig
            /// </summary>
            public Union<Humidifier.CustomerProfiles.DomainTypes.ExportingConfig, BaseFunction>? ExportingConfig { get; set; }
        }

        public class MatchingRule : Humidifier.Base.BaseSubResource, IHaveStringListOfRule
        {
            /// <summary>
            /// Rule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-matchingrule.html#cfn-customerprofiles-domain-matchingrule-rule
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Rule { get; set; }
        }

        public class Readiness : Humidifier.Base.BaseSubResource, IHaveMessage, IHaveProgressPercentage_Integer
        {
            /// <summary>
            /// Message
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-readiness.html#cfn-customerprofiles-domain-readiness-message
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Message { get; set; }
            /// <summary>
            /// ProgressPercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-readiness.html#cfn-customerprofiles-domain-readiness-progresspercentage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ProgressPercentage { get; set; }
        }

        public class RuleBasedMatching : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveMaxAllowedRuleLevelForMerging_Integer, IHaveEnabled_Boolean, IHaveListOfCustomerProfilesDomainTypesMatchingRuleMatchingRules, IHaveCustomerProfilesDomainTypesAttributeTypesSelectorAttributeTypesSelector, IHaveCustomerProfilesDomainTypesConflictResolutionConflictResolution, IHaveCustomerProfilesDomainTypesExportingConfigExportingConfig, IHaveMaxAllowedRuleLevelForMatching_Integer
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-rulebasedmatching.html#cfn-customerprofiles-domain-rulebasedmatching-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// MaxAllowedRuleLevelForMerging
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-rulebasedmatching.html#cfn-customerprofiles-domain-rulebasedmatching-maxallowedrulelevelformerging
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxAllowedRuleLevelForMerging { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-rulebasedmatching.html#cfn-customerprofiles-domain-rulebasedmatching-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
            /// <summary>
            /// MatchingRules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-rulebasedmatching.html#cfn-customerprofiles-domain-rulebasedmatching-matchingrules
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MatchingRule
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CustomerProfiles.DomainTypes.MatchingRule>, IReadOnlyList<Union<Humidifier.CustomerProfiles.DomainTypes.MatchingRule, BaseFunction>>, BaseFunction>? MatchingRules { get; set; }
            /// <summary>
            /// AttributeTypesSelector
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-rulebasedmatching.html#cfn-customerprofiles-domain-rulebasedmatching-attributetypesselector
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AttributeTypesSelector
            /// </summary>
            public Union<Humidifier.CustomerProfiles.DomainTypes.AttributeTypesSelector, BaseFunction>? AttributeTypesSelector { get; set; }
            /// <summary>
            /// ConflictResolution
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-rulebasedmatching.html#cfn-customerprofiles-domain-rulebasedmatching-conflictresolution
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConflictResolution
            /// </summary>
            public Union<Humidifier.CustomerProfiles.DomainTypes.ConflictResolution, BaseFunction>? ConflictResolution { get; set; }
            /// <summary>
            /// ExportingConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-rulebasedmatching.html#cfn-customerprofiles-domain-rulebasedmatching-exportingconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ExportingConfig
            /// </summary>
            public Union<Humidifier.CustomerProfiles.DomainTypes.ExportingConfig, BaseFunction>? ExportingConfig { get; set; }
            /// <summary>
            /// MaxAllowedRuleLevelForMatching
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-rulebasedmatching.html#cfn-customerprofiles-domain-rulebasedmatching-maxallowedrulelevelformatching
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxAllowedRuleLevelForMatching { get; set; }
        }

        public class S3ExportingConfig : Humidifier.Base.BaseSubResource, IHaveS3BucketName, IHaveS3KeyName
        {
            /// <summary>
            /// S3BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-s3exportingconfig.html#cfn-customerprofiles-domain-s3exportingconfig-s3bucketname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3BucketName { get; set; }
            /// <summary>
            /// S3KeyName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domain-s3exportingconfig.html#cfn-customerprofiles-domain-s3exportingconfig-s3keyname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3KeyName { get; set; }
        }
    }
}