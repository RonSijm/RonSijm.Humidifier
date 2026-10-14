namespace Humidifier.QBusiness
{
    using global::System.Collections.Generic;
    using DataAccessorTypes;

    public class DataAccessor : Humidifier.Base.BaseResource, IHaveTags, IHaveDisplayName, IHaveApplicationId, IHavePrincipal
    {
        public class Attributes
        {
            public static string IdcApplicationArn =  "IdcApplicationArn" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string DataAccessorArn =  "DataAccessorArn" ;
            public static string UpdatedAt =  "UpdatedAt" ;
            public static string DataAccessorId =  "DataAccessorId" ;
        }

        public override string AWSTypeName { get => AWS.QBusiness.DataAccessor; }

        /// <summary>
        /// DisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-dataaccessor.html#cfn-qbusiness-dataaccessor-displayname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DisplayName { get; set; }

        /// <summary>
        /// ActionConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-dataaccessor.html#cfn-qbusiness-dataaccessor-actionconfigurations
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ActionConfiguration
        /// </summary>
        [Required]
        public List<Humidifier.QBusiness.DataAccessorTypes.ActionConfiguration> ActionConfigurations { get; set; }

        /// <summary>
        /// ApplicationId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-dataaccessor.html#cfn-qbusiness-dataaccessor-applicationid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ApplicationId { get; set; }

        /// <summary>
        /// Principal
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-dataaccessor.html#cfn-qbusiness-dataaccessor-principal
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Principal { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-dataaccessor.html#cfn-qbusiness-dataaccessor-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        /// <summary>
        /// AuthenticationDetail
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-dataaccessor.html#cfn-qbusiness-dataaccessor-authenticationdetail
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DataAccessorAuthenticationDetail
        /// </summary>
        public Humidifier.QBusiness.DataAccessorTypes.DataAccessorAuthenticationDetail AuthenticationDetail { get; set; }
    }

    namespace DataAccessorTypes
    {
        public class ActionConfiguration : Humidifier.Base.BaseSubResource, IHaveAction
        {
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-dataaccessor-actionconfiguration.html#cfn-qbusiness-dataaccessor-actionconfiguration-action
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Action { get; set; }
            /// <summary>
            /// FilterConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-dataaccessor-actionconfiguration.html#cfn-qbusiness-dataaccessor-actionconfiguration-filterconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ActionFilterConfiguration
            /// </summary>
            public Humidifier.QBusiness.DataAccessorTypes.ActionFilterConfiguration FilterConfiguration { get; set; }
        }

        public class ActionFilterConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DocumentAttributeFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-dataaccessor-actionfilterconfiguration.html#cfn-qbusiness-dataaccessor-actionfilterconfiguration-documentattributefilter
            /// Required: True
            /// UpdateType: Mutable
            /// Type: AttributeFilter
            /// </summary>
            public Humidifier.QBusiness.DataAccessorTypes.AttributeFilter DocumentAttributeFilter { get; set; }
        }

        public class AttributeFilter : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ContainsAny
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-dataaccessor-attributefilter.html#cfn-qbusiness-dataaccessor-attributefilter-containsany
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DocumentAttribute
            /// </summary>
            public Humidifier.QBusiness.DataAccessorTypes.DocumentAttribute ContainsAny { get; set; }
            /// <summary>
            /// LessThan
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-dataaccessor-attributefilter.html#cfn-qbusiness-dataaccessor-attributefilter-lessthan
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DocumentAttribute
            /// </summary>
            public Humidifier.QBusiness.DataAccessorTypes.DocumentAttribute LessThan { get; set; }
            /// <summary>
            /// GreaterThan
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-dataaccessor-attributefilter.html#cfn-qbusiness-dataaccessor-attributefilter-greaterthan
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DocumentAttribute
            /// </summary>
            public Humidifier.QBusiness.DataAccessorTypes.DocumentAttribute GreaterThan { get; set; }
            /// <summary>
            /// NotFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-dataaccessor-attributefilter.html#cfn-qbusiness-dataaccessor-attributefilter-notfilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AttributeFilter
            /// </summary>
            public Humidifier.QBusiness.DataAccessorTypes.AttributeFilter NotFilter { get; set; }
            /// <summary>
            /// LessThanOrEquals
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-dataaccessor-attributefilter.html#cfn-qbusiness-dataaccessor-attributefilter-lessthanorequals
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DocumentAttribute
            /// </summary>
            public Humidifier.QBusiness.DataAccessorTypes.DocumentAttribute LessThanOrEquals { get; set; }
            /// <summary>
            /// OrAllFilters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-dataaccessor-attributefilter.html#cfn-qbusiness-dataaccessor-attributefilter-orallfilters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AttributeFilter
            /// </summary>
            public List<Humidifier.QBusiness.DataAccessorTypes.AttributeFilter> OrAllFilters { get; set; }
            /// <summary>
            /// EqualsTo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-dataaccessor-attributefilter.html#cfn-qbusiness-dataaccessor-attributefilter-equalsto
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DocumentAttribute
            /// </summary>
            public Humidifier.QBusiness.DataAccessorTypes.DocumentAttribute EqualsTo { get; set; }
            /// <summary>
            /// GreaterThanOrEquals
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-dataaccessor-attributefilter.html#cfn-qbusiness-dataaccessor-attributefilter-greaterthanorequals
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DocumentAttribute
            /// </summary>
            public Humidifier.QBusiness.DataAccessorTypes.DocumentAttribute GreaterThanOrEquals { get; set; }
            /// <summary>
            /// AndAllFilters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-dataaccessor-attributefilter.html#cfn-qbusiness-dataaccessor-attributefilter-andallfilters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AttributeFilter
            /// </summary>
            public List<Humidifier.QBusiness.DataAccessorTypes.AttributeFilter> AndAllFilters { get; set; }
            /// <summary>
            /// ContainsAll
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-dataaccessor-attributefilter.html#cfn-qbusiness-dataaccessor-attributefilter-containsall
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DocumentAttribute
            /// </summary>
            public Humidifier.QBusiness.DataAccessorTypes.DocumentAttribute ContainsAll { get; set; }
        }

        public class DataAccessorAuthenticationConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// IdcTrustedTokenIssuerConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-dataaccessor-dataaccessorauthenticationconfiguration.html#cfn-qbusiness-dataaccessor-dataaccessorauthenticationconfiguration-idctrustedtokenissuerconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DataAccessorIdcTrustedTokenIssuerConfiguration
            /// </summary>
            public Humidifier.QBusiness.DataAccessorTypes.DataAccessorIdcTrustedTokenIssuerConfiguration IdcTrustedTokenIssuerConfiguration { get; set; }
        }

        public class DataAccessorAuthenticationDetail : Humidifier.Base.BaseSubResource, IHaveAuthenticationType
        {
            /// <summary>
            /// AuthenticationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-dataaccessor-dataaccessorauthenticationdetail.html#cfn-qbusiness-dataaccessor-dataaccessorauthenticationdetail-authenticationconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataAccessorAuthenticationConfiguration
            /// </summary>
            public Humidifier.QBusiness.DataAccessorTypes.DataAccessorAuthenticationConfiguration AuthenticationConfiguration { get; set; }
            /// <summary>
            /// ExternalIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-dataaccessor-dataaccessorauthenticationdetail.html#cfn-qbusiness-dataaccessor-dataaccessorauthenticationdetail-externalids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ExternalIds { get; set; }
            /// <summary>
            /// AuthenticationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-dataaccessor-dataaccessorauthenticationdetail.html#cfn-qbusiness-dataaccessor-dataaccessorauthenticationdetail-authenticationtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AuthenticationType { get; set; }
        }

        public class DataAccessorIdcTrustedTokenIssuerConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// IdcTrustedTokenIssuerArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-dataaccessor-dataaccessoridctrustedtokenissuerconfiguration.html#cfn-qbusiness-dataaccessor-dataaccessoridctrustedtokenissuerconfiguration-idctrustedtokenissuerarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IdcTrustedTokenIssuerArn { get; set; }
        }

        public class DocumentAttribute : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-dataaccessor-documentattribute.html#cfn-qbusiness-dataaccessor-documentattribute-value
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DocumentAttributeValue
            /// </summary>
            public Humidifier.QBusiness.DataAccessorTypes.DocumentAttributeValue Value { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-dataaccessor-documentattribute.html#cfn-qbusiness-dataaccessor-documentattribute-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class DocumentAttributeValue : Humidifier.Base.BaseSubResource, IHaveStringValue, IHaveLongValue, IHaveDateValue, IHaveStringListValue
        {
            /// <summary>
            /// DateValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-dataaccessor-documentattributevalue.html#cfn-qbusiness-dataaccessor-documentattributevalue-datevalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DateValue { get; set; }
            /// <summary>
            /// LongValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-dataaccessor-documentattributevalue.html#cfn-qbusiness-dataaccessor-documentattributevalue-longvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic LongValue { get; set; }
            /// <summary>
            /// StringValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-dataaccessor-documentattributevalue.html#cfn-qbusiness-dataaccessor-documentattributevalue-stringvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StringValue { get; set; }
            /// <summary>
            /// StringListValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-dataaccessor-documentattributevalue.html#cfn-qbusiness-dataaccessor-documentattributevalue-stringlistvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic StringListValue { get; set; }
        }
    }
}