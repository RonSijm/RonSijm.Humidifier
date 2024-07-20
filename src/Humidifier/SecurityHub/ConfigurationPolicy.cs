namespace Humidifier.SecurityHub
{
    using System.Collections.Generic;
    using ConfigurationPolicyTypes;

    public class ConfigurationPolicy : Humidifier.Resource
    {
        public class Attributes
        {
            public static string CreatedAt =  "CreatedAt" ;
            public static string ServiceEnabled =  "ServiceEnabled" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::SecurityHub::ConfigurationPolicy";
            }
        }

        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityhub-configurationpolicy.html#cfn-securityhub-configurationpolicy-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// ConfigurationPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityhub-configurationpolicy.html#cfn-securityhub-configurationpolicy-configurationpolicy
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Policy
        /// </summary>
        public Policy ConfigurationPolicy_ { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityhub-configurationpolicy.html#cfn-securityhub-configurationpolicy-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> Tags { get; set; }
        /// <summary>
        /// Name
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityhub-configurationpolicy.html#cfn-securityhub-configurationpolicy-name
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Name { get; set; }
    }

    namespace ConfigurationPolicyTypes
    {
        public class ParameterConfiguration
        {
            /// <summary>
            /// ValueType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-configurationpolicy-parameterconfiguration.html#cfn-securityhub-configurationpolicy-parameterconfiguration-valuetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ValueType { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-configurationpolicy-parameterconfiguration.html#cfn-securityhub-configurationpolicy-parameterconfiguration-value
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ParameterValue
            /// </summary>
            public ParameterValue Value { get; set; }
        }

        public class ParameterValue
        {
            /// <summary>
            /// Enum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-configurationpolicy-parametervalue.html#cfn-securityhub-configurationpolicy-parametervalue-enum
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Enum { get; set; }
            /// <summary>
            /// Integer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-configurationpolicy-parametervalue.html#cfn-securityhub-configurationpolicy-parametervalue-integer
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Integer { get; set; }
            /// <summary>
            /// StringList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-configurationpolicy-parametervalue.html#cfn-securityhub-configurationpolicy-parametervalue-stringlist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic StringList { get; set; }
            /// <summary>
            /// EnumList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-configurationpolicy-parametervalue.html#cfn-securityhub-configurationpolicy-parametervalue-enumlist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic EnumList { get; set; }
            /// <summary>
            /// IntegerList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-configurationpolicy-parametervalue.html#cfn-securityhub-configurationpolicy-parametervalue-integerlist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Integer
            /// </summary>
            public List<int> IntegerList { get; set; }
            /// <summary>
            /// String
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-configurationpolicy-parametervalue.html#cfn-securityhub-configurationpolicy-parametervalue-string
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic String { get; set; }
            /// <summary>
            /// Boolean
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-configurationpolicy-parametervalue.html#cfn-securityhub-configurationpolicy-parametervalue-boolean
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Boolean { get; set; }
            /// <summary>
            /// Double
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-configurationpolicy-parametervalue.html#cfn-securityhub-configurationpolicy-parametervalue-double
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Double { get; set; }
        }

        public class Policy
        {
            /// <summary>
            /// SecurityHub
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-configurationpolicy-policy.html#cfn-securityhub-configurationpolicy-policy-securityhub
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SecurityHubPolicy
            /// </summary>
            public SecurityHubPolicy SecurityHub { get; set; }
        }

        public class SecurityControlCustomParameter
        {
            /// <summary>
            /// SecurityControlId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-configurationpolicy-securitycontrolcustomparameter.html#cfn-securityhub-configurationpolicy-securitycontrolcustomparameter-securitycontrolid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SecurityControlId { get; set; }
            /// <summary>
            /// Parameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-configurationpolicy-securitycontrolcustomparameter.html#cfn-securityhub-configurationpolicy-securitycontrolcustomparameter-parameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: ParameterConfiguration
            /// </summary>
            public Dictionary<string, ParameterConfiguration> Parameters { get; set; }
        }

        public class SecurityControlsConfiguration
        {
            /// <summary>
            /// DisabledSecurityControlIdentifiers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-configurationpolicy-securitycontrolsconfiguration.html#cfn-securityhub-configurationpolicy-securitycontrolsconfiguration-disabledsecuritycontrolidentifiers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic DisabledSecurityControlIdentifiers { get; set; }
            /// <summary>
            /// EnabledSecurityControlIdentifiers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-configurationpolicy-securitycontrolsconfiguration.html#cfn-securityhub-configurationpolicy-securitycontrolsconfiguration-enabledsecuritycontrolidentifiers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic EnabledSecurityControlIdentifiers { get; set; }
            /// <summary>
            /// SecurityControlCustomParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-configurationpolicy-securitycontrolsconfiguration.html#cfn-securityhub-configurationpolicy-securitycontrolsconfiguration-securitycontrolcustomparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SecurityControlCustomParameter
            /// </summary>
            public List<SecurityControlCustomParameter> SecurityControlCustomParameters { get; set; }
        }

        public class SecurityHubPolicy
        {
            /// <summary>
            /// EnabledStandardIdentifiers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-configurationpolicy-securityhubpolicy.html#cfn-securityhub-configurationpolicy-securityhubpolicy-enabledstandardidentifiers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic EnabledStandardIdentifiers { get; set; }
            /// <summary>
            /// ServiceEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-configurationpolicy-securityhubpolicy.html#cfn-securityhub-configurationpolicy-securityhubpolicy-serviceenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic ServiceEnabled { get; set; }
            /// <summary>
            /// SecurityControlsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-configurationpolicy-securityhubpolicy.html#cfn-securityhub-configurationpolicy-securityhubpolicy-securitycontrolsconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SecurityControlsConfiguration
            /// </summary>
            public SecurityControlsConfiguration SecurityControlsConfiguration { get; set; }
        }
    }
}