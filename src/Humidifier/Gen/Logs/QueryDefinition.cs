namespace Humidifier.Logs
{
    using global::System.Collections.Generic;
    using QueryDefinitionTypes;

    public class QueryDefinition : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveQueryString
    {
        public class Attributes
        {
            public static string QueryDefinitionId =  "QueryDefinitionId" ;
        }

        public override string AWSTypeName { get => AWS.Logs.QueryDefinition; }
        /// <summary>
        /// Parameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-querydefinition.html#cfn-logs-querydefinition-parameters
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: QueryParameter
        /// </summary>
        public List<Humidifier.Logs.QueryDefinitionTypes.QueryParameter> Parameters { get; set; }

        /// <summary>
        /// QueryString
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-querydefinition.html#cfn-logs-querydefinition-querystring
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic QueryString { get; set; }
        /// <summary>
        /// LogGroupNames
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-querydefinition.html#cfn-logs-querydefinition-loggroupnames
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic LogGroupNames { get; set; }
        /// <summary>
        /// QueryLanguage
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-querydefinition.html#cfn-logs-querydefinition-querylanguage
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic QueryLanguage { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace QueryDefinitionTypes
    {
        public class QueryParameter : Humidifier.Base.BaseSubResource, IHaveName, IHaveDescription, IHaveDefaultValue
        {
            /// <summary>
            /// DefaultValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-querydefinition-queryparameter.html#cfn-logs-querydefinition-queryparameter-defaultvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DefaultValue { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-querydefinition-queryparameter.html#cfn-logs-querydefinition-queryparameter-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-querydefinition-queryparameter.html#cfn-logs-querydefinition-queryparameter-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }
    }
}