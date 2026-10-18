namespace Humidifier.QBusiness
{
    using global::System.Collections.Generic;
    using DataAccessorTypes;

    public class DataAccessor : Humidifier.Base.BaseResource, IHaveTags, IHaveDisplayName, IHaveListOfQBusinessDataAccessorTypesActionConfigurationActionConfigurations, IHaveApplicationId, IHavePrincipal, IHaveQBusinessDataAccessorTypesDataAccessorAuthenticationDetailAuthenticationDetail
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
        public Union<string, BaseFunction>? DisplayName { get; set; }

        /// <summary>
        /// ActionConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-dataaccessor.html#cfn-qbusiness-dataaccessor-actionconfigurations
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ActionConfiguration
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.QBusiness.DataAccessorTypes.ActionConfiguration>, IReadOnlyList<Union<Humidifier.QBusiness.DataAccessorTypes.ActionConfiguration, BaseFunction>>, BaseFunction>? ActionConfigurations { get; set; }

        /// <summary>
        /// ApplicationId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-dataaccessor.html#cfn-qbusiness-dataaccessor-applicationid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ApplicationId { get; set; }

        /// <summary>
        /// Principal
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-dataaccessor.html#cfn-qbusiness-dataaccessor-principal
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Principal { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-dataaccessor.html#cfn-qbusiness-dataaccessor-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// AuthenticationDetail
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-dataaccessor.html#cfn-qbusiness-dataaccessor-authenticationdetail
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DataAccessorAuthenticationDetail
        /// </summary>
        public Union<Humidifier.QBusiness.DataAccessorTypes.DataAccessorAuthenticationDetail, BaseFunction>? AuthenticationDetail { get; set; }
    }

    namespace DataAccessorTypes
    {
        public class ActionConfiguration : Humidifier.Base.BaseSubResource, IHaveAction, IHaveQBusinessDataAccessorTypesActionFilterConfigurationFilterConfiguration
        {
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-dataaccessor-actionconfiguration.html#cfn-qbusiness-dataaccessor-actionconfiguration-action
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Action { get; set; }
            /// <summary>
            /// FilterConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-dataaccessor-actionconfiguration.html#cfn-qbusiness-dataaccessor-actionconfiguration-filterconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ActionFilterConfiguration
            /// </summary>
            public Union<Humidifier.QBusiness.DataAccessorTypes.ActionFilterConfiguration, BaseFunction>? FilterConfiguration { get; set; }
        }

        public class ActionFilterConfiguration : Humidifier.Base.BaseSubResource, IHaveQBusinessDataAccessorTypesAttributeFilterDocumentAttributeFilter
        {
            /// <summary>
            /// DocumentAttributeFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-dataaccessor-actionfilterconfiguration.html#cfn-qbusiness-dataaccessor-actionfilterconfiguration-documentattributefilter
            /// Required: True
            /// UpdateType: Mutable
            /// Type: AttributeFilter
            /// </summary>
            public Union<Humidifier.QBusiness.DataAccessorTypes.AttributeFilter, BaseFunction>? DocumentAttributeFilter { get; set; }
        }

        public class AttributeFilter : Humidifier.Base.BaseSubResource, IHaveQBusinessDataAccessorTypesDocumentAttributeContainsAny, IHaveQBusinessDataAccessorTypesDocumentAttributeLessThan, IHaveQBusinessDataAccessorTypesDocumentAttributeGreaterThan, IHaveQBusinessDataAccessorTypesAttributeFilterNotFilter, IHaveQBusinessDataAccessorTypesDocumentAttributeLessThanOrEquals, IHaveListOfQBusinessDataAccessorTypesAttributeFilterOrAllFilters, IHaveQBusinessDataAccessorTypesDocumentAttributeEqualsTo, IHaveQBusinessDataAccessorTypesDocumentAttributeGreaterThanOrEquals, IHaveListOfQBusinessDataAccessorTypesAttributeFilterAndAllFilters, IHaveQBusinessDataAccessorTypesDocumentAttributeContainsAll
        {
            /// <summary>
            /// ContainsAny
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-dataaccessor-attributefilter.html#cfn-qbusiness-dataaccessor-attributefilter-containsany
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DocumentAttribute
            /// </summary>
            public Union<Humidifier.QBusiness.DataAccessorTypes.DocumentAttribute, BaseFunction>? ContainsAny { get; set; }
            /// <summary>
            /// LessThan
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-dataaccessor-attributefilter.html#cfn-qbusiness-dataaccessor-attributefilter-lessthan
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DocumentAttribute
            /// </summary>
            public Union<Humidifier.QBusiness.DataAccessorTypes.DocumentAttribute, BaseFunction>? LessThan { get; set; }
            /// <summary>
            /// GreaterThan
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-dataaccessor-attributefilter.html#cfn-qbusiness-dataaccessor-attributefilter-greaterthan
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DocumentAttribute
            /// </summary>
            public Union<Humidifier.QBusiness.DataAccessorTypes.DocumentAttribute, BaseFunction>? GreaterThan { get; set; }
            /// <summary>
            /// NotFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-dataaccessor-attributefilter.html#cfn-qbusiness-dataaccessor-attributefilter-notfilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AttributeFilter
            /// </summary>
            public Union<Humidifier.QBusiness.DataAccessorTypes.AttributeFilter, BaseFunction>? NotFilter { get; set; }
            /// <summary>
            /// LessThanOrEquals
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-dataaccessor-attributefilter.html#cfn-qbusiness-dataaccessor-attributefilter-lessthanorequals
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DocumentAttribute
            /// </summary>
            public Union<Humidifier.QBusiness.DataAccessorTypes.DocumentAttribute, BaseFunction>? LessThanOrEquals { get; set; }
            /// <summary>
            /// OrAllFilters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-dataaccessor-attributefilter.html#cfn-qbusiness-dataaccessor-attributefilter-orallfilters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AttributeFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.QBusiness.DataAccessorTypes.AttributeFilter>, IReadOnlyList<Union<Humidifier.QBusiness.DataAccessorTypes.AttributeFilter, BaseFunction>>, BaseFunction>? OrAllFilters { get; set; }
            /// <summary>
            /// EqualsTo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-dataaccessor-attributefilter.html#cfn-qbusiness-dataaccessor-attributefilter-equalsto
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DocumentAttribute
            /// </summary>
            public Union<Humidifier.QBusiness.DataAccessorTypes.DocumentAttribute, BaseFunction>? EqualsTo { get; set; }
            /// <summary>
            /// GreaterThanOrEquals
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-dataaccessor-attributefilter.html#cfn-qbusiness-dataaccessor-attributefilter-greaterthanorequals
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DocumentAttribute
            /// </summary>
            public Union<Humidifier.QBusiness.DataAccessorTypes.DocumentAttribute, BaseFunction>? GreaterThanOrEquals { get; set; }
            /// <summary>
            /// AndAllFilters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-dataaccessor-attributefilter.html#cfn-qbusiness-dataaccessor-attributefilter-andallfilters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AttributeFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.QBusiness.DataAccessorTypes.AttributeFilter>, IReadOnlyList<Union<Humidifier.QBusiness.DataAccessorTypes.AttributeFilter, BaseFunction>>, BaseFunction>? AndAllFilters { get; set; }
            /// <summary>
            /// ContainsAll
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-dataaccessor-attributefilter.html#cfn-qbusiness-dataaccessor-attributefilter-containsall
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DocumentAttribute
            /// </summary>
            public Union<Humidifier.QBusiness.DataAccessorTypes.DocumentAttribute, BaseFunction>? ContainsAll { get; set; }
        }

        public class DataAccessorAuthenticationConfiguration : Humidifier.Base.BaseSubResource, IHaveQBusinessDataAccessorTypesDataAccessorIdcTrustedTokenIssuerConfigurationIdcTrustedTokenIssuerConfiguration
        {
            /// <summary>
            /// IdcTrustedTokenIssuerConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-dataaccessor-dataaccessorauthenticationconfiguration.html#cfn-qbusiness-dataaccessor-dataaccessorauthenticationconfiguration-idctrustedtokenissuerconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DataAccessorIdcTrustedTokenIssuerConfiguration
            /// </summary>
            public Union<Humidifier.QBusiness.DataAccessorTypes.DataAccessorIdcTrustedTokenIssuerConfiguration, BaseFunction>? IdcTrustedTokenIssuerConfiguration { get; set; }
        }

        public class DataAccessorAuthenticationDetail : Humidifier.Base.BaseSubResource, IHaveQBusinessDataAccessorTypesDataAccessorAuthenticationConfigurationAuthenticationConfiguration, IHaveStringListOfExternalIds, IHaveAuthenticationType
        {
            /// <summary>
            /// AuthenticationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-dataaccessor-dataaccessorauthenticationdetail.html#cfn-qbusiness-dataaccessor-dataaccessorauthenticationdetail-authenticationconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataAccessorAuthenticationConfiguration
            /// </summary>
            public Union<Humidifier.QBusiness.DataAccessorTypes.DataAccessorAuthenticationConfiguration, BaseFunction>? AuthenticationConfiguration { get; set; }
            /// <summary>
            /// ExternalIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-dataaccessor-dataaccessorauthenticationdetail.html#cfn-qbusiness-dataaccessor-dataaccessorauthenticationdetail-externalids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ExternalIds { get; set; }
            /// <summary>
            /// AuthenticationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-dataaccessor-dataaccessorauthenticationdetail.html#cfn-qbusiness-dataaccessor-dataaccessorauthenticationdetail-authenticationtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AuthenticationType { get; set; }
        }

        public class DataAccessorIdcTrustedTokenIssuerConfiguration : Humidifier.Base.BaseSubResource, IHaveIdcTrustedTokenIssuerArn
        {
            /// <summary>
            /// IdcTrustedTokenIssuerArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-dataaccessor-dataaccessoridctrustedtokenissuerconfiguration.html#cfn-qbusiness-dataaccessor-dataaccessoridctrustedtokenissuerconfiguration-idctrustedtokenissuerarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IdcTrustedTokenIssuerArn { get; set; }
        }

        public class DocumentAttribute : Humidifier.Base.BaseSubResource, IHaveQBusinessDataAccessorTypesDocumentAttributeValueValue, IHaveName
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-dataaccessor-documentattribute.html#cfn-qbusiness-dataaccessor-documentattribute-value
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DocumentAttributeValue
            /// </summary>
            public Union<Humidifier.QBusiness.DataAccessorTypes.DocumentAttributeValue, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-dataaccessor-documentattribute.html#cfn-qbusiness-dataaccessor-documentattribute-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class DocumentAttributeValue : Humidifier.Base.BaseSubResource, IHaveDateValue, IHaveLongValue_Double, IHaveStringValue, IHaveStringListOfStringListValue
        {
            /// <summary>
            /// DateValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-dataaccessor-documentattributevalue.html#cfn-qbusiness-dataaccessor-documentattributevalue-datevalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DateValue { get; set; }
            /// <summary>
            /// LongValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-dataaccessor-documentattributevalue.html#cfn-qbusiness-dataaccessor-documentattributevalue-longvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? LongValue { get; set; }
            /// <summary>
            /// StringValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-dataaccessor-documentattributevalue.html#cfn-qbusiness-dataaccessor-documentattributevalue-stringvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StringValue { get; set; }
            /// <summary>
            /// StringListValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-dataaccessor-documentattributevalue.html#cfn-qbusiness-dataaccessor-documentattributevalue-stringlistvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? StringListValue { get; set; }
        }
    }
}