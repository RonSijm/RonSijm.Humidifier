namespace Humidifier.Logs
{
    using System.Collections.Generic;

    public class QueryDefinition : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveQueryString
    {
        public class Attributes
        {
            public static string QueryDefinitionId =  "QueryDefinitionId" ;
        }

        public override string AWSTypeName { get => AWS.Logs.QueryDefinition; }

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
}