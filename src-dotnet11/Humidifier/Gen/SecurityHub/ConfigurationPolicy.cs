namespace Humidifier.SecurityHub
{
    using global::System.Collections.Generic;
    using ConfigurationPolicyTypes;

    public class ConfigurationPolicy : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveDescription, IHaveSecurityHubConfigurationPolicyTypesPolicyConfigurationPolicy_, IHaveStringDictionaryOfTags, IHaveName
    {
        public class Attributes
        {
            public static string CreatedAt =  "CreatedAt" ;
            public static string ServiceEnabled =  "ServiceEnabled" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.SecurityHub.ConfigurationPolicy; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityhub-configurationpolicy.html#cfn-securityhub-configurationpolicy-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// ConfigurationPolicy_
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityhub-configurationpolicy.html#cfn-securityhub-configurationpolicy-configurationpolicy
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Policy
        /// </summary>
        [Required]
        public Union<Humidifier.SecurityHub.ConfigurationPolicyTypes.Policy, BaseFunction>? ConfigurationPolicy_ { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityhub-configurationpolicy.html#cfn-securityhub-configurationpolicy-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace ConfigurationPolicyTypes
    {
        public class ParameterConfiguration : Humidifier.Base.BaseSubResource, IHaveValueType, IHaveSecurityHubConfigurationPolicyTypesParameterValueValue
        {
            /// <summary>
            /// ValueType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-configurationpolicy-parameterconfiguration.html#cfn-securityhub-configurationpolicy-parameterconfiguration-valuetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ValueType { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-configurationpolicy-parameterconfiguration.html#cfn-securityhub-configurationpolicy-parameterconfiguration-value
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ParameterValue
            /// </summary>
            public Union<Humidifier.SecurityHub.ConfigurationPolicyTypes.ParameterValue, BaseFunction>? Value { get; set; }
        }

        public class ParameterValue : Humidifier.Base.BaseSubResource, IHaveEnum, IHaveInteger_Integer, IHaveStringListOfStringList, IHaveStringListOfEnumList, IHaveIntegerListOfIntegerList, IHaveString, IHaveBoolean_Boolean, IHaveDouble_Double
        {
            /// <summary>
            /// Enum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-configurationpolicy-parametervalue.html#cfn-securityhub-configurationpolicy-parametervalue-enum
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Enum { get; set; }
            /// <summary>
            /// Integer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-configurationpolicy-parametervalue.html#cfn-securityhub-configurationpolicy-parametervalue-integer
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Integer { get; set; }
            /// <summary>
            /// StringList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-configurationpolicy-parametervalue.html#cfn-securityhub-configurationpolicy-parametervalue-stringlist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? StringList { get; set; }
            /// <summary>
            /// EnumList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-configurationpolicy-parametervalue.html#cfn-securityhub-configurationpolicy-parametervalue-enumlist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? EnumList { get; set; }
            /// <summary>
            /// IntegerList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-configurationpolicy-parametervalue.html#cfn-securityhub-configurationpolicy-parametervalue-integerlist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Integer
            /// </summary>
            public Union<IReadOnlyList<int>, IReadOnlyList<Union<int, BaseFunction>>, BaseFunction>? IntegerList { get; set; }
            /// <summary>
            /// String
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-configurationpolicy-parametervalue.html#cfn-securityhub-configurationpolicy-parametervalue-string
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? String { get; set; }
            /// <summary>
            /// Boolean
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-configurationpolicy-parametervalue.html#cfn-securityhub-configurationpolicy-parametervalue-boolean
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Boolean { get; set; }
            /// <summary>
            /// Double
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-configurationpolicy-parametervalue.html#cfn-securityhub-configurationpolicy-parametervalue-double
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Double { get; set; }
        }

        public class Policy : Humidifier.Base.BaseSubResource, IHaveSecurityHubConfigurationPolicyTypesSecurityHubPolicySecurityHub
        {
            /// <summary>
            /// SecurityHub
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-configurationpolicy-policy.html#cfn-securityhub-configurationpolicy-policy-securityhub
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SecurityHubPolicy
            /// </summary>
            public Union<Humidifier.SecurityHub.ConfigurationPolicyTypes.SecurityHubPolicy, BaseFunction>? SecurityHub { get; set; }
        }

        public class SecurityControlCustomParameter : Humidifier.Base.BaseSubResource, IHaveSecurityControlId, IHaveMapOfSecurityHubConfigurationPolicyTypesParameterConfigurationParameters
        {
            /// <summary>
            /// SecurityControlId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-configurationpolicy-securitycontrolcustomparameter.html#cfn-securityhub-configurationpolicy-securitycontrolcustomparameter-securitycontrolid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecurityControlId { get; set; }
            /// <summary>
            /// Parameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-configurationpolicy-securitycontrolcustomparameter.html#cfn-securityhub-configurationpolicy-securitycontrolcustomparameter-parameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: ParameterConfiguration
            /// </summary>
            public Union<IReadOnlyDictionary<string, Humidifier.SecurityHub.ConfigurationPolicyTypes.ParameterConfiguration>, IReadOnlyDictionary<string, Union<Humidifier.SecurityHub.ConfigurationPolicyTypes.ParameterConfiguration, BaseFunction>>, BaseFunction>? Parameters { get; set; }
        }

        public class SecurityControlsConfiguration : Humidifier.Base.BaseSubResource, IHaveStringListOfDisabledSecurityControlIdentifiers, IHaveStringListOfEnabledSecurityControlIdentifiers, IHaveListOfSecurityHubConfigurationPolicyTypesSecurityControlCustomParameterSecurityControlCustomParameters
        {
            /// <summary>
            /// DisabledSecurityControlIdentifiers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-configurationpolicy-securitycontrolsconfiguration.html#cfn-securityhub-configurationpolicy-securitycontrolsconfiguration-disabledsecuritycontrolidentifiers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? DisabledSecurityControlIdentifiers { get; set; }
            /// <summary>
            /// EnabledSecurityControlIdentifiers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-configurationpolicy-securitycontrolsconfiguration.html#cfn-securityhub-configurationpolicy-securitycontrolsconfiguration-enabledsecuritycontrolidentifiers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? EnabledSecurityControlIdentifiers { get; set; }
            /// <summary>
            /// SecurityControlCustomParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-configurationpolicy-securitycontrolsconfiguration.html#cfn-securityhub-configurationpolicy-securitycontrolsconfiguration-securitycontrolcustomparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SecurityControlCustomParameter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SecurityHub.ConfigurationPolicyTypes.SecurityControlCustomParameter>, IReadOnlyList<Union<Humidifier.SecurityHub.ConfigurationPolicyTypes.SecurityControlCustomParameter, BaseFunction>>, BaseFunction>? SecurityControlCustomParameters { get; set; }
        }

        public class SecurityHubPolicy : Humidifier.Base.BaseSubResource, IHaveStringListOfEnabledStandardIdentifiers, IHaveServiceEnabled_Boolean, IHaveSecurityHubConfigurationPolicyTypesSecurityControlsConfigurationSecurityControlsConfiguration
        {
            /// <summary>
            /// EnabledStandardIdentifiers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-configurationpolicy-securityhubpolicy.html#cfn-securityhub-configurationpolicy-securityhubpolicy-enabledstandardidentifiers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? EnabledStandardIdentifiers { get; set; }
            /// <summary>
            /// ServiceEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-configurationpolicy-securityhubpolicy.html#cfn-securityhub-configurationpolicy-securityhubpolicy-serviceenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ServiceEnabled { get; set; }
            /// <summary>
            /// SecurityControlsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-configurationpolicy-securityhubpolicy.html#cfn-securityhub-configurationpolicy-securityhubpolicy-securitycontrolsconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SecurityControlsConfiguration
            /// </summary>
            public Union<Humidifier.SecurityHub.ConfigurationPolicyTypes.SecurityControlsConfiguration, BaseFunction>? SecurityControlsConfiguration { get; set; }
        }
    }
}