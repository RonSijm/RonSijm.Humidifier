namespace Humidifier.ApplicationSignals
{
    using global::System.Collections.Generic;
    using GroupingConfigurationTypes;

    public class GroupingConfiguration : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string AccountId =  "AccountId" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.ApplicationSignals.GroupingConfiguration; }

        /// <summary>
        /// GroupingAttributeDefinitions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationsignals-groupingconfiguration.html#cfn-applicationsignals-groupingconfiguration-groupingattributedefinitions
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: GroupingAttributeDefinition
        /// </summary>
        [Required]
        public List<Humidifier.ApplicationSignals.GroupingConfigurationTypes.GroupingAttributeDefinition> GroupingAttributeDefinitions { get; set; }
    }

    namespace GroupingConfigurationTypes
    {
        public class GroupingAttributeDefinition : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// GroupingName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-groupingconfiguration-groupingattributedefinition.html#cfn-applicationsignals-groupingconfiguration-groupingattributedefinition-groupingname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GroupingName { get; set; }
            /// <summary>
            /// GroupingSourceKeys
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-groupingconfiguration-groupingattributedefinition.html#cfn-applicationsignals-groupingconfiguration-groupingattributedefinition-groupingsourcekeys
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic GroupingSourceKeys { get; set; }
            /// <summary>
            /// DefaultGroupingValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-groupingconfiguration-groupingattributedefinition.html#cfn-applicationsignals-groupingconfiguration-groupingattributedefinition-defaultgroupingvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DefaultGroupingValue { get; set; }
        }
    }
}