namespace Humidifier.KendraRanking
{
    using global::System.Collections.Generic;
    using ExecutionPlanTypes;

    public class ExecutionPlan : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveKendraRankingExecutionPlanTypesCapacityUnitsConfigurationCapacityUnits, IHaveName
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.KendraRanking.ExecutionPlan; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kendraranking-executionplan.html#cfn-kendraranking-executionplan-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// CapacityUnits
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kendraranking-executionplan.html#cfn-kendraranking-executionplan-capacityunits
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CapacityUnitsConfiguration
        /// </summary>
        public Union<Humidifier.KendraRanking.ExecutionPlanTypes.CapacityUnitsConfiguration, BaseFunction>? CapacityUnits { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kendraranking-executionplan.html#cfn-kendraranking-executionplan-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace ExecutionPlanTypes
    {
        public class CapacityUnitsConfiguration : Humidifier.Base.BaseSubResource, IHaveRescoreCapacityUnits_Integer
        {
            /// <summary>
            /// RescoreCapacityUnits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendraranking-executionplan-capacityunitsconfiguration.html#cfn-kendraranking-executionplan-capacityunitsconfiguration-rescorecapacityunits
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? RescoreCapacityUnits { get; set; }
        }
    }
}