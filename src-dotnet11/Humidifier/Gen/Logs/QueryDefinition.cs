namespace Humidifier.Logs
{
    using global::System.Collections.Generic;
    using QueryDefinitionTypes;

    public class QueryDefinition : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveListOfLogsQueryDefinitionTypesQueryParameterParameters, IHaveQueryString, IHaveStringListOfLogGroupNames, IHaveQueryLanguage, IHaveName
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
        public Union<IReadOnlyList<Humidifier.Logs.QueryDefinitionTypes.QueryParameter>, IReadOnlyList<Union<Humidifier.Logs.QueryDefinitionTypes.QueryParameter, BaseFunction>>, BaseFunction>? Parameters { get; set; }

        /// <summary>
        /// QueryString
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-querydefinition.html#cfn-logs-querydefinition-querystring
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? QueryString { get; set; }
        /// <summary>
        /// LogGroupNames
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-querydefinition.html#cfn-logs-querydefinition-loggroupnames
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? LogGroupNames { get; set; }
        /// <summary>
        /// QueryLanguage
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-querydefinition.html#cfn-logs-querydefinition-querylanguage
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? QueryLanguage { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace QueryDefinitionTypes
    {
        public class QueryParameter : Humidifier.Base.BaseSubResource, IHaveDefaultValue, IHaveDescription, IHaveName
        {
            /// <summary>
            /// DefaultValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-querydefinition-queryparameter.html#cfn-logs-querydefinition-queryparameter-defaultvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DefaultValue { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-querydefinition-queryparameter.html#cfn-logs-querydefinition-queryparameter-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-querydefinition-queryparameter.html#cfn-logs-querydefinition-queryparameter-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }
    }
}