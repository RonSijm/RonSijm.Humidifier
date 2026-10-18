namespace Humidifier.WellArchitected
{
    using global::System.Collections.Generic;
    using AgentProfileTypes;

    public class AgentProfile : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveExecutionRoleArn, IHaveDescription, IHaveListOfWellArchitectedAgentProfileTypesAggregationConfigurationAggregationConfiguration, IHaveDisplayName, IHaveBusinessOverview, IHaveStringListOfPillars, IHaveDeletionProtection_Boolean, IHaveName
    {
        public class Attributes
        {
            public static string LastModifiedBy =  "LastModifiedBy" ;
            public static string CreatedBy =  "CreatedBy" ;
            public static string LastModifiedAt =  "LastModifiedAt" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.WellArchitected.AgentProfile; }

        /// <summary>
        /// ExecutionRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wellarchitected-agentprofile.html#cfn-wellarchitected-agentprofile-executionrolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ExecutionRoleArn { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wellarchitected-agentprofile.html#cfn-wellarchitected-agentprofile-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// AggregationConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wellarchitected-agentprofile.html#cfn-wellarchitected-agentprofile-aggregationconfiguration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AggregationConfiguration
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.WellArchitected.AgentProfileTypes.AggregationConfiguration>, IReadOnlyList<Union<Humidifier.WellArchitected.AgentProfileTypes.AggregationConfiguration, BaseFunction>>, BaseFunction>? AggregationConfiguration { get; set; }
        /// <summary>
        /// DisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wellarchitected-agentprofile.html#cfn-wellarchitected-agentprofile-displayname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DisplayName { get; set; }
        /// <summary>
        /// BusinessOverview
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wellarchitected-agentprofile.html#cfn-wellarchitected-agentprofile-businessoverview
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? BusinessOverview { get; set; }

        /// <summary>
        /// Pillars
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wellarchitected-agentprofile.html#cfn-wellarchitected-agentprofile-pillars
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Pillars { get; set; }
        /// <summary>
        /// DeletionProtection
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wellarchitected-agentprofile.html#cfn-wellarchitected-agentprofile-deletionprotection
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? DeletionProtection { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wellarchitected-agentprofile.html#cfn-wellarchitected-agentprofile-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace AgentProfileTypes
    {
        public class AggregationConfiguration : Humidifier.Base.BaseSubResource, IHaveAccessRoleArn, IHaveAccountId, IHaveStringListOfRegions
        {
            /// <summary>
            /// AccessRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wellarchitected-agentprofile-aggregationconfiguration.html#cfn-wellarchitected-agentprofile-aggregationconfiguration-accessrolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccessRoleArn { get; set; }
            /// <summary>
            /// AccountId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wellarchitected-agentprofile-aggregationconfiguration.html#cfn-wellarchitected-agentprofile-aggregationconfiguration-accountid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccountId { get; set; }
            /// <summary>
            /// Regions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wellarchitected-agentprofile-aggregationconfiguration.html#cfn-wellarchitected-agentprofile-aggregationconfiguration-regions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Regions { get; set; }
        }
    }
}